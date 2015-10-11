using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteCiscoVnmcResourceRequest : APIRequest
    {
        public DeleteCiscoVnmcResourceRequest() : base("deleteCiscoVnmcResource") {}

        /// <summary>
        /// Cisco Vnmc resource ID
        /// </summary>
        public Guid Resourceid {
            get { return (Guid) Parameters[nameof(Resourceid).ToLower()]; }
            set { Parameters[nameof(Resourceid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a Cisco Vnmc controller
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteCiscoVnmcResource(DeleteCiscoVnmcResourceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteCiscoVnmcResource(DeleteCiscoVnmcResourceRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
