using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class FindHostsForMigrationRequest : APIListRequest
    {
        public FindHostsForMigrationRequest() : base("findHostsForMigration") {}

        /// <summary>
        /// find hosts to which this VM can be migrated and flag the hosts with enough CPU/RAM to host the VM
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Find hosts suitable for migrating a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HostForMigrationResponse> FindHostsForMigration(FindHostsForMigrationRequest request);
        Task<ListResponse<HostForMigrationResponse>> FindHostsForMigrationAsync(FindHostsForMigrationRequest request);
        ListResponse<HostForMigrationResponse> FindHostsForMigrationAllPages(FindHostsForMigrationRequest request);
        Task<ListResponse<HostForMigrationResponse>> FindHostsForMigrationAllPagesAsync(FindHostsForMigrationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HostForMigrationResponse> FindHostsForMigration(FindHostsForMigrationRequest request) => _proxy.Request<ListResponse<HostForMigrationResponse>>(request);
        public Task<ListResponse<HostForMigrationResponse>> FindHostsForMigrationAsync(FindHostsForMigrationRequest request) => _proxy.RequestAsync<ListResponse<HostForMigrationResponse>>(request);
        public ListResponse<HostForMigrationResponse> FindHostsForMigrationAllPages(FindHostsForMigrationRequest request) => _proxy.RequestAllPages<HostForMigrationResponse>(request);
        public Task<ListResponse<HostForMigrationResponse>> FindHostsForMigrationAllPagesAsync(FindHostsForMigrationRequest request) => _proxy.RequestAllPagesAsync<HostForMigrationResponse>(request);
    }
}
