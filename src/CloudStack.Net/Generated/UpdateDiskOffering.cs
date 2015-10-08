using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateDiskOfferingRequest : APIRequest
    {
        public UpdateDiskOfferingRequest() : base("updateDiskOffering") {}

        /// <summary>
        /// ID of the disk offering
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, whether to display the offering to the end user or not.
        /// </summary>
        public bool? DisplayOffering { get; set; }

        /// <summary>
        /// updates alternate display text of the disk offering with this value
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// updates name of the disk offering with this value
        /// </summary>
        public string DiskOfferingName { get; set; }

        /// <summary>
        /// sort key of the disk offering, integer
        /// </summary>
        public int? SortKey { get; set; }

    }
    /// <summary>
    /// Updates a disk offering.
    /// </summary>
    /// <summary>
    /// Updates a disk offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DiskOfferingResponse UpdateDiskOffering(UpdateDiskOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DiskOfferingResponse UpdateDiskOffering(UpdateDiskOfferingRequest request) => _proxy.Request<DiskOfferingResponse>(request);
    }
}
