using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddStratosphereSspRequest : APIRequest
    {
        public AddStratosphereSspRequest() : base("addStratosphereSsp") {}

        /// <summary>
        /// stratosphere ssp api name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// stratosphere ssp server url
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the zone ID
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// stratosphere ssp api password
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// stratosphere ssp tenant uuid
        /// </summary>
        public string TenantUuid {
            get { return GetParameterValue<string>(nameof(TenantUuid).ToLower()); }
            set { SetParameterValue(nameof(TenantUuid).ToLower(), value); }
        }

        /// <summary>
        /// stratosphere ssp api username
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds stratosphere ssp server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SspResponse AddStratosphereSsp(AddStratosphereSspRequest request);
        Task<SspResponse> AddStratosphereSspAsync(AddStratosphereSspRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SspResponse AddStratosphereSsp(AddStratosphereSspRequest request) => Proxy.Request<SspResponse>(request);
        public Task<SspResponse> AddStratosphereSspAsync(AddStratosphereSspRequest request) => Proxy.RequestAsync<SspResponse>(request);
    }
}
