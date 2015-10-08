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
        public string Method { get; set; }

        /// <summary>
        /// the network offering id
        /// </summary>
        public Guid NetworkOfferingId { get; set; }

        /// <summary>
        /// the resource in Nuage VSP
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// the Zone ID for the network
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// the child resource in Nuage VSP
        /// </summary>
        public string ChildResource { get; set; }

        /// <summary>
        /// the ID of the physical network in to which Nuage VSP Controller is added
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// the resource filter in Nuage VSP
        /// </summary>
        public string ResourceFilter { get; set; }

        /// <summary>
        /// the ID of the resource in Nuage VSP
        /// </summary>
        public string ResourceId { get; set; }

    }
    /// <summary>
    /// Issues a Nuage VSP REST API resource request
    /// </summary>
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
