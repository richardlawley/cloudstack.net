using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateStorageNetworkIpRangeRequest : APIRequest
    {
        public CreateStorageNetworkIpRangeRequest() : base("createStorageNetworkIpRange") {}

        /// <summary>
        /// the gateway for storage network
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the netmask for storage network
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// UUID of pod where the ip range belongs to
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// the beginning IP address
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// the ending IP address
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// Optional. The vlan the ip range sits on, default to Null when it is not specificed which means you network is not on any Vlan. This is mainly for Vmware as other hypervisors can directly reterive bridge from pyhsical network traffic type table
        /// </summary>
        public int? Vlan { get; set; }

    }
    /// <summary>
    /// Creates a Storage network IP range.
    /// </summary>
    /// <summary>
    /// Creates a Storage network IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StorageNetworkIpRangeResponse CreateStorageNetworkIpRange(CreateStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StorageNetworkIpRangeResponse CreateStorageNetworkIpRange(CreateStorageNetworkIpRangeRequest request) => _proxy.Request<StorageNetworkIpRangeResponse>(request);
    }
}
