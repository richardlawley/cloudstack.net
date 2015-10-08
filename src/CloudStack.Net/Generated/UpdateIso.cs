using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateIsoRequest : APIRequest
    {
        public UpdateIsoRequest() : base("updateIso") {}

        /// <summary>
        /// the ID of the image file
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// true if image is bootable, false otherwise; available only for updateIso API
        /// </summary>
        public bool? Bootable { get; set; }

        /// <summary>
        /// Details in key/value pairs using format details[i].keyname=keyvalue. Example: details[0].hypervisortoolsversion=xenserver61
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// the display text of the image
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the format for the image
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// true if template/ISO contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable { get; set; }

        /// <summary>
        /// true if the template type is routing i.e., if template is used to deploy router
        /// </summary>
        public bool? IsRoutingType { get; set; }

        /// <summary>
        /// the name of the image file
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// the ID of the OS type that best represents the OS of this image.
        /// </summary>
        public Guid OsTypeId { get; set; }

        /// <summary>
        /// true if the image supports the password reset feature; default is false
        /// </summary>
        public bool? PasswordEnabled { get; set; }

        /// <summary>
        /// true if the template requres HVM, false otherwise; available only for updateTemplate API
        /// </summary>
        public bool? RequiresHvm { get; set; }

        /// <summary>
        /// sort key of the template, integer
        /// </summary>
        public int? SortKey { get; set; }

    }
    /// <summary>
    /// Updates an ISO file.
    /// </summary>
    /// <summary>
    /// Updates an ISO file.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse UpdateIso(UpdateIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse UpdateIso(UpdateIsoRequest request) => _proxy.Request<TemplateResponse>(request);
    }
}
