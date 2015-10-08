using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetUploadParamsForTemplateRequest : APIRequest
    {
        public GetUploadParamsForTemplateRequest() : base("getUploadParamsForTemplate") {}

        /// <summary>
        /// the display text of the template. This is usually used for display purposes.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the format for the volume/template. Possible values include QCOW2, OVA, and VHD.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// the target hypervisor for the template
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the name of the volume/template
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the ID of the OS Type that best represents the OS of this template.
        /// </summary>
        public Guid OsTypeId { get; set; }

        /// <summary>
        /// the ID of the zone the volume/template is to be hosted on
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// an optional accountName. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 32 or 64 bits support. 64 by default
        /// </summary>
        public int? Bits { get; set; }

        /// <summary>
        /// the MD5 checksum value of this volume/template
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// Template details in key/value pairs.
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// an optional domainId. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// true if template contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable { get; set; }

        /// <summary>
        /// true if the template or its derivatives are extractable; default is false
        /// </summary>
        public bool? Extractable { get; set; }

        /// <summary>
        /// true if this template is a featured template, false otherwise
        /// </summary>
        public bool? Featured { get; set; }

        /// <summary>
        /// true if the template is available to all accounts; default is true
        /// </summary>
        public bool? PublicTemplate { get; set; }

        /// <summary>
        /// true if the template type is routing i.e., if template is used to deploy router
        /// </summary>
        public bool? IsRoutingType { get; set; }

        /// <summary>
        /// true if the template supports the password reset feature; default is false
        /// </summary>
        public bool? PasswordEnabled { get; set; }

        /// <summary>
        /// Upload volume/template for the project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// true if this template requires HVM
        /// </summary>
        public bool? RequiresHvm { get; set; }

        /// <summary>
        /// true if the template supports the sshkey upload feature; default is false
        /// </summary>
        public bool? SshKeyEnabled { get; set; }

        /// <summary>
        /// the tag for this template.
        /// </summary>
        public string TemplateTag { get; set; }

    }
    /// <summary>
    /// upload an existing template into the CloudStack cloud. 
    /// </summary>
    /// <summary>
    /// upload an existing template into the CloudStack cloud. 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GetUploadParamsResponse GetUploadParamsForTemplate(GetUploadParamsForTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GetUploadParamsResponse GetUploadParamsForTemplate(GetUploadParamsForTemplateRequest request) => _proxy.Request<GetUploadParamsResponse>(request);
    }
}
