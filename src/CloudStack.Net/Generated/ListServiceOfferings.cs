using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListServiceOfferingsRequest : APIRequest
    {
        public ListServiceOfferingsRequest() : base("listServiceOfferings") {}

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// ID of the service offering
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// is this a system vm offering
        /// </summary>
        public bool? IsSystem { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        /// <summary>
        /// name of the service offering
        /// </summary>
        public string ServiceOfferingName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the system VM type. Possible types are "consoleproxy", "secondarystoragevm" or "domainrouter".
        /// </summary>
        public string SystemVmType { get; set; }

        /// <summary>
        /// the ID of the virtual machine. Pass this in if you want to see the available service offering that a virtual machine can be changed to.
        /// </summary>
        public Guid VirtualMachineId { get; set; }

    }
    /// <summary>
    /// Lists all available service offerings.
    /// </summary>
    /// <summary>
    /// Lists all available service offerings.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ServiceOfferingResponse> ListServiceOfferings(ListServiceOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ServiceOfferingResponse> ListServiceOfferings(ListServiceOfferingsRequest request) => _proxy.Request<ListResponse<ServiceOfferingResponse>>(request);
    }
}
