using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHostsRequest : APIRequest
    {
        public ListHostsRequest() : base("listHosts") {}

        /// <summary>
        /// lists hosts existing in particular cluster
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// comma separated list of host details requested, value can be a list of [ min, all, capacity, events, stats]
        /// </summary>
        public IList<string> ViewDetails { get; set; }

        /// <summary>
        /// if true, list only hosts dedicated to HA
        /// </summary>
        public bool? HaHost { get; set; }

        /// <summary>
        /// hypervisor type of host: XenServer,KVM,VMware,Hyperv,BareMetal,Simulator
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the id of the host
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// the name of the host
        /// </summary>
        public string HostName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Pod ID for the host
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// list hosts by resource state. Resource state represents current state determined by admin of host, valule can be one of [Enabled, Disabled, Unmanaged, PrepareForMaintenance, ErrorInMaintenance, Maintenance, Error]
        /// </summary>
        public string ResourceState { get; set; }

        /// <summary>
        /// the state of the host
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the host type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// lists hosts in the same cluster as this VM and flag hosts with enough CPU/RAm to host this VM
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// the Zone ID for the host
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists hosts.
    /// </summary>
    /// <summary>
    /// Lists hosts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HostResponse> ListHosts(ListHostsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HostResponse> ListHosts(ListHostsRequest request) => _proxy.Request<ListResponse<HostResponse>>(request);
    }
}
