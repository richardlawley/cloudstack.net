using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DomainRouterResponse
    {
        /// <summary>
        /// the id of the router
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the router
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the date and time the router was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the first DNS for the router
        /// </summary>
        public string Dns1 { get; set; }

        /// <summary>
        /// the second DNS for the router
        /// </summary>
        public string Dns2 { get; set; }

        /// <summary>
        /// the domain associated with the router
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID associated with the router
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the gateway for the router
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the guest IP address for the router
        /// </summary>
        public string GuestIpAddress { get; set; }

        /// <summary>
        /// the guest MAC address for the router
        /// </summary>
        public string GuestMacAddress { get; set; }

        /// <summary>
        /// the guest netmask for the router
        /// </summary>
        public string GuestNetmask { get; set; }

        /// <summary>
        /// the ID of the corresponding guest network
        /// </summary>
        public string GuestNetworkId { get; set; }

        /// <summary>
        /// the host ID for the router
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// the hostname for the router
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the hypervisor on which the template runs
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the first IPv6 DNS for the router
        /// </summary>
        public string Ip6Dns1 { get; set; }

        /// <summary>
        /// the second IPv6 DNS for the router
        /// </summary>
        public string Ip6Dns2 { get; set; }

        /// <summary>
        /// if this router is an redundant virtual router
        /// </summary>
        public bool IsRedundantRouter { get; set; }

        /// <summary>
        /// the link local IP address for the router
        /// </summary>
        public string LinkLocalIp { get; set; }

        /// <summary>
        /// the link local MAC address for the router
        /// </summary>
        public string LinkLocalMacAddress { get; set; }

        /// <summary>
        /// the link local netmask for the router
        /// </summary>
        public string LinkLocalNetmask { get; set; }

        /// <summary>
        /// the ID of the corresponding link local network
        /// </summary>
        public string LinkLocalNetworkId { get; set; }

        /// <summary>
        /// the name of the router
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the network domain for the router
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// the Pod ID for the router
        /// </summary>
        public string PodId { get; set; }

        /// <summary>
        /// the project name of the address
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the ipaddress
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the public IP address for the router
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// the public MAC address for the router
        /// </summary>
        public string PublicMacAddress { get; set; }

        /// <summary>
        /// the public netmask for the router
        /// </summary>
        public string PublicNetmask { get; set; }

        /// <summary>
        /// the ID of the corresponding public network
        /// </summary>
        public string PublicNetworkId { get; set; }

        /// <summary>
        /// the state of redundant virtual router
        /// </summary>
        public string RedundantState { get; set; }

        /// <summary>
        /// true if the router template requires upgrader
        /// </summary>
        public bool RequiresUpgrade { get; set; }

        /// <summary>
        /// role of the domain router
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// the version of scripts
        /// </summary>
        public string ScriptsVersion { get; set; }

        /// <summary>
        /// the ID of the service offering of the virtual machine
        /// </summary>
        public string ServiceOfferingId { get; set; }

        /// <summary>
        /// the name of the service offering of the virtual machine
        /// </summary>
        public string ServiceOfferingName { get; set; }

        /// <summary>
        /// the state of the router
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// the template ID for the router
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// the version of template
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// VPC the router belongs to
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// the Zone ID for the router
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name for the router
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// the list of nics associated with the router
        /// </summary>
        public IList<NicResponse> Nic { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
