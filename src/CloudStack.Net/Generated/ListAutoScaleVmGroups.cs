using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAutoScaleVmGroupsRequest : APIRequest
    {
        public ListAutoScaleVmGroupsRequest() : base("listAutoScaleVmGroups") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the ID of the autoscale vm group
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
        /// the ID of the loadbalancer
        /// </summary>
        public Guid LoadBalancerId { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the ID of the policy
        /// </summary>
        public Guid PolicyId { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the ID of the profile
        /// </summary>
        public Guid ProfileId { get; set; }

        /// <summary>
        /// the availability zone ID
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists autoscale vm groups.
    /// </summary>
    /// <summary>
    /// Lists autoscale vm groups.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AutoScaleVmGroupResponse> ListAutoScaleVmGroups(ListAutoScaleVmGroupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AutoScaleVmGroupResponse> ListAutoScaleVmGroups(ListAutoScaleVmGroupsRequest request) => _proxy.Request<ListResponse<AutoScaleVmGroupResponse>>(request);
    }
}
