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
        public long? DeviceId {
            get { return (long?) Parameters[nameof(DeviceId).ToLower()]; }
            set { Parameters[nameof(DeviceId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the virtual machine where the volume is detached from
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Detaches a disk volume from a virtual machine.
    /// </summary>
    /// <summary>
    /// Detaches a disk volume from a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DetachVolume(DetachVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DetachVolume(DetachVolumeRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
