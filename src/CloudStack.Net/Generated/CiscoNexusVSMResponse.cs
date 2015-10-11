using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CiscoNexusVSMResponse
    {
        /// <summary>
        /// the management IP address of the external Cisco Nexus 1000v Virtual Supervisor Module
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// The mode of the VSM (standalone/HA)
        /// </summary>
        public string Vsmconfigmode { get; set; }

        /// <summary>
        /// The Config State (Primary/Standby) of the VSM
        /// </summary>
        public string Vsmconfigstate { get; set; }

        /// <summary>
        /// control vlan id of the VSM
        /// </summary>
        public int Vsmctrlvlanid { get; set; }

        /// <summary>
        /// device id of the Cisco N1KV VSM device
        /// </summary>
        public string Vsmdeviceid { get; set; }

        /// <summary>
        /// device name
        /// </summary>
        public string Vsmdevicename { get; set; }

        /// <summary>
        /// device state
        /// </summary>
        public string Vsmdevicestate { get; set; }

        /// <summary>
        /// The Device State (Enabled/Disabled) of the VSM
        /// </summary>
        public string Vsmdevicestate { get; set; }

        /// <summary>
        /// The VSM is a switch supervisor. This is the VSM's switch domain id
        /// </summary>
        public string Vsmdomainid { get; set; }

        /// <summary>
        /// management vlan id of the VSM
        /// </summary>
        public string Vsmmgmtvlanid { get; set; }

        /// <summary>
        /// packet vlan id of the VSM
        /// </summary>
        public int Vsmpktvlanid { get; set; }

        /// <summary>
        /// storage vlan id of the VSM
        /// </summary>
        public int Vsmstoragevlanid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
