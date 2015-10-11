using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCiscoAsa1000vResourcesRequest : APIRequest
    {
        public ListCiscoAsa1000vResourcesRequest() : base("listCiscoAsa1000vResources") {}

        /// <summary>
        /// Hostname or ip address of the Cisco ASA 1000v appliance.
        /// </summary>
        public string Hostname {
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
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

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// Cisco ASA 1000v resource ID
        /// </summary>
        public Guid Resourceid {
            get { return (Guid) Parameters[nameof(Resourceid).ToLower()]; }
            set { Parameters[nameof(Resourceid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists Cisco ASA 1000v appliances
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CiscoAsa1000vResourceResponse> ListCiscoAsa1000vResources(ListCiscoAsa1000vResourcesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CiscoAsa1000vResourceResponse> ListCiscoAsa1000vResources(ListCiscoAsa1000vResourcesRequest request) => _proxy.Request<ListResponse<CiscoAsa1000vResourceResponse>>(request);
    }
}
