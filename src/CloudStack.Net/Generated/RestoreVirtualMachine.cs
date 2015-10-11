using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RestoreVirtualMachineRequest : APIRequest
    {
        public RestoreVirtualMachineRequest() : base("restoreVirtualMachine") {}

        /// <summary>
        /// Virtual Machine ID
        /// </summary>
        public Guid Virtualmachineid {
            get { return (Guid) Parameters[nameof(Virtualmachineid).ToLower()]; }
            set { Parameters[nameof(Virtualmachineid).ToLower()] = value; }
        }

        /// <summary>
        /// an optional template Id to restore vm from the new template. This can be an ISO id in case of restore vm deployed using ISO
        /// </summary>
        public Guid TemplateId {
            get { return (Guid) Parameters[nameof(TemplateId).ToLower()]; }
            set { Parameters[nameof(TemplateId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Restore a VM to original template/ISO or new template/ISO
    /// </summary>
    /// <summary>
    /// Restore a VM to original template/ISO or new template/ISO
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RestoreVirtualMachine(RestoreVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RestoreVirtualMachine(RestoreVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
