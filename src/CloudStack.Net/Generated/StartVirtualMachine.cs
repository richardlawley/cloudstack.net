using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StartVirtualMachineRequest : APIRequest
    {
        public StartVirtualMachineRequest() : base("startVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Deployment planner to use for vm allocation. Available to ROOT admin only
        /// </summary>
        public string DeploymentPlanner { get; set; }

        /// <summary>
        /// destination Host ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid HostId { get; set; }

    }
    /// <summary>
    /// Starts a virtual machine.
    /// </summary>
    /// <summary>
    /// Starts a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse StartVirtualMachine(StartVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse StartVirtualMachine(StartVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
