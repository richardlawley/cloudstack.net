using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GuestOSCategoryResponse
    {
        /// <summary>
        /// the ID of the OS category
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the name of the OS category
        /// </summary>
        public string Name { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
