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
            get { return GetParameterValue<Guid>(nameof(LbRuleId).ToLower()); }
            set { SetParameterValue(nameof(LbRuleId).ToLower(), value); }
        }

        /// <summary>
        /// the description of the load balancer health check policy
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
        /// Number of consecutive health check success before declaring an instance healthy
        /// </summary>
        public int? HealthyThreshold {
            get { return GetParameterValue<int?>(nameof(HealthyThreshold).ToLower()); }
            set { SetParameterValue(nameof(HealthyThreshold).ToLower(), value); }
        }

        /// <summary>
        /// Amount of time between health checks (1 sec - 20940 sec)
        /// </summary>
        public int? Intervaltime {
            get { return GetParameterValue<int?>(nameof(Intervaltime).ToLower()); }
            set { SetParameterValue(nameof(Intervaltime).ToLower(), value); }
        }

        /// <summary>
        /// HTTP ping path
        /// </summary>
        public string PingPath {
            get { return GetParameterValue<string>(nameof(PingPath).ToLower()); }
            set { SetParameterValue(nameof(PingPath).ToLower(), value); }
        }

        /// <summary>
        /// Time to wait when receiving a response from the health check (2sec - 60 sec)
        /// </summary>
        public int? Responsetimeout {
            get { return GetParameterValue<int?>(nameof(Responsetimeout).ToLower()); }
            set { SetParameterValue(nameof(Responsetimeout).ToLower(), value); }
        }

        /// <summary>
        /// Number of consecutive health check failures before declaring an instance unhealthy
        /// </summary>
        public int? UnhealthyThreshold {
            get { return GetParameterValue<int?>(nameof(UnhealthyThreshold).ToLower()); }
            set { SetParameterValue(nameof(UnhealthyThreshold).ToLower(), value); }
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
        public AsyncJobResponse CreateLBHealthCheckPolicy(CreateLBHealthCheckPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateLBHealthCheckPolicyAsync(CreateLBHealthCheckPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
