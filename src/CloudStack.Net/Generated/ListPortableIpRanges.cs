using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPortableIpRangesRequest : APIListRequest
    {
        public ListPortableIpRangesRequest() : base("listPortableIpRanges") {}

        /// <summary>
        /// Id of the portable ip range
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Id of a Region
        /// </summary>
        public int? RegionId {
            get { return GetParameterValue<int?>(nameof(RegionId).ToLower()); }
            set { SetParameterValue(nameof(RegionId).ToLower(), value); }
        }

    }
    /// <summary>
    /// list portable IP ranges
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PortableIpRangeResponse> ListPortableIpRanges(ListPortableIpRangesRequest request);
        Task<ListResponse<PortableIpRangeResponse>> ListPortableIpRangesAsync(ListPortableIpRangesRequest request);
        ListResponse<PortableIpRangeResponse> ListPortableIpRangesAllPages(ListPortableIpRangesRequest request);
        Task<ListResponse<PortableIpRangeResponse>> ListPortableIpRangesAllPagesAsync(ListPortableIpRangesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PortableIpRangeResponse> ListPortableIpRanges(ListPortableIpRangesRequest request) => _proxy.Request<ListResponse<PortableIpRangeResponse>>(request);
        public Task<ListResponse<PortableIpRangeResponse>> ListPortableIpRangesAsync(ListPortableIpRangesRequest request) => _proxy.RequestAsync<ListResponse<PortableIpRangeResponse>>(request);
        public ListResponse<PortableIpRangeResponse> ListPortableIpRangesAllPages(ListPortableIpRangesRequest request) => _proxy.RequestAllPages<PortableIpRangeResponse>(request);
        public Task<ListResponse<PortableIpRangeResponse>> ListPortableIpRangesAllPagesAsync(ListPortableIpRangesRequest request) => _proxy.RequestAllPagesAsync<PortableIpRangeResponse>(request);
    }
}
