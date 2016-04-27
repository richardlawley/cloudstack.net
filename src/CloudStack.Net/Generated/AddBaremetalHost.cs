using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBaremetalHostRequest : APIRequest
    {
        public AddBaremetalHostRequest() : base("addBaremetalHost") {}

        /// <summary>
        /// hypervisor type of the host
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// the password for the host
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the Pod ID for the host
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// the host URL
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the username for the host
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the host
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// Allocation state of this Host for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return GetParameterValue<string>(nameof(AllocationState).ToLower()); }
            set { SetParameterValue(nameof(AllocationState).ToLower(), value); }
        }

        /// <summary>
        /// the cluster ID for the host
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// the cluster name for the host
        /// </summary>
        public string ClusterName {
            get { return GetParameterValue<string>(nameof(ClusterName).ToLower()); }
            set { SetParameterValue(nameof(ClusterName).ToLower(), value); }
        }

        /// <summary>
        /// list of tags to be added to the host
        /// </summary>
        public IList<string> HostTags {
            get { return GetList<string>(nameof(HostTags).ToLower()); }
            set { SetParameterValue(nameof(HostTags).ToLower(), value); }
        }

        /// <summary>
        /// ip address intentionally allocated to this host after provisioning
        /// </summary>
        public string Ipaddress {
            get { return GetParameterValue<string>(nameof(Ipaddress).ToLower()); }
            set { SetParameterValue(nameof(Ipaddress).ToLower(), value); }
        }

    }
    /// <summary>
    /// add a baremetal host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HostResponse AddBaremetalHost(AddBaremetalHostRequest request);
        Task<HostResponse> AddBaremetalHostAsync(AddBaremetalHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HostResponse AddBaremetalHost(AddBaremetalHostRequest request) => _proxy.Request<HostResponse>(request);
        public Task<HostResponse> AddBaremetalHostAsync(AddBaremetalHostRequest request) => _proxy.RequestAsync<HostResponse>(request);
    }
}
