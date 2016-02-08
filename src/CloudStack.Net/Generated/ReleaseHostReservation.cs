using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseHostReservationRequest : APIRequest
    {
        public ReleaseHostReservationRequest() : base("releaseHostReservation") {}

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Releases host reservation.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseHostReservation(ReleaseHostReservationRequest request);
        Task<AsyncJobResponse> ReleaseHostReservationAsync(ReleaseHostReservationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseHostReservation(ReleaseHostReservationRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReleaseHostReservationAsync(ReleaseHostReservationRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
