using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(ServiceOfferingId).ToLower()]; }
            set { Parameters[nameof(ServiceOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the template for the virtual machine
        /// </summary>
        public Guid TemplateId {
            get { return (Guid) Parameters[nameof(TemplateId).ToLower()]; }
            set { Parameters[nameof(TemplateId).ToLower()] = value; }
        }

        /// <summary>
        /// availability zone for the virtual machine
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// comma separated list of affinity groups id that are going to be applied to the virtual machine. Mutually exclusive with affinitygroupnames parameter
        /// </summary>
        public IList<Guid> Affinitygroupids {
            get { return GetList<Guid>(nameof(Affinitygroupids).ToLower()); }
            set { Parameters[nameof(Affinitygroupids).ToLower()] = value; }
        }

        /// <summary>
        /// comma separated list of affinity groups names that are going to be applied to the virtual machine.Mutually exclusive with affinitygroupids parameter
        /// </summary>
        public IList<string> Affinitygroupnames {
            get { return GetList<string>(nameof(Affinitygroupnames).ToLower()); }
            set { Parameters[nameof(Affinitygroupnames).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// Deployment planner to use for vm allocation. Available to ROOT admin only
        /// </summary>
        public string DeploymentPlanner {
            get { return (string) Parameters[nameof(DeploymentPlanner).ToLower()]; }
            set { Parameters[nameof(DeploymentPlanner).ToLower()] = value; }
        }

        /// <summary>
        /// used to specify the custom parameters.
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the disk offering for the virtual machine. If the template is of ISO format, the diskOfferingId is for the root disk volume. Otherwise this parameter is used to indicate the offering for the data disk volume. If the templateId parameter passed is from a Template object, the diskOfferingId refers to a DATA Disk Volume created. If the templateId parameter passed is from an ISO object, the diskOfferingId refers to a ROOT Disk Volume created.
        /// </summary>
        public Guid DiskOfferingId {
            get { return (Guid) Parameters[nameof(DiskOfferingId).ToLower()]; }
            set { Parameters[nameof(DiskOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional user generated name for the virtual machine
        /// </summary>
        public string DisplayName {
            get { return (string) Parameters[nameof(DisplayName).ToLower()]; }
            set { Parameters[nameof(DisplayName).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the vm to the end user or not.
        /// </summary>
        public bool? DisplayVm {
            get { return (bool?) Parameters[nameof(DisplayVm).ToLower()]; }
            set { Parameters[nameof(DisplayVm).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional group for the virtual machine
        /// </summary>
        public string Group {
            get { return (string) Parameters[nameof(Group).ToLower()]; }
            set { Parameters[nameof(Group).ToLower()] = value; }
        }

        /// <summary>
        /// destination Host ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

        /// <summary>
        /// the hypervisor on which to deploy the virtual machine. The parameter is required and respected only when hypervisor info is not set on the ISO/Template passed to the call
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// the ipv6 address for default vm's network
        /// </summary>
        public string Ip6Address {
            get { return (string) Parameters[nameof(Ip6Address).ToLower()]; }
            set { Parameters[nameof(Ip6Address).ToLower()] = value; }
        }

        /// <summary>
        /// the ip address for default vm's network
        /// </summary>
        public string IpAddress {
            get { return (string) Parameters[nameof(IpAddress).ToLower()]; }
            set { Parameters[nameof(IpAddress).ToLower()] = value; }
        }

        /// <summary>
        /// ip to network mapping. Can't be specified with networkIds parameter. Example: iptonetworklist[0].ip=10.10.10.11&iptonetworklist[0].ipv6=fc00:1234:5678::abcd&iptonetworklist[0].networkid=uuid - requests to use ip 10.10.10.11 in network id=uuid
        /// </summary>
        public IList<IDictionary<string, object>> IpToNetworkList {
            get { return GetList<IDictionary<string, object>>(nameof(IpToNetworkList).ToLower()); }
            set { Parameters[nameof(IpToNetworkList).ToLower()] = value; }
        }

        /// <summary>
        /// an optional keyboard device type for the virtual machine. valid value can be one of de,de-ch,es,fi,fr,fr-be,fr-ch,is,it,jp,nl-be,no,pt,uk,us
        /// </summary>
        public string Keyboard {
            get { return (string) Parameters[nameof(Keyboard).ToLower()]; }
            set { Parameters[nameof(Keyboard).ToLower()] = value; }
        }

        /// <summary>
        /// name of the ssh key pair used to login to the virtual machine
        /// </summary>
        public string Keypair {
            get { return (string) Parameters[nameof(Keypair).ToLower()]; }
            set { Parameters[nameof(Keypair).ToLower()] = value; }
        }

        /// <summary>
        /// host name for the virtual machine
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// list of network ids used by virtual machine. Can't be specified with ipToNetworkList parameter
        /// </summary>
        public IList<Guid> NetworkIds {
            get { return GetList<Guid>(nameof(NetworkIds).ToLower()); }
            set { Parameters[nameof(NetworkIds).ToLower()] = value; }
        }

        /// <summary>
        /// Deploy vm for the project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// Optional field to resize root disk on deploy. Value is in GB. Only applies to template-based deployments. Analogous to details[0].rootdisksize, which takes precedence over this parameter if both are provided
        /// </summary>
        public long? Rootdisksize {
            get { return (long?) Parameters[nameof(Rootdisksize).ToLower()]; }
            set { Parameters[nameof(Rootdisksize).ToLower()] = value; }
        }

        /// <summary>
        /// comma separated list of security groups id that going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupnames parameter
        /// </summary>
        public IList<Guid> Securitygroupids {
            get { return GetList<Guid>(nameof(Securitygroupids).ToLower()); }
            set { Parameters[nameof(Securitygroupids).ToLower()] = value; }
        }

        /// <summary>
        /// comma separated list of security groups names that going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupids parameter
        /// </summary>
        public IList<string> Securitygroupnames {
            get { return GetList<string>(nameof(Securitygroupnames).ToLower()); }
            set { Parameters[nameof(Securitygroupnames).ToLower()] = value; }
        }

        /// <summary>
        /// the arbitrary size for the DATADISK volume. Mutually exclusive with diskOfferingId
        /// </summary>
        public long? Size {
            get { return (long?) Parameters[nameof(Size).ToLower()]; }
            set { Parameters[nameof(Size).ToLower()] = value; }
        }

        /// <summary>
        /// true if start vm after creating; defaulted to true if not specified
        /// </summary>
        public bool? StartVm {
            get { return (bool?) Parameters[nameof(StartVm).ToLower()]; }
            set { Parameters[nameof(StartVm).ToLower()] = value; }
        }

        /// <summary>
        /// an optional binary data that can be sent to the virtual machine upon a successful deployment. This binary data must be base64 encoded before adding it to the request. Using HTTP GET (via querystring), you can send up to 2KB of data after base64 encoding. Using HTTP POST(via POST body), you can send up to 32K of data after base64 encoding.
        /// </summary>
        public string UserData {
            get { return (string) Parameters[nameof(UserData).ToLower()]; }
            set { Parameters[nameof(UserData).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates and automatically starts a virtual machine based on a service offering, disk offering, and template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeployVirtualMachine(DeployVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeployVirtualMachine(DeployVirtualMachineRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
