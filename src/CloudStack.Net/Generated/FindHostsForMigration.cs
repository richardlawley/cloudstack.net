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
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
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
