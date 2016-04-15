using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssociateUcsProfileToBladeRequest : APIRequest
    {
        public AssociateUcsProfileToBladeRequest() : base("associateUcsProfileToBlade") {}

        /// <summary>
        /// blade id
        /// </summary>
        public Guid BladeId {
            get { return GetParameterValue<Guid>(nameof(BladeId).ToLower()); }
            set { SetParameterValue(nameof(BladeId).ToLower(), value); }
        }

        /// <summary>
        /// profile dn
        /// </summary>
        public string ProfileDn {
            get { return GetParameterValue<string>(nameof(ProfileDn).ToLower()); }
            set { SetParameterValue(nameof(ProfileDn).ToLower(), value); }
        }

        /// <summary>
        /// ucs manager id
        /// </summary>
        public Guid UcsManagerId {
            get { return GetParameterValue<Guid>(nameof(UcsManagerId).ToLower()); }
            set { SetParameterValue(nameof(UcsManagerId).ToLower(), value); }
        }

    }
    /// <summary>
    /// associate a profile to a blade
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AssociateUcsProfileToBlade(AssociateUcsProfileToBladeRequest request);
        Task<AsyncJobResponse> AssociateUcsProfileToBladeAsync(AssociateUcsProfileToBladeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AssociateUcsProfileToBlade(AssociateUcsProfileToBladeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AssociateUcsProfileToBladeAsync(AssociateUcsProfileToBladeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
