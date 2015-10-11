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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes secondary IP from the NIC.
    /// </summary>
    /// <summary>
    /// Removes secondary IP from the NIC.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveIpFromNic(RemoveIpFromNicRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveIpFromNic(RemoveIpFromNicRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
