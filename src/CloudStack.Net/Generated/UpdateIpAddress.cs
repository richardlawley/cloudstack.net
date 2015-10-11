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
        /// the id of the public ip address to update
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the ip to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates an ip address
    /// </summary>
    /// <summary>
    /// Updates an ip address
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateIpAddress(UpdateIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateIpAddress(UpdateIpAddressRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
