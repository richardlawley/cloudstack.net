using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the mode of extraction - HTTP_DOWNLOAD or FTP_UPLOAD
        /// </summary>
        public string Mode {
            get { return GetParameterValue<string>(nameof(Mode).ToLower()); }
            set { SetParameterValue(nameof(Mode).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone where the volume is located
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// the url to which the volume would be extracted
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

    }
    /// <summary>
    /// Extracts volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ExtractVolume(ExtractVolumeRequest request);
        Task<AsyncJobResponse> ExtractVolumeAsync(ExtractVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ExtractVolume(ExtractVolumeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ExtractVolumeAsync(ExtractVolumeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
