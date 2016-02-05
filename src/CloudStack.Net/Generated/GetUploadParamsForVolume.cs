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
        public string Format {
            get { return (string) Parameters[nameof(Format).ToLower()]; }
            set { Parameters[nameof(Format).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the volume/template
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the zone the volume/template is to be hosted on
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional accountName. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the MD5 checksum value of this volume/template
        /// </summary>
        public string Checksum {
            get { return (string) Parameters[nameof(Checksum).ToLower()]; }
            set { Parameters[nameof(Checksum).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the disk offering. This must be a custom sized offering since during upload of volume/template size is unknown.
        /// </summary>
        public Guid DiskOfferingId {
            get { return (Guid) Parameters[nameof(DiskOfferingId).ToLower()]; }
            set { Parameters[nameof(DiskOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Image store uuid
        /// </summary>
        public string ImageStoreUuid {
            get { return (string) Parameters[nameof(ImageStoreUuid).ToLower()]; }
            set { Parameters[nameof(ImageStoreUuid).ToLower()] = value; }
        }

        /// <summary>
        /// Upload volume/template for the project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
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
