using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLBStickinessPolicyRequest : APIRequest
    {
        public CreateLBStickinessPolicyRequest() : base("createLBStickinessPolicy") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId { get; set; }

        /// <summary>
        /// name of the load balancer stickiness policy method, possible values can be obtained from listNetworks API
        /// </summary>
        public string StickinessMethodName { get; set; }

        /// <summary>
        /// name of the load balancer stickiness policy
        /// </summary>
        public string LbStickinessPolicyName { get; set; }

        /// <summary>
        /// the description of the load balancer stickiness policy
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// param list. Example: param[0].name=cookiename&param[0].value=LBCookie 
        /// </summary>
        public IDictionary<string, string> ParamList { get; set; }

    }
    /// <summary>
    /// Creates a load balancer stickiness policy 
    /// </summary>
    /// <summary>
    /// Creates a load balancer stickiness policy 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LBStickinessResponse CreateLBStickinessPolicy(CreateLBStickinessPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LBStickinessResponse CreateLBStickinessPolicy(CreateLBStickinessPolicyRequest request) => _proxy.Request<LBStickinessResponse>(request);
    }
}
