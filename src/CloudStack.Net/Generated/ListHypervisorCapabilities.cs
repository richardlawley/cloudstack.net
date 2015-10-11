using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHypervisorCapabilitiesRequest : APIRequest
    {
        public ListHypervisorCapabilitiesRequest() : base("listHypervisorCapabilities") {}

        /// <summary>
        /// the hypervisor for which to restrict the search
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// ID of the hypervisor capability
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all hypervisor capabilities.
    /// </summary>
    /// <summary>
    /// Lists all hypervisor capabilities.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HypervisorCapabilitiesResponse> ListHypervisorCapabilities(ListHypervisorCapabilitiesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HypervisorCapabilitiesResponse> ListHypervisorCapabilities(ListHypervisorCapabilitiesRequest request) => _proxy.Request<ListResponse<HypervisorCapabilitiesResponse>>(request);
    }
}
