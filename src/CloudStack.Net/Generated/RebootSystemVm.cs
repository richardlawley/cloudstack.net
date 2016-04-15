using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RebootSystemVmRequest : APIRequest
    {
        public RebootSystemVmRequest() : base("rebootSystemVm") {}

        /// <summary>
        /// The ID of the system virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Reboots a system VM.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RebootSystemVm(RebootSystemVmRequest request);
        Task<AsyncJobResponse> RebootSystemVmAsync(RebootSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RebootSystemVm(RebootSystemVmRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RebootSystemVmAsync(RebootSystemVmRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
