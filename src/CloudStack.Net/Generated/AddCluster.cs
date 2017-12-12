using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(ClusterName).ToLower()); }
            set { SetParameterValue(nameof(ClusterName).ToLower(), value); }
        }

        /// <summary>
        /// type of the cluster: CloudManaged, ExternalManaged
        /// </summary>
        public string ClusterType {
            get { return GetParameterValue<string>(nameof(ClusterType).ToLower()); }
            set { SetParameterValue(nameof(ClusterType).ToLower(), value); }
        }

        /// <summary>
        /// hypervisor type of the cluster: XenServer,KVM,VMware,Hyperv,BareMetal,Simulator,Ovm3
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// the Pod ID for the host
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the cluster
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return GetParameterValue<string>(nameof(AllocationState).ToLower()); }
            set { SetParameterValue(nameof(AllocationState).ToLower(), value); }
        }

        /// <summary>
        /// Name of virtual switch used for guest traffic in the cluster. This would override zone wide traffic label setting.
        /// </summary>
        public string Guestvswitchname {
            get { return GetParameterValue<string>(nameof(Guestvswitchname).ToLower()); }
            set { SetParameterValue(nameof(Guestvswitchname).ToLower(), value); }
        }

        /// <summary>
        /// Type of virtual switch used for guest traffic in the cluster. Allowed values are, vmwaresvs (for VMware standard vSwitch) and vmwaredvs (for VMware distributed vSwitch)
        /// </summary>
        public string Guestvswitchtype {
            get { return GetParameterValue<string>(nameof(Guestvswitchtype).ToLower()); }
            set { SetParameterValue(nameof(Guestvswitchtype).ToLower(), value); }
        }

        /// <summary>
        /// Ovm3 native OCFS2 clustering enabled for cluster
        /// </summary>
        public string Ovm3cluster {
            get { return GetParameterValue<string>(nameof(Ovm3cluster).ToLower()); }
            set { SetParameterValue(nameof(Ovm3cluster).ToLower(), value); }
        }

        /// <summary>
        /// Ovm3 native pooling enabled for cluster
        /// </summary>
        public string Ovm3pool {
            get { return GetParameterValue<string>(nameof(Ovm3pool).ToLower()); }
            set { SetParameterValue(nameof(Ovm3pool).ToLower(), value); }
        }

        /// <summary>
        /// Ovm3 vip to use for pool (and cluster)
        /// </summary>
        public string Ovm3vip {
            get { return GetParameterValue<string>(nameof(Ovm3vip).ToLower()); }
            set { SetParameterValue(nameof(Ovm3vip).ToLower(), value); }
        }

        /// <summary>
        /// the password for the host
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// Name of virtual switch used for public traffic in the cluster.  This would override zone wide traffic label setting.
        /// </summary>
        public string Publicvswitchname {
            get { return GetParameterValue<string>(nameof(Publicvswitchname).ToLower()); }
            set { SetParameterValue(nameof(Publicvswitchname).ToLower(), value); }
        }

        /// <summary>
        /// Type of virtual switch used for public traffic in the cluster. Allowed values are, vmwaresvs (for VMware standard vSwitch) and vmwaredvs (for VMware distributed vSwitch)
        /// </summary>
        public string Publicvswitchtype {
            get { return GetParameterValue<string>(nameof(Publicvswitchtype).ToLower()); }
            set { SetParameterValue(nameof(Publicvswitchtype).ToLower(), value); }
        }

        /// <summary>
        /// the URL
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the username for the cluster
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// the ipaddress of the VSM associated with this cluster
        /// </summary>
        public string Vsmipaddress {
            get { return GetParameterValue<string>(nameof(Vsmipaddress).ToLower()); }
            set { SetParameterValue(nameof(Vsmipaddress).ToLower(), value); }
        }

        /// <summary>
        /// the password for the VSM associated with this cluster
        /// </summary>
        public string Vsmpassword {
            get { return GetParameterValue<string>(nameof(Vsmpassword).ToLower()); }
            set { SetParameterValue(nameof(Vsmpassword).ToLower(), value); }
        }

        /// <summary>
        /// the username for the VSM associated with this cluster
        /// </summary>
        public string Vsmusername {
            get { return GetParameterValue<string>(nameof(Vsmusername).ToLower()); }
            set { SetParameterValue(nameof(Vsmusername).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a new cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ClusterResponse AddCluster(AddClusterRequest request);
        Task<ClusterResponse> AddClusterAsync(AddClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ClusterResponse AddCluster(AddClusterRequest request) => Proxy.Request<ClusterResponse>(request);
        public Task<ClusterResponse> AddClusterAsync(AddClusterRequest request) => Proxy.RequestAsync<ClusterResponse>(request);
    }
}
