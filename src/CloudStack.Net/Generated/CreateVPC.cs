using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Cidr).ToLower()); }
            set { SetParameterValue(nameof(Cidr).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the VPC
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the name of the VPC
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the VPC offering
        /// </summary>
        public Guid Vpcofferingid {
            get { return GetParameterValue<Guid>(nameof(Vpcofferingid).ToLower()); }
            set { SetParameterValue(nameof(Vpcofferingid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the availability zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// the account associated with the VPC. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID associated with the VPC. If used with the account parameter returns the VPC associated with the account for the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the vpc to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// VPC network domain. All networks inside the VPC will belong to this domain
        /// </summary>
        public string NetworkDomain {
            get { return GetParameterValue<string>(nameof(NetworkDomain).ToLower()); }
            set { SetParameterValue(nameof(NetworkDomain).ToLower(), value); }
        }

        /// <summary>
        /// create VPC for the project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, the VPC won't start (VPC VR will not get allocated) until its first network gets implemented. True by default.
        /// </summary>
        public bool? Start {
            get { return GetParameterValue<bool?>(nameof(Start).ToLower()); }
            set { SetParameterValue(nameof(Start).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVPC(CreateVPCRequest request);
        Task<AsyncJobResponse> CreateVPCAsync(CreateVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVPC(CreateVPCRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateVPCAsync(CreateVPCRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
