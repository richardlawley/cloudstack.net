using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureSimulatorRequest : APIRequest
    {
        public ConfigureSimulatorRequest() : base("configureSimulator") {}

        /// <summary>
        /// which command needs to be configured
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// configuration options for this command, which is seperated by ;
        /// </summary>
        public string Value {
            get { return (string) Parameters[nameof(Value).ToLower()]; }
            set { Parameters[nameof(Value).ToLower()] = value; }
        }

        /// <summary>
        /// configure range: in a cluster
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// number of times the mock is active
        /// </summary>
        public int? Count {
            get { return (int?) Parameters[nameof(Count).ToLower()]; }
            set { Parameters[nameof(Count).ToLower()] = value; }
        }

        /// <summary>
        /// configure range: in a host
        /// </summary>
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

        /// <summary>
        /// agent command response to be returned
        /// </summary>
        public string JsonResponse {
            get { return (string) Parameters[nameof(JsonResponse).ToLower()]; }
            set { Parameters[nameof(JsonResponse).ToLower()] = value; }
        }

        /// <summary>
        /// configure range: in a pod
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// configure range: in a zone
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// configure simulator
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        MockResponse ConfigureSimulator(ConfigureSimulatorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public MockResponse ConfigureSimulator(ConfigureSimulatorRequest request) => _proxy.Request<MockResponse>(request);
    }
}
