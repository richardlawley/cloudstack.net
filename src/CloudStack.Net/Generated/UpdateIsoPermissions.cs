using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateIsoPermissionsRequest : APIRequest
    {
        public UpdateIsoPermissionsRequest() : base("updateIsoPermissions") {}

        /// <summary>
        /// the template ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// a comma delimited list of accounts. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<string> Accounts {
            get { return GetList<string>(nameof(Accounts).ToLower()); }
            set { SetParameterValue(nameof(Accounts).ToLower(), value); }
        }

        /// <summary>
        /// true if the template/iso is extractable, false other wise. Can be set only by root admin
        /// </summary>
        public bool? IsExtractable {
            get { return GetParameterValue<bool?>(nameof(IsExtractable).ToLower()); }
            set { SetParameterValue(nameof(IsExtractable).ToLower(), value); }
        }

        /// <summary>
        /// true for featured template/iso, false otherwise
        /// </summary>
        public bool? Isfeatured {
            get { return GetParameterValue<bool?>(nameof(Isfeatured).ToLower()); }
            set { SetParameterValue(nameof(Isfeatured).ToLower(), value); }
        }

        /// <summary>
        /// true for public template/iso, false for private templates/isos
        /// </summary>
        public bool? IsPublic {
            get { return GetParameterValue<bool?>(nameof(IsPublic).ToLower()); }
            set { SetParameterValue(nameof(IsPublic).ToLower(), value); }
        }

        /// <summary>
        /// permission operator (add, remove, reset)
        /// </summary>
        public string Op {
            get { return GetParameterValue<string>(nameof(Op).ToLower()); }
            set { SetParameterValue(nameof(Op).ToLower(), value); }
        }

        /// <summary>
        /// a comma delimited list of projects. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<Guid> ProjectIds {
            get { return GetList<Guid>(nameof(ProjectIds).ToLower()); }
            set { SetParameterValue(nameof(ProjectIds).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates ISO permissions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateIsoPermissions(UpdateIsoPermissionsRequest request);
        Task<SuccessResponse> UpdateIsoPermissionsAsync(UpdateIsoPermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateIsoPermissions(UpdateIsoPermissionsRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> UpdateIsoPermissionsAsync(UpdateIsoPermissionsRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
