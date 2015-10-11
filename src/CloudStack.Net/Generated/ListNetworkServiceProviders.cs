using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkServiceProvidersRequest : APIRequest
    {
        public ListNetworkServiceProvidersRequest() : base("listNetworkServiceProviders") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// list providers by name
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

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// list providers by state
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists network serviceproviders for a given physical network.
    /// </summary>
    /// <summary>
    /// Lists network serviceproviders for a given physical network.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProviderResponse> ListNetworkServiceProviders(ListNetworkServiceProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProviderResponse> ListNetworkServiceProviders(ListNetworkServiceProvidersRequest request) => _proxy.Request<ListResponse<ProviderResponse>>(request);
    }
}
