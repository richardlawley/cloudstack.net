using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// Name of the alert
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Type of the alert
        /// </summary>
        public short Type {
            get { return GetParameterValue<short>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// Pod id for which alert is generated
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// Zone id for which alert is generated
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Generates an alert
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse GenerateAlert(GenerateAlertRequest request);
        Task<AsyncJobResponse> GenerateAlertAsync(GenerateAlertRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse GenerateAlert(GenerateAlertRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> GenerateAlertAsync(GenerateAlertRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
