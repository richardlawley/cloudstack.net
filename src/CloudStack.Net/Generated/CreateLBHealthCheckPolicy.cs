using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLBHealthCheckPolicyRequest : APIRequest
    {
        public CreateLBHealthCheckPolicyRequest() : base("createLBHealthCheckPolicy") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId {
            get { return (Guid) Parameters[nameof(LbRuleId).ToLower()]; }
            set { Parameters[nameof(LbRuleId).ToLower()] = value; }
        }

        /// <summary>
        /// the description of the load balancer health check policy
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
        /// Number of consecutive health check success before declaring an instance healthy
        /// </summary>
        public int? HealthyThreshold {
            get { return (int?) Parameters[nameof(HealthyThreshold).ToLower()]; }
            set { Parameters[nameof(HealthyThreshold).ToLower()] = value; }
        }

        /// <summary>
        /// Amount of time between health checks (1 sec - 20940 sec)
        /// </summary>
        public int? Intervaltime {
            get { return (int?) Parameters[nameof(Intervaltime).ToLower()]; }
            set { Parameters[nameof(Intervaltime).ToLower()] = value; }
        }

        /// <summary>
        /// HTTP ping path
        /// </summary>
        public string PingPath {
            get { return (string) Parameters[nameof(PingPath).ToLower()]; }
            set { Parameters[nameof(PingPath).ToLower()] = value; }
        }

        /// <summary>
        /// Time to wait when receiving a response from the health check (2sec - 60 sec)
        /// </summary>
        public int? Responsetimeout {
            get { return (int?) Parameters[nameof(Responsetimeout).ToLower()]; }
            set { Parameters[nameof(Responsetimeout).ToLower()] = value; }
        }

        /// <summary>
        /// Number of consecutive health check failures before declaring an instance unhealthy
        /// </summary>
        public int? UnhealthyThreshold {
            get { return (int?) Parameters[nameof(UnhealthyThreshold).ToLower()]; }
            set { Parameters[nameof(UnhealthyThreshold).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a load balancer health check policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateLBHealthCheckPolicy(CreateLBHealthCheckPolicyRequest request);
        Task<AsyncJobResponse> CreateLBHealthCheckPolicyAsync(CreateLBHealthCheckPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateLBHealthCheckPolicy(CreateLBHealthCheckPolicyRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateLBHealthCheckPolicyAsync(CreateLBHealthCheckPolicyRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
