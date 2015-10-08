using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AttachIsoRequest : APIRequest
    {
        public AttachIsoRequest() : base("attachIso") {}

        /// <summary>
        /// the ID of the ISO file
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId { get; set; }

    }
    /// <summary>
    /// Attaches an ISO to a virtual machine.
    /// </summary>
    /// <summary>
    /// Attaches an ISO to a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse AttachIso(AttachIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse AttachIso(AttachIsoRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
