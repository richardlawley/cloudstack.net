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
        public Guid Id { get; set; }

    }
    /// <summary>
    /// deletes baremetal rack configuration text
    /// </summary>
    /// <summary>
    /// deletes baremetal rack configuration text
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteBaremetalRct(DeleteBaremetalRctRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteBaremetalRct(DeleteBaremetalRctRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
