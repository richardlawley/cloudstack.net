using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLoadBalancerRuleRequest : APIRequest
    {
        public CreateLoadBalancerRuleRequest() : base("createLoadBalancerRule") {}

        /// <summary>
        /// load balancer algorithm (source, roundrobin, leastconn)
        /// </summary>
        public string Algorithm {
            get { return GetParameterValue<string>(nameof(Algorithm).ToLower()); }
            set { SetParameterValue(nameof(Algorithm).ToLower(), value); }
        }

        /// <summary>
        /// name of the load balancer rule
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the private port of the private IP address/virtual machine where the network traffic will be load balanced to
        /// </summary>
        public int? PrivatePort {
            get { return GetParameterValue<int?>(nameof(PrivatePort).ToLower()); }
            set { SetParameterValue(nameof(PrivatePort).ToLower(), value); }
        }

        /// <summary>
        /// the public port from where the network traffic will be load balanced from
        /// </summary>
        public int? PublicPort {
            get { return GetParameterValue<int?>(nameof(PublicPort).ToLower()); }
            set { SetParameterValue(nameof(PublicPort).ToLower(), value); }
        }

        /// <summary>
        /// the account associated with the load balancer. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the CIDR list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { SetParameterValue(nameof(Cidrlist).ToLower(), value); }
        }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID associated with the load balancer
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// The guest network this rule will be created for. Required when public Ip address is not associated with any Guest network yet (VPC case)
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// if true, firewall rule for source/end public port is automatically created; if false - firewall rule has to be created explicitely. If not specified 1) defaulted to false when LB rule is being created for VPC guest network 2) in all other cases defaulted to true
        /// </summary>
        public bool? OpenFirewall {
            get { return GetParameterValue<bool?>(nameof(OpenFirewall).ToLower()); }
            set { SetParameterValue(nameof(OpenFirewall).ToLower(), value); }
        }

        /// <summary>
        /// The protocol for the LB
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// public IP address ID from where the network traffic will be load balanced from
        /// </summary>
        public Guid? PublicIpId {
            get { return GetParameterValue<Guid?>(nameof(PublicIpId).ToLower()); }
            set { SetParameterValue(nameof(PublicIpId).ToLower(), value); }
        }

        /// <summary>
        /// zone where the load balancer is going to be created. This parameter is required when LB service provider is ElasticLoadBalancerVm
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateLoadBalancerRule(CreateLoadBalancerRuleRequest request);
        Task<AsyncJobResponse> CreateLoadBalancerRuleAsync(CreateLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateLoadBalancerRule(CreateLoadBalancerRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateLoadBalancerRuleAsync(CreateLoadBalancerRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
