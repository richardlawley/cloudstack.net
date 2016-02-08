using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LinkDomainToLdapResponse
    {
        /// <summary>
        /// Domain Admin accountId that is created
        /// </summary>
        public string Accountid { get; set; }

        /// <summary>
        /// Type of the account to auto import
        /// </summary>
        public short AccountType { get; set; }

        /// <summary>
        /// id of the Domain which is linked to LDAP
        /// </summary>
        public long DomainId { get; set; }

        /// <summary>
        /// name of the group or OU in LDAP which is linked to the domain
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// type of the name in LDAP which is linke to the domain
        /// </summary>
        public string Type { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
