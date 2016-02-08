using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterResponse
    {
        /// <summary>
        /// the api key of the registered user
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// the secret key of the registered user
        /// </summary>
        public string SecretKey { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
