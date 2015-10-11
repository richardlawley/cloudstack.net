using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StopRouterRequest : APIRequest
    {
        public StopRouterRequest() : base("stopRouter") {}

        /// <summary>
        /// the ID of the router
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Force stop the VM. The caller knows the VM is stopped.
        /// </summary>
        public bool? Forced {
            get { return (bool?) Parameters[nameof(Forced).ToLower()]; }
            set { Parameters[nameof(Forced).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Stops a router.
    /// </summary>
    /// <summary>
    /// Stops a router.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainRouterResponse StopRouter(StopRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainRouterResponse StopRouter(StopRouterRequest request) => _proxy.Request<DomainRouterResponse>(request);
    }
}
