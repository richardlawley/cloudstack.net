using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// name of the ssh key pair used to login to the virtual machine
        /// </summary>
        public string Keypair {
            get { return GetParameterValue<string>(nameof(Keypair).ToLower()); }
            set { SetParameterValue(nameof(Keypair).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the ssh key. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional project for the ssh key
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Resets the SSH Key for virtual machine. The virtual machine must be in a "Stopped" state. [async]
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ResetSSHKeyForVirtualMachine(ResetSSHKeyForVirtualMachineRequest request);
        Task<AsyncJobResponse> ResetSSHKeyForVirtualMachineAsync(ResetSSHKeyForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ResetSSHKeyForVirtualMachine(ResetSSHKeyForVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ResetSSHKeyForVirtualMachineAsync(ResetSSHKeyForVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
