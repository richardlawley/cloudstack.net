using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Algorithm).ToLower()); }
            set { SetParameterValue(nameof(Algorithm).ToLower(), value); }
        }

        /// <summary>
        /// the TCP port of the virtual machine where the network traffic will be load balanced to
        /// </summary>
        public int? InstancePort {
            get { return GetParameterValue<int?>(nameof(InstancePort).ToLower()); }
            set { SetParameterValue(nameof(InstancePort).ToLower(), value); }
        }

        /// <summary>
        /// name of the load balancer
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// The guest network the load balancer will be created for
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the load balancer scheme. Supported value in this release is Internal
        /// </summary>
        public string Scheme {
            get { return GetParameterValue<string>(nameof(Scheme).ToLower()); }
            set { SetParameterValue(nameof(Scheme).ToLower(), value); }
        }

        /// <summary>
        /// the network id of the source ip address
        /// </summary>
        public Guid Sourceipaddressnetworkid {
            get { return GetParameterValue<Guid>(nameof(Sourceipaddressnetworkid).ToLower()); }
            set { SetParameterValue(nameof(Sourceipaddressnetworkid).ToLower(), value); }
        }

        /// <summary>
        /// the source port the network traffic will be load balanced from
        /// </summary>
        public int? SourcePort {
            get { return GetParameterValue<int?>(nameof(SourcePort).ToLower()); }
            set { SetParameterValue(nameof(SourcePort).ToLower(), value); }
        }

        /// <summary>
        /// the description of the load balancer
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the source IP address the network traffic will be load balanced from
        /// </summary>
        public string Sourceipaddress {
            get { return GetParameterValue<string>(nameof(Sourceipaddress).ToLower()); }
            set { SetParameterValue(nameof(Sourceipaddress).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a load balancer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateLoadBalancer(CreateLoadBalancerRequest request);
        Task<AsyncJobResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateLoadBalancer(CreateLoadBalancerRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
