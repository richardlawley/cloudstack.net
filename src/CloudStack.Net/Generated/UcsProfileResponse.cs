using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UcsProfileResponse
    {
        /// <summary>
        /// ucs profile dn
        /// </summary>
        public string Ucsdn { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
