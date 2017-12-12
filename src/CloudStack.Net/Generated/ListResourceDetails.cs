using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListResourceDetailsRequest : APIListRequest
    {
        public ListResourceDetailsRequest() : base("listResourceDetails") {}

        /// <summary>
        /// list by resource type
        /// </summary>
        public string ResourceType {
            get { return GetParameterValue<string>(nameof(ResourceType).ToLower()); }
            set { SetParameterValue(nameof(ResourceType).ToLower(), value); }
        }

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// if set to true, only details marked with display=true, are returned. False by default
        /// </summary>
        public bool? ForDisplay {
            get { return GetParameterValue<bool?>(nameof(ForDisplay).ToLower()); }
            set { SetParameterValue(nameof(ForDisplay).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// list by key
        /// </summary>
        public string Key {
            get { return GetParameterValue<string>(nameof(Key).ToLower()); }
            set { SetParameterValue(nameof(Key).ToLower(), value); }
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
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// list by resource id
        /// </summary>
        public string ResourceId {
            get { return GetParameterValue<string>(nameof(ResourceId).ToLower()); }
            set { SetParameterValue(nameof(ResourceId).ToLower(), value); }
        }

        /// <summary>
        /// list by key, value. Needs to be passed only along with key
        /// </summary>
        public string Value {
            get { return GetParameterValue<string>(nameof(Value).ToLower()); }
            set { SetParameterValue(nameof(Value).ToLower(), value); }
        }

    }
    /// <summary>
    /// List resource detail(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ResourceTagResponse> ListResourceDetails(ListResourceDetailsRequest request);
        Task<ListResponse<ResourceTagResponse>> ListResourceDetailsAsync(ListResourceDetailsRequest request);
        ListResponse<ResourceTagResponse> ListResourceDetailsAllPages(ListResourceDetailsRequest request);
        Task<ListResponse<ResourceTagResponse>> ListResourceDetailsAllPagesAsync(ListResourceDetailsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ResourceTagResponse> ListResourceDetails(ListResourceDetailsRequest request) => Proxy.Request<ListResponse<ResourceTagResponse>>(request);
        public Task<ListResponse<ResourceTagResponse>> ListResourceDetailsAsync(ListResourceDetailsRequest request) => Proxy.RequestAsync<ListResponse<ResourceTagResponse>>(request);
        public ListResponse<ResourceTagResponse> ListResourceDetailsAllPages(ListResourceDetailsRequest request) => Proxy.RequestAllPages<ResourceTagResponse>(request);
        public Task<ListResponse<ResourceTagResponse>> ListResourceDetailsAllPagesAsync(ListResourceDetailsRequest request) => Proxy.RequestAllPagesAsync<ResourceTagResponse>(request);
    }
}
