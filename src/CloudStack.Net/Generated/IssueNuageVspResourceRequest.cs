using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Method).ToLower()]; }
            set { Parameters[nameof(Method).ToLower()] = value; }
        }

        /// <summary>
        /// the network offering id
        /// </summary>
        public Guid NetworkOfferingId {
            get { return (Guid) Parameters[nameof(NetworkOfferingId).ToLower()]; }
            set { Parameters[nameof(NetworkOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// the resource in Nuage VSP
        /// </summary>
        public string Resource {
            get { return (string) Parameters[nameof(Resource).ToLower()]; }
            set { Parameters[nameof(Resource).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the network
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// the child resource in Nuage VSP
        /// </summary>
        public string ChildResource {
            get { return (string) Parameters[nameof(ChildResource).ToLower()]; }
            set { Parameters[nameof(ChildResource).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the physical network in to which Nuage VSP Controller is added
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// the resource filter in Nuage VSP
        /// </summary>
        public string ResourceFilter {
            get { return (string) Parameters[nameof(ResourceFilter).ToLower()]; }
            set { Parameters[nameof(ResourceFilter).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the resource in Nuage VSP
        /// </summary>
        public string ResourceId {
            get { return (string) Parameters[nameof(ResourceId).ToLower()]; }
            set { Parameters[nameof(ResourceId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Issues a Nuage VSP REST API resource request
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NuageVspResourceResponse IssueNuageVspResourceRequest(IssueNuageVspResourceRequestRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NuageVspResourceResponse IssueNuageVspResourceRequest(IssueNuageVspResourceRequestRequest request) => _proxy.Request<NuageVspResourceResponse>(request);
    }
}
