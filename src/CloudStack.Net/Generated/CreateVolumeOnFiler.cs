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
        public string Aggregatename {
            get { return (string) Parameters[nameof(Aggregatename).ToLower()]; }
            set { Parameters[nameof(Aggregatename).ToLower()] = value; }
        }

        /// <summary>
        /// ip address.
        /// </summary>
        public string IpAddress {
            get { return (string) Parameters[nameof(IpAddress).ToLower()]; }
            set { Parameters[nameof(IpAddress).ToLower()] = value; }
        }

        /// <summary>
        /// password.
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName {
            get { return (string) Parameters[nameof(PoolName).ToLower()]; }
            set { Parameters[nameof(PoolName).ToLower()] = value; }
        }

        /// <summary>
        /// volume size.
        /// </summary>
        public int Size {
            get { return (int) Parameters[nameof(Size).ToLower()]; }
            set { Parameters[nameof(Size).ToLower()] = value; }
        }

        /// <summary>
        /// user name.
        /// </summary>
        public string UserName {
            get { return (string) Parameters[nameof(UserName).ToLower()]; }
            set { Parameters[nameof(UserName).ToLower()] = value; }
        }

        /// <summary>
        /// volume name.
        /// </summary>
        public string Volumename {
            get { return (string) Parameters[nameof(Volumename).ToLower()]; }
            set { Parameters[nameof(Volumename).ToLower()] = value; }
        }

        /// <summary>
        /// snapshot policy.
        /// </summary>
        public string SnapshotPolicy {
            get { return (string) Parameters[nameof(SnapshotPolicy).ToLower()]; }
            set { Parameters[nameof(SnapshotPolicy).ToLower()] = value; }
        }

        /// <summary>
        /// snapshot reservation.
        /// </summary>
        public int? SnapshotReservation {
            get { return (int?) Parameters[nameof(SnapshotReservation).ToLower()]; }
            set { Parameters[nameof(SnapshotReservation).ToLower()] = value; }
        }

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
