using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StopSystemVmRequest : APIRequest
    {
        public StopSystemVmRequest() : base("stopSystemVm") {}

        /// <summary>
        /// The ID of the system virtual machine
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Force stop the VM.  The caller knows the VM is stopped.
        /// </summary>
        public bool? Forced {
            get { return (bool?) Parameters[nameof(Forced).ToLower()]; }
            set { Parameters[nameof(Forced).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Stops a system VM.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StopSystemVm(StopSystemVmRequest request);
        Task<AsyncJobResponse> StopSystemVmAsync(StopSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StopSystemVm(StopSystemVmRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> StopSystemVmAsync(StopSystemVmRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
