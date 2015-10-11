using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// a comma delimited list of accounts. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<string> Accounts {
            get { return GetList<string>(nameof(Accounts).ToLower()); }
            set { Parameters[nameof(Accounts).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template/iso is extractable, false other wise. Can be set only by root admin
        /// </summary>
        public bool? IsExtractable {
            get { return (bool?) Parameters[nameof(IsExtractable).ToLower()]; }
            set { Parameters[nameof(IsExtractable).ToLower()] = value; }
        }

        /// <summary>
        /// true for featured template/iso, false otherwise
        /// </summary>
        public bool? Isfeatured {
            get { return (bool?) Parameters[nameof(Isfeatured).ToLower()]; }
            set { Parameters[nameof(Isfeatured).ToLower()] = value; }
        }

        /// <summary>
        /// true for public template/iso, false for private templates/isos
        /// </summary>
        public bool? IsPublic {
            get { return (bool?) Parameters[nameof(IsPublic).ToLower()]; }
            set { Parameters[nameof(IsPublic).ToLower()] = value; }
        }

        /// <summary>
        /// permission operator (add, remove, reset)
        /// </summary>
        public string Op {
            get { return (string) Parameters[nameof(Op).ToLower()]; }
            set { Parameters[nameof(Op).ToLower()] = value; }
        }

        /// <summary>
        /// a comma delimited list of projects. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<Guid> ProjectIds {
            get { return GetList<Guid>(nameof(ProjectIds).ToLower()); }
            set { Parameters[nameof(ProjectIds).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a template visibility permissions. A public template is visible to all accounts within the same domain. A private template is visible only to the owner of the template. A priviledged template is a private template with account permissions added. Only accounts specified under the template permissions are visible to them.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
