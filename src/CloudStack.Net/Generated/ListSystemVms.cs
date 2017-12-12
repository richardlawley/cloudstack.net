using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSystemVmsRequest : APIListRequest
    {
        public ListSystemVmsRequest() : base("listSystemVms") {}

        /// <summary>
        /// the host ID of the system VM
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the system VM
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the name of the system VM
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the Pod ID of the system VM
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// the state of the system VM
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// the storage ID where vm's volumes belong to
        /// </summary>
        public Guid? StorageId {
            get { return GetParameterValue<Guid?>(nameof(StorageId).ToLower()); }
            set { SetParameterValue(nameof(StorageId).ToLower(), value); }
        }

        /// <summary>
        /// the system VM type. Possible types are "consoleproxy" and "secondarystoragevm".
        /// </summary>
        public string SystemVmType {
            get { return GetParameterValue<string>(nameof(SystemVmType).ToLower()); }
            set { SetParameterValue(nameof(SystemVmType).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID of the system VM
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List system virtual machines.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SystemVmResponse> ListSystemVms(ListSystemVmsRequest request);
        Task<ListResponse<SystemVmResponse>> ListSystemVmsAsync(ListSystemVmsRequest request);
        ListResponse<SystemVmResponse> ListSystemVmsAllPages(ListSystemVmsRequest request);
        Task<ListResponse<SystemVmResponse>> ListSystemVmsAllPagesAsync(ListSystemVmsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SystemVmResponse> ListSystemVms(ListSystemVmsRequest request) => Proxy.Request<ListResponse<SystemVmResponse>>(request);
        public Task<ListResponse<SystemVmResponse>> ListSystemVmsAsync(ListSystemVmsRequest request) => Proxy.RequestAsync<ListResponse<SystemVmResponse>>(request);
        public ListResponse<SystemVmResponse> ListSystemVmsAllPages(ListSystemVmsRequest request) => Proxy.RequestAllPages<SystemVmResponse>(request);
        public Task<ListResponse<SystemVmResponse>> ListSystemVmsAllPagesAsync(ListSystemVmsRequest request) => Proxy.RequestAllPagesAsync<SystemVmResponse>(request);
    }
}
