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
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the vpc offering
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// services supported by the vpc offering
        /// </summary>
        public IList<string> SupportedServices {
            get { return (IList<string>) Parameters[nameof(SupportedServices).ToLower()]; }
            set { Parameters[nameof(SupportedServices).ToLower()] = value; }
        }

        /// <summary>
        /// desired service capabilities as part of vpc offering
        /// </summary>
        public IDictionary<string, string> Servicecapabilitylist {
            get { return (IDictionary<string, string>) Parameters[nameof(Servicecapabilitylist).ToLower()]; }
            set { Parameters[nameof(Servicecapabilitylist).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the service offering for the VPC router appliance
        /// </summary>
        public Guid ServiceOfferingId {
            get { return (Guid) Parameters[nameof(ServiceOfferingId).ToLower()]; }
            set { Parameters[nameof(ServiceOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// provider to service mapping. If not specified, the provider for the service will be mapped to the default provider on the physical network
        /// </summary>
        public IDictionary<string, string> ServiceProviderList {
            get { return (IDictionary<string, string>) Parameters[nameof(ServiceProviderList).ToLower()]; }
            set { Parameters[nameof(ServiceProviderList).ToLower()] = value; }
        }

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
