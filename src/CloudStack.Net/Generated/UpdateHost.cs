using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateHostRequest : APIRequest
    {
        public UpdateHostRequest() : base("updateHost") {}

        /// <summary>
        /// the ID of the host to update
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Change resource state of host, valid values are [Enable, Disable]. Operation may failed if host in states not allowing Enable/Disable
        /// </summary>
        public string AllocationState {
            get { return GetParameterValue<string>(nameof(AllocationState).ToLower()); }
            set { SetParameterValue(nameof(AllocationState).ToLower(), value); }
        }

        /// <summary>
        /// list of tags to be added to the host
        /// </summary>
        public IList<string> HostTags {
            get { return GetList<string>(nameof(HostTags).ToLower()); }
            set { SetParameterValue(nameof(HostTags).ToLower(), value); }
        }

        /// <summary>
        /// the id of Os category to update the host with
        /// </summary>
        public Guid? OsCategoryId {
            get { return GetParameterValue<Guid?>(nameof(OsCategoryId).ToLower()); }
            set { SetParameterValue(nameof(OsCategoryId).ToLower(), value); }
        }

        /// <summary>
        /// the new uri for the secondary storage: nfs://host/path
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HostResponse UpdateHost(UpdateHostRequest request);
        Task<HostResponse> UpdateHostAsync(UpdateHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HostResponse UpdateHost(UpdateHostRequest request) => _proxy.Request<HostResponse>(request);
        public Task<HostResponse> UpdateHostAsync(UpdateHostRequest request) => _proxy.RequestAsync<HostResponse>(request);
    }
}
