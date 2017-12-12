using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the account for swift
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        ///  key for the user for swift
        /// </summary>
        public string Key {
            get { return GetParameterValue<string>(nameof(Key).ToLower()); }
            set { SetParameterValue(nameof(Key).ToLower(), value); }
        }

        /// <summary>
        /// the username for swift
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds Swift.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse AddSwift(AddSwiftRequest request);
        Task<ImageStoreResponse> AddSwiftAsync(AddSwiftRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse AddSwift(AddSwiftRequest request) => Proxy.Request<ImageStoreResponse>(request);
        public Task<ImageStoreResponse> AddSwiftAsync(AddSwiftRequest request) => Proxy.RequestAsync<ImageStoreResponse>(request);
    }
}
