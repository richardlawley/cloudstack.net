using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateServiceOfferingRequest : APIRequest
    {
        public CreateServiceOfferingRequest() : base("createServiceOffering") {}

        /// <summary>
        /// the display text of the service offering
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the service offering
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// bytes read rate of the disk offering
        /// </summary>
        public long? BytesReadRate {
            get { return (long?) Parameters[nameof(BytesReadRate).ToLower()]; }
            set { Parameters[nameof(BytesReadRate).ToLower()] = value; }
        }

        /// <summary>
        /// bytes write rate of the disk offering
        /// </summary>
        public long? BytesWriteRate {
            get { return (long?) Parameters[nameof(BytesWriteRate).ToLower()]; }
            set { Parameters[nameof(BytesWriteRate).ToLower()] = value; }
        }

        /// <summary>
        /// the CPU number of the service offering
        /// </summary>
        public int? CpuNumber {
            get { return (int?) Parameters[nameof(CpuNumber).ToLower()]; }
            set { Parameters[nameof(CpuNumber).ToLower()] = value; }
        }

        /// <summary>
        /// the CPU speed of the service offering in MHz.
        /// </summary>
        public int? CpuSpeed {
            get { return (int?) Parameters[nameof(CpuSpeed).ToLower()]; }
            set { Parameters[nameof(CpuSpeed).ToLower()] = value; }
        }

        /// <summary>
        /// whether compute offering iops is custom or not
        /// </summary>
        public bool? CustomizedIops {
            get { return (bool?) Parameters[nameof(CustomizedIops).ToLower()]; }
            set { Parameters[nameof(CustomizedIops).ToLower()] = value; }
        }

        /// <summary>
        /// The deployment planner heuristics used to deploy a VM of this offering. If null, value of global config vm.deployment.planner is used
        /// </summary>
        public string DeploymentPlanner {
            get { return (string) Parameters[nameof(DeploymentPlanner).ToLower()]; }
            set { Parameters[nameof(DeploymentPlanner).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the containing domain, null for public offerings
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the host tag for this service offering.
        /// </summary>
        public string Hosttags {
            get { return (string) Parameters[nameof(Hosttags).ToLower()]; }
            set { Parameters[nameof(Hosttags).ToLower()] = value; }
        }

        /// <summary>
        /// Hypervisor snapshot reserve space as a percent of a volume (for managed storage using Xen or VMware)
        /// </summary>
        public int? HypervisorSnapshotReserve {
            get { return (int?) Parameters[nameof(HypervisorSnapshotReserve).ToLower()]; }
            set { Parameters[nameof(HypervisorSnapshotReserve).ToLower()] = value; }
        }

        /// <summary>
        /// io requests read rate of the disk offering
        /// </summary>
        public long? IopsReadRate {
            get { return (long?) Parameters[nameof(IopsReadRate).ToLower()]; }
            set { Parameters[nameof(IopsReadRate).ToLower()] = value; }
        }

        /// <summary>
        /// io requests write rate of the disk offering
        /// </summary>
        public long? IopsWriteRate {
            get { return (long?) Parameters[nameof(IopsWriteRate).ToLower()]; }
            set { Parameters[nameof(IopsWriteRate).ToLower()] = value; }
        }

        /// <summary>
        /// is this a system vm offering
        /// </summary>
        public bool? IsSystem {
            get { return (bool?) Parameters[nameof(IsSystem).ToLower()]; }
            set { Parameters[nameof(IsSystem).ToLower()] = value; }
        }

        /// <summary>
        /// true if the virtual machine needs to be volatile so that on every reboot of VM, original root disk is dettached then destroyed and a fresh root disk is created and attached to VM
        /// </summary>
        public bool? IsVolatile {
            get { return (bool?) Parameters[nameof(IsVolatile).ToLower()]; }
            set { Parameters[nameof(IsVolatile).ToLower()] = value; }
        }

        /// <summary>
        /// restrict the CPU usage to committed service offering
        /// </summary>
        public bool? LimitCpuUse {
            get { return (bool?) Parameters[nameof(LimitCpuUse).ToLower()]; }
            set { Parameters[nameof(LimitCpuUse).ToLower()] = value; }
        }

        /// <summary>
        /// max iops of the compute offering
        /// </summary>
        public long? MaxIops {
            get { return (long?) Parameters[nameof(MaxIops).ToLower()]; }
            set { Parameters[nameof(MaxIops).ToLower()] = value; }
        }

        /// <summary>
        /// the total memory of the service offering in MB
        /// </summary>
        public int? Memory {
            get { return (int?) Parameters[nameof(Memory).ToLower()]; }
            set { Parameters[nameof(Memory).ToLower()] = value; }
        }

        /// <summary>
        /// min iops of the compute offering
        /// </summary>
        public long? MinIops {
            get { return (long?) Parameters[nameof(MinIops).ToLower()]; }
            set { Parameters[nameof(MinIops).ToLower()] = value; }
        }

        /// <summary>
        /// data transfer rate in megabits per second allowed. Supported only for non-System offering and system offerings having "domainrouter" systemvmtype
        /// </summary>
        public int? NetworkRate {
            get { return (int?) Parameters[nameof(NetworkRate).ToLower()]; }
            set { Parameters[nameof(NetworkRate).ToLower()] = value; }
        }

        /// <summary>
        /// the HA for the service offering
        /// </summary>
        public bool? OfferHa {
            get { return (bool?) Parameters[nameof(OfferHa).ToLower()]; }
            set { Parameters[nameof(OfferHa).ToLower()] = value; }
        }

        /// <summary>
        /// provisioning type used to create volumes. Valid values are thin, sparse, fat.
        /// </summary>
        public string ProvisioningType {
            get { return (string) Parameters[nameof(ProvisioningType).ToLower()]; }
            set { Parameters[nameof(ProvisioningType).ToLower()] = value; }
        }

        /// <summary>
        /// details for planner, used to store specific parameters
        /// </summary>
        public IList<IDictionary<string, object>> Serviceofferingdetails {
            get { return GetList<IDictionary<string, object>>(nameof(Serviceofferingdetails).ToLower()); }
            set { Parameters[nameof(Serviceofferingdetails).ToLower()] = value; }
        }

        /// <summary>
        /// the storage type of the service offering. Values are local and shared.
        /// </summary>
        public string StorageType {
            get { return (string) Parameters[nameof(StorageType).ToLower()]; }
            set { Parameters[nameof(StorageType).ToLower()] = value; }
        }

        /// <summary>
        /// the system VM type. Possible types are "domainrouter", "consoleproxy" and "secondarystoragevm".
        /// </summary>
        public string SystemVmType {
            get { return (string) Parameters[nameof(SystemVmType).ToLower()]; }
            set { Parameters[nameof(SystemVmType).ToLower()] = value; }
        }

        /// <summary>
        /// the tags for this service offering.
        /// </summary>
        public string Tags {
            get { return (string) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ServiceOfferingResponse CreateServiceOffering(CreateServiceOfferingRequest request);
        Task<ServiceOfferingResponse> CreateServiceOfferingAsync(CreateServiceOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ServiceOfferingResponse CreateServiceOffering(CreateServiceOfferingRequest request) => _proxy.Request<ServiceOfferingResponse>(request);
        public Task<ServiceOfferingResponse> CreateServiceOfferingAsync(CreateServiceOfferingRequest request) => _proxy.RequestAsync<ServiceOfferingResponse>(request);
    }
}
