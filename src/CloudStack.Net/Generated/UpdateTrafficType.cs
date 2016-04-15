using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a Hyperv host
        /// </summary>
        public string Hypervnetworklabel {
            get { return GetParameterValue<string>(nameof(Hypervnetworklabel).ToLower()); }
            set { SetParameterValue(nameof(Hypervnetworklabel).ToLower(), value); }
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
    /// Updates traffic type of a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateTrafficType(UpdateTrafficTypeRequest request);
        Task<AsyncJobResponse> UpdateTrafficTypeAsync(UpdateTrafficTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateTrafficType(UpdateTrafficTypeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateTrafficTypeAsync(UpdateTrafficTypeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
