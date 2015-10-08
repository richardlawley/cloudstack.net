using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTemplateRequest : APIRequest
    {
        public CreateTemplateRequest() : base("createTemplate") {}

        /// <summary>
        /// the display text of the template. This is usually used for display purposes.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the name of the template
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// the ID of the OS Type that best represents the OS of this template.
        /// </summary>
        public Guid OsTypeId { get; set; }

        /// <summary>
        /// 32 or 64 bit
        /// </summary>
        public int? Bits { get; set; }

        /// <summary>
        /// Template details in key/value pairs using format details[i].keyname=keyvalue. Example: details[0].hypervisortoolsversion=xenserver61
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// true if template contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable { get; set; }

        /// <summary>
        /// true if this template is a featured template, false otherwise
        /// </summary>
        public bool? Featured { get; set; }

        /// <summary>
        /// true if this template is a public template, false otherwise
        /// </summary>
        public bool? PublicTemplate { get; set; }

        /// <summary>
        /// true if the template supports the password reset feature; default is false
        /// </summary>
        public bool? PasswordEnabled { get; set; }

        /// <summary>
        /// create template for the project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// true if the template requres HVM, false otherwise
        /// </summary>
        public bool? RequiresHvm { get; set; }

        /// <summary>
        /// the ID of the snapshot the template is being created from. Either this parameter, or volumeId has to be passed in
        /// </summary>
        public Guid SnapshotId { get; set; }

        /// <summary>
        /// the tag for this template.
        /// </summary>
        public string TemplateTag { get; set; }

        /// <summary>
        /// Optional, only for baremetal hypervisor. The directory name where template stored on CIFS server
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Optional, VM ID. If this presents, it is going to create a baremetal template for VM this ID refers to. This is only for VM whose hypervisor type is BareMetal
        /// </summary>
        public Guid VmId { get; set; }

        /// <summary>
        /// the ID of the disk volume the template is being created from. Either this parameter, or snapshotId has to be passed in
        /// </summary>
        public Guid VolumeId { get; set; }

    }
    /// <summary>
    /// Creates a template of a virtual machine. The virtual machine must be in a STOPPED state. A template created from this command is automatically designated as a private template visible to the account that created it.
    /// </summary>
    /// <summary>
    /// Creates a template of a virtual machine. The virtual machine must be in a STOPPED state. A template created from this command is automatically designated as a private template visible to the account that created it.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse CreateTemplate(CreateTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse CreateTemplate(CreateTemplateRequest request) => _proxy.Request<TemplateResponse>(request);
    }
}
