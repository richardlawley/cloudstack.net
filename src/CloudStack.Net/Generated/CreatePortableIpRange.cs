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
            get { return (string) Parameters[nameof(EndIp).ToLower()]; }
            set { Parameters[nameof(EndIp).ToLower()] = value; }
        }

        /// <summary>
        /// the gateway for the portable IP range
        /// </summary>
        public string Gateway {
            get { return (string) Parameters[nameof(Gateway).ToLower()]; }
            set { Parameters[nameof(Gateway).ToLower()] = value; }
        }

        /// <summary>
        /// the netmask of the portable IP range
        /// </summary>
        public string Netmask {
            get { return (string) Parameters[nameof(Netmask).ToLower()]; }
            set { Parameters[nameof(Netmask).ToLower()] = value; }
        }

        /// <summary>
        /// Id of the Region
        /// </summary>
        public int RegionId {
            get { return (int) Parameters[nameof(RegionId).ToLower()]; }
            set { Parameters[nameof(RegionId).ToLower()] = value; }
        }

        /// <summary>
        /// the beginning IP address in the portable IP range
        /// </summary>
        public string StartIp {
            get { return (string) Parameters[nameof(StartIp).ToLower()]; }
            set { Parameters[nameof(StartIp).ToLower()] = value; }
        }

        /// <summary>
        /// VLAN id, if not specified defaulted to untagged
        /// </summary>
        public string Vlan {
            get { return (string) Parameters[nameof(Vlan).ToLower()]; }
            set { Parameters[nameof(Vlan).ToLower()] = value; }
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
        public AsyncJobResponse CreatePortableIpRange(CreatePortableIpRangeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreatePortableIpRangeAsync(CreatePortableIpRangeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
