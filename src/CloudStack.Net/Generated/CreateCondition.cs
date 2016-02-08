using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateConditionRequest : APIRequest
    {
        public CreateConditionRequest() : base("createCondition") {}

        /// <summary>
        /// ID of the Counter.
        /// </summary>
        public Guid CounterId {
            get { return (Guid) Parameters[nameof(CounterId).ToLower()]; }
            set { Parameters[nameof(CounterId).ToLower()] = value; }
        }

        /// <summary>
        /// Relational Operator to be used with threshold.
        /// </summary>
        public string RelationalOperator {
            get { return (string) Parameters[nameof(RelationalOperator).ToLower()]; }
            set { Parameters[nameof(RelationalOperator).ToLower()] = value; }
        }

        /// <summary>
        /// Threshold value.
        /// </summary>
        public long Threshold {
            get { return (long) Parameters[nameof(Threshold).ToLower()]; }
            set { Parameters[nameof(Threshold).ToLower()] = value; }
        }

        /// <summary>
        /// the account of the condition. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the domain ID of the account.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a condition
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateCondition(CreateConditionRequest request);
        Task<AsyncJobResponse> CreateConditionAsync(CreateConditionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateCondition(CreateConditionRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateConditionAsync(CreateConditionRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
