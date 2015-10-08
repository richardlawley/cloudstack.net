using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExtractVolumeRequest : APIRequest
    {
        public ExtractVolumeRequest() : base("extractVolume") {}

        /// <summary>
        /// the ID of the volume
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the mode of extraction - HTTP_DOWNLOAD or FTP_UPLOAD
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// the ID of the zone where the volume is located
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// the url to which the volume would be extracted
        /// </summary>
        public string Url { get; set; }

    }
    /// <summary>
    /// Extracts volume
    /// </summary>
    /// <summary>
    /// Extracts volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ExtractResponse ExtractVolume(ExtractVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ExtractResponse ExtractVolume(ExtractVolumeRequest request) => _proxy.Request<ExtractResponse>(request);
    }
}
