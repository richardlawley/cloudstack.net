using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListIsosRequest : APIListRequest
    {
        public ListIsosRequest() : base("listIsos") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// true if the ISO is bootable, false otherwise
        /// </summary>
        public bool? Bootable {
            get { return GetParameterValue<bool?>(nameof(Bootable).ToLower()); }
            set { SetParameterValue(nameof(Bootable).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the hypervisor for which to restrict the search
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// list ISO by ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// possible values are "featured", "self", "selfexecutable","sharedexecutable","executable", and "community". * featured : templates that have been marked as featured and public. * self : templates that have been registered or created by the calling user. * selfexecutable : same as self, but only returns templates that can be used to deploy a new VM. * sharedexecutable : templates ready to be deployed that have been granted to the calling user by another user. * executable : templates that are owned by the calling user, or public templates, that can be used to deploy a VM. * community : templates that have been marked as public but not featured. * all : all templates (only usable by admins).
        /// </summary>
        public string IsoFilter {
            get { return GetParameterValue<string>(nameof(IsoFilter).ToLower()); }
            set { SetParameterValue(nameof(IsoFilter).ToLower(), value); }
        }

        /// <summary>
        /// true if the ISO is publicly available to all users, false otherwise.
        /// </summary>
        public bool? Ispublic {
            get { return GetParameterValue<bool?>(nameof(Ispublic).ToLower()); }
            set { SetParameterValue(nameof(Ispublic).ToLower(), value); }
        }

        /// <summary>
        /// true if this ISO is ready to be deployed
        /// </summary>
        public bool? Isready {
            get { return GetParameterValue<bool?>(nameof(Isready).ToLower()); }
            set { SetParameterValue(nameof(Isready).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// list all ISOs by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// show removed ISOs as well
        /// </summary>
        public bool? ShowRemoved {
            get { return GetParameterValue<bool?>(nameof(ShowRemoved).ToLower()); }
            set { SetParameterValue(nameof(ShowRemoved).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available ISO files.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TemplateResponse> ListIsos(ListIsosRequest request);
        Task<ListResponse<TemplateResponse>> ListIsosAsync(ListIsosRequest request);
        ListResponse<TemplateResponse> ListIsosAllPages(ListIsosRequest request);
        Task<ListResponse<TemplateResponse>> ListIsosAllPagesAsync(ListIsosRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TemplateResponse> ListIsos(ListIsosRequest request) => _proxy.Request<ListResponse<TemplateResponse>>(request);
        public Task<ListResponse<TemplateResponse>> ListIsosAsync(ListIsosRequest request) => _proxy.RequestAsync<ListResponse<TemplateResponse>>(request);
        public ListResponse<TemplateResponse> ListIsosAllPages(ListIsosRequest request) => _proxy.RequestAllPages<TemplateResponse>(request);
        public Task<ListResponse<TemplateResponse>> ListIsosAllPagesAsync(ListIsosRequest request) => _proxy.RequestAllPagesAsync<TemplateResponse>(request);
    }
}
