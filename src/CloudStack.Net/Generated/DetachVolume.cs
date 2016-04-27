using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<long?>(nameof(DeviceId).ToLower()); }
            set { SetParameterValue(nameof(DeviceId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine where the volume is detached from
        /// </summary>
        public Guid? VirtualMachineId {
            get { return GetParameterValue<Guid?>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Detaches a disk volume from a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DetachVolume(DetachVolumeRequest request);
        Task<AsyncJobResponse> DetachVolumeAsync(DetachVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DetachVolume(DetachVolumeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DetachVolumeAsync(DetachVolumeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
