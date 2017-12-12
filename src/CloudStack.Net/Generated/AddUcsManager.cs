using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddUcsManagerRequest : APIRequest
    {
        public AddUcsManagerRequest() : base("addUcsManager") {}

        /// <summary>
        /// the password of UCS
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the name of UCS url
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the username of UCS
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// the Zone id for the ucs manager
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// the name of UCS manager
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a Ucs manager
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UcsManagerResponse AddUcsManager(AddUcsManagerRequest request);
        Task<UcsManagerResponse> AddUcsManagerAsync(AddUcsManagerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UcsManagerResponse AddUcsManager(AddUcsManagerRequest request) => Proxy.Request<UcsManagerResponse>(request);
        public Task<UcsManagerResponse> AddUcsManagerAsync(AddUcsManagerRequest request) => Proxy.RequestAsync<UcsManagerResponse>(request);
    }
}
