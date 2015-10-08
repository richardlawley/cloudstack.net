using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVPCOfferingsRequest : APIRequest
    {
        public ListVPCOfferingsRequest() : base("listVPCOfferings") {}

        /// <summary>
        /// list VPC offerings by display text
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// list VPC offerings by id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// true if need to list only default VPC offerings. Default value is false
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list VPC offerings by name
        /// </summary>
        public string VpcOffName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list VPC offerings by state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// list VPC offerings supporting certain services
        /// </summary>
        public IList<string> SupportedServices { get; set; }

    }
    /// <summary>
    /// Lists VPC offerings
    /// </summary>
    /// <summary>
    /// Lists VPC offerings
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VpcOfferingResponse> ListVPCOfferings(ListVPCOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VpcOfferingResponse> ListVPCOfferings(ListVPCOfferingsRequest request) => _proxy.Request<ListResponse<VpcOfferingResponse>>(request);
    }
}
