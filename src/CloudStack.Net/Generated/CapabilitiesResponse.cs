using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CapabilitiesResponse
    {
        /// <summary>
        /// true if regular user is allowed to create projects
        /// </summary>
        public bool Allowusercreateprojects { get; set; }

        /// <summary>
        /// true if the user can recover and expunge virtualmachines, false otherwise
        /// </summary>
        public bool AllowUserExpungeRecoverVM { get; set; }

        /// <summary>
        /// true if the user is allowed to view destroyed virtualmachines, false otherwise
        /// </summary>
        public bool AllowUserViewDestroyedVM { get; set; }

        /// <summary>
        /// time interval (in seconds) to reset api count
        /// </summary>
        public int ApiLimitInterval { get; set; }

        /// <summary>
        /// Max allowed number of api requests within the specified interval
        /// </summary>
        public int ApiLimitMax { get; set; }

        /// <summary>
        /// version of the cloud stack
        /// </summary>
        public string CloudStackVersion { get; set; }

        /// <summary>
        /// maximum size that can be specified when create disk from disk offering with custom size
        /// </summary>
        public long Customdiskofferingmaxsize { get; set; }

        /// <summary>
        /// minimum size that can be specified when create disk from disk offering with custom size
        /// </summary>
        public long Customdiskofferingminsize { get; set; }

        /// <summary>
        /// true if snapshot is supported for KVM host, false otherwise
        /// </summary>
        public bool KvmSnapshotEnabled { get; set; }

        /// <summary>
        /// If invitation confirmation is required when add account to project
        /// </summary>
        public bool ProjectInviteRequired { get; set; }

        /// <summary>
        /// true if region wide secondary is enabled, false otherwise
        /// </summary>
        public bool RegionSecondaryEnabled { get; set; }

        /// <summary>
        /// true if security groups support is enabled, false otherwise
        /// </summary>
        public bool SecurityGroupsEnabled { get; set; }

        /// <summary>
        /// true if region supports elastic load balancer on basic zones
        /// </summary>
        public string SupportELB { get; set; }

        /// <summary>
        /// true if user and domain admins can set templates to be shared, false otherwise
        /// </summary>
        public bool UserPublicTemplateEnabled { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
