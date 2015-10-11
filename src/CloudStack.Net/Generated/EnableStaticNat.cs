using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableStaticNatRequest : APIRequest
    {
        public EnableStaticNatRequest() : base("enableStaticNat") {}

        /// <summary>
        /// the public IP address id for which static nat feature is being enabled
        /// </summary>
        public Guid IpAddressId {
            get { return (Guid) Parameters[nameof(IpAddressId).ToLower()]; }
            set { Parameters[nameof(IpAddressId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the virtual machine for enabling static nat feature
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

        /// <summary>
        /// The network of the vm the static nat will be enabled for. Required when public Ip address is not associated with any Guest network yet (VPC case)
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// VM guest nic Secondary ip address for the port forwarding rule
        /// </summary>
        public string Vmguestip {
            get { return (string) Parameters[nameof(Vmguestip).ToLower()]; }
            set { Parameters[nameof(Vmguestip).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Enables static nat for given ip address
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse EnableStaticNat(EnableStaticNatRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse EnableStaticNat(EnableStaticNatRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
