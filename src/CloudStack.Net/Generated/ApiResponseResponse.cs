using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApiResponseResponse
    {
        /// <summary>
        /// description of the api response field
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the name of the api response field
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// api response fields
        /// </summary>
        public IList<ApiResponseResponse> Response { get; set; }

        /// <summary>
        /// response field type
        /// </summary>
        public string Type { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
