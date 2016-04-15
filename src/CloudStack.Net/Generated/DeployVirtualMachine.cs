using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeployVirtualMachineRequest : APIRequest
    {
        public DeployVirtualMachineRequest() : base("deployVirtualMachine") {}

        /// <summary>
        /// the ID of the service offering for the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the template for the virtual machine
        /// </summary>
        public Guid TemplateId {
            get { return GetParameterValue<Guid>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// availability zone for the virtual machine
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of affinity groups id that are going to be applied to the virtual machine. Mutually exclusive with affinitygroupnames parameter
        /// </summary>
        public IList<Guid> Affinitygroupids {
            get { return GetList<Guid>(nameof(Affinitygroupids).ToLower()); }
            set { SetParameterValue(nameof(Affinitygroupids).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of affinity groups names that are going to be applied to the virtual machine.Mutually exclusive with affinitygroupids parameter
        /// </summary>
        public IList<string> Affinitygroupnames {
            get { return GetList<string>(nameof(Affinitygroupnames).ToLower()); }
            set { SetParameterValue(nameof(Affinitygroupnames).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// Deployment planner to use for vm allocation. Available to ROOT admin only
        /// </summary>
        public string DeploymentPlanner {
            get { return GetParameterValue<string>(nameof(DeploymentPlanner).ToLower()); }
            set { SetParameterValue(nameof(DeploymentPlanner).ToLower(), value); }
        }

        /// <summary>
        /// used to specify the custom parameters.
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk offering for the virtual machine. If the template is of ISO format, the diskOfferingId is for the root disk volume. Otherwise this parameter is used to indicate the offering for the data disk volume. If the templateId parameter passed is from a Template object, the diskOfferingId refers to a DATA Disk Volume created. If the templateId parameter passed is from an ISO object, the diskOfferingId refers to a ROOT Disk Volume created.
        /// </summary>
        public Guid DiskOfferingId {
            get { return GetParameterValue<Guid>(nameof(DiskOfferingId).ToLower()); }
            set { SetParameterValue(nameof(DiskOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// an optional user generated name for the virtual machine
        /// </summary>
        public string DisplayName {
            get { return GetParameterValue<string>(nameof(DisplayName).ToLower()); }
            set { SetParameterValue(nameof(DisplayName).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the vm to the end user or not.
        /// </summary>
        public bool? DisplayVm {
            get { return GetParameterValue<bool?>(nameof(DisplayVm).ToLower()); }
            set { SetParameterValue(nameof(DisplayVm).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional group for the virtual machine
        /// </summary>
        public string Group {
            get { return GetParameterValue<string>(nameof(Group).ToLower()); }
            set { SetParameterValue(nameof(Group).ToLower(), value); }
        }

        /// <summary>
        /// destination Host ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the hypervisor on which to deploy the virtual machine. The parameter is required and respected only when hypervisor info is not set on the ISO/Template passed to the call
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// the ipv6 address for default vm's network
        /// </summary>
        public string Ip6Address {
            get { return GetParameterValue<string>(nameof(Ip6Address).ToLower()); }
            set { SetParameterValue(nameof(Ip6Address).ToLower(), value); }
        }

        /// <summary>
        /// the ip address for default vm's network
        /// </summary>
        public string IpAddress {
            get { return GetParameterValue<string>(nameof(IpAddress).ToLower()); }
            set { SetParameterValue(nameof(IpAddress).ToLower(), value); }
        }

        /// <summary>
        /// ip to network mapping. Can't be specified with networkIds parameter. Example: iptonetworklist[0].ip=10.10.10.11&iptonetworklist[0].ipv6=fc00:1234:5678::abcd&iptonetworklist[0].networkid=uuid - requests to use ip 10.10.10.11 in network id=uuid
        /// </summary>
        public IList<IDictionary<string, object>> IpToNetworkList {
            get { return GetList<IDictionary<string, object>>(nameof(IpToNetworkList).ToLower()); }
            set { SetParameterValue(nameof(IpToNetworkList).ToLower(), value); }
        }

        /// <summary>
        /// an optional keyboard device type for the virtual machine. valid value can be one of de,de-ch,es,fi,fr,fr-be,fr-ch,is,it,jp,nl-be,no,pt,uk,us
        /// </summary>
        public string Keyboard {
            get { return GetParameterValue<string>(nameof(Keyboard).ToLower()); }
            set { SetParameterValue(nameof(Keyboard).ToLower(), value); }
        }

        /// <summary>
        /// name of the ssh key pair used to login to the virtual machine
        /// </summary>
        public string Keypair {
            get { return GetParameterValue<string>(nameof(Keypair).ToLower()); }
            set { SetParameterValue(nameof(Keypair).ToLower(), value); }
        }

        /// <summary>
        /// host name for the virtual machine
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list of network ids used by virtual machine. Can't be specified with ipToNetworkList parameter
        /// </summary>
        public IList<Guid> NetworkIds {
            get { return GetList<Guid>(nameof(NetworkIds).ToLower()); }
            set { SetParameterValue(nameof(NetworkIds).ToLower(), value); }
        }

        /// <summary>
        /// Deploy vm for the project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// Optional field to resize root disk on deploy. Value is in GB. Only applies to template-based deployments. Analogous to details[0].rootdisksize, which takes precedence over this parameter if both are provided
        /// </summary>
        public long? Rootdisksize {
            get { return GetParameterValue<long?>(nameof(Rootdisksize).ToLower()); }
            set { SetParameterValue(nameof(Rootdisksize).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of security groups id that going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupnames parameter
        /// </summary>
        public IList<Guid> Securitygroupids {
            get { return GetList<Guid>(nameof(Securitygroupids).ToLower()); }
            set { SetParameterValue(nameof(Securitygroupids).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of security groups names that going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupids parameter
        /// </summary>
        public IList<string> Securitygroupnames {
            get { return GetList<string>(nameof(Securitygroupnames).ToLower()); }
            set { SetParameterValue(nameof(Securitygroupnames).ToLower(), value); }
        }

        /// <summary>
        /// the arbitrary size for the DATADISK volume. Mutually exclusive with diskOfferingId
        /// </summary>
        public long? Size {
            get { return GetParameterValue<long?>(nameof(Size).ToLower()); }
            set { SetParameterValue(nameof(Size).ToLower(), value); }
        }

        /// <summary>
        /// true if start vm after creating; defaulted to true if not specified
        /// </summary>
        public bool? StartVm {
            get { return GetParameterValue<bool?>(nameof(StartVm).ToLower()); }
            set { SetParameterValue(nameof(StartVm).ToLower(), value); }
        }

        /// <summary>
        /// an optional binary data that can be sent to the virtual machine upon a successful deployment. This binary data must be base64 encoded before adding it to the request. Using HTTP GET (via querystring), you can send up to 2KB of data after base64 encoding. Using HTTP POST(via POST body), you can send up to 32K of data after base64 encoding.
        /// </summary>
        public string UserData {
            get { return GetParameterValue<string>(nameof(UserData).ToLower()); }
            set { SetParameterValue(nameof(UserData).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates and automatically starts a virtual machine based on a service offering, disk offering, and template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeployVirtualMachine(DeployVirtualMachineRequest request);
        Task<AsyncJobResponse> DeployVirtualMachineAsync(DeployVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeployVirtualMachine(DeployVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeployVirtualMachineAsync(DeployVirtualMachineRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
