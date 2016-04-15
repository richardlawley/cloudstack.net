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
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// list VPC offerings by id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// true if need to list only default VPC offerings. Default value is false
        /// </summary>
        public bool? IsDefault {
            get { return GetParameterValue<bool?>(nameof(IsDefault).ToLower()); }
            set { SetParameterValue(nameof(IsDefault).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// list VPC offerings by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list VPC offerings by state
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// list VPC offerings supporting certain services
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { SetParameterValue(nameof(SupportedServices).ToLower(), value); }
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
