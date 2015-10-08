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
        public Guid BladeId { get; set; }

        /// <summary>
        /// profile dn
        /// </summary>
        public string ProfileDn { get; set; }

        /// <summary>
        /// ucs manager id
        /// </summary>
        public Guid UcsManagerId { get; set; }

    }
    /// <summary>
    /// associate a profile to a blade
    /// </summary>
    /// <summary>
    /// associate a profile to a blade
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UcsBladeResponse AssociateUcsProfileToBlade(AssociateUcsProfileToBladeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UcsBladeResponse AssociateUcsProfileToBlade(AssociateUcsProfileToBladeRequest request) => _proxy.Request<UcsBladeResponse>(request);
    }
}
