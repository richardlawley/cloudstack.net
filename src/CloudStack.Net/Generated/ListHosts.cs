using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHostsRequest : APIListRequest
    {
        public ListHostsRequest() : base("listHosts") {}

        /// <summary>
        /// lists hosts existing in particular cluster
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// comma separated list of host details requested, value can be a list of [ min, all, capacity, events, stats]
        /// </summary>
        public IList<string> Details {
            get { return GetList<string>(nameof(Details).ToLower()); }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// if true, list only hosts dedicated to HA
        /// </summary>
        public bool? HaHost {
            get { return (bool?) Parameters[nameof(HaHost).ToLower()]; }
            set { Parameters[nameof(HaHost).ToLower()] = value; }
        }

        /// <summary>
        /// hypervisor type of host: XenServer,KVM,VMware,Hyperv,BareMetal,Simulator
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// the id of the host
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the host
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the Pod ID for the host
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// list hosts by resource state. Resource state represents current state determined by admin of host, valule can be one of [Enabled, Disabled, Unmanaged, PrepareForMaintenance, ErrorInMaintenance, Maintenance, Error]
        /// </summary>
        public string ResourceState {
            get { return (string) Parameters[nameof(ResourceState).ToLower()]; }
            set { Parameters[nameof(ResourceState).ToLower()] = value; }
        }

        /// <summary>
        /// the state of the host
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

        /// <summary>
        /// the host type
        /// </summary>
        public string Type {
            get { return (string) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

        /// <summary>
        /// lists hosts in the same cluster as this VM and flag hosts with enough CPU/RAm to host this VM
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the host
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists hosts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HostResponse> ListHosts(ListHostsRequest request);
        Task<ListResponse<HostResponse>> ListHostsAsync(ListHostsRequest request);
        ListResponse<HostResponse> ListHostsAllPages(ListHostsRequest request);
        Task<ListResponse<HostResponse>> ListHostsAllPagesAsync(ListHostsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HostResponse> ListHosts(ListHostsRequest request) => _proxy.Request<ListResponse<HostResponse>>(request);
        public Task<ListResponse<HostResponse>> ListHostsAsync(ListHostsRequest request) => _proxy.RequestAsync<ListResponse<HostResponse>>(request);
        public ListResponse<HostResponse> ListHostsAllPages(ListHostsRequest request) => _proxy.RequestAllPages<HostResponse>(request);
        public Task<ListResponse<HostResponse>> ListHostsAllPagesAsync(ListHostsRequest request) => _proxy.RequestAllPagesAsync<HostResponse>(request);
    }
}
