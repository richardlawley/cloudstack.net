using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateNetworkACLListRequest : APIRequest
    {
        public CreateNetworkACLListRequest() : base("createNetworkACLList") {}

        /// <summary>
        /// Name of the network ACL list
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// ID of the VPC associated with this network ACL list
        /// </summary>
        public Guid VpcId {
            get { return GetParameterValue<Guid>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

        /// <summary>
        /// Description of the network ACL list
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the list to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a network ACL for the given VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateNetworkACLList(CreateNetworkACLListRequest request);
        Task<AsyncJobResponse> CreateNetworkACLListAsync(CreateNetworkACLListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateNetworkACLList(CreateNetworkACLListRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateNetworkACLListAsync(CreateNetworkACLListRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
