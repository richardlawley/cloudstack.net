using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddTrafficMonitorRequest : APIRequest
    {
        public AddTrafficMonitorRequest() : base("addTrafficMonitor") {}

        /// <summary>
        /// URL of the traffic monitor Host
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Zone in which to add the external firewall appliance.
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// Traffic going into the listed zones will not be metered
        /// </summary>
        public string ExclZones { get; set; }

        /// <summary>
        /// Traffic going into the listed zones will be metered
        /// </summary>
        public string InclZones { get; set; }

    }
    /// <summary>
    /// Adds Traffic Monitor Host for Direct Network Usage
    /// </summary>
    /// <summary>
    /// Adds Traffic Monitor Host for Direct Network Usage
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TrafficMonitorResponse AddTrafficMonitor(AddTrafficMonitorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TrafficMonitorResponse AddTrafficMonitor(AddTrafficMonitorRequest request) => _proxy.Request<TrafficMonitorResponse>(request);
    }
}
