using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLunOnFilerRequest : APIRequest
    {
        public CreateLunOnFilerRequest() : base("createLunOnFiler") {}

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName { get; set; }

        /// <summary>
        /// LUN size.
        /// </summary>
        public long Size { get; set; }

    }
    /// <summary>
    /// Create a LUN from a pool
    /// </summary>
    /// <summary>
    /// Create a LUN from a pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CreateLunCmdResponse CreateLunOnFiler(CreateLunOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CreateLunCmdResponse CreateLunOnFiler(CreateLunOnFilerRequest request) => _proxy.Request<CreateLunCmdResponse>(request);
    }
}
