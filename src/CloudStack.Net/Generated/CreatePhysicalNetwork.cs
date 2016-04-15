using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePhysicalNetworkRequest : APIRequest
    {
        public CreatePhysicalNetworkRequest() : base("createPhysicalNetwork") {}

        /// <summary>
        /// the name of the physical network
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the physical network
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// the broadcast domain range for the physical network[Pod or Zone]. In Acton release it can be Zone only in Advance zone, and Pod in Basic
        /// </summary>
        public string BroadcastDomainRange {
            get { return GetParameterValue<string>(nameof(BroadcastDomainRange).ToLower()); }
            set { SetParameterValue(nameof(BroadcastDomainRange).ToLower(), value); }
        }

        /// <summary>
        /// domain ID of the account owning a physical network
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the isolation method for the physical network[VLAN/L3/GRE]
        /// </summary>
        public IList<string> IsolationMethods {
            get { return GetList<string>(nameof(IsolationMethods).ToLower()); }
            set { SetParameterValue(nameof(IsolationMethods).ToLower(), value); }
        }

        /// <summary>
        /// the speed for the physical network[1G/10G]
        /// </summary>
        public string Networkspeed {
            get { return GetParameterValue<string>(nameof(Networkspeed).ToLower()); }
            set { SetParameterValue(nameof(Networkspeed).ToLower(), value); }
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
    /// Creates a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreatePhysicalNetwork(CreatePhysicalNetworkRequest request);
        Task<AsyncJobResponse> CreatePhysicalNetworkAsync(CreatePhysicalNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreatePhysicalNetwork(CreatePhysicalNetworkRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreatePhysicalNetworkAsync(CreatePhysicalNetworkRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
