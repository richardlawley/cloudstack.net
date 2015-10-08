using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResetSSHKeyForVirtualMachineRequest : APIRequest
    {
        public ResetSSHKeyForVirtualMachineRequest() : base("resetSSHKeyForVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// name of the ssh key pair used to login to the virtual machine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// an optional account for the ssh key. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// an optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// an optional project for the ssh key
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Resets the SSH Key for virtual machine. The virtual machine must be in a "Stopped" state. [async]
    /// </summary>
    /// <summary>
    /// Resets the SSH Key for virtual machine. The virtual machine must be in a "Stopped" state. [async]
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse ResetSSHKeyForVirtualMachine(ResetSSHKeyForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse ResetSSHKeyForVirtualMachine(ResetSSHKeyForVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
