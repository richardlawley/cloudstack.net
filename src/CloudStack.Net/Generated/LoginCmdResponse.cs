using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LoginCmdResponse
    {
        /// <summary>
        /// the account name the user belongs to
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Domain ID that the user belongs to
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// first name of the user
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// last name of the user
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Is user registered
        /// </summary>
        public string Registered { get; set; }

        /// <summary>
        /// Session key that can be passed in subsequent Query command calls
        /// </summary>
        public string SessionKey { get; set; }

        /// <summary>
        /// the time period before the session has expired
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// user time zone
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// the account type (admin, domain-admin, read-only-admin, user)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
