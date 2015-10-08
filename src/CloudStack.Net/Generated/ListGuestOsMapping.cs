using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListGuestOsMappingRequest : APIRequest
    {
        public ListGuestOsMappingRequest() : base("listGuestOsMapping") {}

        /// <summary>
        /// list Guest OS mapping by hypervisor
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// list Guest OS mapping by hypervisor version. Must be used with hypervisor parameter
        /// </summary>
        public string HypervisorVersion { get; set; }

        /// <summary>
        /// list mapping by its UUID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list mapping by Guest OS Type UUID
        /// </summary>
        public Guid OsTypeId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all available OS mappings for given hypervisor
    /// </summary>
    /// <summary>
    /// Lists all available OS mappings for given hypervisor
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestOsMappingResponse> ListGuestOsMapping(ListGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestOsMappingResponse> ListGuestOsMapping(ListGuestOsMappingRequest request) => _proxy.Request<ListResponse<GuestOsMappingResponse>>(request);
    }
}
