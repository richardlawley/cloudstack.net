using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVmNicIpRequest : APIRequest
    {
        public UpdateVmNicIpRequest() : base("updateVmNicIp") {}

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
    /// Update the default Ip of a VM Nic
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateVmNicIp(UpdateVmNicIpRequest request);
        Task<AsyncJobResponse> UpdateVmNicIpAsync(UpdateVmNicIpRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateVmNicIp(UpdateVmNicIpRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateVmNicIpAsync(UpdateVmNicIpRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
