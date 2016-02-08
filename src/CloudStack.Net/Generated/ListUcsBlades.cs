using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUcsBladesRequest : APIRequest
    {
        public ListUcsBladesRequest() : base("listUcsBlades") {}

        /// <summary>
        /// ucs manager id
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
    /// List ucs blades
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UcsBladeResponse> ListUcsBlades(ListUcsBladesRequest request);
        Task<ListResponse<UcsBladeResponse>> ListUcsBladesAsync(ListUcsBladesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UcsBladeResponse> ListUcsBlades(ListUcsBladesRequest request) => _proxy.Request<ListResponse<UcsBladeResponse>>(request);
        public Task<ListResponse<UcsBladeResponse>> ListUcsBladesAsync(ListUcsBladesRequest request) => _proxy.RequestAsync<ListResponse<UcsBladeResponse>>(request);
    }
}
