using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCiscoNexusVSMsRequest : APIRequest
    {
        public ListCiscoNexusVSMsRequest() : base("listCiscoNexusVSMs") {}

        /// <summary>
        /// Id of the CloudStack cluster in which the Cisco Nexus 1000v VSM appliance.
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
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
        /// Id of the CloudStack cluster in which the Cisco Nexus 1000v VSM appliance.
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Retrieves a Cisco Nexus 1000v Virtual Switch Manager device associated with a Cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CiscoNexusVSMResponse> ListCiscoNexusVSMs(ListCiscoNexusVSMsRequest request);
        Task<ListResponse<CiscoNexusVSMResponse>> ListCiscoNexusVSMsAsync(ListCiscoNexusVSMsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CiscoNexusVSMResponse> ListCiscoNexusVSMs(ListCiscoNexusVSMsRequest request) => _proxy.Request<ListResponse<CiscoNexusVSMResponse>>(request);
        public Task<ListResponse<CiscoNexusVSMResponse>> ListCiscoNexusVSMsAsync(ListCiscoNexusVSMsRequest request) => _proxy.RequestAsync<ListResponse<CiscoNexusVSMResponse>>(request);
    }
}
