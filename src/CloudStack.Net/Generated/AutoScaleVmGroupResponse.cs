using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AutoScaleVmGroupResponse
    {
        /// <summary>
        /// the autoscale vm group ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account owning the instance group
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain name of the vm profile
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the vm profile
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// is group for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the frequency at which the conditions have to be evaluated
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// the load balancer rule ID
        /// </summary>
        public string Lbruleid { get; set; }

        /// <summary>
        /// the maximum number of members in the vmgroup, The number of instances in the vm group will be equal to or less than this number.
        /// </summary>
        public int MaxMembers { get; set; }

        /// <summary>
        /// the minimum number of members in the vmgroup, the number of instances in the vm group will be equal to or more than this number.
        /// </summary>
        public int MinMembers { get; set; }

        /// <summary>
        /// the project name of the vm profile
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id vm profile
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// list of scaledown autoscale policies
        /// </summary>
        public IList<AutoScalePolicyResponse> ScaleDownPolicies { get; set; }

        /// <summary>
        /// list of scaleup autoscale policies
        /// </summary>
        public IList<AutoScalePolicyResponse> ScaleUpPolicies { get; set; }

        /// <summary>
        /// the current state of the AutoScale Vm Group
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the autoscale profile that contains information about the vms in the vm group.
        /// </summary>
        public string Vmprofileid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
