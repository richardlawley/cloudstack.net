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
        public Guid VmId { get; set; }

        /// <summary>
        /// an optional template Id to restore vm from the new template. This can be an ISO id in case of restore vm deployed using ISO
        /// </summary>
        public Guid TemplateId { get; set; }

    }
    /// <summary>
    /// Restore a VM to original template/ISO or new template/ISO
    /// </summary>
    /// <summary>
    /// Restore a VM to original template/ISO or new template/ISO
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse RestoreVirtualMachine(RestoreVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse RestoreVirtualMachine(RestoreVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
