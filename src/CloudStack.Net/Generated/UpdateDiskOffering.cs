using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to display the offering to the end user or not.
        /// </summary>
        public bool? DisplayOffering {
            get { return GetParameterValue<bool?>(nameof(DisplayOffering).ToLower()); }
            set { SetParameterValue(nameof(DisplayOffering).ToLower(), value); }
        }

        /// <summary>
        /// updates alternate display text of the disk offering with this value
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// updates name of the disk offering with this value
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// sort key of the disk offering, integer
        /// </summary>
        public int? SortKey {
            get { return GetParameterValue<int?>(nameof(SortKey).ToLower()); }
            set { SetParameterValue(nameof(SortKey).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a disk offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DiskOfferingResponse UpdateDiskOffering(UpdateDiskOfferingRequest request);
        Task<DiskOfferingResponse> UpdateDiskOfferingAsync(UpdateDiskOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DiskOfferingResponse UpdateDiskOffering(UpdateDiskOfferingRequest request) => _proxy.Request<DiskOfferingResponse>(request);
        public Task<DiskOfferingResponse> UpdateDiskOfferingAsync(UpdateDiskOfferingRequest request) => _proxy.RequestAsync<DiskOfferingResponse>(request);
    }
}
