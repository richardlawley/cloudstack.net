using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpgradeRouterTemplateRequest : APIRequest
    {
        public UpgradeRouterTemplateRequest() : base("upgradeRouterTemplate") {}

        /// <summary>
        /// upgrades all routers owned by the specified account
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// upgrades all routers within the specified cluster
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// upgrades all routers owned by the specified domain
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// upgrades router with the specified Id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// upgrades all routers within the specified pod
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// upgrades all routers within the specified zone
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Upgrades router to use newer template
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BaseResponse UpgradeRouterTemplate(UpgradeRouterTemplateRequest request);
        Task<BaseResponse> UpgradeRouterTemplateAsync(UpgradeRouterTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BaseResponse UpgradeRouterTemplate(UpgradeRouterTemplateRequest request) => _proxy.Request<BaseResponse>(request);
        public Task<BaseResponse> UpgradeRouterTemplateAsync(UpgradeRouterTemplateRequest request) => _proxy.RequestAsync<BaseResponse>(request);
    }
}
