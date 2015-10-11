using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateGlobalLoadBalancerRuleRequest : APIRequest
    {
        public CreateGlobalLoadBalancerRuleRequest() : base("createGlobalLoadBalancerRule") {}

        /// <summary>
        /// domain name for the GSLB service.
        /// </summary>
        public string Gslbdomainname {
            get { return (string) Parameters[nameof(Gslbdomainname).ToLower()]; }
            set { Parameters[nameof(Gslbdomainname).ToLower()] = value; }
        }

        /// <summary>
        /// GSLB service type (tcp, udp, http)
        /// </summary>
        public string Gslbservicetype {
            get { return (string) Parameters[nameof(Gslbservicetype).ToLower()]; }
            set { Parameters[nameof(Gslbservicetype).ToLower()] = value; }
        }

        /// <summary>
        /// name of the load balancer rule
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// region where the global load balancer is going to be created.
        /// </summary>
        public int RegionId {
            get { return (int) Parameters[nameof(RegionId).ToLower()]; }
            set { Parameters[nameof(RegionId).ToLower()] = value; }
        }

        /// <summary>
        /// the account associated with the global load balancer. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
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
        /// load balancer algorithm (roundrobin, leastconn, proximity) that method is used to distribute traffic across the zones participating in global server load balancing, if not specified defaults to 'round robin'
        /// </summary>
        public string Gslblbmethod {
            get { return (string) Parameters[nameof(Gslblbmethod).ToLower()]; }
            set { Parameters[nameof(Gslblbmethod).ToLower()] = value; }
        }

        /// <summary>
        /// session sticky method (sourceip) if not specified defaults to sourceip
        /// </summary>
        public string Gslbstickysessionmethodname {
            get { return (string) Parameters[nameof(Gslbstickysessionmethodname).ToLower()]; }
            set { Parameters[nameof(Gslbstickysessionmethodname).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a global load balancer rule
    /// </summary>
    /// <summary>
    /// Creates a global load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateGlobalLoadBalancerRule(CreateGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateGlobalLoadBalancerRule(CreateGlobalLoadBalancerRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
