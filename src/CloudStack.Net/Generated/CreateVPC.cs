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
        public string Cidr {
            get { return (string) Parameters[nameof(Cidr).ToLower()]; }
            set { Parameters[nameof(Cidr).ToLower()] = value; }
        }

        /// <summary>
        /// the display text of the VPC
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the VPC
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the VPC offering
        /// </summary>
        public Guid Vpcofferingid {
            get { return (Guid) Parameters[nameof(Vpcofferingid).ToLower()]; }
            set { Parameters[nameof(Vpcofferingid).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the availability zone
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// the account associated with the VPC. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the domain ID associated with the VPC. If used with the account parameter returns the VPC associated with the account for the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the vpc to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// VPC network domain. All networks inside the VPC will belong to this domain
        /// </summary>
        public string NetworkDomain {
            get { return (string) Parameters[nameof(NetworkDomain).ToLower()]; }
            set { Parameters[nameof(NetworkDomain).ToLower()] = value; }
        }

        /// <summary>
        /// create VPC for the project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, the VPC won't start (VPC VR will not get allocated) until its first network gets implemented. True by default.
        /// </summary>
        public bool? Start {
            get { return (bool?) Parameters[nameof(Start).ToLower()]; }
            set { Parameters[nameof(Start).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a VPC
    /// </summary>
    /// <summary>
    /// Creates a VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVPC(CreateVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVPC(CreateVPCRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
