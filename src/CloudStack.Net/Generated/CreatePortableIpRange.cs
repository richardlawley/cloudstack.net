using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePortableIpRangeRequest : APIRequest
    {
        public CreatePortableIpRangeRequest() : base("createPortableIpRange") {}

        /// <summary>
        /// the ending IP address in the portable IP range
        /// </summary>
        public string EndIp {
            get { return GetParameterValue<string>(nameof(EndIp).ToLower()); }
            set { SetParameterValue(nameof(EndIp).ToLower(), value); }
        }

        /// <summary>
        /// the gateway for the portable IP range
        /// </summary>
        public string Gateway {
            get { return GetParameterValue<string>(nameof(Gateway).ToLower()); }
            set { SetParameterValue(nameof(Gateway).ToLower(), value); }
        }

        /// <summary>
        /// the netmask of the portable IP range
        /// </summary>
        public string Netmask {
            get { return GetParameterValue<string>(nameof(Netmask).ToLower()); }
            set { SetParameterValue(nameof(Netmask).ToLower(), value); }
        }

        /// <summary>
        /// Id of the Region
        /// </summary>
        public int? RegionId {
            get { return GetParameterValue<int?>(nameof(RegionId).ToLower()); }
            set { SetParameterValue(nameof(RegionId).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IP address in the portable IP range
        /// </summary>
        public string StartIp {
            get { return GetParameterValue<string>(nameof(StartIp).ToLower()); }
            set { SetParameterValue(nameof(StartIp).ToLower(), value); }
        }

        /// <summary>
        /// VLAN id, if not specified defaulted to untagged
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

    }
    /// <summary>
    /// adds a range of portable public IP's to a region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreatePortableIpRange(CreatePortableIpRangeRequest request);
        Task<AsyncJobResponse> CreatePortableIpRangeAsync(CreatePortableIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreatePortableIpRange(CreatePortableIpRangeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreatePortableIpRangeAsync(CreatePortableIpRangeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
