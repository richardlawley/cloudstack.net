using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePortableIpRangeRequest : APIRequest
    {
        public CreatePortableIpRangeRequest() : base("createPortableIpRange") {}

        /// <summary>
        /// the ending IP address in the portable IP range
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// the gateway for the portable IP range
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the netmask of the portable IP range
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// Id of the Region
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// the beginning IP address in the portable IP range
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// VLAN id, if not specified defaulted to untagged
        /// </summary>
        public string Vlan { get; set; }

    }
    /// <summary>
    /// adds a range of portable public IP's to a region
    /// </summary>
    /// <summary>
    /// adds a range of portable public IP's to a region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PortableIpRangeResponse CreatePortableIpRange(CreatePortableIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PortableIpRangeResponse CreatePortableIpRange(CreatePortableIpRangeRequest request) => _proxy.Request<PortableIpRangeResponse>(request);
    }
}
