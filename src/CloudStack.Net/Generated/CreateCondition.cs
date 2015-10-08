using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateConditionRequest : APIRequest
    {
        public CreateConditionRequest() : base("createCondition") {}

        /// <summary>
        /// ID of the Counter.
        /// </summary>
        public Guid CounterId { get; set; }

        /// <summary>
        /// Relational Operator to be used with threshold.
        /// </summary>
        public string RelationalOperator { get; set; }

        /// <summary>
        /// Threshold value.
        /// </summary>
        public long Threshold { get; set; }

        /// <summary>
        /// the account of the condition. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the domain ID of the account.
        /// </summary>
        public Guid DomainId { get; set; }

    }
    /// <summary>
    /// Creates a condition
    /// </summary>
    /// <summary>
    /// Creates a condition
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ConditionResponse CreateCondition(CreateConditionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ConditionResponse CreateCondition(CreateConditionRequest request) => _proxy.Request<ConditionResponse>(request);
    }
}
