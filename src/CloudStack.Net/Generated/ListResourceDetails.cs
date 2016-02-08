using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListResourceDetailsRequest : APIRequest
    {
        public ListResourceDetailsRequest() : base("listResourceDetails") {}

        /// <summary>
        /// list by resource type
        /// </summary>
        public string ResourceType {
            get { return (string) Parameters[nameof(ResourceType).ToLower()]; }
            set { Parameters[nameof(ResourceType).ToLower()] = value; }
        }

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// if set to true, only details marked with display=true, are returned. False by default
        /// </summary>
        public bool? ForDisplay {
            get { return (bool?) Parameters[nameof(ForDisplay).ToLower()]; }
            set { Parameters[nameof(ForDisplay).ToLower()] = value; }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return (bool?) Parameters[nameof(Isrecursive).ToLower()]; }
            set { Parameters[nameof(Isrecursive).ToLower()] = value; }
        }

        /// <summary>
        /// list by key
        /// </summary>
        public string Key {
            get { return (string) Parameters[nameof(Key).ToLower()]; }
            set { Parameters[nameof(Key).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return (bool?) Parameters[nameof(ListAll).ToLower()]; }
            set { Parameters[nameof(ListAll).ToLower()] = value; }
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
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// list by resource id
        /// </summary>
        public string ResourceId {
            get { return (string) Parameters[nameof(ResourceId).ToLower()]; }
            set { Parameters[nameof(ResourceId).ToLower()] = value; }
        }

        /// <summary>
        /// list by key, value. Needs to be passed only along with key
        /// </summary>
        public string Value {
            get { return (string) Parameters[nameof(Value).ToLower()]; }
            set { Parameters[nameof(Value).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List resource detail(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ResourceTagResponse> ListResourceDetails(ListResourceDetailsRequest request);
        Task<ListResponse<ResourceTagResponse>> ListResourceDetailsAsync(ListResourceDetailsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ResourceTagResponse> ListResourceDetails(ListResourceDetailsRequest request) => _proxy.Request<ListResponse<ResourceTagResponse>>(request);
        public Task<ListResponse<ResourceTagResponse>> ListResourceDetailsAsync(ListResourceDetailsRequest request) => _proxy.RequestAsync<ListResponse<ResourceTagResponse>>(request);
    }
}
