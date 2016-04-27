using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(ChainInfo).ToLower()); }
            set { SetParameterValue(nameof(ChainInfo).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the volume to the end user or not.
        /// </summary>
        public bool? DisplayVolume {
            get { return GetParameterValue<bool?>(nameof(DisplayVolume).ToLower()); }
            set { SetParameterValue(nameof(DisplayVolume).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// The path of the volume
        /// </summary>
        public string Path {
            get { return GetParameterValue<string>(nameof(Path).ToLower()); }
            set { SetParameterValue(nameof(Path).ToLower(), value); }
        }

        /// <summary>
        /// The state of the volume
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// Destination storage pool UUID for the volume
        /// </summary>
        public Guid? StorageId {
            get { return GetParameterValue<Guid?>(nameof(StorageId).ToLower()); }
            set { SetParameterValue(nameof(StorageId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates the volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateVolume(UpdateVolumeRequest request);
        Task<AsyncJobResponse> UpdateVolumeAsync(UpdateVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateVolume(UpdateVolumeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateVolumeAsync(UpdateVolumeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
