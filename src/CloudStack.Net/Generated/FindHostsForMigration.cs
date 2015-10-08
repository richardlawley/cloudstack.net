using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class FindHostsForMigrationRequest : APIRequest
    {
        public FindHostsForMigrationRequest() : base("findHostsForMigration") {}

        /// <summary>
        /// find hosts to which this VM can be migrated and flag the hosts with enough CPU/RAM to host the VM
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Find hosts suitable for migrating a virtual machine.
    /// </summary>
    /// <summary>
    /// Find hosts suitable for migrating a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HostForMigrationResponse> FindHostsForMigration(FindHostsForMigrationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HostForMigrationResponse> FindHostsForMigration(FindHostsForMigrationRequest request) => _proxy.Request<ListResponse<HostForMigrationResponse>>(request);
    }
}
