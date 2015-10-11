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
        public string Gateway {
            get { return (string) Parameters[nameof(Gateway).ToLower()]; }
            set { Parameters[nameof(Gateway).ToLower()] = value; }
        }

        /// <summary>
        /// the netmask for storage network
        /// </summary>
        public string Netmask {
            get { return (string) Parameters[nameof(Netmask).ToLower()]; }
            set { Parameters[nameof(Netmask).ToLower()] = value; }
        }

        /// <summary>
        /// UUID of pod where the ip range belongs to
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// the beginning IP address
        /// </summary>
        public string StartIp {
            get { return (string) Parameters[nameof(StartIp).ToLower()]; }
            set { Parameters[nameof(StartIp).ToLower()] = value; }
        }

        /// <summary>
        /// the ending IP address
        /// </summary>
        public string EndIp {
            get { return (string) Parameters[nameof(EndIp).ToLower()]; }
            set { Parameters[nameof(EndIp).ToLower()] = value; }
        }

        /// <summary>
        /// Optional. The vlan the ip range sits on, default to Null when it is not specificed which means you network is not on any Vlan. This is mainly for Vmware as other hypervisors can directly reterive bridge from pyhsical network traffic type table
        /// </summary>
        public int? Vlan {
            get { return (int?) Parameters[nameof(Vlan).ToLower()]; }
            set { Parameters[nameof(Vlan).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a Storage network IP range.
    /// </summary>
    /// <summary>
    /// Creates a Storage network IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateStorageNetworkIpRange(CreateStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateStorageNetworkIpRange(CreateStorageNetworkIpRangeRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
