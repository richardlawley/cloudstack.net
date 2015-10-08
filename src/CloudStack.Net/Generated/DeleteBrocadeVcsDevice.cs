using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBrocadeVcsDeviceRequest : APIRequest
    {
        public DeleteBrocadeVcsDeviceRequest() : base("deleteBrocadeVcsDevice") {}

        /// <summary>
        /// Brocade Switch ID
        /// </summary>
        public Guid BrocadeVcsDeviceId { get; set; }

    }
    /// <summary>
    ///  delete a Brocade VCS Switch
    /// </summary>
    /// <summary>
    ///  delete a Brocade VCS Switch
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteBrocadeVcsDevice(DeleteBrocadeVcsDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteBrocadeVcsDevice(DeleteBrocadeVcsDeviceRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
