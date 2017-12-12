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
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// Hypervisor version to create the mapping for. Use 'default' for default versions
        /// </summary>
        public string HypervisorVersion {
            get { return GetParameterValue<string>(nameof(HypervisorVersion).ToLower()); }
            set { SetParameterValue(nameof(HypervisorVersion).ToLower(), value); }
        }

        /// <summary>
        /// OS name specific to the hypervisor
        /// </summary>
        public string OsNameForHypervisor {
            get { return GetParameterValue<string>(nameof(OsNameForHypervisor).ToLower()); }
            set { SetParameterValue(nameof(OsNameForHypervisor).ToLower(), value); }
        }

        /// <summary>
        /// Display Name of Guest OS standard type. Either Display Name or UUID must be passed
        /// </summary>
        public string Osdisplayname {
            get { return GetParameterValue<string>(nameof(Osdisplayname).ToLower()); }
            set { SetParameterValue(nameof(Osdisplayname).ToLower(), value); }
        }

        /// <summary>
        /// UUID of Guest OS type. Either the UUID or Display Name must be passed
        /// </summary>
        public Guid? OsTypeId {
            get { return GetParameterValue<Guid?>(nameof(OsTypeId).ToLower()); }
            set { SetParameterValue(nameof(OsTypeId).ToLower(), value); }
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
        public AsyncJobResponse AddGuestOsMapping(AddGuestOsMappingRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddGuestOsMappingAsync(AddGuestOsMappingRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
