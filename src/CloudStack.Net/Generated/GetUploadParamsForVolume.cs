using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetUploadParamsForVolumeRequest : APIRequest
    {
        public GetUploadParamsForVolumeRequest() : base("getUploadParamsForVolume") {}

        /// <summary>
        /// the format for the volume/template. Possible values include QCOW2, OVA, and VHD.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// the name of the volume/template
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the ID of the zone the volume/template is to be hosted on
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// an optional accountName. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the MD5 checksum value of this volume/template
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// the ID of the disk offering. This must be a custom sized offering since during upload of volume/template size is unknown.
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
        /// Upload volume/template for the project
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Upload a data disk to the cloudstack cloud.
    /// </summary>
    /// <summary>
    /// Upload a data disk to the cloudstack cloud.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GetUploadParamsResponse GetUploadParamsForVolume(GetUploadParamsForVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GetUploadParamsResponse GetUploadParamsForVolume(GetUploadParamsForVolumeRequest request) => _proxy.Request<GetUploadParamsResponse>(request);
    }
}
