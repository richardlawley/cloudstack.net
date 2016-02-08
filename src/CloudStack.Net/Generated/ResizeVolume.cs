using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResizeVolumeRequest : APIRequest
    {
        public ResizeVolumeRequest() : base("resizeVolume") {}

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// new disk offering id
        /// </summary>
        public Guid Diskofferingid {
            get { return (Guid) Parameters[nameof(Diskofferingid).ToLower()]; }
            set { Parameters[nameof(Diskofferingid).ToLower()] = value; }
        }

        /// <summary>
        /// New maximum number of IOPS
        /// </summary>
        public long? MaxIops {
            get { return (long?) Parameters[nameof(MaxIops).ToLower()]; }
            set { Parameters[nameof(MaxIops).ToLower()] = value; }
        }

        /// <summary>
        /// New minimum number of IOPS
        /// </summary>
        public long? MinIops {
            get { return (long?) Parameters[nameof(MinIops).ToLower()]; }
            set { Parameters[nameof(MinIops).ToLower()] = value; }
        }

        /// <summary>
        /// Verify OK to Shrink
        /// </summary>
        public bool? ShrinkOk {
            get { return (bool?) Parameters[nameof(ShrinkOk).ToLower()]; }
            set { Parameters[nameof(ShrinkOk).ToLower()] = value; }
        }

        /// <summary>
        /// New volume size in GB
        /// </summary>
        public long? Size {
            get { return (long?) Parameters[nameof(Size).ToLower()]; }
            set { Parameters[nameof(Size).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Resizes a volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ResizeVolume(ResizeVolumeRequest request);
        Task<AsyncJobResponse> ResizeVolumeAsync(ResizeVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ResizeVolume(ResizeVolumeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ResizeVolumeAsync(ResizeVolumeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
