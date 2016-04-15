using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteIsoRequest : APIRequest
    {
        public DeleteIsoRequest() : base("deleteIso") {}

        /// <summary>
        /// the ID of the ISO file
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone of the ISO file. If not specified, the ISO will be deleted from all the zones
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes an ISO file.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteIso(DeleteIsoRequest request);
        Task<AsyncJobResponse> DeleteIsoAsync(DeleteIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteIso(DeleteIsoRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteIsoAsync(DeleteIsoRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
