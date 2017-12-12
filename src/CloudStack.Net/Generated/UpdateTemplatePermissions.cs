using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateTemplatePermissionsRequest : APIRequest
    {
        public UpdateTemplatePermissionsRequest() : base("updateTemplatePermissions") {}

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
    /// Updates a template visibility permissions. A public template is visible to all accounts within the same domain. A private template is visible only to the owner of the template. A priviledged template is a private template with account permissions added. Only accounts specified under the template permissions are visible to them.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request);
        Task<SuccessResponse> UpdateTemplatePermissionsAsync(UpdateTemplatePermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> UpdateTemplatePermissionsAsync(UpdateTemplatePermissionsRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
