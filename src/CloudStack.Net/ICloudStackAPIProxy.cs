using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudStack.Net
{
    /// <summary>
    /// Interface for a proxy to the CloudStack API.  This passes typed requests to the CloudStack API endpoint and 
    /// handles decoding of the results
    /// </summary>
    public interface ICloudStackAPIProxy
    {
        /// <summary>
        /// Return a typed response from the CloudStack API
        /// </summary>
        /// <typeparam name="TResponse">Type of response expected</typeparam>
        /// <param name="request">Request Details</param>
        /// <returns></returns>
        TResponse Request<TResponse>(APIRequest request) where TResponse : new();

        /// <summary>
        /// Return a typed response from the CloudStack API
        /// </summary>
        /// <typeparam name="TResponse">Type of response expected</typeparam>
        /// <param name="request">Request Details</param>
        /// <returns></returns>
        Task<TResponse> RequestAsync<TResponse>(APIRequest request) where TResponse : new();

        /// <summary>
        /// Returns the entire list response from the CloudStack API, detecting paging in use and issuing multiple
        /// requests where necessary
        /// </summary>
        /// <typeparam name="TResponse">Type of item response expected</typeparam>
        /// <param name="request">Request Details</param>
        ListResponse<TResponse> RequestAllPages<TResponse>(APIListRequest request) where TResponse : new();

        /// <summary>
        /// Returns the entire list response from the CloudStack API, detecting paging in use and issuing multiple
        /// requests where necessary
        /// </summary>
        /// <typeparam name="TResponse">Type of item response expected</typeparam>
        /// <param name="request">Request Details</param>
        Task<ListResponse<TResponse>> RequestAllPagesAsync<TResponse>(APIListRequest request) where TResponse : new();
    }
}
