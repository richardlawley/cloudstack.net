using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UcsBladeResponse
    {
        /// <summary>
        /// ucs blade id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// ucs blade dn
        /// </summary>
        public string Bladedn { get; set; }

        /// <summary>
        /// cloudstack host id this blade associates to
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// associated ucs profile dn
        /// </summary>
        public string Profiledn { get; set; }

        /// <summary>
        /// ucs manager id
        /// </summary>
        public string UcsManagerId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
