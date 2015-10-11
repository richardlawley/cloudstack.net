using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddHostRequest : APIRequest
    {
        public AddHostRequest() : base("addHost") {}

        /// <summary>
        /// hypervisor type of the host
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// the password for the host
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// the Pod ID for the host
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// the host URL
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// the username for the host
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the host
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// Allocation state of this Host for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return (string) Parameters[nameof(AllocationState).ToLower()]; }
            set { Parameters[nameof(AllocationState).ToLower()] = value; }
        }

        /// <summary>
        /// the cluster ID for the host
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// the cluster name for the host
        /// </summary>
        public string ClusterName {
            get { return (string) Parameters[nameof(ClusterName).ToLower()]; }
            set { Parameters[nameof(ClusterName).ToLower()] = value; }
        }

        /// <summary>
        /// list of tags to be added to the host
        /// </summary>
        public IList<string> HostTags {
            get { return GetList<string>(nameof(HostTags).ToLower()); }
            set { Parameters[nameof(HostTags).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a new host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HostResponse AddHost(AddHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HostResponse AddHost(AddHostRequest request) => _proxy.Request<HostResponse>(request);
    }
}
