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
        public string ChainInfo {
            get { return (string) Parameters[nameof(ChainInfo).ToLower()]; }
            set { Parameters[nameof(ChainInfo).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the volume to the end user or not.
        /// </summary>
        public bool? DisplayVolume {
            get { return (bool?) Parameters[nameof(DisplayVolume).ToLower()]; }
            set { Parameters[nameof(DisplayVolume).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// The path of the volume
        /// </summary>
        public string Path {
            get { return (string) Parameters[nameof(Path).ToLower()]; }
            set { Parameters[nameof(Path).ToLower()] = value; }
        }

        /// <summary>
        /// The state of the volume
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

        /// <summary>
        /// Destination storage pool UUID for the volume
        /// </summary>
        public Guid StorageId {
            get { return (Guid) Parameters[nameof(StorageId).ToLower()]; }
            set { Parameters[nameof(StorageId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates the volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateVolume(UpdateVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateVolume(UpdateVolumeRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
