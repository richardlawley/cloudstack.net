using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LdapUserResponse
    {
        /// <summary>
        /// The user's domain
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// The user's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The user's firstname
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// The user's lastname
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// The user's principle
        /// </summary>
        public string Principal { get; set; }

        /// <summary>
        /// The user's username
        /// </summary>
        public string Username { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
