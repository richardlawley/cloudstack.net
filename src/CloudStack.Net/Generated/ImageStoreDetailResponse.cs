using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ImageStoreDetailResponse
    {
        /// <summary>
        /// detail property name of the image store
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// detail property value of the image store
        /// </summary>
        public string Value { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
