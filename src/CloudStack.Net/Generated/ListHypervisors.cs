using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHypervisorsRequest : APIRequest
    {
        public ListHypervisorsRequest() : base("listHypervisors") {}

        /// <summary>
        /// the zone id for listing hypervisors.
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List hypervisors
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HypervisorResponse ListHypervisors(ListHypervisorsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HypervisorResponse ListHypervisors(ListHypervisorsRequest request) => _proxy.Request<HypervisorResponse>(request);
    }
}
