using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ChangeServiceForVirtualMachineRequest : APIRequest
    {
        public ChangeServiceForVirtualMachineRequest() : base("changeServiceForVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the service offering ID to apply to the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// name value pairs of custom parameters for cpu, memory and cpunumber. example details[i].name=value
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

    }
    /// <summary>
    /// Changes the service offering for a virtual machine. The virtual machine must be in a "Stopped" state for this command to take effect.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse ChangeServiceForVirtualMachine(ChangeServiceForVirtualMachineRequest request);
        Task<UserVmResponse> ChangeServiceForVirtualMachineAsync(ChangeServiceForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse ChangeServiceForVirtualMachine(ChangeServiceForVirtualMachineRequest request) => Proxy.Request<UserVmResponse>(request);
        public Task<UserVmResponse> ChangeServiceForVirtualMachineAsync(ChangeServiceForVirtualMachineRequest request) => Proxy.RequestAsync<UserVmResponse>(request);
    }
}
