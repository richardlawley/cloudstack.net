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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the mode of extraction - HTTP_DOWNLOAD or FTP_UPLOAD
        /// </summary>
        public string Mode {
            get { return (string) Parameters[nameof(Mode).ToLower()]; }
            set { Parameters[nameof(Mode).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the zone where the volume is located
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// the url to which the volume would be extracted
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Extracts volume
    /// </summary>
    /// <summary>
    /// Extracts volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ExtractVolume(ExtractVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ExtractVolume(ExtractVolumeRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
