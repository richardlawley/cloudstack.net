using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDomainChildrenRequest : APIRequest
    {
        public ListDomainChildrenRequest() : base("listDomainChildren") {}

        /// <summary>
        /// list children domain by parent domain ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// to return the entire tree, use the value "true". To return the first level children, use the value "false".
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
        /// list children domains by name
        /// </summary>
        public string DomainName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all children domains belonging to a specified domain
    /// </summary>
    /// <summary>
    /// Lists all children domains belonging to a specified domain
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DomainResponse> ListDomainChildren(ListDomainChildrenRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DomainResponse> ListDomainChildren(ListDomainChildrenRequest request) => _proxy.Request<ListResponse<DomainResponse>>(request);
    }
}
