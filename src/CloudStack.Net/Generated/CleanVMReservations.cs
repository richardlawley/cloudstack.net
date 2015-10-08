using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CleanVMReservationsRequest : APIRequest
    {
        public CleanVMReservationsRequest() : base("cleanVMReservations") {}

    }
    /// <summary>
    /// Cleanups VM reservations in the database.
    /// </summary>
    /// <summary>
    /// Cleanups VM reservations in the database.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse CleanVMReservations(CleanVMReservationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse CleanVMReservations(CleanVMReservationsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
