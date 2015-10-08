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
        public Guid Id { get; set; }

        /// <summary>
        /// comma separated list of affinity groups id that are going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupnames parameter
        /// </summary>
        public IList<long> AffinityGroupIdList { get; set; }

        /// <summary>
        /// comma separated list of affinity groups names that are going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupids parameter
        /// </summary>
        public IList<string> AffinityGroupNameList { get; set; }

    }
    /// <summary>
    /// Updates the affinity/anti-affinity group associations of a virtual machine. The VM has to be stopped and restarted for the new properties to take effect.
    /// </summary>
    /// <summary>
    /// Updates the affinity/anti-affinity group associations of a virtual machine. The VM has to be stopped and restarted for the new properties to take effect.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse UpdateVMAffinityGroup(UpdateVMAffinityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse UpdateVMAffinityGroup(UpdateVMAffinityGroupRequest request) => _proxy.Request<UserVmResponse>(request);
    }
}
