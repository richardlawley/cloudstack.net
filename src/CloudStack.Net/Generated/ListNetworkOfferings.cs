using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkOfferingsRequest : APIRequest
    {
        public ListNetworkOfferingsRequest() : base("listNetworkOfferings") {}

        /// <summary>
        /// the availability of network offering. Default value is required
        /// </summary>
        public string Availability {
            get { return (string) Parameters[nameof(Availability).ToLower()]; }
            set { Parameters[nameof(Availability).ToLower()] = value; }
        }

        /// <summary>
        /// list network offerings by display text
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the network offering can be used only for network creation inside the VPC
        /// </summary>
        public bool? ForVpc {
            get { return (bool?) Parameters[nameof(ForVpc).ToLower()]; }
            set { Parameters[nameof(ForVpc).ToLower()] = value; }
        }

        /// <summary>
        /// list network offerings by guest type: shared or isolated
        /// </summary>
        public string GuestIpType {
            get { return (string) Parameters[nameof(GuestIpType).ToLower()]; }
            set { Parameters[nameof(GuestIpType).ToLower()] = value; }
        }

        /// <summary>
        /// list network offerings by ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// true if need to list only default network offerings. Default value is false
        /// </summary>
        public bool? IsDefault {
            get { return (bool?) Parameters[nameof(IsDefault).ToLower()]; }
            set { Parameters[nameof(IsDefault).ToLower()] = value; }
        }

        /// <summary>
        /// true if offering has tags specified
        /// </summary>
        public bool? IsTagged {
            get { return (bool?) Parameters[nameof(IsTagged).ToLower()]; }
            set { Parameters[nameof(IsTagged).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// list network offerings by name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the network. Pass this in if you want to see the available network offering that a network can be changed to.
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// true if need to list only netwok offerings where source NAT is supported, false otherwise
        /// </summary>
        public bool? SourceNatSupported {
            get { return (bool?) Parameters[nameof(SourceNatSupported).ToLower()]; }
            set { Parameters[nameof(SourceNatSupported).ToLower()] = value; }
        }

        /// <summary>
        /// true if need to list only network offerings which support specifying ip ranges
        /// </summary>
        public bool? SpecifyIpRanges {
            get { return (bool?) Parameters[nameof(SpecifyIpRanges).ToLower()]; }
            set { Parameters[nameof(SpecifyIpRanges).ToLower()] = value; }
        }

        /// <summary>
        /// the tags for the network offering.
        /// </summary>
        public bool? SpecifyVlan {
            get { return (bool?) Parameters[nameof(SpecifyVlan).ToLower()]; }
            set { Parameters[nameof(SpecifyVlan).ToLower()] = value; }
        }

        /// <summary>
        /// list network offerings by state
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

        /// <summary>
        /// list network offerings supporting certain services
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { Parameters[nameof(SupportedServices).ToLower()] = value; }
        }

        /// <summary>
        /// list network offerings by tags
        /// </summary>
        public string Tags {
            get { return (string) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// list by traffic type
        /// </summary>
        public string TrafficType {
            get { return (string) Parameters[nameof(TrafficType).ToLower()]; }
            set { Parameters[nameof(TrafficType).ToLower()] = value; }
        }

        /// <summary>
        /// list network offerings available for network creation in specific zone
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all available network offerings.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkOfferingResponse> ListNetworkOfferings(ListNetworkOfferingsRequest request);
        Task<ListResponse<NetworkOfferingResponse>> ListNetworkOfferingsAsync(ListNetworkOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkOfferingResponse> ListNetworkOfferings(ListNetworkOfferingsRequest request) => _proxy.Request<ListResponse<NetworkOfferingResponse>>(request);
        public Task<ListResponse<NetworkOfferingResponse>> ListNetworkOfferingsAsync(ListNetworkOfferingsRequest request) => _proxy.RequestAsync<ListResponse<NetworkOfferingResponse>>(request);
    }
}
