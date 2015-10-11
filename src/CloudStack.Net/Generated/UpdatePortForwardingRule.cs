using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the IP address id of the port forwarding rule
        /// </summary>
        public Guid Ipaddressid {
            get { return (Guid) Parameters[nameof(Ipaddressid).ToLower()]; }
            set { Parameters[nameof(Ipaddressid).ToLower()] = value; }
        }

        /// <summary>
        /// the private IP address of the port forwarding rule
        /// </summary>
        public string PrivateIp {
            get { return (string) Parameters[nameof(PrivateIp).ToLower()]; }
            set { Parameters[nameof(PrivateIp).ToLower()] = value; }
        }

        /// <summary>
        /// the private port of the port forwarding rule
        /// </summary>
        public string PrivatePort {
            get { return (string) Parameters[nameof(PrivatePort).ToLower()]; }
            set { Parameters[nameof(PrivatePort).ToLower()] = value; }
        }

        /// <summary>
        /// the protocol for the port fowarding rule. Valid values are TCP or UDP.
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// the public port of the port forwarding rule
        /// </summary>
        public string PublicPort {
            get { return (string) Parameters[nameof(PublicPort).ToLower()]; }
            set { Parameters[nameof(PublicPort).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the virtual machine for the port forwarding rule
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a port forwarding rule.  Only the private port and the virtual machine can be updated.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdatePortForwardingRule(UpdatePortForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdatePortForwardingRule(UpdatePortForwardingRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
