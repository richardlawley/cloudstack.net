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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ending IP address
        /// </summary>
        public string EndIp {
            get { return GetParameterValue<string>(nameof(EndIp).ToLower()); }
            set { SetParameterValue(nameof(EndIp).ToLower(), value); }
        }

        /// <summary>
        /// the netmask for storage network
        /// </summary>
        public string Netmask {
            get { return GetParameterValue<string>(nameof(Netmask).ToLower()); }
            set { SetParameterValue(nameof(Netmask).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IP address
        /// </summary>
        public string StartIp {
            get { return GetParameterValue<string>(nameof(StartIp).ToLower()); }
            set { SetParameterValue(nameof(StartIp).ToLower(), value); }
        }

        /// <summary>
        /// Optional. the vlan the ip range sits on
        /// </summary>
        public int? Vlan {
            get { return GetParameterValue<int?>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
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
        public AsyncJobResponse UpdateStorageNetworkIpRange(UpdateStorageNetworkIpRangeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateStorageNetworkIpRangeAsync(UpdateStorageNetworkIpRangeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
