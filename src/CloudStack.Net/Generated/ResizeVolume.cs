using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResizeVolumeRequest : APIRequest
    {
        public ResizeVolumeRequest() : base("resizeVolume") {}

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// new disk offering id
        /// </summary>
        public Guid NewDiskOfferingId { get; set; }

        /// <summary>
        /// New maximum number of IOPS
        /// </summary>
        public long? MaxIops { get; set; }

        /// <summary>
        /// New minimum number of IOPS
        /// </summary>
        public long? MinIops { get; set; }

        /// <summary>
        /// Verify OK to Shrink
        /// </summary>
        public bool? ShrinkOk { get; set; }

        /// <summary>
        /// New volume size in GB
        /// </summary>
        public long? Size { get; set; }

    }
    /// <summary>
    /// Resizes a volume
    /// </summary>
    /// <summary>
    /// Resizes a volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VolumeResponse ResizeVolume(ResizeVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VolumeResponse ResizeVolume(ResizeVolumeRequest request) => _proxy.Request<VolumeResponse>(request);
    }
}
