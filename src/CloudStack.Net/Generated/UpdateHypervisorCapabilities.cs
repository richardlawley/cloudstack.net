using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateHypervisorCapabilitiesRequest : APIRequest
    {
        public UpdateHypervisorCapabilitiesRequest() : base("updateHypervisorCapabilities") {}

        /// <summary>
        /// ID of the hypervisor capability
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the max number of Guest VMs per host for this hypervisor.
        /// </summary>
        public long? MaxGuestsLimit {
            get { return (long?) Parameters[nameof(MaxGuestsLimit).ToLower()]; }
            set { Parameters[nameof(MaxGuestsLimit).ToLower()] = value; }
        }

        /// <summary>
        /// set true to enable security group for this hypervisor.
        /// </summary>
        public bool? SecurityGroupEnabled {
            get { return (bool?) Parameters[nameof(SecurityGroupEnabled).ToLower()]; }
            set { Parameters[nameof(SecurityGroupEnabled).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a hypervisor capabilities.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HypervisorCapabilitiesResponse UpdateHypervisorCapabilities(UpdateHypervisorCapabilitiesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HypervisorCapabilitiesResponse UpdateHypervisorCapabilities(UpdateHypervisorCapabilitiesRequest request) => _proxy.Request<HypervisorCapabilitiesResponse>(request);
    }
}
