using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPrivateGatewaysRequest : APIListRequest
    {
        public ListPrivateGatewaysRequest() : base("listPrivateGateways") {}

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
        /// list private gateway by id
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// list gateways by ip address
        /// </summary>
        public string IpAddress {
            get { return GetParameterValue<string>(nameof(IpAddress).ToLower()); }
            set { SetParameterValue(nameof(IpAddress).ToLower(), value); }
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
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// list gateways by state
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// list gateways by vlan
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

        /// <summary>
        /// list gateways by vpc
        /// </summary>
        public Guid? VpcId {
            get { return GetParameterValue<Guid?>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List private gateways
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PrivateGatewayResponse> ListPrivateGateways(ListPrivateGatewaysRequest request);
        Task<ListResponse<PrivateGatewayResponse>> ListPrivateGatewaysAsync(ListPrivateGatewaysRequest request);
        ListResponse<PrivateGatewayResponse> ListPrivateGatewaysAllPages(ListPrivateGatewaysRequest request);
        Task<ListResponse<PrivateGatewayResponse>> ListPrivateGatewaysAllPagesAsync(ListPrivateGatewaysRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PrivateGatewayResponse> ListPrivateGateways(ListPrivateGatewaysRequest request) => Proxy.Request<ListResponse<PrivateGatewayResponse>>(request);
        public Task<ListResponse<PrivateGatewayResponse>> ListPrivateGatewaysAsync(ListPrivateGatewaysRequest request) => Proxy.RequestAsync<ListResponse<PrivateGatewayResponse>>(request);
        public ListResponse<PrivateGatewayResponse> ListPrivateGatewaysAllPages(ListPrivateGatewaysRequest request) => Proxy.RequestAllPages<PrivateGatewayResponse>(request);
        public Task<ListResponse<PrivateGatewayResponse>> ListPrivateGatewaysAllPagesAsync(ListPrivateGatewaysRequest request) => Proxy.RequestAllPagesAsync<PrivateGatewayResponse>(request);
    }
}
