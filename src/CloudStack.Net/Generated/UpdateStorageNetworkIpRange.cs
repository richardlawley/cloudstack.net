using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateStorageNetworkIpRangeRequest : APIRequest
    {
        public UpdateStorageNetworkIpRangeRequest() : base("updateStorageNetworkIpRange") {}

        /// <summary>
        /// UUID of storage network ip range
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the ending IP address
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// the netmask for storage network
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the beginning IP address
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// Optional. the vlan the ip range sits on
        /// </summary>
        public int? Vlan { get; set; }

    }
    /// <summary>
    /// Update a Storage network IP range, only allowed when no IPs in this range have been allocated.
    /// </summary>
    /// <summary>
    /// Update a Storage network IP range, only allowed when no IPs in this range have been allocated.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StorageNetworkIpRangeResponse UpdateStorageNetworkIpRange(UpdateStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StorageNetworkIpRangeResponse UpdateStorageNetworkIpRange(UpdateStorageNetworkIpRangeRequest request) => _proxy.Request<StorageNetworkIpRangeResponse>(request);
    }
}
