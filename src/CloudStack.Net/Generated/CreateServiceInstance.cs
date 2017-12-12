using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(LeftNetworkId).ToLower()); }
            set { SetParameterValue(nameof(LeftNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// The name of the service instance
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// The right (outside) network ID for the service instance
        /// </summary>
        public Guid RightNetworkId {
            get { return GetParameterValue<Guid>(nameof(RightNetworkId).ToLower()); }
            set { SetParameterValue(nameof(RightNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// The service offering ID that defines the resources consumed by the service appliance
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// The template ID that specifies the image for the service appliance
        /// </summary>
        public Guid TemplateId {
            get { return GetParameterValue<Guid>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// Availability zone for the service instance
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// An optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// An optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Project ID for the service instance
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a system virtual-machine that implements network services
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateServiceInstance(CreateServiceInstanceRequest request);
        Task<AsyncJobResponse> CreateServiceInstanceAsync(CreateServiceInstanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateServiceInstance(CreateServiceInstanceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateServiceInstanceAsync(CreateServiceInstanceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
