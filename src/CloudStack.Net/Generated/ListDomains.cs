using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDomainsRequest : APIRequest
    {
        public ListDomainsRequest() : base("listDomains") {}

        /// <summary>
        /// List domain by domain ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// List domains by domain level.
        /// </summary>
        public int? Level { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        /// <summary>
        /// List domain by domain name.
        /// </summary>
        public string DomainName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists domains and provides detailed information for listed domains
    /// </summary>
    /// <summary>
    /// Lists domains and provides detailed information for listed domains
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DomainResponse> ListDomains(ListDomainsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DomainResponse> ListDomains(ListDomainsRequest request) => _proxy.Request<ListResponse<DomainResponse>>(request);
    }
}
