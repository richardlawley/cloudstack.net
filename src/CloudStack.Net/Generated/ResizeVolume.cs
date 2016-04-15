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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// new disk offering id
        /// </summary>
        public Guid Diskofferingid {
            get { return GetParameterValue<Guid>(nameof(Diskofferingid).ToLower()); }
            set { SetParameterValue(nameof(Diskofferingid).ToLower(), value); }
        }

        /// <summary>
        /// New maximum number of IOPS
        /// </summary>
        public long? MaxIops {
            get { return GetParameterValue<long?>(nameof(MaxIops).ToLower()); }
            set { SetParameterValue(nameof(MaxIops).ToLower(), value); }
        }

        /// <summary>
        /// New minimum number of IOPS
        /// </summary>
        public long? MinIops {
            get { return GetParameterValue<long?>(nameof(MinIops).ToLower()); }
            set { SetParameterValue(nameof(MinIops).ToLower(), value); }
        }

        /// <summary>
        /// Verify OK to Shrink
        /// </summary>
        public bool? ShrinkOk {
            get { return GetParameterValue<bool?>(nameof(ShrinkOk).ToLower()); }
            set { SetParameterValue(nameof(ShrinkOk).ToLower(), value); }
        }

        /// <summary>
        /// New volume size in GB
        /// </summary>
        public long? Size {
            get { return GetParameterValue<long?>(nameof(Size).ToLower()); }
            set { SetParameterValue(nameof(Size).ToLower(), value); }
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
