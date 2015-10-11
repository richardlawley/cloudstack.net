using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddSwiftRequest : APIRequest
    {
        public AddSwiftRequest() : base("addSwift") {}

        /// <summary>
        /// the URL for swift
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// the account for swift
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        ///  key for the user for swift
        /// </summary>
        public string Key {
            get { return (string) Parameters[nameof(Key).ToLower()]; }
            set { Parameters[nameof(Key).ToLower()] = value; }
        }

        /// <summary>
        /// the username for swift
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds Swift.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse AddSwift(AddSwiftRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse AddSwift(AddSwiftRequest request) => _proxy.Request<ImageStoreResponse>(request);
    }
}
