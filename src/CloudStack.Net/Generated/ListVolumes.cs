using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVolumesRequest : APIRequest
    {
        public ListVolumesRequest() : base("listVolumes") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list volumes by disk offering
        /// </summary>
        public Guid DiskOfferingId { get; set; }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list volumes on specified host
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid Id { get; set; }

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
        /// the name of the disk volume
        /// </summary>
        public string VolumeName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the pod id the disk volume belongs to
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the ID of the storage pool, available to ROOT admin only
        /// </summary>
        public Guid StorageId { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// the type of disk volume
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// the ID of the availability zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all volumes.
    /// </summary>
    /// <summary>
    /// Lists all volumes.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VolumeResponse> ListVolumes(ListVolumesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VolumeResponse> ListVolumes(ListVolumesRequest request) => _proxy.Request<ListResponse<VolumeResponse>>(request);
    }
}
