using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateServiceOfferingRequest : APIRequest
    {
        public CreateServiceOfferingRequest() : base("createServiceOffering") {}

        /// <summary>
        /// the display text of the service offering
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the name of the service offering
        /// </summary>
        public string ServiceOfferingName { get; set; }

        /// <summary>
        /// bytes read rate of the disk offering
        /// </summary>
        public long? BytesReadRate { get; set; }

        /// <summary>
        /// bytes write rate of the disk offering
        /// </summary>
        public long? BytesWriteRate { get; set; }

        /// <summary>
        /// the CPU number of the service offering
        /// </summary>
        public int? CpuNumber { get; set; }

        /// <summary>
        /// the CPU speed of the service offering in MHz.
        /// </summary>
        public int? CpuSpeed { get; set; }

        /// <summary>
        /// whether compute offering iops is custom or not
        /// </summary>
        public bool? CustomizedIops { get; set; }

        /// <summary>
        /// The deployment planner heuristics used to deploy a VM of this offering. If null, value of global config vm.deployment.planner is used
        /// </summary>
        public string DeploymentPlanner { get; set; }

        /// <summary>
        /// the ID of the containing domain, null for public offerings
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the host tag for this service offering.
        /// </summary>
        public string HostTag { get; set; }

        /// <summary>
        /// Hypervisor snapshot reserve space as a percent of a volume (for managed storage using Xen or VMware)
        /// </summary>
        public int? HypervisorSnapshotReserve { get; set; }

        /// <summary>
        /// io requests read rate of the disk offering
        /// </summary>
        public long? IopsReadRate { get; set; }

        /// <summary>
        /// io requests write rate of the disk offering
        /// </summary>
        public long? IopsWriteRate { get; set; }

        /// <summary>
        /// is this a system vm offering
        /// </summary>
        public bool? IsSystem { get; set; }

        /// <summary>
        /// true if the virtual machine needs to be volatile so that on every reboot of VM, original root disk is dettached then destroyed and a fresh root disk is created and attached to VM
        /// </summary>
        public bool? IsVolatile { get; set; }

        /// <summary>
        /// restrict the CPU usage to committed service offering
        /// </summary>
        public bool? LimitCpuUse { get; set; }

        /// <summary>
        /// max iops of the compute offering
        /// </summary>
        public long? MaxIops { get; set; }

        /// <summary>
        /// the total memory of the service offering in MB
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// min iops of the compute offering
        /// </summary>
        public long? MinIops { get; set; }

        /// <summary>
        /// data transfer rate in megabits per second allowed. Supported only for non-System offering and system offerings having "domainrouter" systemvmtype
        /// </summary>
        public int? NetworkRate { get; set; }

        /// <summary>
        /// the HA for the service offering
        /// </summary>
        public bool? OfferHa { get; set; }

        /// <summary>
        /// provisioning type used to create volumes. Valid values are thin, sparse, fat.
        /// </summary>
        public string ProvisioningType { get; set; }

        /// <summary>
        /// details for planner, used to store specific parameters
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// the storage type of the service offering. Values are local and shared.
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// the system VM type. Possible types are "domainrouter", "consoleproxy" and "secondarystoragevm".
        /// </summary>
        public string SystemVmType { get; set; }

        /// <summary>
        /// the tags for this service offering.
        /// </summary>
        public string Tags { get; set; }

    }
    /// <summary>
    /// Creates a service offering.
    /// </summary>
    /// <summary>
    /// Creates a service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ServiceOfferingResponse CreateServiceOffering(CreateServiceOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ServiceOfferingResponse CreateServiceOffering(CreateServiceOfferingRequest request) => _proxy.Request<ServiceOfferingResponse>(request);
    }
}
