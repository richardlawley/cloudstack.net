using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableStaticNatRequest : APIRequest
    {
        public DisableStaticNatRequest() : base("disableStaticNat") {}

        /// <summary>
        /// the public IP address id for which static nat feature is being disableed
        /// </summary>
        public Guid IpAddressId {
            get { return (Guid) Parameters[nameof(IpAddressId).ToLower()]; }
            set { Parameters[nameof(IpAddressId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Disables static rule for given ip address
    /// </summary>
    /// <summary>
    /// Disables static rule for given ip address
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DisableStaticNat(DisableStaticNatRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DisableStaticNat(DisableStaticNatRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
