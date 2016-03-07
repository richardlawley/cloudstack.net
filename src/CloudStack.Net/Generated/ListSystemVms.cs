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
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the system VM
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the system VM
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the Pod ID of the system VM
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// the state of the system VM
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

        /// <summary>
        /// the storage ID where vm's volumes belong to
        /// </summary>
        public Guid StorageId {
            get { return (Guid) Parameters[nameof(StorageId).ToLower()]; }
            set { Parameters[nameof(StorageId).ToLower()] = value; }
        }

        /// <summary>
        /// the system VM type. Possible types are "consoleproxy" and "secondarystoragevm".
        /// </summary>
        public string SystemVmType {
            get { return (string) Parameters[nameof(SystemVmType).ToLower()]; }
            set { Parameters[nameof(SystemVmType).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID of the system VM
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
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
        public ListResponse<SystemVmResponse> ListSystemVms(ListSystemVmsRequest request) => _proxy.Request<ListResponse<SystemVmResponse>>(request);
        public Task<ListResponse<SystemVmResponse>> ListSystemVmsAsync(ListSystemVmsRequest request) => _proxy.RequestAsync<ListResponse<SystemVmResponse>>(request);
        public ListResponse<SystemVmResponse> ListSystemVmsAllPages(ListSystemVmsRequest request) => _proxy.RequestAllPages<SystemVmResponse>(request);
        public Task<ListResponse<SystemVmResponse>> ListSystemVmsAllPagesAsync(ListSystemVmsRequest request) => _proxy.RequestAllPagesAsync<SystemVmResponse>(request);
    }
}
