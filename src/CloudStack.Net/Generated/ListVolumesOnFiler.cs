using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVolumesOnFilerRequest : APIRequest
    {
        public ListVolumesOnFilerRequest() : base("listVolumesOnFiler") {}

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName { get; set; }

    }
    /// <summary>
    /// List Volumes
    /// </summary>
    /// <summary>
    /// List Volumes
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListVolumesOnFilerCmdResponse ListVolumesOnFiler(ListVolumesOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListVolumesOnFilerCmdResponse ListVolumesOnFiler(ListVolumesOnFilerRequest request) => _proxy.Request<ListVolumesOnFilerCmdResponse>(request);
    }
}
