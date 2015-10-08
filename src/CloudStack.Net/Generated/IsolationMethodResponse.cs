using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IsolationMethodResponse
    {
        /// <summary>
        /// Network isolation method name
        /// </summary>
        public string Name { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
