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
        public Guid LbRuleId {
            get { return (Guid) Parameters[nameof(LbRuleId).ToLower()]; }
            set { Parameters[nameof(LbRuleId).ToLower()] = value; }
        }

        /// <summary>
        /// name of the LB Stickiness policy method, possible values can be obtained from ListNetworks API 
        /// </summary>
        public string Methodname {
            get { return (string) Parameters[nameof(Methodname).ToLower()]; }
            set { Parameters[nameof(Methodname).ToLower()] = value; }
        }

        /// <summary>
        /// name of the LB Stickiness policy
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the description of the LB Stickiness policy
        /// </summary>
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// param list. Example: param[0].name=cookiename&param[0].value=LBCookie 
        /// </summary>
        public IDictionary<string, string> Param {
            get { return (IDictionary<string, string>) Parameters[nameof(Param).ToLower()]; }
            set { Parameters[nameof(Param).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a Load Balancer stickiness policy 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateLBStickinessPolicy(CreateLBStickinessPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateLBStickinessPolicy(CreateLBStickinessPolicyRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
