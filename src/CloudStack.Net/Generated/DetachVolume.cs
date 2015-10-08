using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DetachVolumeRequest : APIRequest
    {
        public DetachVolumeRequest() : base("detachVolume") {}

        /// <summary>
        /// the device ID on the virtual machine where volume is detached from
        /// </summary>
        public long? DeviceId { get; set; }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the ID of the virtual machine where the volume is detached from
        /// </summary>
        public Guid VirtualMachineId { get; set; }

    }
    /// <summary>
    /// Detaches a disk volume from a virtual machine.
    /// </summary>
    /// <summary>
    /// Detaches a disk volume from a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VolumeResponse DetachVolume(DetachVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VolumeResponse DetachVolume(DetachVolumeRequest request) => _proxy.Request<VolumeResponse>(request);
    }
}
