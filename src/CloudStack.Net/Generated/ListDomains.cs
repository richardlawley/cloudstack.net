using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDomainsRequest : APIListRequest
    {
        public ListDomainsRequest() : base("listDomains") {}

        /// <summary>
        /// List domain by domain ID.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// List domains by domain level.
        /// </summary>
        public int? Level {
            get { return GetParameterValue<int?>(nameof(Level).ToLower()); }
            set { SetParameterValue(nameof(Level).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// List domain by domain name.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists domains and provides detailed information for listed domains
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DomainResponse> ListDomains(ListDomainsRequest request);
        Task<ListResponse<DomainResponse>> ListDomainsAsync(ListDomainsRequest request);
        ListResponse<DomainResponse> ListDomainsAllPages(ListDomainsRequest request);
        Task<ListResponse<DomainResponse>> ListDomainsAllPagesAsync(ListDomainsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DomainResponse> ListDomains(ListDomainsRequest request) => _proxy.Request<ListResponse<DomainResponse>>(request);
        public Task<ListResponse<DomainResponse>> ListDomainsAsync(ListDomainsRequest request) => _proxy.RequestAsync<ListResponse<DomainResponse>>(request);
        public ListResponse<DomainResponse> ListDomainsAllPages(ListDomainsRequest request) => _proxy.RequestAllPages<DomainResponse>(request);
        public Task<ListResponse<DomainResponse>> ListDomainsAllPagesAsync(ListDomainsRequest request) => _proxy.RequestAllPagesAsync<DomainResponse>(request);
    }
}
