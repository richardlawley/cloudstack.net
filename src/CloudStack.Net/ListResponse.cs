using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    /// <summary>
    /// Response class for all CloudStack API calls which return a list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListResponse<T>
    {
        public int Count { get; set; }

        public IList<T> Results { get; set; }

        /// <summary>
        /// Creates a ListResponse from a list of objects, used for test purposes
        /// </summary>
        /// <param name="source">List of objects</param>
        /// <param name="request">Request containing paging info</param>
        /// <param name="maxPageSize">Optional max page size (to simulate config max page size)</param>
        /// <returns>ListResponse around part of the wrapper</returns>
        public static ListResponse<T> CreateFromList(IList<T> source, APIListRequest request, int maxPageSize = 500)
        {
            var response = new ListResponse<T>
            {
                Count = source.Count
            };

            int pageSize = request.PageSize ?? maxPageSize;
            int pageNumber = (request.Page ?? 1) - 1;

            response.Results = source.Skip(pageNumber * pageSize).Take(pageSize).ToList();
            return response;
        }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}