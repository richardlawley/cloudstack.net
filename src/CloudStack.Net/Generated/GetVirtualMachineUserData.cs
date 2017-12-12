using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetVirtualMachineUserDataRequest : APIRequest
    {
        public GetVirtualMachineUserDataRequest() : base("getVirtualMachineUserData") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Returns user data associated with the VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VMUserDataResponse GetVirtualMachineUserData(GetVirtualMachineUserDataRequest request);
        Task<VMUserDataResponse> GetVirtualMachineUserDataAsync(GetVirtualMachineUserDataRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VMUserDataResponse GetVirtualMachineUserData(GetVirtualMachineUserDataRequest request) => Proxy.Request<VMUserDataResponse>(request);
        public Task<VMUserDataResponse> GetVirtualMachineUserDataAsync(GetVirtualMachineUserDataRequest request) => Proxy.RequestAsync<VMUserDataResponse>(request);
    }
}
