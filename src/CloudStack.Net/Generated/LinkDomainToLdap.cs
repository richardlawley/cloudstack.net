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
            get { return GetParameterValue<short>(nameof(AccountType).ToLower()); }
            set { SetParameterValue(nameof(AccountType).ToLower(), value); }
        }

        /// <summary>
        /// The id of the domain which has to be linked to LDAP.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// name of the group or OU in LDAP
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// type of the ldap name. GROUP or OU
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// domain admin username in LDAP 
        /// </summary>
        public string Admin {
            get { return GetParameterValue<string>(nameof(Admin).ToLower()); }
            set { SetParameterValue(nameof(Admin).ToLower(), value); }
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
