using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteHostRequest : APIRequest
    {
        public DeleteHostRequest() : base("deleteHost") {}

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Force delete the host. All HA enabled vms running on the host will be put to HA; HA disabled ones will be stopped
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

        /// <summary>
        /// Force destroy local storage on this host. All VMs created on this local storage will be destroyed
        /// </summary>
        public bool? ForceDestroyLocalStorage {
            get { return GetParameterValue<bool?>(nameof(ForceDestroyLocalStorage).ToLower()); }
            set { SetParameterValue(nameof(ForceDestroyLocalStorage).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteHost(DeleteHostRequest request);
        Task<SuccessResponse> DeleteHostAsync(DeleteHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteHost(DeleteHostRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteHostAsync(DeleteHostRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
