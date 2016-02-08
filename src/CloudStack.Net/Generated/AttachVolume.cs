using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AttachVolumeRequest : APIRequest
    {
        public AttachVolumeRequest() : base("attachVolume") {}

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        ///     the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the device to map the volume to within the guest OS. If no deviceId is passed in, the next available deviceId will be chosen. Possible values for a Linux OS are:* 0 - /dev/xvda* 1 - /dev/xvdb* 2 - /dev/xvdc* 4 - /dev/xvde* 5 - /dev/xvdf* 6 - /dev/xvdg* 7 - /dev/xvdh* 8 - /dev/xvdi* 9 - /dev/xvdj
        /// </summary>
        public long? DeviceId {
            get { return (long?) Parameters[nameof(DeviceId).ToLower()]; }
            set { Parameters[nameof(DeviceId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Attaches a disk volume to a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AttachVolume(AttachVolumeRequest request);
        Task<AsyncJobResponse> AttachVolumeAsync(AttachVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AttachVolume(AttachVolumeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AttachVolumeAsync(AttachVolumeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
