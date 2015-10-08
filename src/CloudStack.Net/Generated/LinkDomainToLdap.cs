using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LinkDomainToLdapRequest : APIRequest
    {
        public LinkDomainToLdapRequest() : base("linkDomainToLdap") {}

        /// <summary>
        /// Type of the account to auto import. Specify 0 for user and 2 for domain admin
        /// </summary>
        public short AccountType { get; set; }

        /// <summary>
        /// The id of the domain which has to be linked to LDAP.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// name of the group or OU in LDAP
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// type of the ldap name. GROUP or OU
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// domain admin username in LDAP 
        /// </summary>
        public string Admin { get; set; }

    }
    /// <summary>
    /// link an existing cloudstack domain to group or OU in ldap
    /// </summary>
    /// <summary>
    /// link an existing cloudstack domain to group or OU in ldap
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LinkDomainToLdapResponse LinkDomainToLdap(LinkDomainToLdapRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LinkDomainToLdapResponse LinkDomainToLdap(LinkDomainToLdapRequest request) => _proxy.Request<LinkDomainToLdapResponse>(request);
    }
}
