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
            get { return GetParameterValue<string>(nameof(PoolName).ToLower()); }
            set { SetParameterValue(nameof(PoolName).ToLower(), value); }
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
        public ListVolumesOnFilerCmdResponse ListVolumesOnFiler(ListVolumesOnFilerRequest request) => Proxy.Request<ListVolumesOnFilerCmdResponse>(request);
        public Task<ListVolumesOnFilerCmdResponse> ListVolumesOnFilerAsync(ListVolumesOnFilerRequest request) => Proxy.RequestAsync<ListVolumesOnFilerCmdResponse>(request);
    }
}
