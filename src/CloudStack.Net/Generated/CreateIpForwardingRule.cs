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
            get { return GetParameterValue<Guid>(nameof(IpAddressId).ToLower()); }
            set { SetParameterValue(nameof(IpAddressId).ToLower(), value); }
        }

        /// <summary>
        /// the protocol for the rule. Valid values are TCP or UDP.
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// the start port for the rule
        /// </summary>
        public int StartPort {
            get { return GetParameterValue<int>(nameof(StartPort).ToLower()); }
            set { SetParameterValue(nameof(StartPort).ToLower(), value); }
        }

        /// <summary>
        /// the CIDR list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { SetParameterValue(nameof(Cidrlist).ToLower(), value); }
        }

        /// <summary>
        /// the end port for the rule
        /// </summary>
        public int? EndPort {
            get { return GetParameterValue<int?>(nameof(EndPort).ToLower()); }
            set { SetParameterValue(nameof(EndPort).ToLower(), value); }
        }

        /// <summary>
        /// if true, firewall rule for source/end public port is automatically created; if false - firewall rule has to be created explicitly. Has value true by default
        /// </summary>
        public bool? OpenFirewall {
            get { return GetParameterValue<bool?>(nameof(OpenFirewall).ToLower()); }
            set { SetParameterValue(nameof(OpenFirewall).ToLower(), value); }
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
