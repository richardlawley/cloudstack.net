using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetVMPasswordResponse
    {
        /// <summary>
        /// The base64 encoded encrypted password of the VM
        /// </summary>
        public string EncryptedPassword { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
