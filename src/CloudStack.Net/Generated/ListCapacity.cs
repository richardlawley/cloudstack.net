using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCapacityRequest : APIRequest
    {
        public ListCapacityRequest() : base("listCapacity") {}

        /// <summary>
        /// lists capacity by the Cluster ID
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// recalculate capacities and fetch the latest
        /// </summary>
        public bool? FetchLatest { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// lists capacity by the Pod ID
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// Sort the results. Available values: Usage
        /// </summary>
        public string SortBy { get; set; }

        /// <summary>
        /// lists capacity by type* CAPACITY_TYPE_MEMORY = 0* CAPACITY_TYPE_CPU = 1* CAPACITY_TYPE_STORAGE = 2* CAPACITY_TYPE_STORAGE_ALLOCATED = 3* CAPACITY_TYPE_VIRTUAL_NETWORK_PUBLIC_IP = 4* CAPACITY_TYPE_PRIVATE_IP = 5* CAPACITY_TYPE_SECONDARY_STORAGE = 6* CAPACITY_TYPE_VLAN = 7* CAPACITY_TYPE_DIRECT_ATTACHED_PUBLIC_IP = 8* CAPACITY_TYPE_LOCAL_STORAGE = 9.
        /// </summary>
        public int? Type { get; set; }

        /// <summary>
        /// lists capacity by the Zone ID
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all the system wide capacities.
    /// </summary>
    /// <summary>
    /// Lists all the system wide capacities.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CapacityResponse> ListCapacity(ListCapacityRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CapacityResponse> ListCapacity(ListCapacityRequest request) => _proxy.Request<ListResponse<CapacityResponse>>(request);
    }
}
