using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVPCOfferingRequest : APIRequest
    {
        public UpdateVPCOfferingRequest() : base("updateVPCOffering") {}

        /// <summary>
        /// the id of the VPC offering
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the display text of the VPC offering
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the name of the VPC offering
        /// </summary>
        public string VpcOffName { get; set; }

        /// <summary>
        /// update state for the VPC offering; supported states - Enabled/Disabled
        /// </summary>
        public string State { get; set; }

    }
    /// <summary>
    /// Updates VPC offering
    /// </summary>
    /// <summary>
    /// Updates VPC offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VpcOfferingResponse UpdateVPCOffering(UpdateVPCOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VpcOfferingResponse UpdateVPCOffering(UpdateVPCOfferingRequest request) => _proxy.Request<VpcOfferingResponse>(request);
    }
}
