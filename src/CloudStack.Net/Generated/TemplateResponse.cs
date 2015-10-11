using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TemplateResponse
    {
        /// <summary>
        /// the template ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account name to which the template belongs
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the account id to which the template belongs
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// true if the ISO is bootable, false otherwise
        /// </summary>
        public bool Bootable { get; set; }

        /// <summary>
        /// checksum of the template
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// the date this template was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// true if the template is managed across all Zones, false otherwise
        /// </summary>
        public bool CrossZones { get; set; }

        /// <summary>
        /// additional key/value details tied with template
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// the template display text
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the name of the domain to which the template belongs
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain to which the template belongs
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the format of the template.
        /// </summary>
        public ImageFormat Format { get; set; }

        /// <summary>
        /// the ID of the secondary storage host for the template
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// the name of the secondary storage host for the template
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the hypervisor on which the template runs
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// true if template contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool IsDynamicallyScalable { get; set; }

        /// <summary>
        /// true if the template is extractable, false otherwise
        /// </summary>
        public bool Isextractable { get; set; }

        /// <summary>
        /// true if this template is a featured template, false otherwise
        /// </summary>
        public bool Isfeatured { get; set; }

        /// <summary>
        /// true if this template is a public template, false otherwise
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// true if the template is ready to be deployed from, false otherwise.
        /// </summary>
        public bool IsReady { get; set; }

        /// <summary>
        /// the template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the ID of the OS type for this template.
        /// </summary>
        public string OsTypeId { get; set; }

        /// <summary>
        /// the name of the OS type for this template.
        /// </summary>
        public string OsTypeName { get; set; }

        /// <summary>
        /// true if the reset password feature is enabled, false otherwise
        /// </summary>
        public bool PasswordEnabled { get; set; }

        /// <summary>
        /// the project name of the template
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the template
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the date this template was removed
        /// </summary>
        public DateTime Removed { get; set; }

        /// <summary>
        /// the size of the template
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// the template ID of the parent template if present
        /// </summary>
        public string SourcetemplateId { get; set; }

        /// <summary>
        /// true if template is sshkey enabled, false otherwise
        /// </summary>
        public bool SshKeyEnabled { get; set; }

        /// <summary>
        /// the status of the template
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// the tag of this template
        /// </summary>
        public string TemplateTag { get; set; }

        /// <summary>
        /// the type of the template
        /// </summary>
        public string TemplateType { get; set; }

        /// <summary>
        /// the ID of the zone for this template
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the name of the zone for this template
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// the list of resource tags associated with tempate
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
