using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSupportedNetworkServicesRequest : APIRequest
    {
        public ListSupportedNetworkServicesRequest() : base("listSupportedNetworkServices") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
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
        /// network service provider name
        /// </summary>
        public string Provider {
            get { return (string) Parameters[nameof(Provider).ToLower()]; }
            set { Parameters[nameof(Provider).ToLower()] = value; }
        }

        /// <summary>
        /// network service name to list providers and capabilities of
        /// </summary>
        public string Service {
            get { return (string) Parameters[nameof(Service).ToLower()]; }
            set { Parameters[nameof(Service).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all network services provided by CloudStack or for the given Provider.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ServiceResponse> ListSupportedNetworkServices(ListSupportedNetworkServicesRequest request);
        Task<ListResponse<ServiceResponse>> ListSupportedNetworkServicesAsync(ListSupportedNetworkServicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ServiceResponse> ListSupportedNetworkServices(ListSupportedNetworkServicesRequest request) => _proxy.Request<ListResponse<ServiceResponse>>(request);
        public Task<ListResponse<ServiceResponse>> ListSupportedNetworkServicesAsync(ListSupportedNetworkServicesRequest request) => _proxy.RequestAsync<ListResponse<ServiceResponse>>(request);
    }
}
