using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicatePublicIpRangeRequest : APIRequest
    {
        public DedicatePublicIpRangeRequest() : base("dedicatePublicIpRange") {}

        /// <summary>
        /// the id of the VLAN IP range
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// account who will own the VLAN
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// domain ID of the account owning a VLAN
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// project who will own the VLAN
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Dedicates a Public IP range to an account
    /// </summary>
    /// <summary>
    /// Dedicates a Public IP range to an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VlanIpRangeResponse DedicatePublicIpRange(DedicatePublicIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VlanIpRangeResponse DedicatePublicIpRange(DedicatePublicIpRangeRequest request) => _proxy.Request<VlanIpRangeResponse>(request);
    }
}
