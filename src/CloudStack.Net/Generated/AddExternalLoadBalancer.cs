using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddExternalLoadBalancerRequest : APIRequest
    {
        public AddExternalLoadBalancerRequest() : base("addExternalLoadBalancer") {}

        /// <summary>
        /// Password of the external load balancer appliance.
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// URL of the external load balancer appliance.
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Username of the external load balancer appliance.
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// Zone in which to add the external load balancer appliance.
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds F5 external load balancer appliance.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ExternalLoadBalancerResponse AddExternalLoadBalancer(AddExternalLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ExternalLoadBalancerResponse AddExternalLoadBalancer(AddExternalLoadBalancerRequest request) => _proxy.Request<ExternalLoadBalancerResponse>(request);
    }
}
