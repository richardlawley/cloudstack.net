using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVlanIpRangeRequest : APIRequest
    {
        public DeleteVlanIpRangeRequest() : base("deleteVlanIpRange") {}

        /// <summary>
        /// the id of the VLAN IP range
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a VLAN IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVlanIpRange(DeleteVlanIpRangeRequest request);
        Task<SuccessResponse> DeleteVlanIpRangeAsync(DeleteVlanIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVlanIpRange(DeleteVlanIpRangeRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteVlanIpRangeAsync(DeleteVlanIpRangeRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
