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
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// Name of the alert
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// Type of the alert
        /// </summary>
        public short Type {
            get { return (short) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

        /// <summary>
        /// Pod id for which alert is generated
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// Zone id for which alert is generated
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Generates an alert
    /// </summary>
    /// <summary>
    /// Generates an alert
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse GenerateAlert(GenerateAlertRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse GenerateAlert(GenerateAlertRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
