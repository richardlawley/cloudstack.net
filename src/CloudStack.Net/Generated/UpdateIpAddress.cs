using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateIpAddressRequest : APIRequest
    {
        public UpdateIpAddressRequest() : base("updateIpAddress") {}

        /// <summary>
        /// the ID of the public IP address to update
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the IP to the end user or not
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Updates an IP address
    /// </summary>
    /// <summary>
    /// Updates an IP address
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        IPAddressResponse UpdateIpAddress(UpdateIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public IPAddressResponse UpdateIpAddress(UpdateIpAddressRequest request) => _proxy.Request<IPAddressResponse>(request);
    }
}
