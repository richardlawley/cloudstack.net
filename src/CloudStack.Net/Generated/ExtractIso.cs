using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExtractIsoRequest : APIRequest
    {
        public ExtractIsoRequest() : base("extractIso") {}

        /// <summary>
        /// the ID of the ISO file
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the mode of extraction - HTTP_DOWNLOAD or FTP_UPLOAD
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// the URL to which the ISO would be extracted
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the ID of the zone where the ISO is originally located
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Extracts an ISO
    /// </summary>
    /// <summary>
    /// Extracts an ISO
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ExtractResponse ExtractIso(ExtractIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ExtractResponse ExtractIso(ExtractIsoRequest request) => _proxy.Request<ExtractResponse>(request);
    }
}
