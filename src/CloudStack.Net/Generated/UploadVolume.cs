using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UploadVolumeRequest : APIRequest
    {
        public UploadVolumeRequest() : base("uploadVolume") {}

        /// <summary>
        /// the format for the volume. Possible values include QCOW2, OVA, and VHD.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// the name of the volume
        /// </summary>
        public string VolumeName { get; set; }

        /// <summary>
        /// the URL of where the volume is hosted. Possible URL include http:// and https://
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the ID of the zone the volume is to be hosted on
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// an optional accountName. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the MD5 checksum value of this volume
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// the ID of the disk offering. This must be a custom sized offering since during uploadVolume volume size is unknown.
        /// </summary>
        public Guid DiskOfferingId { get; set; }

        /// <summary>
        /// an optional domainId. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Image store uuid
        /// </summary>
        public string ImageStoreUuid { get; set; }

        /// <summary>
        /// Upload volume for the project
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Uploads a data disk.
    /// </summary>
    /// <summary>
    /// Uploads a data disk.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VolumeResponse UploadVolume(UploadVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VolumeResponse UploadVolume(UploadVolumeRequest request) => _proxy.Request<VolumeResponse>(request);
    }
}
