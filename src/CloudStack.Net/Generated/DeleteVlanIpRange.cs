using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a VLAN IP range.
    /// </summary>
    /// <summary>
    /// Creates a VLAN IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVlanIpRange(DeleteVlanIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVlanIpRange(DeleteVlanIpRangeRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
