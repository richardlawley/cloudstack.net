using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ScaleVirtualMachineRequest : APIRequest
    {
        public ScaleVirtualMachineRequest() : base("scaleVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the service offering for the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// name value pairs of custom parameters for cpu,memory and cpunumber. example details[i].name=value
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

    }
    /// <summary>
    /// Scales the virtual machine to a new service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ScaleVirtualMachine(ScaleVirtualMachineRequest request);
        Task<AsyncJobResponse> ScaleVirtualMachineAsync(ScaleVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ScaleVirtualMachine(ScaleVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ScaleVirtualMachineAsync(ScaleVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
