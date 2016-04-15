using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the service offering ID to apply to the domain router
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Upgrades domain router to a new service offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainRouterResponse ChangeServiceForRouter(ChangeServiceForRouterRequest request);
        Task<DomainRouterResponse> ChangeServiceForRouterAsync(ChangeServiceForRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainRouterResponse ChangeServiceForRouter(ChangeServiceForRouterRequest request) => _proxy.Request<DomainRouterResponse>(request);
        public Task<DomainRouterResponse> ChangeServiceForRouterAsync(ChangeServiceForRouterRequest request) => _proxy.RequestAsync<DomainRouterResponse>(request);
    }
}
