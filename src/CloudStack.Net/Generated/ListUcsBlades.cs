using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUcsBladesRequest : APIListRequest
    {
        public ListUcsBladesRequest() : base("listUcsBlades") {}

        /// <summary>
        /// ucs manager id
        /// </summary>
        public Guid UcsManagerId {
            get { return GetParameterValue<Guid>(nameof(UcsManagerId).ToLower()); }
            set { SetParameterValue(nameof(UcsManagerId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// List ucs blades
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UcsBladeResponse> ListUcsBlades(ListUcsBladesRequest request);
        Task<ListResponse<UcsBladeResponse>> ListUcsBladesAsync(ListUcsBladesRequest request);
        ListResponse<UcsBladeResponse> ListUcsBladesAllPages(ListUcsBladesRequest request);
        Task<ListResponse<UcsBladeResponse>> ListUcsBladesAllPagesAsync(ListUcsBladesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UcsBladeResponse> ListUcsBlades(ListUcsBladesRequest request) => _proxy.Request<ListResponse<UcsBladeResponse>>(request);
        public Task<ListResponse<UcsBladeResponse>> ListUcsBladesAsync(ListUcsBladesRequest request) => _proxy.RequestAsync<ListResponse<UcsBladeResponse>>(request);
        public ListResponse<UcsBladeResponse> ListUcsBladesAllPages(ListUcsBladesRequest request) => _proxy.RequestAllPages<UcsBladeResponse>(request);
        public Task<ListResponse<UcsBladeResponse>> ListUcsBladesAllPagesAsync(ListUcsBladesRequest request) => _proxy.RequestAllPagesAsync<UcsBladeResponse>(request);
    }
}
