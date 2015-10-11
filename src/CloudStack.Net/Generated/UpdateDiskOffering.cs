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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to display the offering to the end user or not.
        /// </summary>
        public bool? DisplayOffering {
            get { return (bool?) Parameters[nameof(DisplayOffering).ToLower()]; }
            set { Parameters[nameof(DisplayOffering).ToLower()] = value; }
        }

        /// <summary>
        /// updates alternate display text of the disk offering with this value
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// updates name of the disk offering with this value
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// sort key of the disk offering, integer
        /// </summary>
        public int? SortKey {
            get { return (int?) Parameters[nameof(SortKey).ToLower()]; }
            set { Parameters[nameof(SortKey).ToLower()] = value; }
        }

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
