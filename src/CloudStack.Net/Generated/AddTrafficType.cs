using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// the trafficType to be added to the physical network
        /// </summary>
        public string TrafficType {
            get { return (string) Parameters[nameof(TrafficType).ToLower()]; }
            set { Parameters[nameof(TrafficType).ToLower()] = value; }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a Hyperv host
        /// </summary>
        public string Hypervnetworklabel {
            get { return (string) Parameters[nameof(Hypervnetworklabel).ToLower()]; }
            set { Parameters[nameof(Hypervnetworklabel).ToLower()] = value; }
        }

        /// <summary>
        /// Used if physical network has multiple isolation types and traffic type is public. Choose which isolation method. Valid options currently 'vlan' or 'vxlan', defaults to 'vlan'.
        /// </summary>
        public string IsolationMethod {
            get { return (string) Parameters[nameof(IsolationMethod).ToLower()]; }
            set { Parameters[nameof(IsolationMethod).ToLower()] = value; }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a KVM host
        /// </summary>
        public string Kvmnetworklabel {
            get { return (string) Parameters[nameof(Kvmnetworklabel).ToLower()]; }
            set { Parameters[nameof(Kvmnetworklabel).ToLower()] = value; }
        }

        /// <summary>
        /// The VLAN id to be used for Management traffic by VMware host
        /// </summary>
        public string Vlan {
            get { return (string) Parameters[nameof(Vlan).ToLower()]; }
            set { Parameters[nameof(Vlan).ToLower()] = value; }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a VMware host
        /// </summary>
        public string Vmwarenetworklabel {
            get { return (string) Parameters[nameof(Vmwarenetworklabel).ToLower()]; }
            set { Parameters[nameof(Vmwarenetworklabel).ToLower()] = value; }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a XenServer host
        /// </summary>
        public string Xennetworklabel {
            get { return (string) Parameters[nameof(Xennetworklabel).ToLower()]; }
            set { Parameters[nameof(Xennetworklabel).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds traffic type to a physical network
    /// </summary>
    /// <summary>
    /// Adds traffic type to a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TrafficTypeResponse AddTrafficType(AddTrafficTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TrafficTypeResponse AddTrafficType(AddTrafficTypeRequest request) => _proxy.Request<TrafficTypeResponse>(request);
    }
}
