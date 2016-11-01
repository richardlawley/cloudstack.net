using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    /// <summary>
    /// Solves difficult of parsing CloudStack API call error information that is embedded in a variety of responses.
    /// Difficult arises from error information not be demarcated by a specific tag.  Instead, error information may appear
    /// in a job result or at the top level of a response type.
    /// </summary>
    [Serializable]
    public class APIErrorResult
    {
        /// <summary>
        /// Initializes a new instance of the APIErrorResult class from an XDocument contain XML 
        /// corresponding to API call response.
        /// </summary>
        public APIErrorResult()
        {
            this.ErrorText = this.ErrorCode = string.Empty;
        }

        /// <summary>
        /// HTTP error code.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Description of exact problem.
        /// </summary>
        public string ErrorText { get; set; }

        /// <summary>
        /// CloudStack Error Code
        /// </summary>
        [JsonProperty("cserrorcode")]
        public int? CloudStackErrorCode { get; set; }

        public dynamic UuidList { get; set; }

        /// <summary>
        /// Create string corresponding to object.
        /// </summary>
        /// <returns>String providing error details held by object.</returns>
        public override string ToString() => $"Error: ({CloudStackErrorCode}) {ErrorText}";
    }
}
