using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateCounterRequest : APIRequest
    {
        public CreateCounterRequest() : base("createCounter") {}

        /// <summary>
        /// Name of the counter.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Source of the counter.
        /// </summary>
        public string Source {
            get { return GetParameterValue<string>(nameof(Source).ToLower()); }
            set { SetParameterValue(nameof(Source).ToLower(), value); }
        }

        /// <summary>
        /// Value of the counter e.g. oid in case of snmp.
        /// </summary>
        public string Value {
            get { return GetParameterValue<string>(nameof(Value).ToLower()); }
            set { SetParameterValue(nameof(Value).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds metric counter
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateCounter(CreateCounterRequest request);
        Task<AsyncJobResponse> CreateCounterAsync(CreateCounterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateCounter(CreateCounterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateCounterAsync(CreateCounterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
