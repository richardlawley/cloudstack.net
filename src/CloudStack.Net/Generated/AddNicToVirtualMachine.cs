using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNicToVirtualMachineRequest : APIRequest
    {
        public AddNicToVirtualMachineRequest() : base("addNicToVirtualMachine") {}

        /// <summary>
        /// Network ID
        /// </summary>
        public Guid NetId { get; set; }

        /// <summary>
        /// Virtual Machine ID
        /// </summary>
        public Guid VmId { get; set; }

        /// <summary>
        /// IP Address for the new network
        /// </summary>
        public string Ipaddr { get; set; }

    }
    /// <summary>
    /// Adds VM to specified network by creating a NIC
    /// </summary>
    /// <summary>
    /// Adds VM to specified network by creating a NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse AddNicToVirtualMachine(AddNicToVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse AddNicToVirtualMachine(AddNicToVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
