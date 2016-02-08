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

    }
}
