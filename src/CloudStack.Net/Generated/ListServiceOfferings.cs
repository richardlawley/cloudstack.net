using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListServiceOfferingsRequest : APIListRequest
    {
        public ListServiceOfferingsRequest() : base("listServiceOfferings") {}

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// ID of the service offering
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
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
        /// is this a system vm offering
        /// </summary>
        public bool? IsSystem {
            get { return GetParameterValue<bool?>(nameof(IsSystem).ToLower()); }
            set { SetParameterValue(nameof(IsSystem).ToLower(), value); }
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
        /// name of the service offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the system VM type. Possible types are "consoleproxy", "secondarystoragevm" or "domainrouter".
        /// </summary>
        public string SystemVmType {
            get { return GetParameterValue<string>(nameof(SystemVmType).ToLower()); }
            set { SetParameterValue(nameof(SystemVmType).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine. Pass this in if you want to see the available service offering that a virtual machine can be changed to.
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available service offerings.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ServiceOfferingResponse> ListServiceOfferings(ListServiceOfferingsRequest request);
        Task<ListResponse<ServiceOfferingResponse>> ListServiceOfferingsAsync(ListServiceOfferingsRequest request);
        ListResponse<ServiceOfferingResponse> ListServiceOfferingsAllPages(ListServiceOfferingsRequest request);
        Task<ListResponse<ServiceOfferingResponse>> ListServiceOfferingsAllPagesAsync(ListServiceOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ServiceOfferingResponse> ListServiceOfferings(ListServiceOfferingsRequest request) => _proxy.Request<ListResponse<ServiceOfferingResponse>>(request);
        public Task<ListResponse<ServiceOfferingResponse>> ListServiceOfferingsAsync(ListServiceOfferingsRequest request) => _proxy.RequestAsync<ListResponse<ServiceOfferingResponse>>(request);
        public ListResponse<ServiceOfferingResponse> ListServiceOfferingsAllPages(ListServiceOfferingsRequest request) => _proxy.RequestAllPages<ServiceOfferingResponse>(request);
        public Task<ListResponse<ServiceOfferingResponse>> ListServiceOfferingsAllPagesAsync(ListServiceOfferingsRequest request) => _proxy.RequestAllPagesAsync<ServiceOfferingResponse>(request);
    }
}
