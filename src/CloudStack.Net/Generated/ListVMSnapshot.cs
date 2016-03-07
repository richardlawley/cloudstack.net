using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVMSnapshotRequest : APIListRequest
    {
        public ListVMSnapshotRequest() : base("listVMSnapshot") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return (bool?) Parameters[nameof(Isrecursive).ToLower()]; }
            set { Parameters[nameof(Isrecursive).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return (bool?) Parameters[nameof(ListAll).ToLower()]; }
            set { Parameters[nameof(ListAll).ToLower()] = value; }
        }

        /// <summary>
        /// lists snapshot by snapshot name or display name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// state of the virtual machine snapshot
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the vm
        /// </summary>
        public Guid Virtualmachineid {
            get { return (Guid) Parameters[nameof(Virtualmachineid).ToLower()]; }
            set { Parameters[nameof(Virtualmachineid).ToLower()] = value; }
        }

        /// <summary>
        /// The ID of the VM snapshot
        /// </summary>
        public Guid Vmsnapshotid {
            get { return (Guid) Parameters[nameof(Vmsnapshotid).ToLower()]; }
            set { Parameters[nameof(Vmsnapshotid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List virtual machine snapshot by conditions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VMSnapshotResponse> ListVMSnapshot(ListVMSnapshotRequest request);
        Task<ListResponse<VMSnapshotResponse>> ListVMSnapshotAsync(ListVMSnapshotRequest request);
        ListResponse<VMSnapshotResponse> ListVMSnapshotAllPages(ListVMSnapshotRequest request);
        Task<ListResponse<VMSnapshotResponse>> ListVMSnapshotAllPagesAsync(ListVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VMSnapshotResponse> ListVMSnapshot(ListVMSnapshotRequest request) => _proxy.Request<ListResponse<VMSnapshotResponse>>(request);
        public Task<ListResponse<VMSnapshotResponse>> ListVMSnapshotAsync(ListVMSnapshotRequest request) => _proxy.RequestAsync<ListResponse<VMSnapshotResponse>>(request);
        public ListResponse<VMSnapshotResponse> ListVMSnapshotAllPages(ListVMSnapshotRequest request) => _proxy.RequestAllPages<VMSnapshotResponse>(request);
        public Task<ListResponse<VMSnapshotResponse>> ListVMSnapshotAllPagesAsync(ListVMSnapshotRequest request) => _proxy.RequestAllPagesAsync<VMSnapshotResponse>(request);
    }
}
