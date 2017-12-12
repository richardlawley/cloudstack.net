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
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// upgrades all routers within the specified cluster
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// upgrades all routers owned by the specified domain
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// upgrades router with the specified Id
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// upgrades all routers within the specified pod
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// upgrades all routers within the specified zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
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
        public BaseResponse UpgradeRouterTemplate(UpgradeRouterTemplateRequest request) => Proxy.Request<BaseResponse>(request);
        public Task<BaseResponse> UpgradeRouterTemplateAsync(UpgradeRouterTemplateRequest request) => Proxy.RequestAsync<BaseResponse>(request);
    }
}
