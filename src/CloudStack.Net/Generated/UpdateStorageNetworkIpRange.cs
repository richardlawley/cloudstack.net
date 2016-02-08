using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateStorageNetworkIpRangeRequest : APIRequest
    {
        public UpdateStorageNetworkIpRangeRequest() : base("updateStorageNetworkIpRange") {}

        /// <summary>
        /// UUID of storage network ip range
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the ending IP address
        /// </summary>
        public string EndIp {
            get { return (string) Parameters[nameof(EndIp).ToLower()]; }
            set { Parameters[nameof(EndIp).ToLower()] = value; }
        }

        /// <summary>
        /// the netmask for storage network
        /// </summary>
        public string Netmask {
            get { return (string) Parameters[nameof(Netmask).ToLower()]; }
            set { Parameters[nameof(Netmask).ToLower()] = value; }
        }

        /// <summary>
        /// the beginning IP address
        /// </summary>
        public string StartIp {
            get { return (string) Parameters[nameof(StartIp).ToLower()]; }
            set { Parameters[nameof(StartIp).ToLower()] = value; }
        }

        /// <summary>
        /// Optional. the vlan the ip range sits on
        /// </summary>
        public int? Vlan {
            get { return (int?) Parameters[nameof(Vlan).ToLower()]; }
            set { Parameters[nameof(Vlan).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Update a Storage network IP range, only allowed when no IPs in this range have been allocated.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateStorageNetworkIpRange(UpdateStorageNetworkIpRangeRequest request);
        Task<AsyncJobResponse> UpdateStorageNetworkIpRangeAsync(UpdateStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateStorageNetworkIpRange(UpdateStorageNetworkIpRangeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateStorageNetworkIpRangeAsync(UpdateStorageNetworkIpRangeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
