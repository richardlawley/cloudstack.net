using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroyLunOnFilerRequest : APIRequest
    {
        public DestroyLunOnFilerRequest() : base("destroyLunOnFiler") {}

        /// <summary>
        /// LUN path.
        /// </summary>
        public string Path { get; set; }

    }
    /// <summary>
    /// Destroy a LUN
    /// </summary>
    /// <summary>
    /// Destroy a LUN
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DeleteLUNCmdResponse DestroyLunOnFiler(DestroyLunOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DeleteLUNCmdResponse DestroyLunOnFiler(DestroyLunOnFilerRequest request) => _proxy.Request<DeleteLUNCmdResponse>(request);
    }
}
