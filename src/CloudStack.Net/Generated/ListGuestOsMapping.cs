using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListGuestOsMappingRequest : APIListRequest
    {
        public ListGuestOsMappingRequest() : base("listGuestOsMapping") {}

        /// <summary>
        /// list Guest OS mapping by hypervisor
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// list Guest OS mapping by hypervisor version. Must be used with hypervisor parameter
        /// </summary>
        public string HypervisorVersion {
            get { return GetParameterValue<string>(nameof(HypervisorVersion).ToLower()); }
            set { SetParameterValue(nameof(HypervisorVersion).ToLower(), value); }
        }

        /// <summary>
        /// list mapping by its UUID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
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
        /// list mapping by Guest OS Type UUID
        /// </summary>
        public Guid? OsTypeId {
            get { return GetParameterValue<Guid?>(nameof(OsTypeId).ToLower()); }
            set { SetParameterValue(nameof(OsTypeId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available OS mappings for given hypervisor
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestOsMappingResponse> ListGuestOsMapping(ListGuestOsMappingRequest request);
        Task<ListResponse<GuestOsMappingResponse>> ListGuestOsMappingAsync(ListGuestOsMappingRequest request);
        ListResponse<GuestOsMappingResponse> ListGuestOsMappingAllPages(ListGuestOsMappingRequest request);
        Task<ListResponse<GuestOsMappingResponse>> ListGuestOsMappingAllPagesAsync(ListGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestOsMappingResponse> ListGuestOsMapping(ListGuestOsMappingRequest request) => Proxy.Request<ListResponse<GuestOsMappingResponse>>(request);
        public Task<ListResponse<GuestOsMappingResponse>> ListGuestOsMappingAsync(ListGuestOsMappingRequest request) => Proxy.RequestAsync<ListResponse<GuestOsMappingResponse>>(request);
        public ListResponse<GuestOsMappingResponse> ListGuestOsMappingAllPages(ListGuestOsMappingRequest request) => Proxy.RequestAllPages<GuestOsMappingResponse>(request);
        public Task<ListResponse<GuestOsMappingResponse>> ListGuestOsMappingAllPagesAsync(ListGuestOsMappingRequest request) => Proxy.RequestAllPagesAsync<GuestOsMappingResponse>(request);
    }
}
