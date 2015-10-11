using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// a comma delimited list of accounts. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<string> Accounts {
            get { return (IList<string>) Parameters[nameof(Accounts).ToLower()]; }
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
            get { return (IList<Guid>) Parameters[nameof(ProjectIds).ToLower()]; }
            set { Parameters[nameof(ProjectIds).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates iso permissions
    /// </summary>
    /// <summary>
    /// Updates iso permissions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateIsoPermissions(UpdateIsoPermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateIsoPermissions(UpdateIsoPermissionsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
