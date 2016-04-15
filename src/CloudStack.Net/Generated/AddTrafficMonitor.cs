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
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Zone in which to add the external firewall appliance.
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// Traffic going into the listed zones will not be metered
        /// </summary>
        public string Excludezones {
            get { return GetParameterValue<string>(nameof(Excludezones).ToLower()); }
            set { SetParameterValue(nameof(Excludezones).ToLower(), value); }
        }

        /// <summary>
        /// Traffic going into the listed zones will be metered
        /// </summary>
        public string Includezones {
            get { return GetParameterValue<string>(nameof(Includezones).ToLower()); }
            set { SetParameterValue(nameof(Includezones).ToLower(), value); }
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
