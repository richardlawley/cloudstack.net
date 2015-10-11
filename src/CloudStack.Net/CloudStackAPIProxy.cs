using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CloudStack.Net
{
    public class CloudStackAPIProxy : ICloudStackAPIProxy
    {
        private static MethodInfo _decodeListResponseMethod = typeof(CloudStackAPIProxy).GetMethod(nameof(DecodeListResponse), BindingFlags.Static | BindingFlags.NonPublic);

        public CloudStackAPIProxy(string serviceUrl, string apiKey, string secretKey)
            : this(serviceUrl)
        {
            if (String.IsNullOrEmpty(apiKey)) { throw new ArgumentNullException(nameof(apiKey)); }
            if (String.IsNullOrEmpty(secretKey)) { throw new ArgumentNullException(nameof(secretKey)); }

            ApiKey = apiKey;
            SecretKey = secretKey;
        }

        public CloudStackAPIProxy(string serviceUrl, string sessionKey)
            : this(serviceUrl)
        {
            SessionKey = sessionKey;
        }

        private CloudStackAPIProxy(string serviceUrl)
        {
            if (String.IsNullOrEmpty(serviceUrl)) { throw new ArgumentNullException(nameof(serviceUrl)); }
            if (!serviceUrl.EndsWith("/api")) { throw new ArgumentException(nameof(serviceUrl), $"Expected Service Url to end with /api - it is {serviceUrl}"); }

            ServiceUrl = serviceUrl;
        }

        /// <summary>
        /// Timeout used for connections and used for writes/reads.
        /// </summary>
        public TimeSpan HttpRequestTimeout { get; set; } = TimeSpan.FromSeconds(10);

        public string ServiceUrl { get; }
        private string ApiKey { get; }
        private string SecretKey { get; }
        private string SessionKey { get; }

        /// <summary>
        /// Calculates a HMAC SHA-1 hash of the supplied string.
        /// </summary>
        /// <param name="toSign">String to sign</param>
        /// <param name="ssoKey">Signing private key</param>
        /// <returns>HMAC SHA-1 signature</returns>
        public static string CalcSignature(string toSign, string secretKey)
        {
            if (secretKey == null) { throw new ArgumentNullException(nameof(secretKey)); }

            byte[] secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
            HMACSHA1 hasher = new System.Security.Cryptography.HMACSHA1(secretKeyBytes);
            byte[] bytesToSign = Encoding.UTF8.GetBytes(toSign.ToLower());
            byte[] signatureUTF8 = hasher.ComputeHash(bytesToSign);
            string signature = Convert.ToBase64String(signatureUTF8);
            signature = Uri.EscapeDataString(signature);
            return signature;
        }

        /// <summary>
        /// Produces a query string with an optional signature from arguments in key/value string form.
        /// </summary>
        /// <param name="arguments">Command in terms of key/value pairs</param>
        /// <param name="ssoKey">Optional secret key if the query is to be signed</param>
        /// <returns>Http query string including the signature.</returns>
        /// <remarks>
        /// Reference:
        /// http://docs.cloud.com/CloudStack_Documentation/Developer%27s_Guide%3A_CloudStack#Signing_API_Requests
        /// </remarks>
        public static string CreateQuery(IDictionary<string, object> arguments, string apiKey, string secretKey, string sessionKey)
        {
            StringBuilder query = new StringBuilder();
            SortedList<string, object> sortedArgs = new SortedList<string, object>(arguments, StringComparer.OrdinalIgnoreCase);
            if (!String.IsNullOrEmpty(apiKey))
            {
                sortedArgs["apikey"] = apiKey;
            }

            foreach (string key in sortedArgs.Keys)
            {
                string token = SerialiseValue(key, sortedArgs[key]);
                if (!String.IsNullOrEmpty(token))
                {
                    query.Append(token);
                    query.Append("&");
                }
            }
            query.Remove(query.Length - 1, 1);

            if (secretKey != null)
            {
                string signature = CalcSignature(query.ToString().ToLowerInvariant(), secretKey);
                query.Append(string.Format(CultureInfo.InvariantCulture, "&{0}={1}", "signature", signature));
            }
            else if (sessionKey != null)
            {
                query.Append(string.Format(CultureInfo.InvariantCulture, "&{0}={1}", "sessionkey", Uri.EscapeDataString(sessionKey)));
            }
            return query.ToString();
        }

        public static string SerialiseValue(string name, object value)
        {
            if (value == null) { return null; }
            name = name.ToLower();

            var type = value.GetType();
            if (type.IsValueType || value is string)
            {
                return $"{name}={Uri.EscapeDataString(value.ToString())}";
            }
            else if (value is IDictionary)
            {
                IDictionary dict = (IDictionary)value;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < dict.Count; i++)
                {
                    object key = dict.Keys.OfType<object>().ElementAt(i);

                    if (i > 0)
                    {
                        sb.Append("&");
                    }
                    sb.Append($"{name}[0].{Uri.EscapeDataString(key.ToString())}={Uri.EscapeDataString(dict[key].ToString())}");
                }
                return sb.ToString();

            }
            else if (value is IList)
            {
                IList list = (IList)value;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i > 0)
                    {
                        sb.Append("&");
                    }
                    sb.Append($"{name}[{i}]={Uri.EscapeDataString(list[i].ToString())}");
                }
                return sb.ToString();
            }

            throw new NotImplementedException("Couldn't serialise object of type " + type.FullName);
        }

        public static TResponse DecodeResponse<TResponse>(string response) where TResponse : new()
        {
            JObject root = JsonConvert.DeserializeObject<JObject>(response);
            if (root.Count != 1)
            {
                throw new FormatException($"Expected root to contain a single object - it contains {root.Count}");
            }

            JToken listElement = ((JProperty)root.First).Value;
            TResponse decodedResponse = listElement.ToObject<TResponse>();

            if (typeof(TResponse).IsGenericType && typeof(TResponse).GetGenericTypeDefinition() == typeof(ListResponse<>))
            {
                if (listElement is JContainer)        // An empty list will be null
                {
                    MethodInfo decodeListResponse = _decodeListResponseMethod.MakeGenericMethod(typeof(TResponse).GetGenericArguments().Single());
                    decodeListResponse.Invoke(null, new object[] { decodedResponse, (JContainer)listElement });
                }
            }
            return decodedResponse;
        }

        public TResponse Request<TResponse>(APIRequest request) where TResponse : new()
        {
            bool useGet = request.Command.StartsWith("list", StringComparison.OrdinalIgnoreCase) || request.Command.StartsWith("get", StringComparison.OrdinalIgnoreCase);
            useGet = true;

            string queryString = CreateQuery(request.Parameters, ApiKey, SecretKey, SessionKey);
            Uri fullUri = new Uri(ServiceUrl + (useGet ? $"?{queryString}" : ""));

            HttpWebRequest webRequest = WebRequest.CreateHttp(fullUri);
            webRequest.Accept = "application/json;charset=UTF-8";
            webRequest.Method = useGet ? "GET" : "POST";

            if (!useGet)
            {
                using (StreamWriter sw = new StreamWriter(webRequest.GetRequestStream()))
                {
                    sw.WriteLine(queryString);
                }
            }

            try
            {
                using (HttpWebResponse httpWebResponse = webRequest.GetResponse() as HttpWebResponse)
                {
                    using (Stream respStrm = httpWebResponse.GetResponseStream())
                    {
                        respStrm.ReadTimeout = (int)this.HttpRequestTimeout.TotalMilliseconds;
                        using (StreamReader streamReader = new StreamReader(respStrm, Encoding.UTF8))
                        {
                            string responseText = streamReader.ReadToEnd();
                            try
                            {
                                return DecodeResponse<TResponse>(responseText);
                            }
                            catch (FormatException ex)
                            {
                                throw new FormatException("Could not decode CloudStack API Response", ex);
                            }
                        }
                    }
                }
            }
            catch (WebException e)
            {
                throw CreateCloudStackException(e, fullUri);
            }
        }

        /// <summary>
        /// Decodes the list result of a List Response.  We don't know the name of this in advance, so we look for the
        /// one which is not count.  This is how CloudStack do it in their own code too.
        /// </summary>
        private static void DecodeListResponse<TResponse>(ListResponse<TResponse> decodedResponse, JContainer responseContainer) where TResponse : new()
        {
            if (responseContainer.Count == 0)
            {
                // empty list
                decodedResponse.Results = new List<TResponse>();
                return;
            }
            if (responseContainer.Count < 2)
            {
                throw new FormatException("Expected multiple elements for a list object");
            }

            JProperty resultElement = responseContainer.Children().OfType<JProperty>().Where(p => !p.Name.Equals("count", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            if (resultElement == null)
            {
                throw new FormatException("Couldn't find a results element for a list command");
            }

            decodedResponse.Results = resultElement.Value.ToObject<IList<TResponse>>();
        }

        /// <summary>
        /// Create a CloudStackException from the supplied WebException. If avaiable the response
        /// stream is read and added to the exception.
        /// </summary>
        /// <param name="we">The WebException</param>
        /// <param name="fullUri">URI of the server</param>
        /// <returns>a CloudStackException</returns>
        private CloudStackException CreateCloudStackException(WebException we, Uri fullUri)
        {
            if (we.Status == WebExceptionStatus.ProtocolError)
            {
                HttpWebResponse responseStream = (HttpWebResponse)we.Response;
                try
                {
                    using (StreamReader reader = new StreamReader(responseStream.GetResponseStream()))
                    {
                        string responseString = reader.ReadToEnd();
                        var errorResult = DecodeResponse<APIErrorResult>(responseString);
                        return new CloudStackException("ProtocolError on API Call", fullUri.ToString(), errorResult, we);
                    }
                }
                catch
                {
                    return new CloudStackException(
                        "Error on API call (cannot read response stream)",
                        fullUri.ToString(),
                        responseStream.StatusCode.ToString(),
                        responseStream.StatusDescription,
                        we);
                }
            }
            return new CloudStackException(
                "Error on API call",
                fullUri.ToString(),
                we.Status.ToString(),
                we.Message,
                    we);
        }
    }
}