using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLBStickinessPolicyRequest : APIRequest
    {
        public CreateLBStickinessPolicyRequest() : base("createLBStickinessPolicy") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId {
            get { return GetParameterValue<Guid>(nameof(LbRuleId).ToLower()); }
            set { SetParameterValue(nameof(LbRuleId).ToLower(), value); }
        }

        /// <summary>
        /// name of the load balancer stickiness policy method, possible values can be obtained from listNetworks API
        /// </summary>
        public string Methodname {
            get { return GetParameterValue<string>(nameof(Methodname).ToLower()); }
            set { SetParameterValue(nameof(Methodname).ToLower(), value); }
        }

        /// <summary>
        /// name of the load balancer stickiness policy
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the description of the load balancer stickiness policy
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// param list. Example: param[0].name=cookiename&param[0].value=LBCookie 
        /// </summary>
        public IList<IDictionary<string, object>> Param {
            get { return GetList<IDictionary<string, object>>(nameof(Param).ToLower()); }
            set { SetParameterValue(nameof(Param).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a load balancer stickiness policy 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateLBStickinessPolicy(CreateLBStickinessPolicyRequest request);
        Task<AsyncJobResponse> CreateLBStickinessPolicyAsync(CreateLBStickinessPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateLBStickinessPolicy(CreateLBStickinessPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateLBStickinessPolicyAsync(CreateLBStickinessPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
