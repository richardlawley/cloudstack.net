using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVPCsRequest : APIRequest
    {
        public ListVPCsRequest() : base("listVPCs") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list by cidr of the VPC. All VPC guest networks' cidrs should be within this CIDR
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// List by display text of the VPC
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// list VPC by id
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
        /// list by name of the VPC
        /// </summary>
        public string VpcName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// list VPCs by restartRequired option
        /// </summary>
        public bool? RestartRequired { get; set; }

        /// <summary>
        /// list VPCs by state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// list VPC supporting certain services
        /// </summary>
        public IList<string> SupportedServices { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// list by ID of the VPC offering
        /// </summary>
        public Guid VpcOffId { get; set; }

        /// <summary>
        /// list by zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists VPCs
    /// </summary>
    /// <summary>
    /// Lists VPCs
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VpcResponse> ListVPCs(ListVPCsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VpcResponse> ListVPCs(ListVPCsRequest request) => _proxy.Request<ListResponse<VpcResponse>>(request);
    }
}
