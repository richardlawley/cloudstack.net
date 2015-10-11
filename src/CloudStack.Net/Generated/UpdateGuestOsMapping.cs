using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateGuestOsMappingRequest : APIRequest
    {
        public UpdateGuestOsMappingRequest() : base("updateGuestOsMapping") {}

        /// <summary>
        /// UUID of the Guest OS to hypervisor name Mapping
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Hypervisor specific name for this Guest OS
        /// </summary>
        public string OsNameForHypervisor {
            get { return (string) Parameters[nameof(OsNameForHypervisor).ToLower()]; }
            set { Parameters[nameof(OsNameForHypervisor).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates the information about Guest OS to Hypervisor specific name mapping
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateGuestOsMapping(UpdateGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateGuestOsMapping(UpdateGuestOsMappingRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
