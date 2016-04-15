using System;
using System.Linq;
using System.Threading.Tasks;

namespace CloudStack.Net
{
    public static class ProxyExtensions
    {
        /// <summary>
        /// Returns the entire list response from the CloudStack API, detecting paging in use and issuing multiple
        /// requests where necessary
        /// </summary>
        /// <typeparam name="TResponse">Type of item response expected</typeparam>
        /// <param name="proxy">Proxy to operate on</param>
        /// <param name="request">Request Details</param>
        public static ListResponse<TResponse> RequestAllPages<TResponse>(this ICloudStackAPIProxy proxy, APIListRequest request) where TResponse : new()
        {
            int page = 1;
            ListResponse<TResponse> response = proxy.Request<ListResponse<TResponse>>(request);

            while (response.Results.Count < response.Count)
            {
                page++;

                request.Page = page;
                if (!request.PageSize.HasValue)
                {
                    request.PageSize = response.Results.Count;
                }

                ListResponse<TResponse> pageResponse = proxy.Request<ListResponse<TResponse>>(request);
                foreach (TResponse item in pageResponse.Results)
                {
                    response.Results.Add(item);
                }
                response.Count = pageResponse.Count;        // In case it changed while we pulled results
            }

            return response;
        }

        /// <summary>
        /// Returns the entire list response from the CloudStack API, detecting paging in use and issuing multiple
        /// requests where necessary
        /// </summary>
        /// <typeparam name="TResponse">Type of item response expected</typeparam>
        /// <param name="proxy">Proxy to operate on</param>
        /// <param name="request">Request Details</param>
        public static async Task<ListResponse<TResponse>> RequestAllPagesAsync<TResponse>(this ICloudStackAPIProxy proxy, APIListRequest request) where TResponse : new()
        {
            int page = 0;
            ListResponse<TResponse> response = await proxy.RequestAsync<ListResponse<TResponse>>(request);

            while (response.Results.Count < response.Count)
            {
                page++;

                request.Page = page;
                ListResponse<TResponse> pageReponse = await proxy.RequestAsync<ListResponse<TResponse>>(request);
                foreach (TResponse item in pageReponse.Results)
                {
                    response.Results.Add(item);
                }
            }

            return response;
        }
    }
}