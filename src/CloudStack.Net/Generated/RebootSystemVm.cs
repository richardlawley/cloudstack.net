using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Reboots a system VM.
    /// </summary>
    /// <summary>
    /// Reboots a system VM.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RebootSystemVm(RebootSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RebootSystemVm(RebootSystemVmRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
