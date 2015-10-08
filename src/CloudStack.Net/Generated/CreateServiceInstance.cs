using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateServiceInstanceRequest : APIRequest
    {
        public CreateServiceInstanceRequest() : base("createServiceInstance") {}

        /// <summary>
        /// The left (inside) network for service instance
        /// </summary>
        public Guid LeftNetworkId { get; set; }

        /// <summary>
        /// The name of the service instance
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The right (outside) network ID for the service instance
        /// </summary>
        public Guid RightNetworkId { get; set; }

        /// <summary>
        /// The service offering ID that defines the resources consumed by the service appliance
        /// </summary>
        public Guid ServiceOfferingId { get; set; }

        /// <summary>
        /// The template ID that specifies the image for the service appliance
        /// </summary>
        public Guid TemplateId { get; set; }

        /// <summary>
        /// Availability zone for the service instance
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// An optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// An optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Project ID for the service instance
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Creates a system virtual-machine that implements network services
    /// </summary>
    /// <summary>
    /// Creates a system virtual-machine that implements network services
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ServiceInstanceResponse CreateServiceInstance(CreateServiceInstanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ServiceInstanceResponse CreateServiceInstance(CreateServiceInstanceRequest request) => _proxy.Request<ServiceInstanceResponse>(request);
    }
}
