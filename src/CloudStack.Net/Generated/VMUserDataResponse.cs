using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VMUserDataResponse
    {
        /// <summary>
        /// Base 64 encoded VM user data
        /// </summary>
        public string UserData { get; set; }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public string Virtualmachineid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
