using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AttachIsoRequest : APIRequest
    {
        public AttachIsoRequest() : base("attachIso") {}

        /// <summary>
        /// the ID of the ISO file
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Attaches an ISO to a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AttachIso(AttachIsoRequest request);
        Task<AsyncJobResponse> AttachIsoAsync(AttachIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AttachIso(AttachIsoRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AttachIsoAsync(AttachIsoRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
