using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVolumeRequest : APIRequest
    {
        public UpdateVolumeRequest() : base("updateVolume") {}

        /// <summary>
        /// The chain info of the volume
        /// </summary>
        public string ChainInfo { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the volume to the end user or not.
        /// </summary>
        public bool? DisplayVolume { get; set; }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The path of the volume
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// The state of the volume
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Destination storage pool UUID for the volume
        /// </summary>
        public Guid StorageId { get; set; }

    }
    /// <summary>
    /// Updates the volume.
    /// </summary>
    /// <summary>
    /// Updates the volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VolumeResponse UpdateVolume(UpdateVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VolumeResponse UpdateVolume(UpdateVolumeRequest request) => _proxy.Request<VolumeResponse>(request);
    }
}
