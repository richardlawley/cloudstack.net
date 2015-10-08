using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBaremetalRctRequest : APIRequest
    {
        public AddBaremetalRctRequest() : base("addBaremetalRct") {}

        /// <summary>
        /// http url to baremetal RCT configuration
        /// </summary>
        public String RctUrl { get; set; }

    }
    /// <summary>
    /// adds baremetal rack configuration text
    /// </summary>
    /// <summary>
    /// adds baremetal rack configuration text
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BaremetalRctResponse AddBaremetalRct(AddBaremetalRctRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BaremetalRctResponse AddBaremetalRct(AddBaremetalRctRequest request) => _proxy.Request<BaremetalRctResponse>(request);
    }
}
