using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddTrafficTypeRequest : APIRequest
    {
        public AddTrafficTypeRequest() : base("addTrafficType") {}

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the trafficType to be added to the physical network
        /// </summary>
        public string TrafficType {
            get { return GetParameterValue<string>(nameof(TrafficType).ToLower()); }
            set { SetParameterValue(nameof(TrafficType).ToLower(), value); }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a Hyperv host
        /// </summary>
        public string Hypervnetworklabel {
            get { return GetParameterValue<string>(nameof(Hypervnetworklabel).ToLower()); }
            set { SetParameterValue(nameof(Hypervnetworklabel).ToLower(), value); }
        }

        /// <summary>
        /// Used if physical network has multiple isolation types and traffic type is public. Choose which isolation method. Valid options currently 'vlan' or 'vxlan', defaults to 'vlan'.
        /// </summary>
        public string IsolationMethod {
            get { return GetParameterValue<string>(nameof(IsolationMethod).ToLower()); }
            set { SetParameterValue(nameof(IsolationMethod).ToLower(), value); }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a KVM host
        /// </summary>
        public string Kvmnetworklabel {
            get { return GetParameterValue<string>(nameof(Kvmnetworklabel).ToLower()); }
            set { SetParameterValue(nameof(Kvmnetworklabel).ToLower(), value); }
        }

        /// <summary>
        /// The network name of the physical device dedicated to this traffic on an OVM3 host
        /// </summary>
        public string Ovm3networklabel {
            get { return GetParameterValue<string>(nameof(Ovm3networklabel).ToLower()); }
            set { SetParameterValue(nameof(Ovm3networklabel).ToLower(), value); }
        }

        /// <summary>
        /// The VLAN id to be used for Management traffic by VMware host
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a VMware host
        /// </summary>
        public string Vmwarenetworklabel {
            get { return GetParameterValue<string>(nameof(Vmwarenetworklabel).ToLower()); }
            set { SetParameterValue(nameof(Vmwarenetworklabel).ToLower(), value); }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a XenServer host
        /// </summary>
        public string Xennetworklabel {
            get { return GetParameterValue<string>(nameof(Xennetworklabel).ToLower()); }
            set { SetParameterValue(nameof(Xennetworklabel).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds traffic type to a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddTrafficType(AddTrafficTypeRequest request);
        Task<AsyncJobResponse> AddTrafficTypeAsync(AddTrafficTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddTrafficType(AddTrafficTypeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddTrafficTypeAsync(AddTrafficTypeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
