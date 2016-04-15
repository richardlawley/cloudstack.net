using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MarkDefaultZoneForAccountRequest : APIRequest
    {
        public MarkDefaultZoneForAccountRequest() : base("markDefaultZoneForAccount") {}

        /// <summary>
        /// Name of the account that is to be marked.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Marks the account that belongs to the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// The Zone ID with which the account is to be marked.
        /// </summary>
        public Guid Zoneid {
            get { return GetParameterValue<Guid>(nameof(Zoneid).ToLower()); }
            set { SetParameterValue(nameof(Zoneid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Marks a default zone for this account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MarkDefaultZoneForAccount(MarkDefaultZoneForAccountRequest request);
        Task<AsyncJobResponse> MarkDefaultZoneForAccountAsync(MarkDefaultZoneForAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MarkDefaultZoneForAccount(MarkDefaultZoneForAccountRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MarkDefaultZoneForAccountAsync(MarkDefaultZoneForAccountRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
