using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IPAddressResponse
    {
        /// <summary>
        /// public IP address id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account the public IP address is associated with
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// date the public IP address was acquired
        /// </summary>
        public DateTime Allocated { get; set; }

        /// <summary>
        /// the ID of the Network associated with the IP address
        /// </summary>
        public string AssociatedNetworkId { get; set; }

        /// <summary>
        /// the name of the Network associated with the IP address
        /// </summary>
        public string AssociatedNetworkName { get; set; }

        /// <summary>
        /// the domain the public IP address is associated with
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID the public IP address is associated with
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// is public ip for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the virtual network for the IP address
        /// </summary>
        public bool ForVirtualNetwork { get; set; }

        /// <summary>
        /// public IP address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// is public IP portable across the zones
        /// </summary>
        public bool IsPortable { get; set; }

        /// <summary>
        /// true if the IP address is a source nat address, false otherwise
        /// </summary>
        public bool Issourcenat { get; set; }

        /// <summary>
        /// true if this ip is for static nat, false otherwise
        /// </summary>
        public bool Isstaticnat { get; set; }

        /// <summary>
        /// true if this ip is system ip (was allocated as a part of deployVm or createLbRule)
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// the ID of the Network where ip belongs to
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the physical network this belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// the project name of the address
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the ipaddress
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// purpose of the IP address. In Acton this value is not null for Ips with isSystem=true, and can have either StaticNat or LB value
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// State of the ip address. Can be: Allocatin, Allocated and Releasing
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// virutal machine display name the ip address is assigned to (not null only for static nat Ip)
        /// </summary>
        public string VirtualMachineDisplayName { get; set; }

        /// <summary>
        /// virutal machine id the ip address is assigned to (not null only for static nat Ip)
        /// </summary>
        public string VirtualMachineId { get; set; }

        /// <summary>
        /// virutal machine name the ip address is assigned to (not null only for static nat Ip)
        /// </summary>
        public string VirtualMachineName { get; set; }

        /// <summary>
        /// the ID of the VLAN associated with the IP address. This parameter is visible to ROOT admins only
        /// </summary>
        public string VlanId { get; set; }

        /// <summary>
        /// the VLAN associated with the IP address
        /// </summary>
        public string VlanName { get; set; }

        /// <summary>
        /// virutal machine (dnat) ip address (not null only for static nat Ip)
        /// </summary>
        public string Vmipaddress { get; set; }

        /// <summary>
        /// VPC the ip belongs to
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// the ID of the zone the public IP address belongs to
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the name of the zone the public IP address belongs to
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// the list of resource tags associated with ip address
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        /// <summary>
        /// the ID of the latest async job acting on this object
        /// </summary>
        public Guid jobid { get; set; }

        /// <summary>
        /// the current status of the latest async job acting on this object
        /// </summary>
        public string jobstatus { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
