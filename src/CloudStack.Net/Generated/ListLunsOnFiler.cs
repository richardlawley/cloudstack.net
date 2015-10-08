using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLunsOnFilerRequest : APIRequest
    {
        public ListLunsOnFilerRequest() : base("listLunsOnFiler") {}

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName { get; set; }

    }
    /// <summary>
    /// List LUN
    /// </summary>
    /// <summary>
    /// List LUN
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListLunsCmdResponse ListLunsOnFiler(ListLunsOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListLunsCmdResponse ListLunsOnFiler(ListLunsOnFilerRequest request) => _proxy.Request<ListLunsCmdResponse>(request);
    }
}
