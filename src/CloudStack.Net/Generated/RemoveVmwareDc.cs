using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveVmwareDcRequest : APIRequest
    {
        public RemoveVmwareDcRequest() : base("removeVmwareDc") {}

        /// <summary>
        /// The id of Zone from which VMware datacenter has to be removed.
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Remove a VMware datacenter from a zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveVmwareDc(RemoveVmwareDcRequest request);
        Task<SuccessResponse> RemoveVmwareDcAsync(RemoveVmwareDcRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveVmwareDc(RemoveVmwareDcRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> RemoveVmwareDcAsync(RemoveVmwareDcRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
