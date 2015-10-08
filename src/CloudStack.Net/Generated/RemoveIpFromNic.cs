using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveIpFromNicRequest : APIRequest
    {
        public RemoveIpFromNicRequest() : base("removeIpFromNic") {}

        /// <summary>
        /// the ID of the secondary ip address to nic
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Removes secondary IP from the NIC.
    /// </summary>
    /// <summary>
    /// Removes secondary IP from the NIC.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveIpFromNic(RemoveIpFromNicRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveIpFromNic(RemoveIpFromNicRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
