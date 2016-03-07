using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVPCOfferingsRequest : APIListRequest
    {
        public ListVPCOfferingsRequest() : base("listVPCOfferings") {}

        /// <summary>
        /// list VPC offerings by display text
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// list VPC offerings by id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// true if need to list only default VPC offerings. Default value is false
        /// </summary>
        public bool? IsDefault {
            get { return (bool?) Parameters[nameof(IsDefault).ToLower()]; }
            set { Parameters[nameof(IsDefault).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// list VPC offerings by name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// list VPC offerings by state
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

        /// <summary>
        /// list VPC offerings supporting certain services
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { Parameters[nameof(SupportedServices).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists VPC offerings
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VpcOfferingResponse> ListVPCOfferings(ListVPCOfferingsRequest request);
        Task<ListResponse<VpcOfferingResponse>> ListVPCOfferingsAsync(ListVPCOfferingsRequest request);
        ListResponse<VpcOfferingResponse> ListVPCOfferingsAllPages(ListVPCOfferingsRequest request);
        Task<ListResponse<VpcOfferingResponse>> ListVPCOfferingsAllPagesAsync(ListVPCOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VpcOfferingResponse> ListVPCOfferings(ListVPCOfferingsRequest request) => _proxy.Request<ListResponse<VpcOfferingResponse>>(request);
        public Task<ListResponse<VpcOfferingResponse>> ListVPCOfferingsAsync(ListVPCOfferingsRequest request) => _proxy.RequestAsync<ListResponse<VpcOfferingResponse>>(request);
        public ListResponse<VpcOfferingResponse> ListVPCOfferingsAllPages(ListVPCOfferingsRequest request) => _proxy.RequestAllPages<VpcOfferingResponse>(request);
        public Task<ListResponse<VpcOfferingResponse>> ListVPCOfferingsAllPagesAsync(ListVPCOfferingsRequest request) => _proxy.RequestAllPagesAsync<VpcOfferingResponse>(request);
    }
}
