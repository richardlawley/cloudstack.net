using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetUploadParamsResponse
    {
        /// <summary>
        /// the template/volume ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the timestamp after which the signature expires
        /// </summary>
        public string Expires { get; set; }

        /// <summary>
        /// encrypted data to be sent in the POST request.
        /// </summary>
        public string Metadata { get; set; }

        /// <summary>
        /// POST url to upload the file to
        /// </summary>
        public string PostURL { get; set; }

        /// <summary>
        /// signature to be sent in the POST request.
        /// </summary>
        public string Signature { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
