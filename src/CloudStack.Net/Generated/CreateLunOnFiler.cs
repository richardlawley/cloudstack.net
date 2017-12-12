using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// LUN size.
        /// </summary>
        public long Size {
            get { return GetParameterValue<long>(nameof(Size).ToLower()); }
            set { SetParameterValue(nameof(Size).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create a LUN from a pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CreateLunCmdResponse CreateLunOnFiler(CreateLunOnFilerRequest request);
        Task<CreateLunCmdResponse> CreateLunOnFilerAsync(CreateLunOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CreateLunCmdResponse CreateLunOnFiler(CreateLunOnFilerRequest request) => Proxy.Request<CreateLunCmdResponse>(request);
        public Task<CreateLunCmdResponse> CreateLunOnFilerAsync(CreateLunOnFilerRequest request) => Proxy.RequestAsync<CreateLunCmdResponse>(request);
    }
}
