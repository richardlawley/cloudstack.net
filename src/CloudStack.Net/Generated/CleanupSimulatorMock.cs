using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CleanupSimulatorMockRequest : APIRequest
    {
        public CleanupSimulatorMockRequest() : base("cleanupSimulatorMock") {}

        /// <summary>
        /// id of the configured mock
        /// </summary>
        public long? Id {
            get { return (long?) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// cleanup simulator mock
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse CleanupSimulatorMock(CleanupSimulatorMockRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse CleanupSimulatorMock(CleanupSimulatorMockRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
