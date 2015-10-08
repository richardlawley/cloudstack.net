using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisassociateIpAddressRequest : APIRequest
    {
        public DisassociateIpAddressRequest() : base("disassociateIpAddress") {}

        /// <summary>
        /// the ID of the public IP address to disassociate
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Disassociates an IP address from the account.
    /// </summary>
    /// <summary>
    /// Disassociates an IP address from the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DisassociateIpAddress(DisassociateIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DisassociateIpAddress(DisassociateIpAddressRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
