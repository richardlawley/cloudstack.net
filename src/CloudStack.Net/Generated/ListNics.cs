using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNicsRequest : APIRequest
    {
        public ListNicsRequest() : base("listNics") {}

        /// <summary>
        /// the ID of the vm
        /// </summary>
        public Guid VmId { get; set; }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list nic of the specific vm's network
        /// </summary>
        public Guid NetworkId { get; set; }

        /// <summary>
        /// the ID of the nic to to list IPs
        /// </summary>
        public Guid NicId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// list the vm nics  IP to NIC
    /// </summary>
    /// <summary>
    /// list the vm nics  IP to NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NicResponse> ListNics(ListNicsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NicResponse> ListNics(ListNicsRequest request) => _proxy.Request<ListResponse<NicResponse>>(request);
    }
}
