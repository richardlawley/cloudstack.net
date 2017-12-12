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
            get { return GetParameterValue<Guid>(nameof(Networkid).ToLower()); }
            set { SetParameterValue(nameof(Networkid).ToLower(), value); }
        }

        /// <summary>
        /// Virtual Machine ID
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// IP Address for the new network
        /// </summary>
        public string Ipaddress {
            get { return GetParameterValue<string>(nameof(Ipaddress).ToLower()); }
            set { SetParameterValue(nameof(Ipaddress).ToLower(), value); }
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
        public AsyncJobResponse AddNicToVirtualMachine(AddNicToVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddNicToVirtualMachineAsync(AddNicToVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
