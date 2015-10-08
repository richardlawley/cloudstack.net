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
        public Guid ServiceOfferingId { get; set; }

        /// <summary>
        /// the ID of the template for the virtual machine
        /// </summary>
        public Guid TemplateId { get; set; }

        /// <summary>
        /// availability zone for the virtual machine
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// an optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// comma separated list of affinity groups id that are going to be applied to the virtual machine. Mutually exclusive with affinitygroupnames parameter
        /// </summary>
        public IList<long> AffinityGroupIdList { get; set; }

        /// <summary>
        /// comma separated list of affinity groups names that are going to be applied to the virtual machine.Mutually exclusive with affinitygroupids parameter
        /// </summary>
        public IList<string> AffinityGroupNameList { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// Deployment planner to use for vm allocation. Available to ROOT admin only
        /// </summary>
        public string DeploymentPlanner { get; set; }

        /// <summary>
        /// used to specify the custom parameters.
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// the ID of the disk offering for the virtual machine. If the template is of ISO format, the diskOfferingId is for the root disk volume. Otherwise this parameter is used to indicate the offering for the data disk volume. If the templateId parameter passed is from a Template object, the diskOfferingId refers to a DATA Disk Volume created. If the templateId parameter passed is from an ISO object, the diskOfferingId refers to a ROOT Disk Volume created.
        /// </summary>
        public Guid DiskOfferingId { get; set; }

        /// <summary>
        /// an optional user generated name for the virtual machine
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// an optional field, whether to the display the vm to the end user or not.
        /// </summary>
        public bool? DisplayVm { get; set; }

        /// <summary>
        /// an optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// an optional group for the virtual machine
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// destination Host ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// the hypervisor on which to deploy the virtual machine. The parameter is required and respected only when hypervisor info is not set on the ISO/Template passed to the call
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the ipv6 address for default vm's network
        /// </summary>
        public string Ip6Address { get; set; }

        /// <summary>
        /// the ip address for default vm's network
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// ip to network mapping. Can't be specified with networkIds parameter. Example: iptonetworklist[0].ip=10.10.10.11&iptonetworklist[0].ipv6=fc00:1234:5678::abcd&iptonetworklist[0].networkid=uuid - requests to use ip 10.10.10.11 in network id=uuid
        /// </summary>
        public IDictionary<string, string> IpToNetworkList { get; set; }

        /// <summary>
        /// an optional keyboard device type for the virtual machine. valid value can be one of de,de-ch,es,fi,fr,fr-be,fr-ch,is,it,jp,nl-be,no,pt,uk,us
        /// </summary>
        public string Keyboard { get; set; }

        /// <summary>
        /// name of the ssh key pair used to login to the virtual machine
        /// </summary>
        public string SshKeyPairName { get; set; }

        /// <summary>
        /// host name for the virtual machine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// list of network ids used by virtual machine. Can't be specified with ipToNetworkList parameter
        /// </summary>
        public IList<long> NetworkIds { get; set; }

        /// <summary>
        /// Deploy vm for the project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Optional field to resize root disk on deploy. Value is in GB. Only applies to template-based deployments. Analogous to details[0].rootdisksize, which takes precedence over this parameter if both are provided
        /// </summary>
        public long? Rootdisksize { get; set; }

        /// <summary>
        /// comma separated list of security groups id that going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupnames parameter
        /// </summary>
        public IList<long> SecurityGroupIdList { get; set; }

        /// <summary>
        /// comma separated list of security groups names that going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupids parameter
        /// </summary>
        public IList<string> SecurityGroupNameList { get; set; }

        /// <summary>
        /// the arbitrary size for the DATADISK volume. Mutually exclusive with diskOfferingId
        /// </summary>
        public long? Size { get; set; }

        /// <summary>
        /// true if network offering supports specifying ip ranges; defaulted to true if not specified
        /// </summary>
        public bool? StartVm { get; set; }

        /// <summary>
        /// an optional binary data that can be sent to the virtual machine upon a successful deployment. This binary data must be base64 encoded before adding it to the request. Using HTTP GET (via querystring), you can send up to 2KB of data after base64 encoding. Using HTTP POST(via POST body), you can send up to 32K of data after base64 encoding.
        /// </summary>
        public string UserData { get; set; }

    }
    /// <summary>
    /// Creates and automatically starts a virtual machine based on a service offering, disk offering, and template.
    /// </summary>
    /// <summary>
    /// Creates and automatically starts a virtual machine based on a service offering, disk offering, and template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse DeployVirtualMachine(DeployVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse DeployVirtualMachine(DeployVirtualMachineRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
