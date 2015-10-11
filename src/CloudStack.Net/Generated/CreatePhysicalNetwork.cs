using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the physical network
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// the broadcast domain range for the physical network[Pod or Zone]. In Acton release it can be Zone only in Advance zone, and Pod in Basic
        /// </summary>
        public string BroadcastDomainRange {
            get { return (string) Parameters[nameof(BroadcastDomainRange).ToLower()]; }
            set { Parameters[nameof(BroadcastDomainRange).ToLower()] = value; }
        }

        /// <summary>
        /// domain ID of the account owning a physical network
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the isolation method for the physical network[VLAN/L3/GRE]
        /// </summary>
        public IList<string> IsolationMethods {
            get { return (IList<string>) Parameters[nameof(IsolationMethods).ToLower()]; }
            set { Parameters[nameof(IsolationMethods).ToLower()] = value; }
        }

        /// <summary>
        /// the speed for the physical network[1G/10G]
        /// </summary>
        public string Networkspeed {
            get { return (string) Parameters[nameof(Networkspeed).ToLower()]; }
            set { Parameters[nameof(Networkspeed).ToLower()] = value; }
        }

        /// <summary>
        /// Tag the physical network
        /// </summary>
        public IList<string> Tags {
            get { return (IList<string>) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// the VLAN for the physical network
        /// </summary>
        public string Vlan {
            get { return (string) Parameters[nameof(Vlan).ToLower()]; }
            set { Parameters[nameof(Vlan).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a physical network
    /// </summary>
    /// <summary>
    /// Creates a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreatePhysicalNetwork(CreatePhysicalNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreatePhysicalNetwork(CreatePhysicalNetworkRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
