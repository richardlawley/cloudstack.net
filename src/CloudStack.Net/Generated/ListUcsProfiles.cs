using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUcsProfilesRequest : APIRequest
    {
        public ListUcsProfilesRequest() : base("listUcsProfiles") {}

        /// <summary>
        /// the id for the ucs manager
        /// </summary>
        public Guid UcsManagerId {
            get { return (Guid) Parameters[nameof(UcsManagerId).ToLower()]; }
            set { Parameters[nameof(UcsManagerId).ToLower()] = value; }
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
    /// List profile in ucs manager
    /// </summary>
    /// <summary>
    /// List profile in ucs manager
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UcsProfileResponse> ListUcsProfiles(ListUcsProfilesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UcsProfileResponse> ListUcsProfiles(ListUcsProfilesRequest request) => _proxy.Request<ListResponse<UcsProfileResponse>>(request);
    }
}
