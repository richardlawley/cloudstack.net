using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddStratosphereSspRequest : APIRequest
    {
        public AddStratosphereSspRequest() : base("addStratosphereSsp") {}

        /// <summary>
        /// stratosphere ssp api name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// stratosphere ssp server url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the zone ID
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// stratosphere ssp api password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// stratosphere ssp tenant uuid
        /// </summary>
        public string TenantUuid { get; set; }

        /// <summary>
        /// stratosphere ssp api username
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds stratosphere ssp server
    /// </summary>
    /// <summary>
    /// Adds stratosphere ssp server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SspResponse AddStratosphereSsp(AddStratosphereSspRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SspResponse AddStratosphereSsp(AddStratosphereSspRequest request) => _proxy.Request<SspResponse>(request);
    }
}
