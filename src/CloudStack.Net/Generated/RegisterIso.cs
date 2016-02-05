using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterIsoRequest : APIRequest
    {
        public RegisterIsoRequest() : base("registerIso") {}

        /// <summary>
        /// the display text of the ISO. This is usually used for display purposes.
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the ISO
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the URL to where the ISO is currently being hosted
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the zone you wish to register the ISO to.
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional account name. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// true if this ISO is bootable. If not passed explicitly its assumed to be true
        /// </summary>
        public bool? Bootable {
            get { return (bool?) Parameters[nameof(Bootable).ToLower()]; }
            set { Parameters[nameof(Bootable).ToLower()] = value; }
        }

        /// <summary>
        /// the MD5 checksum value of this ISO
        /// </summary>
        public string Checksum {
            get { return (string) Parameters[nameof(Checksum).ToLower()]; }
            set { Parameters[nameof(Checksum).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Image store UUID
        /// </summary>
        public string ImageStoreUuid {
            get { return (string) Parameters[nameof(ImageStoreUuid).ToLower()]; }
            set { Parameters[nameof(ImageStoreUuid).ToLower()] = value; }
        }

        /// <summary>
        /// true if ISO contains XS/VMWare tools inorder to support dynamic scaling of VM CPU/memory
        /// </summary>
        public bool? IsDynamicallyScalable {
            get { return (bool?) Parameters[nameof(IsDynamicallyScalable).ToLower()]; }
            set { Parameters[nameof(IsDynamicallyScalable).ToLower()] = value; }
        }

        /// <summary>
        /// true if the ISO or its derivatives are extractable; default is false
        /// </summary>
        public bool? Isextractable {
            get { return (bool?) Parameters[nameof(Isextractable).ToLower()]; }
            set { Parameters[nameof(Isextractable).ToLower()] = value; }
        }

        /// <summary>
        /// true if you want this ISO to be featured
        /// </summary>
        public bool? Isfeatured {
            get { return (bool?) Parameters[nameof(Isfeatured).ToLower()]; }
            set { Parameters[nameof(Isfeatured).ToLower()] = value; }
        }

        /// <summary>
        /// true if you want to register the ISO to be publicly available to all users, false otherwise.
        /// </summary>
        public bool? Ispublic {
            get { return (bool?) Parameters[nameof(Ispublic).ToLower()]; }
            set { Parameters[nameof(Ispublic).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the OS type that best represents the OS of this ISO. If the ISO is bootable this parameter needs to be passed
        /// </summary>
        public Guid OsTypeId {
            get { return (Guid) Parameters[nameof(OsTypeId).ToLower()]; }
            set { Parameters[nameof(OsTypeId).ToLower()] = value; }
        }

        /// <summary>
        /// Register ISO for the project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Registers an existing ISO into the CloudStack Cloud.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse RegisterIso(RegisterIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse RegisterIso(RegisterIsoRequest request) => _proxy.Request<TemplateResponse>(request);
    }
}
