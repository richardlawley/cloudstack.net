using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVolumeRequest : APIRequest
    {
        public DeleteVolumeRequest() : base("deleteVolume") {}

        /// <summary>
        /// The ID of the disk volume
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a detached disk volume.
    /// </summary>
    /// <summary>
    /// Deletes a detached disk volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVolume(DeleteVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVolume(DeleteVolumeRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
