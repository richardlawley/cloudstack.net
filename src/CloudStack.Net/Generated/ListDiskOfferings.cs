using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDiskOfferingsRequest : APIRequest
    {
        public ListDiskOfferingsRequest() : base("listDiskOfferings") {}

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// ID of the disk offering
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        /// <summary>
        /// name of the disk offering
        /// </summary>
        public string DiskOfferingName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all available disk offerings.
    /// </summary>
    /// <summary>
    /// Lists all available disk offerings.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DiskOfferingResponse> ListDiskOfferings(ListDiskOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DiskOfferingResponse> ListDiskOfferings(ListDiskOfferingsRequest request) => _proxy.Request<ListResponse<DiskOfferingResponse>>(request);
    }
}
