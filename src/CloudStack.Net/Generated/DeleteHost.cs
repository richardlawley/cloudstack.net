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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Force delete the host. All HA enabled vms running on the host will be put to HA; HA disabled ones will be stopped
        /// </summary>
        public bool? Forced {
            get { return (bool?) Parameters[nameof(Forced).ToLower()]; }
            set { Parameters[nameof(Forced).ToLower()] = value; }
        }

        /// <summary>
        /// Force destroy local storage on this host. All VMs created on this local storage will be destroyed
        /// </summary>
        public bool? ForceDestroyLocalStorage {
            get { return (bool?) Parameters[nameof(ForceDestroyLocalStorage).ToLower()]; }
            set { Parameters[nameof(ForceDestroyLocalStorage).ToLower()] = value; }
        }

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
