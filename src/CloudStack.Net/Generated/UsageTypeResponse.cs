using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UsageTypeResponse
    {
        /// <summary>
        /// description of usage type
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// usage type
        /// </summary>
        public int Usagetypeid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
