using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SamlAuthorizationResponse
    {
        /// <summary>
        /// the authorized Identity Provider ID
        /// </summary>
        public string IdpId { get; set; }

        /// <summary>
        /// the SAML authorization status
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// the user ID
        /// </summary>
        public string UserId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
