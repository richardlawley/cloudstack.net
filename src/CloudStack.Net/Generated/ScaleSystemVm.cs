using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ScaleSystemVmRequest : APIRequest
    {
        public ScaleSystemVmRequest() : base("scaleSystemVm") {}

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
    /// Scale the service offering for a system vm (console proxy or secondary storage). The system vm must be in a "Stopped" state for this command to take effect.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ScaleSystemVm(ScaleSystemVmRequest request);
        Task<AsyncJobResponse> ScaleSystemVmAsync(ScaleSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ScaleSystemVm(ScaleSystemVmRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ScaleSystemVmAsync(ScaleSystemVmRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
