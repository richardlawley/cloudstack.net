using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExtractIsoRequest : APIRequest
    {
        public ExtractIsoRequest() : base("extractIso") {}

        /// <summary>
        /// the ID of the ISO file
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
        /// the URL to which the ISO would be extracted
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone where the ISO is originally located
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Extracts an ISO
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ExtractIso(ExtractIsoRequest request);
        Task<AsyncJobResponse> ExtractIsoAsync(ExtractIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ExtractIso(ExtractIsoRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ExtractIsoAsync(ExtractIsoRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
