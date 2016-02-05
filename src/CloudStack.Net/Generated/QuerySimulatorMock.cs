using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuerySimulatorMockRequest : APIRequest
    {
        public QuerySimulatorMockRequest() : base("querySimulatorMock") {}

        /// <summary>
        /// id of the configured mock
        /// </summary>
        public long? Id {
            get { return (long?) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// query simulator mock
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        MockResponse QuerySimulatorMock(QuerySimulatorMockRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public MockResponse QuerySimulatorMock(QuerySimulatorMockRequest request) => _proxy.Request<MockResponse>(request);
    }
}
