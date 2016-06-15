using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Aggregatename).ToLower()); }
            set { SetParameterValue(nameof(Aggregatename).ToLower(), value); }
        }

        /// <summary>
        /// ip address.
        /// </summary>
        public string IpAddress {
            get { return GetParameterValue<string>(nameof(IpAddress).ToLower()); }
            set { SetParameterValue(nameof(IpAddress).ToLower(), value); }
        }

        /// <summary>
        /// password.
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName {
            get { return GetParameterValue<string>(nameof(PoolName).ToLower()); }
            set { SetParameterValue(nameof(PoolName).ToLower(), value); }
        }

        /// <summary>
        /// volume size.
        /// </summary>
        public int? Size {
            get { return GetParameterValue<int?>(nameof(Size).ToLower()); }
            set { SetParameterValue(nameof(Size).ToLower(), value); }
        }

        /// <summary>
        /// user name.
        /// </summary>
        public string UserName {
            get { return GetParameterValue<string>(nameof(UserName).ToLower()); }
            set { SetParameterValue(nameof(UserName).ToLower(), value); }
        }

        /// <summary>
        /// volume name.
        /// </summary>
        public string Volumename {
            get { return GetParameterValue<string>(nameof(Volumename).ToLower()); }
            set { SetParameterValue(nameof(Volumename).ToLower(), value); }
        }

        /// <summary>
        /// snapshot policy.
        /// </summary>
        public string SnapshotPolicy {
            get { return GetParameterValue<string>(nameof(SnapshotPolicy).ToLower()); }
            set { SetParameterValue(nameof(SnapshotPolicy).ToLower(), value); }
        }

        /// <summary>
        /// snapshot reservation.
        /// </summary>
        public int? SnapshotReservation {
            get { return GetParameterValue<int?>(nameof(SnapshotReservation).ToLower()); }
            set { SetParameterValue(nameof(SnapshotReservation).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create a volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CreateVolumeOnFilerCmdResponse CreateVolumeOnFiler(CreateVolumeOnFilerRequest request);
        Task<CreateVolumeOnFilerCmdResponse> CreateVolumeOnFilerAsync(CreateVolumeOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CreateVolumeOnFilerCmdResponse CreateVolumeOnFiler(CreateVolumeOnFilerRequest request) => _proxy.Request<CreateVolumeOnFilerCmdResponse>(request);
        public Task<CreateVolumeOnFilerCmdResponse> CreateVolumeOnFilerAsync(CreateVolumeOnFilerRequest request) => _proxy.RequestAsync<CreateVolumeOnFilerCmdResponse>(request);
    }
}
