using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SuccessResponse
    {
        /// <summary>
        /// any text associated with the success or failure
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// true if operation is executed successfully
        /// </summary>
        public bool Success { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
