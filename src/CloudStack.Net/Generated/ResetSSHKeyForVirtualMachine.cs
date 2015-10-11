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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// name of the ssh key pair used to login to the virtual machine
        /// </summary>
        public string Keypair {
            get { return (string) Parameters[nameof(Keypair).ToLower()]; }
            set { Parameters[nameof(Keypair).ToLower()] = value; }
        }

        /// <summary>
        /// an optional account for the ssh key. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional project for the ssh key
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Resets the SSH Key for virtual machine. The virtual machine must be in a "Stopped" state. [async]
    /// </summary>
    /// <summary>
    /// Resets the SSH Key for virtual machine. The virtual machine must be in a "Stopped" state. [async]
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ResetSSHKeyForVirtualMachine(ResetSSHKeyForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ResetSSHKeyForVirtualMachine(ResetSSHKeyForVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
