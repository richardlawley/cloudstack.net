using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBaremetalRctRequest : APIRequest
    {
        public DeleteBaremetalRctRequest() : base("deleteBaremetalRct") {}

        /// <summary>
        /// RCT id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// deletes baremetal rack configuration text
    /// </summary>
    /// <summary>
    /// deletes baremetal rack configuration text
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteBaremetalRct(DeleteBaremetalRctRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteBaremetalRct(DeleteBaremetalRctRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
