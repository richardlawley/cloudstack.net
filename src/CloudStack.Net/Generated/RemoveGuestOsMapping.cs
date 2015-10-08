using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveGuestOsMappingRequest : APIRequest
    {
        public RemoveGuestOsMappingRequest() : base("removeGuestOsMapping") {}

        /// <summary>
        /// ID of the guest OS mapping
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Removes a Guest OS Mapping.
    /// </summary>
    /// <summary>
    /// Removes a Guest OS Mapping.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveGuestOsMapping(RemoveGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveGuestOsMapping(RemoveGuestOsMappingRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
