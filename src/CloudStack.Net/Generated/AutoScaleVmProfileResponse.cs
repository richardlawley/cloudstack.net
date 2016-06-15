using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AutoScaleVmProfileResponse
    {
        /// <summary>
        /// the autoscale vm profile ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account owning the instance group
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the ID of the user used to launch and destroy the VMs
        /// </summary>
        public string AutoscaleUserId { get; set; }

        /// <summary>
        /// the time allowed for existing connections to get closed before a vm is destroyed
        /// </summary>
        public int? DestroyVmGraceperiod { get; set; }

        /// <summary>
        /// the domain name of the vm profile
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the vm profile
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// is profile for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// parameters other than zoneId/serviceOfferringId/templateId to be used while deploying a virtual machine
        /// </summary>
        public string OtherDeployParams { get; set; }

        /// <summary>
        /// the project name of the vm profile
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id vm profile
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the service offering to be used while deploying a virtual machine
        /// </summary>
        public string ServiceOfferingId { get; set; }

        /// <summary>
        /// the template to be used while deploying a virtual machine
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// the availability zone to be used while deploying a virtual machine
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
