using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StartVirtualMachineRequest : APIRequest
    {
        public StartVirtualMachineRequest() : base("startVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Deployment planner to use for vm allocation. Available to ROOT admin only
        /// </summary>
        public string DeploymentPlanner {
            get { return (string) Parameters[nameof(DeploymentPlanner).ToLower()]; }
            set { Parameters[nameof(DeploymentPlanner).ToLower()] = value; }
        }

        /// <summary>
        /// destination Host ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Starts a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StartVirtualMachine(StartVirtualMachineRequest request);
        Task<AsyncJobResponse> StartVirtualMachineAsync(StartVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StartVirtualMachine(StartVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> StartVirtualMachineAsync(StartVirtualMachineRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
