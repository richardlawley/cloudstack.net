using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the speed for the physical network[1G/10G]
        /// </summary>
        public string Networkspeed {
            get { return (string) Parameters[nameof(Networkspeed).ToLower()]; }
            set { Parameters[nameof(Networkspeed).ToLower()] = value; }
        }

        /// <summary>
        /// Enabled/Disabled
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
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
    /// Updates a physical network
    /// </summary>
    /// <summary>
    /// Updates a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PhysicalNetworkResponse UpdatePhysicalNetwork(UpdatePhysicalNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PhysicalNetworkResponse UpdatePhysicalNetwork(UpdatePhysicalNetworkRequest request) => _proxy.Request<PhysicalNetworkResponse>(request);
    }
}
