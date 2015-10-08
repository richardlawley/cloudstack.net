using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDeploymentPlannersRequest : APIRequest
    {
        public ListDeploymentPlannersRequest() : base("listDeploymentPlanners") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all DeploymentPlanners available.
    /// </summary>
    /// <summary>
    /// Lists all DeploymentPlanners available.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DeploymentPlannersResponse> ListDeploymentPlanners(ListDeploymentPlannersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DeploymentPlannersResponse> ListDeploymentPlanners(ListDeploymentPlannersRequest request) => _proxy.Request<ListResponse<DeploymentPlannersResponse>>(request);
    }
}
