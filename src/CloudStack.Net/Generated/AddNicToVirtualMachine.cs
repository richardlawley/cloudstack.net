using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNicToVirtualMachineRequest : APIRequest
    {
        public AddNicToVirtualMachineRequest() : base("addNicToVirtualMachine") {}

        /// <summary>
        /// Network ID
        /// </summary>
        public Guid Networkid {
            get { return (Guid) Parameters[nameof(Networkid).ToLower()]; }
            set { Parameters[nameof(Networkid).ToLower()] = value; }
        }

        /// <summary>
        /// Virtual Machine ID
        /// </summary>
        public Guid Virtualmachineid {
            get { return (Guid) Parameters[nameof(Virtualmachineid).ToLower()]; }
            set { Parameters[nameof(Virtualmachineid).ToLower()] = value; }
        }

        /// <summary>
        /// IP Address for the new network
        /// </summary>
        public string Ipaddress {
            get { return (string) Parameters[nameof(Ipaddress).ToLower()]; }
            set { Parameters[nameof(Ipaddress).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds VM to specified network by creating a NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddNicToVirtualMachine(AddNicToVirtualMachineRequest request);
        Task<AsyncJobResponse> AddNicToVirtualMachineAsync(AddNicToVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddNicToVirtualMachine(AddNicToVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddNicToVirtualMachineAsync(AddNicToVirtualMachineRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
