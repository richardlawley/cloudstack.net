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
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// the display text of the VPC
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// an optional field, whether to the display the vpc to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the name of the VPC
        /// </summary>
        public string VpcName { get; set; }

    }
    /// <summary>
    /// Updates a VPC
    /// </summary>
    /// <summary>
    /// Updates a VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VpcResponse UpdateVPC(UpdateVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VpcResponse UpdateVPC(UpdateVPCRequest request) => _proxy.Request<VpcResponse>(request);
    }
}
