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
        public string ClusterName {
            get { return (string) Parameters[nameof(ClusterName).ToLower()]; }
            set { Parameters[nameof(ClusterName).ToLower()] = value; }
        }

        /// <summary>
        /// type of the cluster: CloudManaged, ExternalManaged
        /// </summary>
        public string ClusterType {
            get { return (string) Parameters[nameof(ClusterType).ToLower()]; }
            set { Parameters[nameof(ClusterType).ToLower()] = value; }
        }

        /// <summary>
        /// hypervisor type of the cluster: XenServer,KVM,VMware,Hyperv,BareMetal,Simulator,Ovm3
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// the Pod ID for the host
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the cluster
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return (string) Parameters[nameof(AllocationState).ToLower()]; }
            set { Parameters[nameof(AllocationState).ToLower()] = value; }
        }

        /// <summary>
        /// Name of virtual switch used for guest traffic in the cluster. This would override zone wide traffic label setting.
        /// </summary>
        public string Guestvswitchname {
            get { return (string) Parameters[nameof(Guestvswitchname).ToLower()]; }
            set { Parameters[nameof(Guestvswitchname).ToLower()] = value; }
        }

        /// <summary>
        /// Type of virtual switch used for guest traffic in the cluster. Allowed values are, vmwaresvs (for VMware standard vSwitch) and vmwaredvs (for VMware distributed vSwitch)
        /// </summary>
        public string Guestvswitchtype {
            get { return (string) Parameters[nameof(Guestvswitchtype).ToLower()]; }
            set { Parameters[nameof(Guestvswitchtype).ToLower()] = value; }
        }

        /// <summary>
        /// Ovm3 native OCFS2 clustering enabled for cluster
        /// </summary>
        public string Ovm3cluster {
            get { return (string) Parameters[nameof(Ovm3cluster).ToLower()]; }
            set { Parameters[nameof(Ovm3cluster).ToLower()] = value; }
        }

        /// <summary>
        /// Ovm3 native pooling enabled for cluster
        /// </summary>
        public string Ovm3pool {
            get { return (string) Parameters[nameof(Ovm3pool).ToLower()]; }
            set { Parameters[nameof(Ovm3pool).ToLower()] = value; }
        }

        /// <summary>
        /// Ovm3 vip to use for pool (and cluster)
        /// </summary>
        public string Ovm3vip {
            get { return (string) Parameters[nameof(Ovm3vip).ToLower()]; }
            set { Parameters[nameof(Ovm3vip).ToLower()] = value; }
        }

        /// <summary>
        /// the password for the host
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// Name of virtual switch used for public traffic in the cluster.  This would override zone wide traffic label setting.
        /// </summary>
        public string Publicvswitchname {
            get { return (string) Parameters[nameof(Publicvswitchname).ToLower()]; }
            set { Parameters[nameof(Publicvswitchname).ToLower()] = value; }
        }

        /// <summary>
        /// Type of virtual switch used for public traffic in the cluster. Allowed values are, vmwaresvs (for VMware standard vSwitch) and vmwaredvs (for VMware distributed vSwitch)
        /// </summary>
        public string Publicvswitchtype {
            get { return (string) Parameters[nameof(Publicvswitchtype).ToLower()]; }
            set { Parameters[nameof(Publicvswitchtype).ToLower()] = value; }
        }

        /// <summary>
        /// the URL
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// the username for the cluster
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// the ipaddress of the VSM associated with this cluster
        /// </summary>
        public string Vsmipaddress {
            get { return (string) Parameters[nameof(Vsmipaddress).ToLower()]; }
            set { Parameters[nameof(Vsmipaddress).ToLower()] = value; }
        }

        /// <summary>
        /// the password for the VSM associated with this cluster
        /// </summary>
        public string Vsmpassword {
            get { return (string) Parameters[nameof(Vsmpassword).ToLower()]; }
            set { Parameters[nameof(Vsmpassword).ToLower()] = value; }
        }

        /// <summary>
        /// the username for the VSM associated with this cluster
        /// </summary>
        public string Vsmusername {
            get { return (string) Parameters[nameof(Vsmusername).ToLower()]; }
            set { Parameters[nameof(Vsmusername).ToLower()] = value; }
        }

    }
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
