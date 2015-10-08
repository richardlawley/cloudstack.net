using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GenerateAlertRequest : APIRequest
    {
        public GenerateAlertRequest() : base("generateAlert") {}

        /// <summary>
        /// Alert description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of the alert
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the alert
        /// </summary>
        public short Type { get; set; }

        /// <summary>
        /// Pod id for which alert is generated
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// Zone id for which alert is generated
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Generates an alert
    /// </summary>
    /// <summary>
    /// Generates an alert
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse GenerateAlert(GenerateAlertRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse GenerateAlert(GenerateAlertRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
