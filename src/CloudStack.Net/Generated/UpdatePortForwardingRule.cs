using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdatePortForwardingRuleRequest : APIRequest
    {
        public UpdatePortForwardingRuleRequest() : base("updatePortForwardingRule") {}

        /// <summary>
        /// the ID of the port forwarding rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the private port of the port forwarding rule
        /// </summary>
        public int? PrivatePort {
            get { return GetParameterValue<int?>(nameof(PrivatePort).ToLower()); }
            set { SetParameterValue(nameof(PrivatePort).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine for the port forwarding rule
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// VM guest nic Secondary ip address for the port forwarding rule
        /// </summary>
        public string VmGuestIp {
            get { return GetParameterValue<string>(nameof(VmGuestIp).ToLower()); }
            set { SetParameterValue(nameof(VmGuestIp).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a port forwarding rule. Only the private port and the virtual machine can be updated.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdatePortForwardingRule(UpdatePortForwardingRuleRequest request);
        Task<AsyncJobResponse> UpdatePortForwardingRuleAsync(UpdatePortForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdatePortForwardingRule(UpdatePortForwardingRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdatePortForwardingRuleAsync(UpdatePortForwardingRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
