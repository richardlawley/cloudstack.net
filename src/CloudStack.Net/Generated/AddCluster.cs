using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddClusterRequest : APIRequest
    {
        public AddClusterRequest() : base("addCluster") {}

        /// <summary>
        /// the cluster name
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// type of the cluster: CloudManaged, ExternalManaged
        /// </summary>
        public string ClusterType { get; set; }

        /// <summary>
        /// hypervisor type of the cluster: XenServer,KVM,VMware,Hyperv,BareMetal,Simulator,Ovm3
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the Pod ID for the host
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// the Zone ID for the cluster
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// Name of virtual switch used for guest traffic in the cluster. This would override zone wide traffic label setting.
        /// </summary>
        public string VSwitchNameGuestTraffic { get; set; }

        /// <summary>
        /// Type of virtual switch used for guest traffic in the cluster. Allowed values are, vmwaresvs (for VMware standard vSwitch) and vmwaredvs (for VMware distributed vSwitch)
        /// </summary>
        public string VSwitchTypeGuestTraffic { get; set; }

        /// <summary>
        /// Ovm3 native OCFS2 clustering enabled for cluster
        /// </summary>
        public string Ovm3cluster { get; set; }

        /// <summary>
        /// Ovm3 native pooling enabled for cluster
        /// </summary>
        public string Ovm3pool { get; set; }

        /// <summary>
        /// Ovm3 vip to use for pool (and cluster)
        /// </summary>
        public string Ovm3vip { get; set; }

        /// <summary>
        /// the password for the host
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Name of virtual switch used for public traffic in the cluster.  This would override zone wide traffic label setting.
        /// </summary>
        public string VSwitchNamePublicTraffic { get; set; }

        /// <summary>
        /// Type of virtual switch used for public traffic in the cluster. Allowed values are, vmwaresvs (for VMware standard vSwitch) and vmwaredvs (for VMware distributed vSwitch)
        /// </summary>
        public string VSwitchTypePublicTraffic { get; set; }

        /// <summary>
        /// the URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the username for the cluster
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// the ipaddress of the VSM associated with this cluster
        /// </summary>
        public string Vsmipaddress { get; set; }

        /// <summary>
        /// the password for the VSM associated with this cluster
        /// </summary>
        public string Vsmpassword { get; set; }

        /// <summary>
        /// the username for the VSM associated with this cluster
        /// </summary>
        public string Vsmusername { get; set; }

    }
    /// <summary>
    /// Adds a new cluster
    /// </summary>
    /// <summary>
    /// Adds a new cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ClusterResponse AddCluster(AddClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ClusterResponse AddCluster(AddClusterRequest request) => _proxy.Request<ClusterResponse>(request);
    }
}
