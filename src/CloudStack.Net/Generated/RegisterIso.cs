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
        public string DisplayText { get; set; }

        /// <summary>
        /// the name of the ISO
        /// </summary>
        public string IsoName { get; set; }

        /// <summary>
        /// the URL to where the ISO is currently being hosted
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the ID of the zone you wish to register the ISO to.
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// an optional account name. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// true if this ISO is bootable. If not passed explicitly its assumed to be true
        /// </summary>
        public bool? Bootable { get; set; }

        /// <summary>
        /// the MD5 checksum value of this ISO
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// an optional domainId. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Image store UUID
        /// </summary>
        public string ImageStoreUuid { get; set; }

        /// <summary>
        /// true if ISO contains XS/VMWare tools inorder to support dynamic scaling of VM CPU/memory
        /// </summary>
        public bool? IsDynamicallyScalable { get; set; }

        /// <summary>
        /// true if the ISO or its derivatives are extractable; default is false
        /// </summary>
        public bool? Extractable { get; set; }

        /// <summary>
        /// true if you want this ISO to be featured
        /// </summary>
        public bool? Featured { get; set; }

        /// <summary>
        /// true if you want to register the ISO to be publicly available to all users, false otherwise.
        /// </summary>
        public bool? PublicIso { get; set; }

        /// <summary>
        /// the ID of the OS type that best represents the OS of this ISO. If the ISO is bootable this parameter needs to be passed
        /// </summary>
        public Guid OsTypeId { get; set; }

        /// <summary>
        /// Register ISO for the project
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Registers an existing ISO into the CloudStack Cloud.
    /// </summary>
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
