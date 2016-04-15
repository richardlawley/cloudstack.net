using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ChangeServiceForSystemVmRequest : APIRequest
    {
        public ChangeServiceForSystemVmRequest() : base("changeServiceForSystemVm") {}

        /// <summary>
        /// The ID of the system vm
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the service offering ID to apply to the system vm
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
    /// Changes the service offering for a system vm (console proxy or secondary storage). The system vm must be in a "Stopped" state for this command to take effect.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SystemVmResponse ChangeServiceForSystemVm(ChangeServiceForSystemVmRequest request);
        Task<SystemVmResponse> ChangeServiceForSystemVmAsync(ChangeServiceForSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SystemVmResponse ChangeServiceForSystemVm(ChangeServiceForSystemVmRequest request) => _proxy.Request<SystemVmResponse>(request);
        public Task<SystemVmResponse> ChangeServiceForSystemVmAsync(ChangeServiceForSystemVmRequest request) => _proxy.RequestAsync<SystemVmResponse>(request);
    }
}
