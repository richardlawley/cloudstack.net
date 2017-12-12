using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disassociates an IP address from the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisassociateIpAddress(DisassociateIpAddressRequest request);
        Task<AsyncJobResponse> DisassociateIpAddressAsync(DisassociateIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisassociateIpAddress(DisassociateIpAddressRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisassociateIpAddressAsync(DisassociateIpAddressRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
