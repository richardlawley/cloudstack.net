using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSrxFirewallRequest : APIRequest
    {
        public DeleteSrxFirewallRequest() : base("deleteSrxFirewall") {}

        /// <summary>
        /// srx firewall device ID
        /// </summary>
        public Guid FwDeviceId {
            get { return (Guid) Parameters[nameof(FwDeviceId).ToLower()]; }
            set { Parameters[nameof(FwDeviceId).ToLower()] = value; }
        }

    }
    /// <summary>
    ///  delete a SRX firewall device
    /// </summary>
    /// <summary>
    ///  delete a SRX firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSrxFirewall(DeleteSrxFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSrxFirewall(DeleteSrxFirewallRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
