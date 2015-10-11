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
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// LUN size.
        /// </summary>
        public long Size {
            get { return (long) Parameters[nameof(Size).ToLower()]; }
            set { Parameters[nameof(Size).ToLower()] = value; }
        }

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
