using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDomainChildrenRequest : APIRequest
    {
        public ListDomainChildrenRequest() : base("listDomainChildren") {}

        /// <summary>
        /// list children domain by parent domain ID.
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// to return the entire tree, use the value "true". To return the first level children, use the value "false".
        /// </summary>
        public bool? Isrecursive {
            get { return (bool?) Parameters[nameof(Isrecursive).ToLower()]; }
            set { Parameters[nameof(Isrecursive).ToLower()] = value; }
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

        /// <summary>
        /// list children domains by name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all children domains belonging to a specified domain
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DomainResponse> ListDomainChildren(ListDomainChildrenRequest request);
        Task<ListResponse<DomainResponse>> ListDomainChildrenAsync(ListDomainChildrenRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DomainResponse> ListDomainChildren(ListDomainChildrenRequest request) => _proxy.Request<ListResponse<DomainResponse>>(request);
        public Task<ListResponse<DomainResponse>> ListDomainChildrenAsync(ListDomainChildrenRequest request) => _proxy.RequestAsync<ListResponse<DomainResponse>>(request);
    }
}
