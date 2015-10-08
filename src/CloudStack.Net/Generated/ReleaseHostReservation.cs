using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseHostReservationRequest : APIRequest
    {
        public ReleaseHostReservationRequest() : base("releaseHostReservation") {}

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Releases host reservation.
    /// </summary>
    /// <summary>
    /// Releases host reservation.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleaseHostReservation(ReleaseHostReservationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleaseHostReservation(ReleaseHostReservationRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
