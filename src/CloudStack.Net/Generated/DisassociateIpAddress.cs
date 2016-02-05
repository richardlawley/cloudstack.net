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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Disassociates an IP address from the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisassociateIpAddress(DisassociateIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisassociateIpAddress(DisassociateIpAddressRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
