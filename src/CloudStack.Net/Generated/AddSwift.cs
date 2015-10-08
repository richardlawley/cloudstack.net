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
        public string Url { get; set; }

        /// <summary>
        /// the account for swift
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        ///  key for the user for swift
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// the username for swift
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds Swift.
    /// </summary>
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
