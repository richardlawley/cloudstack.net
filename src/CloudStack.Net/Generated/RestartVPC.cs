using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RestartVPCRequest : APIRequest
    {
        public RestartVPCRequest() : base("restartVPC") {}

        /// <summary>
        /// the id of the VPC
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// If cleanup old network elements
        /// </summary>
        public bool? Cleanup {
            get { return GetParameterValue<bool?>(nameof(Cleanup).ToLower()); }
            set { SetParameterValue(nameof(Cleanup).ToLower(), value); }
        }

        /// <summary>
        /// Turn a single VPC into a redundant one.
        /// </summary>
        public bool? Makeredundant {
            get { return GetParameterValue<bool?>(nameof(Makeredundant).ToLower()); }
            set { SetParameterValue(nameof(Makeredundant).ToLower(), value); }
        }

    }
    /// <summary>
    /// Restarts a VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RestartVPC(RestartVPCRequest request);
        Task<AsyncJobResponse> RestartVPCAsync(RestartVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RestartVPC(RestartVPCRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RestartVPCAsync(RestartVPCRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
