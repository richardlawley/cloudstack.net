using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdatePhysicalNetworkRequest : APIRequest
    {
        public UpdatePhysicalNetworkRequest() : base("updatePhysicalNetwork") {}

        /// <summary>
        /// physical network id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the speed for the physical network[1G/10G]
        /// </summary>
        public string Networkspeed {
            get { return GetParameterValue<string>(nameof(Networkspeed).ToLower()); }
            set { SetParameterValue(nameof(Networkspeed).ToLower(), value); }
        }

        /// <summary>
        /// Enabled/Disabled
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// Tag the physical network
        /// </summary>
        public IList<string> Tags {
            get { return GetList<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the VLAN for the physical network
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdatePhysicalNetwork(UpdatePhysicalNetworkRequest request);
        Task<AsyncJobResponse> UpdatePhysicalNetworkAsync(UpdatePhysicalNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdatePhysicalNetwork(UpdatePhysicalNetworkRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdatePhysicalNetworkAsync(UpdatePhysicalNetworkRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
