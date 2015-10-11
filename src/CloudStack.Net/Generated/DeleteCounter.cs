using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteCounterRequest : APIRequest
    {
        public DeleteCounterRequest() : base("deleteCounter") {}

        /// <summary>
        /// the ID of the counter
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a counter
    /// </summary>
    /// <summary>
    /// Deletes a counter
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteCounter(DeleteCounterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteCounter(DeleteCounterRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
