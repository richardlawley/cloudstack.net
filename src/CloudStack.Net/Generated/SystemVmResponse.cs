using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SystemVmResponse
    {
        /// <summary>
        /// the ID of the system VM
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the number of active console sessions for the console proxy system vm
        /// </summary>
        public int ActiveViewerSessions { get; set; }

        /// <summary>
        /// the date and time the system VM was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the first DNS for the system VM
        /// </summary>
        public string Dns1 { get; set; }

        /// <summary>
        /// the second DNS for the system VM
        /// </summary>
        public string Dns2 { get; set; }

        /// <summary>
        /// the gateway for the system VM
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the host ID for the system VM
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// the hostname for the system VM
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the hypervisor on which the template runs
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the job ID associated with the system VM. This is only displayed if the router listed is part of a currently running asynchronous job.
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// the job status associated with the system VM.  This is only displayed if the router listed is part of a currently running asynchronous job.
        /// </summary>
        public int JobStatus { get; set; }

        /// <summary>
        /// the link local IP address for the system vm
        /// </summary>
        public string LinkLocalIp { get; set; }

        /// <summary>
        /// the link local MAC address for the system vm
        /// </summary>
        public string LinkLocalMacAddress { get; set; }

        /// <summary>
        /// the link local netmask for the system vm
        /// </summary>
        public string LinkLocalNetmask { get; set; }

        /// <summary>
        /// the name of the system VM
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the network domain for the system VM
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// the Pod ID for the system VM
        /// </summary>
        public string PodId { get; set; }

        /// <summary>
        /// the private IP address for the system VM
        /// </summary>
        public string PrivateIp { get; set; }

        /// <summary>
        /// the private MAC address for the system VM
        /// </summary>
        public string PrivateMacAddress { get; set; }

        /// <summary>
        /// the private netmask for the system VM
        /// </summary>
        public string PrivateNetmask { get; set; }

        /// <summary>
        /// the public IP address for the system VM
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// the public MAC address for the system VM
        /// </summary>
        public string PublicMacAddress { get; set; }

        /// <summary>
        /// the public netmask for the system VM
        /// </summary>
        public string PublicNetmask { get; set; }

        /// <summary>
        /// the state of the system VM
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the system VM type
        /// </summary>
        public string SystemVmType { get; set; }

        /// <summary>
        /// the template ID for the system VM
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// the Zone ID for the system VM
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name for the system VM
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
