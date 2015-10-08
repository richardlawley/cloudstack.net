using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CiscoAsa1000vResourceResponse
    {
        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
