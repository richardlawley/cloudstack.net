using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroyVolumeOnFilerRequest : APIRequest
    {
        public DestroyVolumeOnFilerRequest() : base("destroyVolumeOnFiler") {}

        /// <summary>
        /// aggregate name.
        /// </summary>
        public string AggrName { get; set; }

        /// <summary>
        /// ip address.
        /// </summary>
        public string IpAddr { get; set; }

        /// <summary>
        /// volume name.
        /// </summary>
        public string VolumeName { get; set; }

    }
    /// <summary>
    /// Destroy a Volume
    /// </summary>
    /// <summary>
    /// Destroy a Volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DeleteVolumeOnFilerCmdResponse DestroyVolumeOnFiler(DestroyVolumeOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DeleteVolumeOnFilerCmdResponse DestroyVolumeOnFiler(DestroyVolumeOnFilerRequest request) => _proxy.Request<DeleteVolumeOnFilerCmdResponse>(request);
    }
}
