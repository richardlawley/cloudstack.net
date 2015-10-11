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
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the template
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the OS Type that best represents the OS of this template.
        /// </summary>
        public Guid OsTypeId {
            get { return (Guid) Parameters[nameof(OsTypeId).ToLower()]; }
            set { Parameters[nameof(OsTypeId).ToLower()] = value; }
        }

        /// <summary>
        /// 32 or 64 bit
        /// </summary>
        public int? Bits {
            get { return (int?) Parameters[nameof(Bits).ToLower()]; }
            set { Parameters[nameof(Bits).ToLower()] = value; }
        }

        /// <summary>
        /// Template details in key/value pairs.
        /// </summary>
        public IDictionary<string, string> Details {
            get { return (IDictionary<string, string>) Parameters[nameof(Details).ToLower()]; }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// true if template contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable {
            get { return (bool?) Parameters[nameof(IsDynamicallyScalable).ToLower()]; }
            set { Parameters[nameof(IsDynamicallyScalable).ToLower()] = value; }
        }

        /// <summary>
        /// true if this template is a featured template, false otherwise
        /// </summary>
        public bool? Isfeatured {
            get { return (bool?) Parameters[nameof(Isfeatured).ToLower()]; }
            set { Parameters[nameof(Isfeatured).ToLower()] = value; }
        }

        /// <summary>
        /// true if this template is a public template, false otherwise
        /// </summary>
        public bool? Ispublic {
            get { return (bool?) Parameters[nameof(Ispublic).ToLower()]; }
            set { Parameters[nameof(Ispublic).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template supports the password reset feature; default is false
        /// </summary>
        public bool? PasswordEnabled {
            get { return (bool?) Parameters[nameof(PasswordEnabled).ToLower()]; }
            set { Parameters[nameof(PasswordEnabled).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template requres HVM, false otherwise
        /// </summary>
        public bool? RequiresHvm {
            get { return (bool?) Parameters[nameof(RequiresHvm).ToLower()]; }
            set { Parameters[nameof(RequiresHvm).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the snapshot the template is being created from. Either this parameter, or volumeId has to be passed in
        /// </summary>
        public Guid SnapshotId {
            get { return (Guid) Parameters[nameof(SnapshotId).ToLower()]; }
            set { Parameters[nameof(SnapshotId).ToLower()] = value; }
        }

        /// <summary>
        /// the tag for this template.
        /// </summary>
        public string TemplateTag {
            get { return (string) Parameters[nameof(TemplateTag).ToLower()]; }
            set { Parameters[nameof(TemplateTag).ToLower()] = value; }
        }

        /// <summary>
        /// Optional, only for baremetal hypervisor. The directory name where template stored on CIFS server
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Optional, VM ID. If this presents, it is going to create a baremetal template for VM this ID refers to. This is only for VM whose hypervisor type is BareMetal
        /// </summary>
        public Guid Virtualmachineid {
            get { return (Guid) Parameters[nameof(Virtualmachineid).ToLower()]; }
            set { Parameters[nameof(Virtualmachineid).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the disk volume the template is being created from. Either this parameter, or snapshotId has to be passed in
        /// </summary>
        public Guid VolumeId {
            get { return (Guid) Parameters[nameof(VolumeId).ToLower()]; }
            set { Parameters[nameof(VolumeId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a template of a virtual machine. The virtual machine must be in a STOPPED state. A template created from this command is automatically designated as a private template visible to the account that created it.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTemplate(CreateTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTemplate(CreateTemplateRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
