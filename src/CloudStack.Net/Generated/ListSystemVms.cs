using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSystemVmsRequest : APIRequest
    {
        public ListSystemVmsRequest() : base("listSystemVms") {}

        /// <summary>
        /// the host ID of the system VM
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// the ID of the system VM
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// the name of the system VM
        /// </summary>
        public string SystemVmName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Pod ID of the system VM
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// the state of the system VM
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the storage ID where vm's volumes belong to
        /// </summary>
        public Guid StorageId { get; set; }

        /// <summary>
        /// the system VM type. Possible types are "consoleproxy" and "secondarystoragevm".
        /// </summary>
        public string SystemVmType { get; set; }

        /// <summary>
        /// the Zone ID of the system VM
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// List system virtual machines.
    /// </summary>
    /// <summary>
    /// List system virtual machines.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SystemVmResponse> ListSystemVms(ListSystemVmsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SystemVmResponse> ListSystemVms(ListSystemVmsRequest request) => _proxy.Request<ListResponse<SystemVmResponse>>(request);
    }
}
