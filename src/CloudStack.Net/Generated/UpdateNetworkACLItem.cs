using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateNetworkACLItemRequest : APIRequest
    {
        public UpdateNetworkACLItemRequest() : base("updateNetworkACLItem") {}

        /// <summary>
        /// the ID of the network ACL item
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// scl entry action, allow or deny
        /// </summary>
        public string Action {
            get { return (string) Parameters[nameof(Action).ToLower()]; }
            set { Parameters[nameof(Action).ToLower()] = value; }
        }

        /// <summary>
        /// the cidr list to allow traffic from/to
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { Parameters[nameof(Cidrlist).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// the ending port of ACL
        /// </summary>
        public int? Endport {
            get { return (int?) Parameters[nameof(Endport).ToLower()]; }
            set { Parameters[nameof(Endport).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// error code for this ICMP message
        /// </summary>
        public int? IcmpCode {
            get { return (int?) Parameters[nameof(IcmpCode).ToLower()]; }
            set { Parameters[nameof(IcmpCode).ToLower()] = value; }
        }

        /// <summary>
        /// type of the ICMP message being sent
        /// </summary>
        public int? IcmpType {
            get { return (int?) Parameters[nameof(IcmpType).ToLower()]; }
            set { Parameters[nameof(IcmpType).ToLower()] = value; }
        }

        /// <summary>
        /// The network of the vm the ACL will be created for
        /// </summary>
        public int? Number {
            get { return (int?) Parameters[nameof(Number).ToLower()]; }
            set { Parameters[nameof(Number).ToLower()] = value; }
        }

        /// <summary>
        /// the protocol for the ACL rule. Valid values are TCP/UDP/ICMP/ALL or valid protocol number
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// the starting port of ACL
        /// </summary>
        public int? Startport {
            get { return (int?) Parameters[nameof(Startport).ToLower()]; }
            set { Parameters[nameof(Startport).ToLower()] = value; }
        }

        /// <summary>
        /// the traffic type for the ACL,can be Ingress or Egress, defaulted to Ingress if not specified
        /// </summary>
        public string TrafficType {
            get { return (string) Parameters[nameof(TrafficType).ToLower()]; }
            set { Parameters[nameof(TrafficType).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates ACL item with specified ID
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateNetworkACLItem(UpdateNetworkACLItemRequest request);
        Task<AsyncJobResponse> UpdateNetworkACLItemAsync(UpdateNetworkACLItemRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateNetworkACLItem(UpdateNetworkACLItemRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateNetworkACLItemAsync(UpdateNetworkACLItemRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
