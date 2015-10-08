using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssociateIpAddressRequest : APIRequest
    {
        public AssociateIpAddressRequest() : base("associateIpAddress") {}

        /// <summary>
        /// the account to associate with this IP address
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the ID of the domain to associate with this IP address
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the IP to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// should be set to true if public IP is required to be transferable across zones, if not specified defaults to false
        /// </summary>
        public bool? IsPortable { get; set; }

        /// <summary>
        /// The network this IP address should be associated to.
        /// </summary>
        public Guid NetworkId { get; set; }

        /// <summary>
        /// Deploy VM for the project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// region ID from where portable IP is to be associated.
        /// </summary>
        public int? RegionId { get; set; }

        /// <summary>
        /// the VPC you want the IP address to be associated with
        /// </summary>
        public Guid VpcId { get; set; }

        /// <summary>
        /// the ID of the availability zone you want to acquire an public IP address from
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Acquires and associates a public IP to an account.
    /// </summary>
    /// <summary>
    /// Acquires and associates a public IP to an account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        IPAddressResponse AssociateIpAddress(AssociateIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public IPAddressResponse AssociateIpAddress(AssociateIpAddressRequest request) => _proxy.Request<IPAddressResponse>(request);
    }
}
