using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LBHealthCheckPolicyResponse
    {
        /// <summary>
        /// the LB HealthCheck policy ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the description of the healthcheck policy
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// is policy for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// Amount of time between health checks
        /// </summary>
        public int HealthcheckInterval { get; set; }

        /// <summary>
        /// Number of consecutive health check success before declaring an instance healthy
        /// </summary>
        public int Healthcheckthresshold { get; set; }

        /// <summary>
        /// the pingpath  of the healthcheck policy
        /// </summary>
        public string Pingpath { get; set; }

        /// <summary>
        /// Time to wait when receiving a response from the health check
        /// </summary>
        public int ResponseTime { get; set; }

        /// <summary>
        /// the state of the policy
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Number of consecutive health check failures before declaring an instance unhealthy.
        /// </summary>
        public int Unhealthcheckthresshold { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
