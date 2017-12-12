using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddIpToNicRequest : APIRequest
    {
        public AddIpToNicRequest() : base("addIpToNic") {}

        /// <summary>
        /// the ID of the nic to which you want to assign private IP
        /// </summary>
        public Guid NicId {
            get { return GetParameterValue<Guid>(nameof(NicId).ToLower()); }
            set { SetParameterValue(nameof(NicId).ToLower(), value); }
        }

        /// <summary>
        /// Secondary IP Address
        /// </summary>
        public string Ipaddress {
            get { return GetParameterValue<string>(nameof(Ipaddress).ToLower()); }
            set { SetParameterValue(nameof(Ipaddress).ToLower(), value); }
        }

    }
    /// <summary>
    /// Assigns secondary IP to NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddIpToNic(AddIpToNicRequest request);
        Task<AsyncJobResponse> AddIpToNicAsync(AddIpToNicRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddIpToNic(AddIpToNicRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddIpToNicAsync(AddIpToNicRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
