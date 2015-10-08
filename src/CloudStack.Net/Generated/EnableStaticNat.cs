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
        /// the public IP address ID for which static NAT feature is being enabled
        /// </summary>
        public Guid IpAddressId { get; set; }

        /// <summary>
        /// the ID of the virtual machine for enabling static NAT feature
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// The network of the VM the static NAT will be enabled for. Required when public IP address is not associated with any guest network yet (VPC case)
        /// </summary>
        public Guid NetworkId { get; set; }

        /// <summary>
        /// VM guest NIC secondary IP address for the port forwarding rule
        /// </summary>
        public string VmSecondaryIp { get; set; }

    }
    /// <summary>
    /// Enables static NAT for given IP address
    /// </summary>
    /// <summary>
    /// Enables static NAT for given IP address
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
