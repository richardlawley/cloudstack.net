using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVPCRequest : APIRequest
    {
        public CreateVPCRequest() : base("createVPC") {}

        /// <summary>
        /// the cidr of the VPC. All VPC guest networks' cidrs should be within this CIDR
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// the display text of the VPC
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the name of the VPC
        /// </summary>
        public string VpcName { get; set; }

        /// <summary>
        /// the ID of the VPC offering
        /// </summary>
        public Guid VpcOffering { get; set; }

        /// <summary>
        /// the ID of the availability zone
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// the account associated with the VPC. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the domain ID associated with the VPC. If used with the account parameter returns the VPC associated with the account for the specified domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the vpc to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// VPC network domain. All networks inside the VPC will belong to this domain
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// create VPC for the project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// If set to false, the VPC won't start (VPC VR will not get allocated) until its first network gets implemented. True by default.
        /// </summary>
        public bool? Start { get; set; }

    }
    /// <summary>
    /// Creates a VPC
    /// </summary>
    /// <summary>
    /// Creates a VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VpcResponse CreateVPC(CreateVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VpcResponse CreateVPC(CreateVPCRequest request) => _proxy.Request<VpcResponse>(request);
    }
}
