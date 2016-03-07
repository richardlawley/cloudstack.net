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
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// list Guest OS mapping by hypervisor version. Must be used with hypervisor parameter
        /// </summary>
        public string HypervisorVersion {
            get { return (string) Parameters[nameof(HypervisorVersion).ToLower()]; }
            set { Parameters[nameof(HypervisorVersion).ToLower()] = value; }
        }

        /// <summary>
        /// list mapping by its UUID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// list mapping by Guest OS Type UUID
        /// </summary>
        public Guid OsTypeId {
            get { return (Guid) Parameters[nameof(OsTypeId).ToLower()]; }
            set { Parameters[nameof(OsTypeId).ToLower()] = value; }
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
        public ListResponse<GuestOsMappingResponse> ListGuestOsMapping(ListGuestOsMappingRequest request) => _proxy.Request<ListResponse<GuestOsMappingResponse>>(request);
        public Task<ListResponse<GuestOsMappingResponse>> ListGuestOsMappingAsync(ListGuestOsMappingRequest request) => _proxy.RequestAsync<ListResponse<GuestOsMappingResponse>>(request);
        public ListResponse<GuestOsMappingResponse> ListGuestOsMappingAllPages(ListGuestOsMappingRequest request) => _proxy.RequestAllPages<GuestOsMappingResponse>(request);
        public Task<ListResponse<GuestOsMappingResponse>> ListGuestOsMappingAllPagesAsync(ListGuestOsMappingRequest request) => _proxy.RequestAllPagesAsync<GuestOsMappingResponse>(request);
    }
}
