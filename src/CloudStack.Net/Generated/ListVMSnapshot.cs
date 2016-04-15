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
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// lists snapshot by snapshot name or display name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// state of the virtual machine snapshot
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the vm
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the VM snapshot
        /// </summary>
        public Guid Vmsnapshotid {
            get { return GetParameterValue<Guid>(nameof(Vmsnapshotid).ToLower()); }
            set { SetParameterValue(nameof(Vmsnapshotid).ToLower(), value); }
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
