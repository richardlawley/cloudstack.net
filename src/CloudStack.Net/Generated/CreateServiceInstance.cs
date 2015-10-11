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
        public Guid LeftNetworkId {
            get { return (Guid) Parameters[nameof(LeftNetworkId).ToLower()]; }
            set { Parameters[nameof(LeftNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// The name of the service instance
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// The right (outside) network ID for the service instance
        /// </summary>
        public Guid RightNetworkId {
            get { return (Guid) Parameters[nameof(RightNetworkId).ToLower()]; }
            set { Parameters[nameof(RightNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// The service offering ID that defines the resources consumed by the service appliance
        /// </summary>
        public Guid ServiceOfferingId {
            get { return (Guid) Parameters[nameof(ServiceOfferingId).ToLower()]; }
            set { Parameters[nameof(ServiceOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// The template ID that specifies the image for the service appliance
        /// </summary>
        public Guid TemplateId {
            get { return (Guid) Parameters[nameof(TemplateId).ToLower()]; }
            set { Parameters[nameof(TemplateId).ToLower()] = value; }
        }

        /// <summary>
        /// Availability zone for the service instance
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// An optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// An optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Project ID for the service instance
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a system virtual-machine that implements network services
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateServiceInstance(CreateServiceInstanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateServiceInstance(CreateServiceInstanceRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
