using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateServiceOfferingRequest : APIRequest
    {
        public UpdateServiceOfferingRequest() : base("updateServiceOffering") {}

        /// <summary>
        /// the ID of the service offering to be updated
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the display text of the service offering to be updated
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the service offering to be updated
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// sort key of the service offering, integer
        /// </summary>
        public int? SortKey {
            get { return (int?) Parameters[nameof(SortKey).ToLower()]; }
            set { Parameters[nameof(SortKey).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ServiceOfferingResponse UpdateServiceOffering(UpdateServiceOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ServiceOfferingResponse UpdateServiceOffering(UpdateServiceOfferingRequest request) => _proxy.Request<ServiceOfferingResponse>(request);
    }
}
