using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddGuestOsMappingRequest : APIRequest
    {
        public AddGuestOsMappingRequest() : base("addGuestOsMapping") {}

        /// <summary>
        /// Hypervisor type. One of : XenServer, KVM, VMWare
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// Hypervisor version to create the mapping for. Use 'default' for default versions
        /// </summary>
        public string HypervisorVersion { get; set; }

        /// <summary>
        /// OS name specific to the hypervisor
        /// </summary>
        public string OsNameForHypervisor { get; set; }

        /// <summary>
        /// Display Name of Guest OS standard type. Either Display Name or UUID must be passed
        /// </summary>
        public string OsStdName { get; set; }

        /// <summary>
        /// UUID of Guest OS type. Either the UUID or Display Name must be passed
        /// </summary>
        public Guid OsTypeId { get; set; }

    }
    /// <summary>
    /// Adds a guest OS name to hypervisor OS name mapping
    /// </summary>
    /// <summary>
    /// Adds a guest OS name to hypervisor OS name mapping
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GuestOsMappingResponse AddGuestOsMapping(AddGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GuestOsMappingResponse AddGuestOsMapping(AddGuestOsMappingRequest request) => _proxy.Request<GuestOsMappingResponse>(request);
    }
}
