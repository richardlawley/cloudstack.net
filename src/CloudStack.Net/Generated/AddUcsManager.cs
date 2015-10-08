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
        public string Password { get; set; }

        /// <summary>
        /// the name of UCS url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the username of UCS
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// the Zone id for the ucs manager
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// the name of UCS manager
        /// </summary>
        public string Name { get; set; }

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
