using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVMAffinityGroupRequest : APIRequest
    {
        public UpdateVMAffinityGroupRequest() : base("updateVMAffinityGroup") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// comma separated list of affinity groups id that are going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupnames parameter
        /// </summary>
        public IList<Guid> Affinitygroupids {
            get { return GetList<Guid>(nameof(Affinitygroupids).ToLower()); }
            set { Parameters[nameof(Affinitygroupids).ToLower()] = value; }
        }

        /// <summary>
        /// comma separated list of affinity groups names that are going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupids parameter
        /// </summary>
        public IList<string> Affinitygroupnames {
            get { return GetList<string>(nameof(Affinitygroupnames).ToLower()); }
            set { Parameters[nameof(Affinitygroupnames).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates the affinity/anti-affinity group associations of a virtual machine. The VM has to be stopped and restarted for the new properties to take effect.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateVMAffinityGroup(UpdateVMAffinityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateVMAffinityGroup(UpdateVMAffinityGroupRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
