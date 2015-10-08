using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVolumeOnFilerRequest : APIRequest
    {
        public CreateVolumeOnFilerRequest() : base("createVolumeOnFiler") {}

        /// <summary>
        /// aggregate name.
        /// </summary>
        public string AggrName { get; set; }

        /// <summary>
        /// ip address.
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName { get; set; }

        /// <summary>
        /// volume size.
        /// </summary>
        public int VolSize { get; set; }

        /// <summary>
        /// user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// volume name.
        /// </summary>
        public string VolName { get; set; }

        /// <summary>
        /// snapshot policy.
        /// </summary>
        public string SnapshotPolicy { get; set; }

        /// <summary>
        /// snapshot reservation.
        /// </summary>
        public int? SnapshotReservation { get; set; }

    }
    /// <summary>
    /// Create a volume
    /// </summary>
    /// <summary>
    /// Create a volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CreateVolumeOnFilerCmdResponse CreateVolumeOnFiler(CreateVolumeOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CreateVolumeOnFilerCmdResponse CreateVolumeOnFiler(CreateVolumeOnFilerRequest request) => _proxy.Request<CreateVolumeOnFilerCmdResponse>(request);
    }
}
