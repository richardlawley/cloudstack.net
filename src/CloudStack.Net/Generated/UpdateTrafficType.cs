using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateTrafficTypeRequest : APIRequest
    {
        public UpdateTrafficTypeRequest() : base("updateTrafficType") {}

        /// <summary>
        /// traffic type id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a Hyperv host
        /// </summary>
        public string Hypervnetworklabel {
            get { return (string) Parameters[nameof(Hypervnetworklabel).ToLower()]; }
            set { Parameters[nameof(Hypervnetworklabel).ToLower()] = value; }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a KVM host
        /// </summary>
        public string Kvmnetworklabel {
            get { return (string) Parameters[nameof(Kvmnetworklabel).ToLower()]; }
            set { Parameters[nameof(Kvmnetworklabel).ToLower()] = value; }
        }

        /// <summary>
        /// The network name of the physical device dedicated to this traffic on an OVM3 host
        /// </summary>
        public string Ovm3networklabel {
            get { return (string) Parameters[nameof(Ovm3networklabel).ToLower()]; }
            set { Parameters[nameof(Ovm3networklabel).ToLower()] = value; }
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
    /// Updates traffic type of a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateTrafficType(UpdateTrafficTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateTrafficType(UpdateTrafficTypeRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
