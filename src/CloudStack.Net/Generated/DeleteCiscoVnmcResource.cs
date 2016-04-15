using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Resourceid).ToLower()); }
            set { SetParameterValue(nameof(Resourceid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a Cisco Vnmc controller
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteCiscoVnmcResource(DeleteCiscoVnmcResourceRequest request);
        Task<SuccessResponse> DeleteCiscoVnmcResourceAsync(DeleteCiscoVnmcResourceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteCiscoVnmcResource(DeleteCiscoVnmcResourceRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteCiscoVnmcResourceAsync(DeleteCiscoVnmcResourceRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
