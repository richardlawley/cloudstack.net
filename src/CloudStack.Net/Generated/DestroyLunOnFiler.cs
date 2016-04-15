using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroyLunOnFilerRequest : APIRequest
    {
        public DestroyLunOnFilerRequest() : base("destroyLunOnFiler") {}

        /// <summary>
        /// LUN path.
        /// </summary>
        public string Path {
            get { return GetParameterValue<string>(nameof(Path).ToLower()); }
            set { SetParameterValue(nameof(Path).ToLower(), value); }
        }

    }
    /// <summary>
    /// Destroy a LUN
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DeleteLUNCmdResponse DestroyLunOnFiler(DestroyLunOnFilerRequest request);
        Task<DeleteLUNCmdResponse> DestroyLunOnFilerAsync(DestroyLunOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DeleteLUNCmdResponse DestroyLunOnFiler(DestroyLunOnFilerRequest request) => _proxy.Request<DeleteLUNCmdResponse>(request);
        public Task<DeleteLUNCmdResponse> DestroyLunOnFilerAsync(DestroyLunOnFilerRequest request) => _proxy.RequestAsync<DeleteLUNCmdResponse>(request);
    }
}
