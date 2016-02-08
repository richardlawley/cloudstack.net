using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssociateIpAddressRequest : APIRequest
    {
        public AssociateIpAddressRequest() : base("associateIpAddress") {}

        /// <summary>
        /// the account to associate with this IP address
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the domain to associate with this IP address
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the IP to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// should be set to true if public IP is required to be transferable across zones, if not specified defaults to false
        /// </summary>
        public bool? IsPortable {
            get { return (bool?) Parameters[nameof(IsPortable).ToLower()]; }
            set { Parameters[nameof(IsPortable).ToLower()] = value; }
        }

        /// <summary>
        /// The network this IP address should be associated to.
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// Deploy VM for the project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// region ID from where portable IP is to be associated.
        /// </summary>
        public int? RegionId {
            get { return (int?) Parameters[nameof(RegionId).ToLower()]; }
            set { Parameters[nameof(RegionId).ToLower()] = value; }
        }

        /// <summary>
        /// the VPC you want the IP address to be associated with
        /// </summary>
        public Guid VpcId {
            get { return (Guid) Parameters[nameof(VpcId).ToLower()]; }
            set { Parameters[nameof(VpcId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the availability zone you want to acquire an public IP address from
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Acquires and associates a public IP to an account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AssociateIpAddress(AssociateIpAddressRequest request);
        Task<AsyncJobResponse> AssociateIpAddressAsync(AssociateIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AssociateIpAddress(AssociateIpAddressRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AssociateIpAddressAsync(AssociateIpAddressRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
