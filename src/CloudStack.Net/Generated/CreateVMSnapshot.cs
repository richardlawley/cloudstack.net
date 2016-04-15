using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVMSnapshotRequest : APIRequest
    {
        public CreateVMSnapshotRequest() : base("createVMSnapshot") {}

        /// <summary>
        /// The ID of the vm
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// The description of the snapshot
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// The display name of the snapshot
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// quiesce vm if true
        /// </summary>
        public bool? Quiescevm {
            get { return GetParameterValue<bool?>(nameof(Quiescevm).ToLower()); }
            set { SetParameterValue(nameof(Quiescevm).ToLower(), value); }
        }

        /// <summary>
        /// snapshot memory if true
        /// </summary>
        public bool? SnapshotMemory {
            get { return GetParameterValue<bool?>(nameof(SnapshotMemory).ToLower()); }
            set { SetParameterValue(nameof(SnapshotMemory).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates snapshot for a vm.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVMSnapshot(CreateVMSnapshotRequest request);
        Task<AsyncJobResponse> CreateVMSnapshotAsync(CreateVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVMSnapshot(CreateVMSnapshotRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateVMSnapshotAsync(CreateVMSnapshotRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
