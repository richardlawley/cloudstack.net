using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UserVmResponse
    {
        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the virtual machine
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the number of cpu this virtual machine is running with
        /// </summary>
        public int CpuNumber { get; set; }

        /// <summary>
        /// the speed of each cpu
        /// </summary>
        public int CpuSpeed { get; set; }

        /// <summary>
        /// the amount of the vm's CPU currently used
        /// </summary>
        public string CpuUsed { get; set; }

        /// <summary>
        /// the date when this virtual machine was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Vm details in key/value pairs.
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// the read (io) of disk on the vm
        /// </summary>
        public long DiskIORead { get; set; }

        /// <summary>
        /// the write (io) of disk on the vm
        /// </summary>
        public long DiskIOWrite { get; set; }

        /// <summary>
        /// the read (bytes) of disk on the vm
        /// </summary>
        public long DiskKbsRead { get; set; }

        /// <summary>
        /// the write (bytes) of disk on the vm
        /// </summary>
        public long DiskKbsWrite { get; set; }

        /// <summary>
        /// the ID of the disk offering of the virtual machine
        /// </summary>
        public string DiskOfferingId { get; set; }

        /// <summary>
        /// the name of the disk offering of the virtual machine
        /// </summary>
        public string DiskOfferingName { get; set; }

        /// <summary>
        /// user generated name. The name of the virtual machine is returned if no displayname exists.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// an optional field whether to the display the vm to the end user or not.
        /// </summary>
        public bool DisplayVm { get; set; }

        /// <summary>
        /// the name of the domain in which the virtual machine exists
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain in which the virtual machine exists
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the virtual network for the service offering
        /// </summary>
        public bool ForVirtualNetwork { get; set; }

        /// <summary>
        /// the group name of the virtual machine
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// the group ID of the virtual machine
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Os type ID of the virtual machine
        /// </summary>
        public string GuestOsId { get; set; }

        /// <summary>
        /// true if high-availability is enabled, false otherwise
        /// </summary>
        public bool HaEnable { get; set; }

        /// <summary>
        /// the ID of the host for the virtual machine
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// the name of the host for the virtual machine
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the hypervisor on which the template runs
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// instance name of the user vm; this parameter is returned to the ROOT admin only
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// true if vm contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory.
        /// </summary>
        public bool IsDynamicallyScalable { get; set; }

        /// <summary>
        /// an alternate display text of the ISO attached to the virtual machine
        /// </summary>
        public string IsoDisplayText { get; set; }

        /// <summary>
        /// the ID of the ISO attached to the virtual machine
        /// </summary>
        public string IsoId { get; set; }

        /// <summary>
        /// the name of the ISO attached to the virtual machine
        /// </summary>
        public string IsoName { get; set; }

        /// <summary>
        /// ssh key-pair
        /// </summary>
        public string Keypair { get; set; }

        /// <summary>
        /// the memory allocated for the virtual machine
        /// </summary>
        public int Memory { get; set; }

        /// <summary>
        /// the name of the virtual machine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the incoming network traffic on the vm
        /// </summary>
        public long NetworkKbsRead { get; set; }

        /// <summary>
        /// the outgoing network traffic on the host
        /// </summary>
        public long NetworkKbsWrite { get; set; }

        /// <summary>
        /// OS type id of the vm
        /// </summary>
        public long OsTypeId { get; set; }

        /// <summary>
        /// the password (if exists) of the virtual machine
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// true if the password rest feature is enabled, false otherwise
        /// </summary>
        public bool PasswordEnabled { get; set; }

        /// <summary>
        /// the project name of the vm
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the vm
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// public IP address id associated with vm via Static nat rule
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// public IP address id associated with vm via Static nat rule
        /// </summary>
        public string PublicIpId { get; set; }

        /// <summary>
        /// device ID of the root volume
        /// </summary>
        public long RootDeviceId { get; set; }

        /// <summary>
        /// device type of the root volume
        /// </summary>
        public string RootDeviceType { get; set; }

        /// <summary>
        /// the ID of the service offering of the virtual machine
        /// </summary>
        public string ServiceOfferingId { get; set; }

        /// <summary>
        /// the name of the service offering of the virtual machine
        /// </summary>
        public string ServiceOfferingName { get; set; }

        /// <summary>
        /// State of the Service from LB rule
        /// </summary>
        public string ServiceState { get; set; }

        /// <summary>
        /// the state of the virtual machine
        /// </summary>
        public string State { get; set; }

        /// <summary>
        ///  an alternate display text of the template for the virtual machine
        /// </summary>
        public string TemplateDisplayText { get; set; }

        /// <summary>
        /// the ID of the template for the virtual machine. A -1 is returned if the virtual machine was created from an ISO file.
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// the name of the template for the virtual machine
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// the vgpu type used by the virtual machine
        /// </summary>
        public string Vgpu { get; set; }

        /// <summary>
        /// the ID of the availablility zone for the virtual machine
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the name of the availability zone for the virtual machine
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// list of affinity groups associated with the virtual machine
        /// </summary>
        public IList<AffinityGroupResponse> Affinitygroup { get; set; }

        /// <summary>
        /// the list of nics associated with vm
        /// </summary>
        public IList<NicResponse> Nic { get; set; }

        /// <summary>
        /// list of security groups associated with the virtual machine
        /// </summary>
        public IList<SecurityGroupResponse> Securitygroup { get; set; }

        /// <summary>
        /// the list of resource tags associated with vm
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
