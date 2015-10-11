using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRegionsRequest : APIRequest
    {
        public ListRegionsRequest() : base("listRegions") {}

        /// <summary>
        /// List Region by region ID.
        /// </summary>
        public int? Id {
            get { return (int?) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// List Region by region name.
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
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
    /// Lists Regions
    /// </summary>
    /// <summary>
    /// Lists Regions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<RegionResponse> ListRegions(ListRegionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<RegionResponse> ListRegions(ListRegionsRequest request) => _proxy.Request<ListResponse<RegionResponse>>(request);
    }
}
