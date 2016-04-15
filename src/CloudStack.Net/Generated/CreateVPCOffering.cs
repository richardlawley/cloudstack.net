using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVPCOfferingRequest : APIRequest
    {
        public CreateVPCOfferingRequest() : base("createVPCOffering") {}

        /// <summary>
        /// the display text of the vpc offering
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the name of the vpc offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// services supported by the vpc offering
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { SetParameterValue(nameof(SupportedServices).ToLower(), value); }
        }

        /// <summary>
        /// desired service capabilities as part of vpc offering
        /// </summary>
        public IList<IDictionary<string, object>> Servicecapabilitylist {
            get { return GetList<IDictionary<string, object>>(nameof(Servicecapabilitylist).ToLower()); }
            set { SetParameterValue(nameof(Servicecapabilitylist).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the service offering for the VPC router appliance
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// provider to service mapping. If not specified, the provider for the service will be mapped to the default provider on the physical network
        /// </summary>
        public IList<IDictionary<string, object>> ServiceProviderList {
            get { return GetList<IDictionary<string, object>>(nameof(ServiceProviderList).ToLower()); }
            set { SetParameterValue(nameof(ServiceProviderList).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates VPC offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVPCOffering(CreateVPCOfferingRequest request);
        Task<AsyncJobResponse> CreateVPCOfferingAsync(CreateVPCOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVPCOffering(CreateVPCOfferingRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateVPCOfferingAsync(CreateVPCOfferingRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
