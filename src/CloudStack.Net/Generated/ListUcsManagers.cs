using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUcsManagersRequest : APIRequest
    {
        public ListUcsManagersRequest() : base("listUcsManagers") {}

        /// <summary>
        /// the ID of the ucs manager
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

        /// <summary>
        /// the zone id
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List ucs manager
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UcsManagerResponse> ListUcsManagers(ListUcsManagersRequest request);
        Task<ListResponse<UcsManagerResponse>> ListUcsManagersAsync(ListUcsManagersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UcsManagerResponse> ListUcsManagers(ListUcsManagersRequest request) => _proxy.Request<ListResponse<UcsManagerResponse>>(request);
        public Task<ListResponse<UcsManagerResponse>> ListUcsManagersAsync(ListUcsManagersRequest request) => _proxy.RequestAsync<ListResponse<UcsManagerResponse>>(request);
    }
}
