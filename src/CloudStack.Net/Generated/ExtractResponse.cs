using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExtractResponse
    {
        /// <summary>
        /// the id of extracted object
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account id to which the extracted object belongs
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the time and date the object was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the upload id of extracted object
        /// </summary>
        public string ExtractId { get; set; }

        /// <summary>
        /// the mode of extraction - upload or download
        /// </summary>
        public string ExtractMode { get; set; }

        /// <summary>
        /// the name of the extracted object
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the state of the extracted object
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the status of the extraction
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// type of the storage
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// the percentage of the entity uploaded to the specified location
        /// </summary>
        public int? Uploadpercentage { get; set; }

        /// <summary>
        /// if mode = upload then url of the uploaded entity. if mode = download the url from which the entity can be downloaded
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// zone ID the object was extracted from
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// zone name the object was extracted from
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
