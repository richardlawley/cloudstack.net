using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IdpResponse
    {
        /// <summary>
        /// The IdP Entity ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The IdP Organization Name
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// The IdP Organization URL
        /// </summary>
        public string OrgUrl { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
