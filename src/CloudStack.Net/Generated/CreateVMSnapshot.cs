using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Virtualmachineid).ToLower()]; }
            set { Parameters[nameof(Virtualmachineid).ToLower()] = value; }
        }

        /// <summary>
        /// The description of the snapshot
        /// </summary>
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// The display name of the snapshot
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// quiesce vm if true
        /// </summary>
        public bool? Quiescevm {
            get { return (bool?) Parameters[nameof(Quiescevm).ToLower()]; }
            set { Parameters[nameof(Quiescevm).ToLower()] = value; }
        }

        /// <summary>
        /// snapshot memory if true
        /// </summary>
        public bool? SnapshotMemory {
            get { return (bool?) Parameters[nameof(SnapshotMemory).ToLower()]; }
            set { Parameters[nameof(SnapshotMemory).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates snapshot for a vm.
    /// </summary>
    /// <summary>
    /// Creates snapshot for a vm.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VMSnapshotResponse CreateVMSnapshot(CreateVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VMSnapshotResponse CreateVMSnapshot(CreateVMSnapshotRequest request) => _proxy.Request<VMSnapshotResponse>(request);
    }
}
