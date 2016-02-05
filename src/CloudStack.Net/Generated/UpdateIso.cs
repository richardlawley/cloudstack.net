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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// true if image is bootable, false otherwise; available only for updateIso API
        /// </summary>
        public bool? Bootable {
            get { return (bool?) Parameters[nameof(Bootable).ToLower()]; }
            set { Parameters[nameof(Bootable).ToLower()] = value; }
        }

        /// <summary>
        /// Details in key/value pairs using format details[i].keyname=keyvalue. Example: details[0].hypervisortoolsversion=xenserver61
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// the display text of the image
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the format for the image
        /// </summary>
        public string Format {
            get { return (string) Parameters[nameof(Format).ToLower()]; }
            set { Parameters[nameof(Format).ToLower()] = value; }
        }

        /// <summary>
        /// true if template/ISO contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable {
            get { return (bool?) Parameters[nameof(IsDynamicallyScalable).ToLower()]; }
            set { Parameters[nameof(IsDynamicallyScalable).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template type is routing i.e., if template is used to deploy router
        /// </summary>
        public bool? Isrouting {
            get { return (bool?) Parameters[nameof(Isrouting).ToLower()]; }
            set { Parameters[nameof(Isrouting).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the image file
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the OS type that best represents the OS of this image.
        /// </summary>
        public Guid OsTypeId {
            get { return (Guid) Parameters[nameof(OsTypeId).ToLower()]; }
            set { Parameters[nameof(OsTypeId).ToLower()] = value; }
        }

        /// <summary>
        /// true if the image supports the password reset feature; default is false
        /// </summary>
        public bool? PasswordEnabled {
            get { return (bool?) Parameters[nameof(PasswordEnabled).ToLower()]; }
            set { Parameters[nameof(PasswordEnabled).ToLower()] = value; }
        }

        /// <summary>
        /// true if the template requres HVM, false otherwise; available only for updateTemplate API
        /// </summary>
        public bool? RequiresHvm {
            get { return (bool?) Parameters[nameof(RequiresHvm).ToLower()]; }
            set { Parameters[nameof(RequiresHvm).ToLower()] = value; }
        }

        /// <summary>
        /// sort key of the template, integer
        /// </summary>
        public int? SortKey {
            get { return (int?) Parameters[nameof(SortKey).ToLower()]; }
            set { Parameters[nameof(SortKey).ToLower()] = value; }
        }

    }
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
