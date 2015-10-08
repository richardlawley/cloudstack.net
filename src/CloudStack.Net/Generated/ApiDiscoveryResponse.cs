using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApiDiscoveryResponse
    {
        /// <summary>
        /// description of the api
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// true if api is asynchronous
        /// </summary>
        public bool IsAsync { get; set; }

        /// <summary>
        /// the name of the api command
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// comma separated related apis
        /// </summary>
        public string Related { get; set; }

        /// <summary>
        /// version of CloudStack the api was introduced in
        /// </summary>
        public string Since { get; set; }

        /// <summary>
        /// response field type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// the list params the api accepts
        /// </summary>
        public IList<ApiParameterResponse> Params { get; set; }

        /// <summary>
        /// api response fields
        /// </summary>
        public IList<ApiResponseResponse> Response { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
