using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteHostRequest : APIRequest
    {
        public DeleteHostRequest() : base("deleteHost") {}

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Force delete the host. All HA enabled vms running on the host will be put to HA; HA disabled ones will be stopped
        /// </summary>
        public bool? Forced { get; set; }

        /// <summary>
        /// Force destroy local storage on this host. All VMs created on this local storage will be destroyed
        /// </summary>
        public bool? ForceDestroyLocalStorage { get; set; }

    }
    /// <summary>
    /// Deletes a host.
    /// </summary>
    /// <summary>
    /// Deletes a host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteHost(DeleteHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteHost(DeleteHostRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
