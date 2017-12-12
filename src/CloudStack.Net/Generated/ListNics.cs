using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNicsRequest : APIListRequest
    {
        public ListNicsRequest() : base("listNics") {}

        /// <summary>
        /// the ID of the vm
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// list nic of the specific vm's network
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the nic to to list IPs
        /// </summary>
        public Guid? NicId {
            get { return GetParameterValue<Guid?>(nameof(NicId).ToLower()); }
            set { SetParameterValue(nameof(NicId).ToLower(), value); }
        }

    }
    /// <summary>
    /// list the vm nics  IP to NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NicResponse> ListNics(ListNicsRequest request);
        Task<ListResponse<NicResponse>> ListNicsAsync(ListNicsRequest request);
        ListResponse<NicResponse> ListNicsAllPages(ListNicsRequest request);
        Task<ListResponse<NicResponse>> ListNicsAllPagesAsync(ListNicsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NicResponse> ListNics(ListNicsRequest request) => Proxy.Request<ListResponse<NicResponse>>(request);
        public Task<ListResponse<NicResponse>> ListNicsAsync(ListNicsRequest request) => Proxy.RequestAsync<ListResponse<NicResponse>>(request);
        public ListResponse<NicResponse> ListNicsAllPages(ListNicsRequest request) => Proxy.RequestAllPages<NicResponse>(request);
        public Task<ListResponse<NicResponse>> ListNicsAllPagesAsync(ListNicsRequest request) => Proxy.RequestAllPagesAsync<NicResponse>(request);
    }
}
