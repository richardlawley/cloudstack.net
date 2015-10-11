using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// stratosphere ssp server url
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// the zone ID
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// stratosphere ssp api password
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// stratosphere ssp tenant uuid
        /// </summary>
        public string TenantUuid {
            get { return (string) Parameters[nameof(TenantUuid).ToLower()]; }
            set { Parameters[nameof(TenantUuid).ToLower()] = value; }
        }

        /// <summary>
        /// stratosphere ssp api username
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds stratosphere ssp server
    /// </summary>
    /// <summary>
    /// Adds stratosphere ssp server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SspResponse AddStratosphereSsp(AddStratosphereSspRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SspResponse AddStratosphereSsp(AddStratosphereSspRequest request) => _proxy.Request<SspResponse>(request);
    }
}
