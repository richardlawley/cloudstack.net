using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDiskOfferingsRequest : APIListRequest
    {
        public ListDiskOfferingsRequest() : base("listDiskOfferings") {}

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// ID of the disk offering
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// name of the disk offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available disk offerings.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DiskOfferingResponse> ListDiskOfferings(ListDiskOfferingsRequest request);
        Task<ListResponse<DiskOfferingResponse>> ListDiskOfferingsAsync(ListDiskOfferingsRequest request);
        ListResponse<DiskOfferingResponse> ListDiskOfferingsAllPages(ListDiskOfferingsRequest request);
        Task<ListResponse<DiskOfferingResponse>> ListDiskOfferingsAllPagesAsync(ListDiskOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DiskOfferingResponse> ListDiskOfferings(ListDiskOfferingsRequest request) => _proxy.Request<ListResponse<DiskOfferingResponse>>(request);
        public Task<ListResponse<DiskOfferingResponse>> ListDiskOfferingsAsync(ListDiskOfferingsRequest request) => _proxy.RequestAsync<ListResponse<DiskOfferingResponse>>(request);
        public ListResponse<DiskOfferingResponse> ListDiskOfferingsAllPages(ListDiskOfferingsRequest request) => _proxy.RequestAllPages<DiskOfferingResponse>(request);
        public Task<ListResponse<DiskOfferingResponse>> ListDiskOfferingsAllPagesAsync(ListDiskOfferingsRequest request) => _proxy.RequestAllPagesAsync<DiskOfferingResponse>(request);
    }
}
