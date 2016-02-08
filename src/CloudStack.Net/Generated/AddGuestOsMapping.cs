using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddGuestOsMappingRequest : APIRequest
    {
        public AddGuestOsMappingRequest() : base("addGuestOsMapping") {}

        /// <summary>
        /// Hypervisor type. One of : XenServer, KVM, VMWare
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// Hypervisor version to create the mapping for. Use 'default' for default versions
        /// </summary>
        public string HypervisorVersion {
            get { return (string) Parameters[nameof(HypervisorVersion).ToLower()]; }
            set { Parameters[nameof(HypervisorVersion).ToLower()] = value; }
        }

        /// <summary>
        /// OS name specific to the hypervisor
        /// </summary>
        public string OsNameForHypervisor {
            get { return (string) Parameters[nameof(OsNameForHypervisor).ToLower()]; }
            set { Parameters[nameof(OsNameForHypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// Display Name of Guest OS standard type. Either Display Name or UUID must be passed
        /// </summary>
        public string Osdisplayname {
            get { return (string) Parameters[nameof(Osdisplayname).ToLower()]; }
            set { Parameters[nameof(Osdisplayname).ToLower()] = value; }
        }

        /// <summary>
        /// UUID of Guest OS type. Either the UUID or Display Name must be passed
        /// </summary>
        public Guid OsTypeId {
            get { return (Guid) Parameters[nameof(OsTypeId).ToLower()]; }
            set { Parameters[nameof(OsTypeId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a guest OS name to hypervisor OS name mapping
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddGuestOsMapping(AddGuestOsMappingRequest request);
        Task<AsyncJobResponse> AddGuestOsMappingAsync(AddGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddGuestOsMapping(AddGuestOsMappingRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddGuestOsMappingAsync(AddGuestOsMappingRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
