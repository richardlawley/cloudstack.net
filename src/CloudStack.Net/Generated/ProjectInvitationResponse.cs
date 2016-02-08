using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ProjectInvitationResponse
    {
        /// <summary>
        /// the id of the invitation
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account name of the project's owner
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain name where the project belongs to
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id the project belongs to
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the email the invitation was sent to
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// the name of the project
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the id of the project
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the invitation state
        /// </summary>
        public string State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
