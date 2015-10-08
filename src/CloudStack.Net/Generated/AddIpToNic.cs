using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddIpToNicRequest : APIRequest
    {
        public AddIpToNicRequest() : base("addIpToNic") {}

        /// <summary>
        /// the ID of the nic to which you want to assign private IP
        /// </summary>
        public Guid NicId { get; set; }

        /// <summary>
        /// Secondary IP Address
        /// </summary>
        public string IpAddr { get; set; }

    }
    /// <summary>
    /// Assigns secondary IP to NIC
    /// </summary>
    /// <summary>
    /// Assigns secondary IP to NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NicSecondaryIpResponse AddIpToNic(AddIpToNicRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NicSecondaryIpResponse AddIpToNic(AddIpToNicRequest request) => _proxy.Request<NicSecondaryIpResponse>(request);
    }
}
