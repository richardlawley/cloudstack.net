using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateNetworkACLRequest : APIRequest
    {
        public CreateNetworkACLRequest() : base("createNetworkACL") {}

        /// <summary>
        /// the protocol for the ACL rule. Valid values are TCP/UDP/ICMP/ALL or valid protocol number
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// The network of the VM the ACL will be created for
        /// </summary>
        public Guid AclId {
            get { return GetParameterValue<Guid>(nameof(AclId).ToLower()); }
            set { SetParameterValue(nameof(AclId).ToLower(), value); }
        }

        /// <summary>
        /// scl entry action, allow or deny
        /// </summary>
        public string Action {
            get { return GetParameterValue<string>(nameof(Action).ToLower()); }
            set { SetParameterValue(nameof(Action).ToLower(), value); }
        }

        /// <summary>
        /// the CIDR list to allow traffic from/to
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { SetParameterValue(nameof(Cidrlist).ToLower(), value); }
        }

        /// <summary>
        /// the ending port of ACL
        /// </summary>
        public int? Endport {
            get { return GetParameterValue<int?>(nameof(Endport).ToLower()); }
            set { SetParameterValue(nameof(Endport).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// error code for this ICMP message
        /// </summary>
        public int? IcmpCode {
            get { return GetParameterValue<int?>(nameof(IcmpCode).ToLower()); }
            set { SetParameterValue(nameof(IcmpCode).ToLower(), value); }
        }

        /// <summary>
        /// type of the ICMP message being sent
        /// </summary>
        public int? IcmpType {
            get { return GetParameterValue<int?>(nameof(IcmpType).ToLower()); }
            set { SetParameterValue(nameof(IcmpType).ToLower(), value); }
        }

        /// <summary>
        /// The network of the VM the ACL will be created for
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// The network of the VM the ACL will be created for
        /// </summary>
        public int? Number {
            get { return GetParameterValue<int?>(nameof(Number).ToLower()); }
            set { SetParameterValue(nameof(Number).ToLower(), value); }
        }

        /// <summary>
        /// the starting port of ACL
        /// </summary>
        public int? Startport {
            get { return GetParameterValue<int?>(nameof(Startport).ToLower()); }
            set { SetParameterValue(nameof(Startport).ToLower(), value); }
        }

        /// <summary>
        /// the traffic type for the ACL,can be ingress or egress, defaulted to ingress if not specified
        /// </summary>
        public string TrafficType {
            get { return GetParameterValue<string>(nameof(TrafficType).ToLower()); }
            set { SetParameterValue(nameof(TrafficType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a ACL rule in the given network (the network has to belong to VPC)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateNetworkACL(CreateNetworkACLRequest request);
        Task<AsyncJobResponse> CreateNetworkACLAsync(CreateNetworkACLRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateNetworkACL(CreateNetworkACLRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateNetworkACLAsync(CreateNetworkACLRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
