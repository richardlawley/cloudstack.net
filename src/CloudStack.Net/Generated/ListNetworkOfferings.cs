using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkOfferingsRequest : APIRequest
    {
        public ListNetworkOfferingsRequest() : base("listNetworkOfferings") {}

        /// <summary>
        /// the availability of network offering. Default value is required
        /// </summary>
        public string Availability { get; set; }

        /// <summary>
        /// list network offerings by display text
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the network offering can be used only for network creation inside the VPC
        /// </summary>
        public bool? ForVpc { get; set; }

        /// <summary>
        /// list network offerings by guest type: shared or isolated
        /// </summary>
        public string GuestIpType { get; set; }

        /// <summary>
        /// list network offerings by ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// true if need to list only default network offerings. Default value is false
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// true if offering has tags specified
        /// </summary>
        public bool? IsTagged { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list network offerings by name
        /// </summary>
        public string NetworkOfferingName { get; set; }

        /// <summary>
        /// the ID of the network. Pass this in if you want to see the available network offering that a network can be changed to.
        /// </summary>
        public Guid NetworkId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// true if need to list only netwok offerings where source NAT is supported, false otherwise
        /// </summary>
        public bool? SourceNatSupported { get; set; }

        /// <summary>
        /// true if need to list only network offerings which support specifying ip ranges
        /// </summary>
        public bool? SpecifyIpRanges { get; set; }

        /// <summary>
        /// the tags for the network offering.
        /// </summary>
        public bool? SpecifyVlan { get; set; }

        /// <summary>
        /// list network offerings by state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// list network offerings supporting certain services
        /// </summary>
        public IList<string> SupportedServices { get; set; }

        /// <summary>
        /// list network offerings by tags
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// list by traffic type
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// list network offerings available for network creation in specific zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all available network offerings.
    /// </summary>
    /// <summary>
    /// Lists all available network offerings.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkOfferingResponse> ListNetworkOfferings(ListNetworkOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkOfferingResponse> ListNetworkOfferings(ListNetworkOfferingsRequest request) => _proxy.Request<ListResponse<NetworkOfferingResponse>>(request);
    }
}
