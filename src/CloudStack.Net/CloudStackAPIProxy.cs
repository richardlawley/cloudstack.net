using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CloudStack.Net
{
    public class CloudStackAPIProxy : ICloudStackAPIProxy
    {
        private static readonly MethodInfo _decodeListResponseMethod = typeof(CloudStackAPIProxy).GetMethod(nameof(DecodeListResponse), BindingFlags.Static | BindingFlags.NonPublic);

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
            if (serviceUrl.EndsWith("/clients", StringComparison.Ordinal)) { throw new ArgumentException(nameof(serviceUrl), $"Please specify the URL to the API endpoint, not the management UI.  URL specified is {serviceUrl}"); }

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
        /// <param name="secretKey">Signing private key</param>
        /// <returns>HMAC SHA-1 signature</returns>
        public static string CalcSignature(string toSign, string secretKey)
        {
            var args = new SortedDictionary<string, string>();
            foreach (string item in toSign.Split('&'))
            {
                args.Add(item.Split('=')[0], item.Split('=')[1]);
            }

            Sign(args, secretKey);
            return args["signature"];
        }

        /// <summary>
        /// Produces a query string with an optional signature from arguments in key/value string form.
        /// </summary>
        /// <param name="arguments">Command in terms of key/value pairs</param>
        /// <param name="secretKey">Optional secret key if the query is to be signed</param>
        /// <returns>Http query string including the signature.</returns>
        /// <remarks>
        /// Reference:
        /// http://docs.cloud.com/CloudStack_Documentation/Developer%27s_Guide%3A_CloudStack#Signing_API_Requests
        /// </remarks>
        public static string CreateQuery(IDictionary<string, object> arguments, string apiKey, string secretKey, string sessionKey)
        {
            SortedDictionary<string, string> sortedArgs = Transform(arguments);
            if (!String.IsNullOrEmpty(apiKey))
            {
                sortedArgs["apiKey"] = apiKey;
            }
            if (sortedArgs.ContainsKey("signature"))
            {
                sortedArgs.Remove("signature");
            }

            if (secretKey != null)
            {
                Sign(sortedArgs, secretKey);
            }
            else if (sessionKey != null)
            {
                sortedArgs["sessionkey"] = sessionKey;
            }

            if (sortedArgs.ContainsKey("expires"))      // expires requires this
            {
                sortedArgs["signatureVersion"] = "3";
            }

            var query = new StringBuilder();
            foreach ((string key, string value) in sortedArgs)
            {
                query.Append($"&{CsEncode(key.ToLower())}={CsEncode(value)}");
            }
            query.Remove(0, 1);          // Remove first &

            return query.ToString();
        }

        public static string CsEncode(string input) => Uri.EscapeDataString(input).Replace("+", "%20");

        public static TResponse DecodeResponse<TResponse>(string response) where TResponse : new()
        {
            JObject root = JsonConvert.DeserializeObject<JObject>(response);
            if (root.Count != 1)
            {
                throw new FormatException($"Expected root to contain a single object - it contains {root.Count}");
            }
            return DecodeResponse<TResponse>(root);
        }

        public static TResponse DecodeResponse<TResponse>(JObject root) where TResponse : new()
        {
            TResponse decodedResponse;

            // Top should always be a JProperty, normally with the name of the response
            var rootProperty = (JProperty)root.First;
            var rootObject = (JObject)rootProperty.Value;

            if (typeof(TResponse).IsGenericType && typeof(TResponse).GetGenericTypeDefinition() == typeof(ListResponse<>))
            {
                // When expecting a list response, we should be getting a JProperty with an array
                decodedResponse = rootObject.ToObject<TResponse>();
                if (rootObject is JContainer)        // An empty list will be null
                {
                    MethodInfo decodeListResponse = _decodeListResponseMethod.MakeGenericMethod(typeof(TResponse).GetGenericArguments().Single());
                    decodeListResponse.Invoke(null, new object[] { decodedResponse, (JContainer)rootObject });
                }
            }
            else if (rootObject.Count == 1 && rootObject.First is JProperty && ((JProperty)rootObject.First).Value is JObject)
            {
                // e.g. { "createdomainresponse" : { "domain" : { ...
                decodedResponse = ((JProperty)rootObject.First).Value.ToObject<TResponse>();
            }
            else
            {
                // e.g. { "createdomainresponse" : { "errorCode" : "1", "errorText": "blah"
                decodedResponse = rootProperty.Value.ToObject<TResponse>();
            }
            return decodedResponse;
        }

        /// <summary>
        /// Calculates a HMAC SHA-1 hash of the supplied string.
        /// </summary>
        /// <param name="args">Values to sign</param>
        /// <param name="secretKey">Signing private key</param>
        public static void Sign(SortedDictionary<string, string> args, string secretKey)
        {
            string toSign = String.Join("&", args.Select(kvp => $"{kvp.Key}={CsEncode(kvp.Value)}"));

            byte[] secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
            var hasher = new System.Security.Cryptography.HMACSHA1(secretKeyBytes);
            byte[] bytesToSign = Encoding.UTF8.GetBytes(toSign.ToLower());
            byte[] signatureUTF8 = hasher.ComputeHash(bytesToSign);
            string signature = Convert.ToBase64String(signatureUTF8);
            //signature = Uri.EscapeDataString(signature);

            args["signature"] = signature;
        }

        public static SortedDictionary<string, string> Transform(IDictionary<string, object> input)
        {
            var result = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (KeyValuePair<string, object> kvp in input)
            {
                string key = kvp.Key;
                object value = kvp.Value;

                if (value == null) { continue; }
                Type type = value.GetType();
                if (type.IsValueType || value is string)
                {
                    result.Add(key, value.ToString());
                }
                else
                {
                    if (value is IDictionary)
                    {
                        var wrapper = new List<object>
                        {
                            value
                        };
                        value = wrapper;
                    }

                    if (value is IList list && list.Count > 0)
                    {
                        if (!(list[0] is IDictionary))
                        {
                            result.Add(key, String.Join(",", list.OfType<object>().Select(x => x.ToString())));
                        }
                        else
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                var dict = (IDictionary)list[i];

                                foreach (string innerKey in dict.Keys)
                                {
                                    result.Add($"{key}[{i}].{innerKey}", dict[innerKey].ToString());
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }

        public TResponse Request<TResponse>(APIRequest request) where TResponse : new()
        {
            HttpWebRequest webRequest = CreateRequest(request);
            webRequest.Timeout = (int)this.HttpRequestTimeout.TotalMilliseconds;
            webRequest.ReadWriteTimeout = (int)this.HttpRequestTimeout.TotalMilliseconds;

            try
            {
                using var httpWebResponse = webRequest.GetResponse() as HttpWebResponse;

                using Stream respStrm = httpWebResponse.GetResponseStream();
                respStrm.ReadTimeout = (int)this.HttpRequestTimeout.TotalMilliseconds;

                using var streamReader = new StreamReader(respStrm, Encoding.UTF8);
                string responseText = streamReader.ReadToEnd();
                TResponse response;
                if (request.OverrideDecodeResponse)
                {
                    response = new TResponse();
                    if (!(response is CustomResponse customResponse))
                    {
                        throw new InvalidOperationException($"{nameof(request.OverrideDecodeResponse)} has been selected, but result does not derive from {nameof(CustomResponse)}");
                    }
                    customResponse.DecodeResponse(responseText);
                }
                else
                {
                    try
                    {
                        response = DecodeResponse<TResponse>(responseText);
                    }
                    catch (FormatException ex)
                    {
                        throw new FormatException("Could not decode CloudStack API Response", ex);
                    }
                }

                return response;
            }
            catch (WebException e)
            {
                throw CreateCloudStackException(e, webRequest.RequestUri);
            }
        }

        public async Task<TResponse> RequestAsync<TResponse>(APIRequest request) where TResponse : new()
        {
            HttpWebRequest webRequest = CreateRequest(request);

            try
            {
                using var httpWebResponse = (await webRequest.GetResponseAsync().ConfigureAwait(false)) as HttpWebResponse;
                
                using Stream respStrm = httpWebResponse.GetResponseStream();
                respStrm.ReadTimeout = (int)this.HttpRequestTimeout.TotalMilliseconds;

                using var streamReader = new StreamReader(respStrm, Encoding.UTF8);
                string responseText = await streamReader.ReadToEndAsync().ConfigureAwait(false);
                try
                {
                    return DecodeResponse<TResponse>(responseText);
                }
                catch (FormatException ex)
                {
                    throw new FormatException("Could not decode CloudStack API Response", ex);
                }
            }
            catch (WebException e)
            {
                throw CreateCloudStackException(e, webRequest.RequestUri);
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

            JProperty resultElement = responseContainer.Children().OfType<JProperty>().FirstOrDefault(p => !p.Name.Equals("count", StringComparison.OrdinalIgnoreCase));
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
        private CloudStackBaseException CreateCloudStackException(WebException we, Uri fullUri)
        {
            if (we.InnerException is SocketException)
            {
                return new CloudStackUnavailableException($"The CloudStack API Endpoint at {ServiceUrl} was unavailable", we.InnerException);
            }
            else if (we.Status == WebExceptionStatus.ProtocolError)
            {
                var responseStream = (HttpWebResponse)we.Response;
                try
                {
                    using var reader = new StreamReader(responseStream.GetResponseStream());
                    string responseString = reader.ReadToEnd();
                    APIErrorResult errorResult = DecodeResponse<APIErrorResult>(responseString);
                    return new CloudStackException("ProtocolError on API Call", fullUri.ToString(), errorResult, we);
                }
                catch
                {
                    return new CloudStackException(
                        "Error on API call (cannot parse result)",
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

        internal HttpWebRequest CreateRequest(APIRequest request)
        {
            string queryString = CreateQuery(request.Parameters, ApiKey, SecretKey, SessionKey);
            string serviceUrlBase = ServiceUrl;
            if (!String.IsNullOrEmpty(request.OverrideEndpoint))
            {
                serviceUrlBase = serviceUrlBase.Substring(0, serviceUrlBase.Length - "api".Length) + request.OverrideEndpoint;
            }
            var fullUri = new Uri(serviceUrlBase + "?" + queryString);

            HttpWebRequest webRequest = WebRequest.CreateHttp(fullUri);
            webRequest.Accept = "application/json;charset=UTF-8";
            webRequest.Method = "GET";

            return webRequest;
        }
    }
}