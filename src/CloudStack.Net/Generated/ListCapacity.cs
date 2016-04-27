using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCapacityRequest : APIListRequest
    {
        public ListCapacityRequest() : base("listCapacity") {}

        /// <summary>
        /// lists capacity by the Cluster ID
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// recalculate capacities and fetch the latest
        /// </summary>
        public bool? FetchLatest {
            get { return GetParameterValue<bool?>(nameof(FetchLatest).ToLower()); }
            set { SetParameterValue(nameof(FetchLatest).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// lists capacity by the Pod ID
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// Sort the results. Available values: Usage
        /// </summary>
        public string SortBy {
            get { return GetParameterValue<string>(nameof(SortBy).ToLower()); }
            set { SetParameterValue(nameof(SortBy).ToLower(), value); }
        }

        /// <summary>
        /// lists capacity by type* CAPACITY_TYPE_MEMORY = 0* CAPACITY_TYPE_CPU = 1* CAPACITY_TYPE_STORAGE = 2* CAPACITY_TYPE_STORAGE_ALLOCATED = 3* CAPACITY_TYPE_VIRTUAL_NETWORK_PUBLIC_IP = 4* CAPACITY_TYPE_PRIVATE_IP = 5* CAPACITY_TYPE_SECONDARY_STORAGE = 6* CAPACITY_TYPE_VLAN = 7* CAPACITY_TYPE_DIRECT_ATTACHED_PUBLIC_IP = 8* CAPACITY_TYPE_LOCAL_STORAGE = 9.
        /// </summary>
        public int? Type {
            get { return GetParameterValue<int?>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// lists capacity by the Zone ID
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all the system wide capacities.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CapacityResponse> ListCapacity(ListCapacityRequest request);
        Task<ListResponse<CapacityResponse>> ListCapacityAsync(ListCapacityRequest request);
        ListResponse<CapacityResponse> ListCapacityAllPages(ListCapacityRequest request);
        Task<ListResponse<CapacityResponse>> ListCapacityAllPagesAsync(ListCapacityRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CapacityResponse> ListCapacity(ListCapacityRequest request) => _proxy.Request<ListResponse<CapacityResponse>>(request);
        public Task<ListResponse<CapacityResponse>> ListCapacityAsync(ListCapacityRequest request) => _proxy.RequestAsync<ListResponse<CapacityResponse>>(request);
        public ListResponse<CapacityResponse> ListCapacityAllPages(ListCapacityRequest request) => _proxy.RequestAllPages<CapacityResponse>(request);
        public Task<ListResponse<CapacityResponse>> ListCapacityAllPagesAsync(ListCapacityRequest request) => _proxy.RequestAllPagesAsync<CapacityResponse>(request);
    }
}
