using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(BladeId).ToLower()]; }
            set { Parameters[nameof(BladeId).ToLower()] = value; }
        }

        /// <summary>
        /// profile dn
        /// </summary>
        public string ProfileDn {
            get { return (string) Parameters[nameof(ProfileDn).ToLower()]; }
            set { Parameters[nameof(ProfileDn).ToLower()] = value; }
        }

        /// <summary>
        /// ucs manager id
        /// </summary>
        public Guid UcsManagerId {
            get { return (Guid) Parameters[nameof(UcsManagerId).ToLower()]; }
            set { Parameters[nameof(UcsManagerId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// associate a profile to a blade
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AssociateUcsProfileToBlade(AssociateUcsProfileToBladeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AssociateUcsProfileToBlade(AssociateUcsProfileToBladeRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
