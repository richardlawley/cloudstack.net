using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetVMPasswordRequest : APIRequest
    {
        public GetVMPasswordRequest() : base("getVMPassword") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Returns an encrypted password for the VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GetVMPasswordResponse GetVMPassword(GetVMPasswordRequest request);
        Task<GetVMPasswordResponse> GetVMPasswordAsync(GetVMPasswordRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GetVMPasswordResponse GetVMPassword(GetVMPasswordRequest request) => Proxy.Request<GetVMPasswordResponse>(request);
        public Task<GetVMPasswordResponse> GetVMPasswordAsync(GetVMPasswordRequest request) => Proxy.RequestAsync<GetVMPasswordResponse>(request);
    }
}
