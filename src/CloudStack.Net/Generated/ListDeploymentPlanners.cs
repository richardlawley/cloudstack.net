using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDeploymentPlannersRequest : APIRequest
    {
        public ListDeploymentPlannersRequest() : base("listDeploymentPlanners") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all DeploymentPlanners available.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DeploymentPlannersResponse> ListDeploymentPlanners(ListDeploymentPlannersRequest request);
        Task<ListResponse<DeploymentPlannersResponse>> ListDeploymentPlannersAsync(ListDeploymentPlannersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DeploymentPlannersResponse> ListDeploymentPlanners(ListDeploymentPlannersRequest request) => _proxy.Request<ListResponse<DeploymentPlannersResponse>>(request);
        public Task<ListResponse<DeploymentPlannersResponse>> ListDeploymentPlannersAsync(ListDeploymentPlannersRequest request) => _proxy.RequestAsync<ListResponse<DeploymentPlannersResponse>>(request);
    }
}
