using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVolumesOnFilerRequest : APIRequest
    {
        public ListVolumesOnFilerRequest() : base("listVolumesOnFiler") {}

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName {
            get { return (string) Parameters[nameof(PoolName).ToLower()]; }
            set { Parameters[nameof(PoolName).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List Volumes
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListVolumesOnFilerCmdResponse ListVolumesOnFiler(ListVolumesOnFilerRequest request);
        Task<ListVolumesOnFilerCmdResponse> ListVolumesOnFilerAsync(ListVolumesOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListVolumesOnFilerCmdResponse ListVolumesOnFiler(ListVolumesOnFilerRequest request) => _proxy.Request<ListVolumesOnFilerCmdResponse>(request);
        public Task<ListVolumesOnFilerCmdResponse> ListVolumesOnFilerAsync(ListVolumesOnFilerRequest request) => _proxy.RequestAsync<ListVolumesOnFilerCmdResponse>(request);
    }
}
