using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CustomCertificateResponse
    {
        /// <summary>
        /// message of the certificate upload operation
        /// </summary>
        public string Message { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
