using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLoadBalancerRequest : APIRequest
    {
        public CreateLoadBalancerRequest() : base("createLoadBalancer") {}

        /// <summary>
        /// load balancer algorithm (source, roundrobin, leastconn)
        /// </summary>
        public string Algorithm {
            get { return (string) Parameters[nameof(Algorithm).ToLower()]; }
            set { Parameters[nameof(Algorithm).ToLower()] = value; }
        }

        /// <summary>
        /// the TCP port of the virtual machine where the network traffic will be load balanced to
        /// </summary>
        public int InstancePort {
            get { return (int) Parameters[nameof(InstancePort).ToLower()]; }
            set { Parameters[nameof(InstancePort).ToLower()] = value; }
        }

        /// <summary>
        /// name of the load balancer
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// The guest network the load balancer will be created for
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// the load balancer scheme. Supported value in this release is Internal
        /// </summary>
        public string Scheme {
            get { return (string) Parameters[nameof(Scheme).ToLower()]; }
            set { Parameters[nameof(Scheme).ToLower()] = value; }
        }

        /// <summary>
        /// the network id of the source ip address
        /// </summary>
        public Guid Sourceipaddressnetworkid {
            get { return (Guid) Parameters[nameof(Sourceipaddressnetworkid).ToLower()]; }
            set { Parameters[nameof(Sourceipaddressnetworkid).ToLower()] = value; }
        }

        /// <summary>
        /// the source port the network traffic will be load balanced from
        /// </summary>
        public int SourcePort {
            get { return (int) Parameters[nameof(SourcePort).ToLower()]; }
            set { Parameters[nameof(SourcePort).ToLower()] = value; }
        }

        /// <summary>
        /// the description of the load balancer
        /// </summary>
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the source IP address the network traffic will be load balanced from
        /// </summary>
        public string Sourceipaddress {
            get { return (string) Parameters[nameof(Sourceipaddress).ToLower()]; }
            set { Parameters[nameof(Sourceipaddress).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a load balancer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateLoadBalancer(CreateLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateLoadBalancer(CreateLoadBalancerRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
