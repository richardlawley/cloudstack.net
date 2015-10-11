using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Algorithm).ToLower()]; }
            set { Parameters[nameof(Algorithm).ToLower()] = value; }
        }

        /// <summary>
        /// name of the load balancer rule
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the private port of the private ip address/virtual machine where the network traffic will be load balanced to
        /// </summary>
        public int PrivatePort {
            get { return (int) Parameters[nameof(PrivatePort).ToLower()]; }
            set { Parameters[nameof(PrivatePort).ToLower()] = value; }
        }

        /// <summary>
        /// the public port from where the network traffic will be load balanced from
        /// </summary>
        public int PublicPort {
            get { return (int) Parameters[nameof(PublicPort).ToLower()]; }
            set { Parameters[nameof(PublicPort).ToLower()] = value; }
        }

        /// <summary>
        /// the account associated with the load balancer. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the cidr list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { Parameters[nameof(Cidrlist).ToLower()] = value; }
        }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// the domain ID associated with the load balancer
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// The guest network this rule will be created for. Required when public Ip address is not associated with any Guest network yet (VPC case)
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// if true, firewall rule for source/end pubic port is automatically created; if false - firewall rule has to be created explicitely. If not specified 1) defaulted to false when LB rule is being created for VPC guest network 2) in all other cases defaulted to true
        /// </summary>
        public bool? OpenFirewall {
            get { return (bool?) Parameters[nameof(OpenFirewall).ToLower()]; }
            set { Parameters[nameof(OpenFirewall).ToLower()] = value; }
        }

        /// <summary>
        /// The protocol for the LB
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// public ip address id from where the network traffic will be load balanced from
        /// </summary>
        public Guid PublicIpId {
            get { return (Guid) Parameters[nameof(PublicIpId).ToLower()]; }
            set { Parameters[nameof(PublicIpId).ToLower()] = value; }
        }

        /// <summary>
        /// zone where the load balancer is going to be created. This parameter is required when LB service provider is ElasticLoadBalancerVm
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateLoadBalancerRule(CreateLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateLoadBalancerRule(CreateLoadBalancerRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
