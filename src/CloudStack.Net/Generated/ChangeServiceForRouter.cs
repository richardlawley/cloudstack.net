using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ChangeServiceForRouterRequest : APIRequest
    {
        public ChangeServiceForRouterRequest() : base("changeServiceForRouter") {}

        /// <summary>
        /// The ID of the router
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the service offering ID to apply to the domain router
        /// </summary>
        public Guid ServiceOfferingId {
            get { return (Guid) Parameters[nameof(ServiceOfferingId).ToLower()]; }
            set { Parameters[nameof(ServiceOfferingId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Upgrades domain router to a new service offering
    /// </summary>
    /// <summary>
    /// Upgrades domain router to a new service offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainRouterResponse ChangeServiceForRouter(ChangeServiceForRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainRouterResponse ChangeServiceForRouter(ChangeServiceForRouterRequest request) => _proxy.Request<DomainRouterResponse>(request);
    }
}
