using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePortForwardingRuleRequest : APIRequest
    {
        public CreatePortForwardingRuleRequest() : base("createPortForwardingRule") {}

        /// <summary>
        /// the IP address id of the port forwarding rule
        /// </summary>
        public Guid IpAddressId {
            get { return GetParameterValue<Guid>(nameof(IpAddressId).ToLower()); }
            set { SetParameterValue(nameof(IpAddressId).ToLower(), value); }
        }

        /// <summary>
        /// the starting port of port forwarding rule's private port range
        /// </summary>
        public int Privateport {
            get { return GetParameterValue<int>(nameof(Privateport).ToLower()); }
            set { SetParameterValue(nameof(Privateport).ToLower(), value); }
        }

        /// <summary>
        /// the protocol for the port forwarding rule. Valid values are TCP or UDP.
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// the starting port of port forwarding rule's public port range
        /// </summary>
        public int Publicport {
            get { return GetParameterValue<int>(nameof(Publicport).ToLower()); }
            set { SetParameterValue(nameof(Publicport).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine for the port forwarding rule
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { SetParameterValue(nameof(Cidrlist).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the network of the virtual machine the port forwarding rule will be created for. Required when public IP address is not associated with any guest network yet (VPC case).
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// if true, firewall rule for source/end public port is automatically created; if false - firewall rule has to be created explicitly. If not specified 1) defaulted to false when PF rule is being created for VPC guest network 2) in all other cases defaulted to true
        /// </summary>
        public bool? OpenFirewall {
            get { return GetParameterValue<bool?>(nameof(OpenFirewall).ToLower()); }
            set { SetParameterValue(nameof(OpenFirewall).ToLower(), value); }
        }

        /// <summary>
        /// the ending port of port forwarding rule's private port range
        /// </summary>
        public int? PrivateEndPort {
            get { return GetParameterValue<int?>(nameof(PrivateEndPort).ToLower()); }
            set { SetParameterValue(nameof(PrivateEndPort).ToLower(), value); }
        }

        /// <summary>
        /// the ending port of port forwarding rule's private port range
        /// </summary>
        public int? PublicEndPort {
            get { return GetParameterValue<int?>(nameof(PublicEndPort).ToLower()); }
            set { SetParameterValue(nameof(PublicEndPort).ToLower(), value); }
        }

        /// <summary>
        /// VM guest nic secondary IP address for the port forwarding rule
        /// </summary>
        public string Vmguestip {
            get { return GetParameterValue<string>(nameof(Vmguestip).ToLower()); }
            set { SetParameterValue(nameof(Vmguestip).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a port forwarding rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreatePortForwardingRule(CreatePortForwardingRuleRequest request);
        Task<AsyncJobResponse> CreatePortForwardingRuleAsync(CreatePortForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreatePortForwardingRule(CreatePortForwardingRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreatePortForwardingRuleAsync(CreatePortForwardingRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
