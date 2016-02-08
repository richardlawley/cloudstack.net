using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddTrafficMonitorRequest : APIRequest
    {
        public AddTrafficMonitorRequest() : base("addTrafficMonitor") {}

        /// <summary>
        /// URL of the traffic monitor Host
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Zone in which to add the external firewall appliance.
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// Traffic going into the listed zones will not be metered
        /// </summary>
        public string Excludezones {
            get { return (string) Parameters[nameof(Excludezones).ToLower()]; }
            set { Parameters[nameof(Excludezones).ToLower()] = value; }
        }

        /// <summary>
        /// Traffic going into the listed zones will be metered
        /// </summary>
        public string Includezones {
            get { return (string) Parameters[nameof(Includezones).ToLower()]; }
            set { Parameters[nameof(Includezones).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds Traffic Monitor Host for Direct Network Usage
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TrafficMonitorResponse AddTrafficMonitor(AddTrafficMonitorRequest request);
        Task<TrafficMonitorResponse> AddTrafficMonitorAsync(AddTrafficMonitorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TrafficMonitorResponse AddTrafficMonitor(AddTrafficMonitorRequest request) => _proxy.Request<TrafficMonitorResponse>(request);
        public Task<TrafficMonitorResponse> AddTrafficMonitorAsync(AddTrafficMonitorRequest request) => _proxy.RequestAsync<TrafficMonitorResponse>(request);
    }
}
