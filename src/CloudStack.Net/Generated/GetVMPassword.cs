using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetVMPasswordRequest : APIRequest
    {
        public GetVMPasswordRequest() : base("getVMPassword") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Returns an encrypted password for the VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GetVMPasswordResponse GetVMPassword(GetVMPasswordRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GetVMPasswordResponse GetVMPassword(GetVMPasswordRequest request) => _proxy.Request<GetVMPasswordResponse>(request);
    }
}
