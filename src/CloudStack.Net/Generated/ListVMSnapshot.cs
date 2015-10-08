using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVMSnapshotRequest : APIRequest
    {
        public ListVMSnapshotRequest() : base("listVMSnapshot") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        /// <summary>
        /// lists snapshot by snapshot name or display name
        /// </summary>
        public string VmSnapshotName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// state of the virtual machine snapshot
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// the ID of the vm
        /// </summary>
        public Guid VmId { get; set; }

        /// <summary>
        /// The ID of the VM snapshot
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// List virtual machine snapshot by conditions
    /// </summary>
    /// <summary>
    /// List virtual machine snapshot by conditions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VMSnapshotResponse> ListVMSnapshot(ListVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VMSnapshotResponse> ListVMSnapshot(ListVMSnapshotRequest request) => _proxy.Request<ListResponse<VMSnapshotResponse>>(request);
    }
}
