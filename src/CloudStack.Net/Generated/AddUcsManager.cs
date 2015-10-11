using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// the name of UCS url
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// the username of UCS
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone id for the ucs manager
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// the name of UCS manager
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a Ucs manager
    /// </summary>
    /// <summary>
    /// Adds a Ucs manager
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UcsManagerResponse AddUcsManager(AddUcsManagerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UcsManagerResponse AddUcsManager(AddUcsManagerRequest request) => _proxy.Request<UcsManagerResponse>(request);
    }
}
