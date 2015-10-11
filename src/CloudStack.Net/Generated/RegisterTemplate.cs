using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterTemplateRequest : APIRequest
    {
        public RegisterTemplateRequest() : base("registerTemplate") {}

        /// <summary>
        /// the display text of the template. This is usually used for display purposes.
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the format for the template. Possible values include QCOW2, RAW, VHD and OVA.
        /// </summary>
        public string Format {
            get { return (string) Parameters[nameof(Format).ToLower()]; }
            set { Parameters[nameof(Format).ToLower()] = value; }
        }

        /// <summary>
        /// the target hypervisor for the template
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
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
        /// the URL of where the template is hosted. Possible URL include http:// and https://
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the zone the template is to be hosted on
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional accountName. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// 32 or 64 bits support. 64 by default
        /// </summary>
        public int? Bits {
            get { return (int?) Parameters[nameof(Bits).ToLower()]; }
            set { Parameters[nameof(Bits).ToLower()] = value; }
        }

        /// <summary>
        /// the MD5 checksum value of this template
        /// </summary>
        public string Checksum {
            get { return (string) Parameters[nameof(Checksum).ToLower()]; }
            set { Parameters[nameof(Checksum).ToLower()] = value; }
        }

        /// <summary>
        /// Template details in key/value pairs.
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// true if template contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable {
            get { return (bool?) Parameters[nameof(IsDynamicallyScalable).ToLower()]; }
            set { Parameters[nameof(IsDynamicallyScalable).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template or its derivatives are extractable; default is false
        /// </summary>
        public bool? Isextractable {
            get { return (bool?) Parameters[nameof(Isextractable).ToLower()]; }
            set { Parameters[nameof(Isextractable).ToLower()] = value; }
        }

        /// <summary>
        /// true if this template is a featured template, false otherwise
        /// </summary>
        public bool? Isfeatured {
            get { return (bool?) Parameters[nameof(Isfeatured).ToLower()]; }
            set { Parameters[nameof(Isfeatured).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template is available to all accounts; default is true
        /// </summary>
        public bool? Ispublic {
            get { return (bool?) Parameters[nameof(Ispublic).ToLower()]; }
            set { Parameters[nameof(Ispublic).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template type is routing i.e., if template is used to deploy router
        /// </summary>
        public bool? Isrouting {
            get { return (bool?) Parameters[nameof(Isrouting).ToLower()]; }
            set { Parameters[nameof(Isrouting).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template supports the password reset feature; default is false
        /// </summary>
        public bool? PasswordEnabled {
            get { return (bool?) Parameters[nameof(PasswordEnabled).ToLower()]; }
            set { Parameters[nameof(PasswordEnabled).ToLower()] = value; }
        }

        /// <summary>
        /// Register template for the project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// true if this template requires HVM
        /// </summary>
        public bool? RequiresHvm {
            get { return (bool?) Parameters[nameof(RequiresHvm).ToLower()]; }
            set { Parameters[nameof(RequiresHvm).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template supports the sshkey upload feature; default is false
        /// </summary>
        public bool? SshKeyEnabled {
            get { return (bool?) Parameters[nameof(SshKeyEnabled).ToLower()]; }
            set { Parameters[nameof(SshKeyEnabled).ToLower()] = value; }
        }

        /// <summary>
        /// the tag for this template.
        /// </summary>
        public string TemplateTag {
            get { return (string) Parameters[nameof(TemplateTag).ToLower()]; }
            set { Parameters[nameof(TemplateTag).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Registers an existing template into the CloudStack cloud. 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse RegisterTemplate(RegisterTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse RegisterTemplate(RegisterTemplateRequest request) => _proxy.Request<TemplateResponse>(request);
    }
}
