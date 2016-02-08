using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableStaticNatRequest : APIRequest
    {
        public EnableStaticNatRequest() : base("enableStaticNat") {}

        /// <summary>
        /// the public IP address ID for which static NAT feature is being enabled
        /// </summary>
        public Guid IpAddressId {
            get { return (Guid) Parameters[nameof(IpAddressId).ToLower()]; }
            set { Parameters[nameof(IpAddressId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the virtual machine for enabling static NAT feature
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

        /// <summary>
        /// The network of the VM the static NAT will be enabled for. Required when public IP address is not associated with any guest network yet (VPC case)
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// VM guest NIC secondary IP address for the port forwarding rule
        /// </summary>
        public string Vmguestip {
            get { return (string) Parameters[nameof(Vmguestip).ToLower()]; }
            set { Parameters[nameof(Vmguestip).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Enables static NAT for given IP address
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse EnableStaticNat(EnableStaticNatRequest request);
        Task<SuccessResponse> EnableStaticNatAsync(EnableStaticNatRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse EnableStaticNat(EnableStaticNatRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> EnableStaticNatAsync(EnableStaticNatRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
