using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBrocadeVcsDeviceRequest : APIRequest
    {
        public AddBrocadeVcsDeviceRequest() : base("addBrocadeVcsDevice") {}

        /// <summary>
        /// Hostname of ip address of the Brocade VCS Switch.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Credentials to access the Brocade VCS Switch API
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// Credentials to access the Brocade VCS Switch API
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds a Brocade VCS Switch
    /// </summary>
    /// <summary>
    /// Adds a Brocade VCS Switch
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BrocadeVcsDeviceResponse AddBrocadeVcsDevice(AddBrocadeVcsDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BrocadeVcsDeviceResponse AddBrocadeVcsDevice(AddBrocadeVcsDeviceRequest request) => _proxy.Request<BrocadeVcsDeviceResponse>(request);
    }
}
