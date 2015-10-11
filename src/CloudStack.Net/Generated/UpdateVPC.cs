using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVPCRequest : APIRequest
    {
        public UpdateVPCRequest() : base("updateVPC") {}

        /// <summary>
        /// the id of the VPC
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// the display text of the VPC
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the vpc to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the VPC
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a VPC
    /// </summary>
    /// <summary>
    /// Updates a VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateVPC(UpdateVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateVPC(UpdateVPCRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
