using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IssueNuageVspResourceRequestRequest : APIRequest
    {
        public IssueNuageVspResourceRequestRequest() : base("issueNuageVspResourceRequest") {}

        /// <summary>
        /// the Nuage VSP REST API method type
        /// </summary>
        public string Method {
            get { return GetParameterValue<string>(nameof(Method).ToLower()); }
            set { SetParameterValue(nameof(Method).ToLower(), value); }
        }

        /// <summary>
        /// the network offering id
        /// </summary>
        public Guid NetworkOfferingId {
            get { return GetParameterValue<Guid>(nameof(NetworkOfferingId).ToLower()); }
            set { SetParameterValue(nameof(NetworkOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the resource in Nuage VSP
        /// </summary>
        public string Resource {
            get { return GetParameterValue<string>(nameof(Resource).ToLower()); }
            set { SetParameterValue(nameof(Resource).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the network
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// the child resource in Nuage VSP
        /// </summary>
        public string ChildResource {
            get { return GetParameterValue<string>(nameof(ChildResource).ToLower()); }
            set { SetParameterValue(nameof(ChildResource).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the physical network in to which Nuage VSP Controller is added
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the resource filter in Nuage VSP
        /// </summary>
        public string ResourceFilter {
            get { return GetParameterValue<string>(nameof(ResourceFilter).ToLower()); }
            set { SetParameterValue(nameof(ResourceFilter).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the resource in Nuage VSP
        /// </summary>
        public string ResourceId {
            get { return GetParameterValue<string>(nameof(ResourceId).ToLower()); }
            set { SetParameterValue(nameof(ResourceId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Issues a Nuage VSP REST API resource request
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NuageVspResourceResponse IssueNuageVspResourceRequest(IssueNuageVspResourceRequestRequest request);
        Task<NuageVspResourceResponse> IssueNuageVspResourceRequestAsync(IssueNuageVspResourceRequestRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NuageVspResourceResponse IssueNuageVspResourceRequest(IssueNuageVspResourceRequestRequest request) => _proxy.Request<NuageVspResourceResponse>(request);
        public Task<NuageVspResourceResponse> IssueNuageVspResourceRequestAsync(IssueNuageVspResourceRequestRequest request) => _proxy.RequestAsync<NuageVspResourceResponse>(request);
    }
}
