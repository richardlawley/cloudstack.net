using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateIpForwardingRuleRequest : APIRequest
    {
        public CreateIpForwardingRuleRequest() : base("createIpForwardingRule") {}

        /// <summary>
        /// the public IP address ID of the forwarding rule, already associated via associateIp
        /// </summary>
        public Guid IpAddressId {
            get { return (Guid) Parameters[nameof(IpAddressId).ToLower()]; }
            set { Parameters[nameof(IpAddressId).ToLower()] = value; }
        }

        /// <summary>
        /// the protocol for the rule. Valid values are TCP or UDP.
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// the start port for the rule
        /// </summary>
        public int StartPort {
            get { return (int) Parameters[nameof(StartPort).ToLower()]; }
            set { Parameters[nameof(StartPort).ToLower()] = value; }
        }

        /// <summary>
        /// the CIDR list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { Parameters[nameof(Cidrlist).ToLower()] = value; }
        }

        /// <summary>
        /// the end port for the rule
        /// </summary>
        public int? EndPort {
            get { return (int?) Parameters[nameof(EndPort).ToLower()]; }
            set { Parameters[nameof(EndPort).ToLower()] = value; }
        }

        /// <summary>
        /// if true, firewall rule for source/end public port is automatically created; if false - firewall rule has to be created explicitly. Has value true by default
        /// </summary>
        public bool? OpenFirewall {
            get { return (bool?) Parameters[nameof(OpenFirewall).ToLower()]; }
            set { Parameters[nameof(OpenFirewall).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates an IP forwarding rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateIpForwardingRule(CreateIpForwardingRuleRequest request);
        Task<AsyncJobResponse> CreateIpForwardingRuleAsync(CreateIpForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateIpForwardingRule(CreateIpForwardingRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateIpForwardingRuleAsync(CreateIpForwardingRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
