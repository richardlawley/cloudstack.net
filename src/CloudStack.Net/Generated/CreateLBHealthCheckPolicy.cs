using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateLBHealthCheckPolicyRequest : APIRequest
    {
        public CreateLBHealthCheckPolicyRequest() : base("createLBHealthCheckPolicy") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId { get; set; }

        /// <summary>
        /// the description of the load balancer health check policy
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Number of consecutive health check success before declaring an instance healthy
        /// </summary>
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// Amount of time between health checks (1 sec - 20940 sec)
        /// </summary>
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// HTTP ping path
        /// </summary>
        public string PingPath { get; set; }

        /// <summary>
        /// Time to wait when receiving a response from the health check (2sec - 60 sec)
        /// </summary>
        public int? ResponsTimeOut { get; set; }

        /// <summary>
        /// Number of consecutive health check failures before declaring an instance unhealthy
        /// </summary>
        public int? UnhealthyThreshold { get; set; }

    }
    /// <summary>
    /// Creates a load balancer health check policy
    /// </summary>
    /// <summary>
    /// Creates a load balancer health check policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LBHealthCheckResponse CreateLBHealthCheckPolicy(CreateLBHealthCheckPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LBHealthCheckResponse CreateLBHealthCheckPolicy(CreateLBHealthCheckPolicyRequest request) => _proxy.Request<LBHealthCheckResponse>(request);
    }
}
