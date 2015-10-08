using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVPCOfferingRequest : APIRequest
    {
        public CreateVPCOfferingRequest() : base("createVPCOffering") {}

        /// <summary>
        /// the display text of the vpc offering
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the name of the vpc offering
        /// </summary>
        public string VpcOfferingName { get; set; }

        /// <summary>
        /// services supported by the vpc offering
        /// </summary>
        public IList<string> SupportedServices { get; set; }

        /// <summary>
        /// desired service capabilities as part of vpc offering
        /// </summary>
        public IDictionary<string, IDictionary<String, String>> ServiceCapabilitystList { get; set; }

        /// <summary>
        /// the ID of the service offering for the VPC router appliance
        /// </summary>
        public Guid ServiceOfferingId { get; set; }

        /// <summary>
        /// provider to service mapping. If not specified, the provider for the service will be mapped to the default provider on the physical network
        /// </summary>
        public IDictionary<string, List<String>> ServiceProviderList { get; set; }

    }
    /// <summary>
    /// Creates VPC offering
    /// </summary>
    /// <summary>
    /// Creates VPC offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VpcOfferingResponse CreateVPCOffering(CreateVPCOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VpcOfferingResponse CreateVPCOffering(CreateVPCOfferingRequest request) => _proxy.Request<VpcOfferingResponse>(request);
    }
}
