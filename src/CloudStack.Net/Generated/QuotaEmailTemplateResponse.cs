using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaEmailTemplateResponse
    {
        /// <summary>
        /// Last date/time when template was updated
        /// </summary>
        public DateTime Last_updated { get; set; }

        /// <summary>
        /// The quota email template locale
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// The quota email template content
        /// </summary>
        public string Templatebody { get; set; }

        /// <summary>
        /// The quota email template subject
        /// </summary>
        public string TemplateSubject { get; set; }

        /// <summary>
        /// Template type
        /// </summary>
        public string TemplateType { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
