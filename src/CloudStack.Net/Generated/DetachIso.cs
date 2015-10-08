using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DetachIsoRequest : APIRequest
    {
        public DetachIsoRequest() : base("detachIso") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId { get; set; }

    }
    /// <summary>
    /// Detaches any ISO file (if any) currently attached to a virtual machine.
    /// </summary>
    /// <summary>
    /// Detaches any ISO file (if any) currently attached to a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse DetachIso(DetachIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse DetachIso(DetachIsoRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
