using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpgradeRouterTemplateRequest : APIRequest
    {
        public UpgradeRouterTemplateRequest() : base("upgradeRouterTemplate") {}

        /// <summary>
        /// upgrades all routers owned by the specified account
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// upgrades all routers within the specified cluster
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// upgrades all routers owned by the specified domain
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// upgrades router with the specified Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// upgrades all routers within the specified pod
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// upgrades all routers within the specified zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Upgrades router to use newer template
    /// </summary>
    /// <summary>
    /// Upgrades router to use newer template
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BaseResponse UpgradeRouterTemplate(UpgradeRouterTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BaseResponse UpgradeRouterTemplate(UpgradeRouterTemplateRequest request) => _proxy.Request<BaseResponse>(request);
    }
}
