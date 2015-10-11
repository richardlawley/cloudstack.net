using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBaremetalRctRequest : APIRequest
    {
        public ListBaremetalRctRequest() : base("listBaremetalRct") {}

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
    /// list baremetal rack configuration
    /// </summary>
    /// <summary>
    /// list baremetal rack configuration
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BaremetalRctResponse> ListBaremetalRct(ListBaremetalRctRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BaremetalRctResponse> ListBaremetalRct(ListBaremetalRctRequest request) => _proxy.Request<ListResponse<BaremetalRctResponse>>(request);
    }
}
