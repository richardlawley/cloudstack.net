using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLunsOnFilerRequest : APIRequest
    {
        public ListLunsOnFilerRequest() : base("listLunsOnFiler") {}

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName {
            get { return (string) Parameters[nameof(PoolName).ToLower()]; }
            set { Parameters[nameof(PoolName).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List LUN
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListLunsCmdResponse ListLunsOnFiler(ListLunsOnFilerRequest request);
        Task<ListLunsCmdResponse> ListLunsOnFilerAsync(ListLunsOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListLunsCmdResponse ListLunsOnFiler(ListLunsOnFilerRequest request) => _proxy.Request<ListLunsCmdResponse>(request);
        public Task<ListLunsCmdResponse> ListLunsOnFilerAsync(ListLunsOnFilerRequest request) => _proxy.RequestAsync<ListLunsCmdResponse>(request);
    }
}
