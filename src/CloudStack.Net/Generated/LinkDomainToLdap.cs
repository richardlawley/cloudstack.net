using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LinkDomainToLdapRequest : APIRequest
    {
        public LinkDomainToLdapRequest() : base("linkDomainToLdap") {}

        /// <summary>
        /// Type of the account to auto import. Specify 0 for user and 2 for domain admin
        /// </summary>
        public short AccountType {
            get { return (short) Parameters[nameof(AccountType).ToLower()]; }
            set { Parameters[nameof(AccountType).ToLower()] = value; }
        }

        /// <summary>
        /// The id of the domain which has to be linked to LDAP.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// name of the group or OU in LDAP
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// type of the ldap name. GROUP or OU
        /// </summary>
        public string Type {
            get { return (string) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

        /// <summary>
        /// domain admin username in LDAP 
        /// </summary>
        public string Admin {
            get { return (string) Parameters[nameof(Admin).ToLower()]; }
            set { Parameters[nameof(Admin).ToLower()] = value; }
        }

    }
    /// <summary>
    /// link an existing cloudstack domain to group or OU in ldap
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LinkDomainToLdapResponse LinkDomainToLdap(LinkDomainToLdapRequest request);
        Task<LinkDomainToLdapResponse> LinkDomainToLdapAsync(LinkDomainToLdapRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LinkDomainToLdapResponse LinkDomainToLdap(LinkDomainToLdapRequest request) => _proxy.Request<LinkDomainToLdapResponse>(request);
        public Task<LinkDomainToLdapResponse> LinkDomainToLdapAsync(LinkDomainToLdapRequest request) => _proxy.RequestAsync<LinkDomainToLdapResponse>(request);
    }
}
