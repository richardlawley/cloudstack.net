using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAutoScaleVmProfilesRequest : APIListRequest
    {
        public ListAutoScaleVmProfilesRequest() : base("listAutoScaleVmProfiles") {}

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
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the autoscale vm profile
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
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
        /// the otherdeployparameters of the autoscale vm profile
        /// </summary>
        public string OtherDeployParams {
            get { return GetParameterValue<string>(nameof(OtherDeployParams).ToLower()); }
            set { SetParameterValue(nameof(OtherDeployParams).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// list profiles by service offering id
        /// </summary>
        public Guid? Serviceofferingid {
            get { return GetParameterValue<Guid?>(nameof(Serviceofferingid).ToLower()); }
            set { SetParameterValue(nameof(Serviceofferingid).ToLower(), value); }
        }

        /// <summary>
        /// the templateid of the autoscale vm profile
        /// </summary>
        public Guid? TemplateId {
            get { return GetParameterValue<Guid?>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// availability zone for the auto deployed virtual machine
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists autoscale vm profiles.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AutoScaleVmProfileResponse> ListAutoScaleVmProfiles(ListAutoScaleVmProfilesRequest request);
        Task<ListResponse<AutoScaleVmProfileResponse>> ListAutoScaleVmProfilesAsync(ListAutoScaleVmProfilesRequest request);
        ListResponse<AutoScaleVmProfileResponse> ListAutoScaleVmProfilesAllPages(ListAutoScaleVmProfilesRequest request);
        Task<ListResponse<AutoScaleVmProfileResponse>> ListAutoScaleVmProfilesAllPagesAsync(ListAutoScaleVmProfilesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AutoScaleVmProfileResponse> ListAutoScaleVmProfiles(ListAutoScaleVmProfilesRequest request) => _proxy.Request<ListResponse<AutoScaleVmProfileResponse>>(request);
        public Task<ListResponse<AutoScaleVmProfileResponse>> ListAutoScaleVmProfilesAsync(ListAutoScaleVmProfilesRequest request) => _proxy.RequestAsync<ListResponse<AutoScaleVmProfileResponse>>(request);
        public ListResponse<AutoScaleVmProfileResponse> ListAutoScaleVmProfilesAllPages(ListAutoScaleVmProfilesRequest request) => _proxy.RequestAllPages<AutoScaleVmProfileResponse>(request);
        public Task<ListResponse<AutoScaleVmProfileResponse>> ListAutoScaleVmProfilesAllPagesAsync(ListAutoScaleVmProfilesRequest request) => _proxy.RequestAllPagesAsync<AutoScaleVmProfileResponse>(request);
    }
}
