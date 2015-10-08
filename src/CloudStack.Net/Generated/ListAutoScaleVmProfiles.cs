using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAutoScaleVmProfilesRequest : APIRequest
    {
        public ListAutoScaleVmProfilesRequest() : base("listAutoScaleVmProfiles") {}

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
        /// the ID of the autoscale vm profile
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
        /// the otherdeployparameters of the autoscale vm profile
        /// </summary>
        public string OtherDeployParams { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// list profiles by service offering id
        /// </summary>
        public Guid ServiceOffId { get; set; }

        /// <summary>
        /// the templateid of the autoscale vm profile
        /// </summary>
        public Guid TemplateId { get; set; }

        /// <summary>
        /// availability zone for the auto deployed virtual machine
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists autoscale vm profiles.
    /// </summary>
    /// <summary>
    /// Lists autoscale vm profiles.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AutoScaleVmProfileResponse> ListAutoScaleVmProfiles(ListAutoScaleVmProfilesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AutoScaleVmProfileResponse> ListAutoScaleVmProfiles(ListAutoScaleVmProfilesRequest request) => _proxy.Request<ListResponse<AutoScaleVmProfileResponse>>(request);
    }
}
