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
        public Guid Id { get; set; }

        /// <summary>
        /// the max number of Guest VMs per host for this hypervisor.
        /// </summary>
        public long? MaxGuestsLimit { get; set; }

        /// <summary>
        /// set true to enable security group for this hypervisor.
        /// </summary>
        public bool? SecurityGroupEnabled { get; set; }

    }
    /// <summary>
    /// Updates a hypervisor capabilities.
    /// </summary>
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
