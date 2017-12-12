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
            get { return GetParameterValue<Guid>(nameof(IpAddressId).ToLower()); }
            set { SetParameterValue(nameof(IpAddressId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine for enabling static NAT feature
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// The network of the VM the static NAT will be enabled for. Required when public IP address is not associated with any guest network yet (VPC case)
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// VM guest NIC secondary IP address for the port forwarding rule
        /// </summary>
        public string Vmguestip {
            get { return GetParameterValue<string>(nameof(Vmguestip).ToLower()); }
            set { SetParameterValue(nameof(Vmguestip).ToLower(), value); }
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
        public SuccessResponse EnableStaticNat(EnableStaticNatRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> EnableStaticNatAsync(EnableStaticNatRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
