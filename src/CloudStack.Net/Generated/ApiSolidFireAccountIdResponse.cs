using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApiSolidFireAccountIdResponse
    {
        /// <summary>
        /// SolidFire Account ID
        /// </summary>
        public long SolidFireAccountId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
