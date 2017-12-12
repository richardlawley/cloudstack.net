using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkOfferingsRequest : APIListRequest
    {
        public ListNetworkOfferingsRequest() : base("listNetworkOfferings") {}

        /// <summary>
        /// the availability of network offering. Default value is required
        /// </summary>
        public string Availability {
            get { return GetParameterValue<string>(nameof(Availability).ToLower()); }
            set { SetParameterValue(nameof(Availability).ToLower(), value); }
        }

        /// <summary>
        /// list network offerings by display text
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the network offering can be used only for network creation inside the VPC
        /// </summary>
        public bool? ForVpc {
            get { return GetParameterValue<bool?>(nameof(ForVpc).ToLower()); }
            set { SetParameterValue(nameof(ForVpc).ToLower(), value); }
        }

        /// <summary>
        /// list network offerings by guest type: shared or isolated
        /// </summary>
        public string GuestIpType {
            get { return GetParameterValue<string>(nameof(GuestIpType).ToLower()); }
            set { SetParameterValue(nameof(GuestIpType).ToLower(), value); }
        }

        /// <summary>
        /// list network offerings by ID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// true if need to list only default network offerings. Default value is false
        /// </summary>
        public bool? IsDefault {
            get { return GetParameterValue<bool?>(nameof(IsDefault).ToLower()); }
            set { SetParameterValue(nameof(IsDefault).ToLower(), value); }
        }

        /// <summary>
        /// true if offering has tags specified
        /// </summary>
        public bool? IsTagged {
            get { return GetParameterValue<bool?>(nameof(IsTagged).ToLower()); }
            set { SetParameterValue(nameof(IsTagged).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// list network offerings by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the network. Pass this in if you want to see the available network offering that a network can be changed to.
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// true if need to list only netwok offerings where source NAT is supported, false otherwise
        /// </summary>
        public bool? SourceNatSupported {
            get { return GetParameterValue<bool?>(nameof(SourceNatSupported).ToLower()); }
            set { SetParameterValue(nameof(SourceNatSupported).ToLower(), value); }
        }

        /// <summary>
        /// true if need to list only network offerings which support specifying ip ranges
        /// </summary>
        public bool? SpecifyIpRanges {
            get { return GetParameterValue<bool?>(nameof(SpecifyIpRanges).ToLower()); }
            set { SetParameterValue(nameof(SpecifyIpRanges).ToLower(), value); }
        }

        /// <summary>
        /// the tags for the network offering.
        /// </summary>
        public bool? SpecifyVlan {
            get { return GetParameterValue<bool?>(nameof(SpecifyVlan).ToLower()); }
            set { SetParameterValue(nameof(SpecifyVlan).ToLower(), value); }
        }

        /// <summary>
        /// list network offerings by state
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// list network offerings supporting certain services
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { SetParameterValue(nameof(SupportedServices).ToLower(), value); }
        }

        /// <summary>
        /// list network offerings by tags
        /// </summary>
        public string Tags {
            get { return GetParameterValue<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// list by traffic type
        /// </summary>
        public string TrafficType {
            get { return GetParameterValue<string>(nameof(TrafficType).ToLower()); }
            set { SetParameterValue(nameof(TrafficType).ToLower(), value); }
        }

        /// <summary>
        /// list network offerings available for network creation in specific zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available network offerings.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkOfferingResponse> ListNetworkOfferings(ListNetworkOfferingsRequest request);
        Task<ListResponse<NetworkOfferingResponse>> ListNetworkOfferingsAsync(ListNetworkOfferingsRequest request);
        ListResponse<NetworkOfferingResponse> ListNetworkOfferingsAllPages(ListNetworkOfferingsRequest request);
        Task<ListResponse<NetworkOfferingResponse>> ListNetworkOfferingsAllPagesAsync(ListNetworkOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkOfferingResponse> ListNetworkOfferings(ListNetworkOfferingsRequest request) => Proxy.Request<ListResponse<NetworkOfferingResponse>>(request);
        public Task<ListResponse<NetworkOfferingResponse>> ListNetworkOfferingsAsync(ListNetworkOfferingsRequest request) => Proxy.RequestAsync<ListResponse<NetworkOfferingResponse>>(request);
        public ListResponse<NetworkOfferingResponse> ListNetworkOfferingsAllPages(ListNetworkOfferingsRequest request) => Proxy.RequestAllPages<NetworkOfferingResponse>(request);
        public Task<ListResponse<NetworkOfferingResponse>> ListNetworkOfferingsAllPagesAsync(ListNetworkOfferingsRequest request) => Proxy.RequestAllPagesAsync<NetworkOfferingResponse>(request);
    }
}
