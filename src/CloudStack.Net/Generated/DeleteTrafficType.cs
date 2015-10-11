using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTrafficTypeRequest : APIRequest
    {
        public DeleteTrafficTypeRequest() : base("deleteTrafficType") {}

        /// <summary>
        /// traffic type id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes traffic type of a physical network
    /// </summary>
    /// <summary>
    /// Deletes traffic type of a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteTrafficType(DeleteTrafficTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteTrafficType(DeleteTrafficTypeRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
