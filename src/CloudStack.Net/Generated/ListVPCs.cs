using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVPCsRequest : APIListRequest
    {
        public ListVPCsRequest() : base("listVPCs") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list by cidr of the VPC. All VPC guest networks' cidrs should be within this CIDR
        /// </summary>
        public string Cidr {
            get { return GetParameterValue<string>(nameof(Cidr).ToLower()); }
            set { SetParameterValue(nameof(Cidr).ToLower(), value); }
        }

        /// <summary>
        /// List by display text of the VPC
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
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
        /// list VPC by id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
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
        /// list by name of the VPC
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
        /// list VPCs by restartRequired option
        /// </summary>
        public bool? RestartRequired {
            get { return GetParameterValue<bool?>(nameof(RestartRequired).ToLower()); }
            set { SetParameterValue(nameof(RestartRequired).ToLower(), value); }
        }

        /// <summary>
        /// list VPCs by state
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// list VPC supporting certain services
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { SetParameterValue(nameof(SupportedServices).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// list by ID of the VPC offering
        /// </summary>
        public Guid Vpcofferingid {
            get { return GetParameterValue<Guid>(nameof(Vpcofferingid).ToLower()); }
            set { SetParameterValue(nameof(Vpcofferingid).ToLower(), value); }
        }

        /// <summary>
        /// list by zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists VPCs
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VpcResponse> ListVPCs(ListVPCsRequest request);
        Task<ListResponse<VpcResponse>> ListVPCsAsync(ListVPCsRequest request);
        ListResponse<VpcResponse> ListVPCsAllPages(ListVPCsRequest request);
        Task<ListResponse<VpcResponse>> ListVPCsAllPagesAsync(ListVPCsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VpcResponse> ListVPCs(ListVPCsRequest request) => _proxy.Request<ListResponse<VpcResponse>>(request);
        public Task<ListResponse<VpcResponse>> ListVPCsAsync(ListVPCsRequest request) => _proxy.RequestAsync<ListResponse<VpcResponse>>(request);
        public ListResponse<VpcResponse> ListVPCsAllPages(ListVPCsRequest request) => _proxy.RequestAllPages<VpcResponse>(request);
        public Task<ListResponse<VpcResponse>> ListVPCsAllPagesAsync(ListVPCsRequest request) => _proxy.RequestAllPagesAsync<VpcResponse>(request);
    }
}
