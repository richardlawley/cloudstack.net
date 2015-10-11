using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// Source of the counter.
        /// </summary>
        public string Source {
            get { return (string) Parameters[nameof(Source).ToLower()]; }
            set { Parameters[nameof(Source).ToLower()] = value; }
        }

        /// <summary>
        /// Value of the counter e.g. oid in case of snmp.
        /// </summary>
        public string Value {
            get { return (string) Parameters[nameof(Value).ToLower()]; }
            set { Parameters[nameof(Value).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds metric counter
    /// </summary>
    /// <summary>
    /// Adds metric counter
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CounterResponse CreateCounter(CreateCounterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CounterResponse CreateCounter(CreateCounterRequest request) => _proxy.Request<CounterResponse>(request);
    }
}
