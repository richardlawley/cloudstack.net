using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TemplatePermissionsResponse
    {
        /// <summary>
        /// the template ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the list of accounts the template is available for
        /// </summary>
        public IList<string> Account { get; set; }

        /// <summary>
        /// the ID of the domain to which the template belongs
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// true if this template is a public template, false otherwise
        /// </summary>
        public bool Ispublic { get; set; }

        /// <summary>
        /// the list of projects the template is available for
        /// </summary>
        public IList<string> ProjectIds { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
