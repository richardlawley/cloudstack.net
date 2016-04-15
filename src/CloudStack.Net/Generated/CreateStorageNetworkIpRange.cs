using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Gateway).ToLower()); }
            set { SetParameterValue(nameof(Gateway).ToLower(), value); }
        }

        /// <summary>
        /// the netmask for storage network
        /// </summary>
        public string Netmask {
            get { return GetParameterValue<string>(nameof(Netmask).ToLower()); }
            set { SetParameterValue(nameof(Netmask).ToLower(), value); }
        }

        /// <summary>
        /// UUID of pod where the ip range belongs to
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IP address
        /// </summary>
        public string StartIp {
            get { return GetParameterValue<string>(nameof(StartIp).ToLower()); }
            set { SetParameterValue(nameof(StartIp).ToLower(), value); }
        }

        /// <summary>
        /// the ending IP address
        /// </summary>
        public string EndIp {
            get { return GetParameterValue<string>(nameof(EndIp).ToLower()); }
            set { SetParameterValue(nameof(EndIp).ToLower(), value); }
        }

        /// <summary>
        /// Optional. The vlan the ip range sits on, default to Null when it is not specificed which means you network is not on any Vlan. This is mainly for Vmware as other hypervisors can directly reterive bridge from pyhsical network traffic type table
        /// </summary>
        public int? Vlan {
            get { return GetParameterValue<int?>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a Storage network IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateStorageNetworkIpRange(CreateStorageNetworkIpRangeRequest request);
        Task<AsyncJobResponse> CreateStorageNetworkIpRangeAsync(CreateStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateStorageNetworkIpRange(CreateStorageNetworkIpRangeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateStorageNetworkIpRangeAsync(CreateStorageNetworkIpRangeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
