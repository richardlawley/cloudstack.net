using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPoolsRequest : APIRequest
    {
        public ListPoolsRequest() : base("listPools") {}

    }
    /// <summary>
    /// List Pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListVolumePoolsCmdResponse ListPools(ListPoolsRequest request);
        Task<ListVolumePoolsCmdResponse> ListPoolsAsync(ListPoolsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListVolumePoolsCmdResponse ListPools(ListPoolsRequest request) => _proxy.Request<ListVolumePoolsCmdResponse>(request);
        public Task<ListVolumePoolsCmdResponse> ListPoolsAsync(ListPoolsRequest request) => _proxy.RequestAsync<ListVolumePoolsCmdResponse>(request);
    }
}
