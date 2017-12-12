using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Gslbdomainname).ToLower()); }
            set { SetParameterValue(nameof(Gslbdomainname).ToLower(), value); }
        }

        /// <summary>
        /// GSLB service type (tcp, udp, http)
        /// </summary>
        public string Gslbservicetype {
            get { return GetParameterValue<string>(nameof(Gslbservicetype).ToLower()); }
            set { SetParameterValue(nameof(Gslbservicetype).ToLower(), value); }
        }

        /// <summary>
        /// name of the load balancer rule
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// region where the global load balancer is going to be created.
        /// </summary>
        public int? RegionId {
            get { return GetParameterValue<int?>(nameof(RegionId).ToLower()); }
            set { SetParameterValue(nameof(RegionId).ToLower(), value); }
        }

        /// <summary>
        /// the account associated with the global load balancer. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
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
        /// load balancer algorithm (roundrobin, leastconn, proximity) that method is used to distribute traffic across the zones participating in global server load balancing, if not specified defaults to 'round robin'
        /// </summary>
        public string Gslblbmethod {
            get { return GetParameterValue<string>(nameof(Gslblbmethod).ToLower()); }
            set { SetParameterValue(nameof(Gslblbmethod).ToLower(), value); }
        }

        /// <summary>
        /// session sticky method (sourceip) if not specified defaults to sourceip
        /// </summary>
        public string Gslbstickysessionmethodname {
            get { return GetParameterValue<string>(nameof(Gslbstickysessionmethodname).ToLower()); }
            set { SetParameterValue(nameof(Gslbstickysessionmethodname).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a global load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateGlobalLoadBalancerRule(CreateGlobalLoadBalancerRuleRequest request);
        Task<AsyncJobResponse> CreateGlobalLoadBalancerRuleAsync(CreateGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateGlobalLoadBalancerRule(CreateGlobalLoadBalancerRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateGlobalLoadBalancerRuleAsync(CreateGlobalLoadBalancerRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
