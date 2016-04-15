using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVirtualMachinesRequest : APIListRequest
    {
        public ListVirtualMachinesRequest() : base("listVirtualMachines") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list vms by affinity group
        /// </summary>
        public Guid AffinityGroupId {
            get { return GetParameterValue<Guid>(nameof(AffinityGroupId).ToLower()); }
            set { SetParameterValue(nameof(AffinityGroupId).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of host details requested, value can be a list of [all, group, nics, stats, secgrp, tmpl, servoff, diskoff, iso, volume, min, affgrp]. If no parameter is passed in, the details will be defaulted to all
        /// </summary>
        public IList<string> Details {
            get { return GetList<string>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Displayvm {
            get { return GetParameterValue<bool?>(nameof(Displayvm).ToLower()); }
            set { SetParameterValue(nameof(Displayvm).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list by network type; true if need to list vms using Virtual Network, false otherwise
        /// </summary>
        public bool? ForVirtualNetwork {
            get { return GetParameterValue<bool?>(nameof(ForVirtualNetwork).ToLower()); }
            set { SetParameterValue(nameof(ForVirtualNetwork).ToLower(), value); }
        }

        /// <summary>
        /// the group ID
        /// </summary>
        public Guid GroupId {
            get { return GetParameterValue<Guid>(nameof(GroupId).ToLower()); }
            set { SetParameterValue(nameof(GroupId).ToLower(), value); }
        }

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the target hypervisor for the template
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the virtual machines, mutually exclusive with id
        /// </summary>
        public IList<Guid> Ids {
            get { return GetList<Guid>(nameof(Ids).ToLower()); }
            set { SetParameterValue(nameof(Ids).ToLower(), value); }
        }

        /// <summary>
        /// list vms by iso
        /// </summary>
        public Guid IsoId {
            get { return GetParameterValue<Guid>(nameof(IsoId).ToLower()); }
            set { SetParameterValue(nameof(IsoId).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// list vms by ssh keypair name
        /// </summary>
        public string Keypair {
            get { return GetParameterValue<string>(nameof(Keypair).ToLower()); }
            set { SetParameterValue(nameof(Keypair).ToLower(), value); }
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
        /// name of the virtual machine (a substring match is made against the parameter value, data for all matching VMs will be returned)
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list by network id
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the pod ID
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// list by the service offering
        /// </summary>
        public Guid Serviceofferingid {
            get { return GetParameterValue<Guid>(nameof(Serviceofferingid).ToLower()); }
            set { SetParameterValue(nameof(Serviceofferingid).ToLower(), value); }
        }

        /// <summary>
        /// state of the virtual machine. Possible values are: Running, Stopped, Present, Destroyed, Expunged. Present is used for the state equal not destroyed.
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// the storage ID where vm's volumes belong to
        /// </summary>
        public Guid StorageId {
            get { return GetParameterValue<Guid>(nameof(StorageId).ToLower()); }
            set { SetParameterValue(nameof(StorageId).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// list vms by template
        /// </summary>
        public Guid TemplateId {
            get { return GetParameterValue<Guid>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// the user ID that created the VM and is under the account that owns the VM
        /// </summary>
        public Guid UserId {
            get { return GetParameterValue<Guid>(nameof(UserId).ToLower()); }
            set { SetParameterValue(nameof(UserId).ToLower(), value); }
        }

        /// <summary>
        /// list vms by vpc
        /// </summary>
        public Guid VpcId {
            get { return GetParameterValue<Guid>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

        /// <summary>
        /// the availability zone ID
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List the virtual machines owned by the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UserVmResponse> ListVirtualMachines(ListVirtualMachinesRequest request);
        Task<ListResponse<UserVmResponse>> ListVirtualMachinesAsync(ListVirtualMachinesRequest request);
        ListResponse<UserVmResponse> ListVirtualMachinesAllPages(ListVirtualMachinesRequest request);
        Task<ListResponse<UserVmResponse>> ListVirtualMachinesAllPagesAsync(ListVirtualMachinesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UserVmResponse> ListVirtualMachines(ListVirtualMachinesRequest request) => _proxy.Request<ListResponse<UserVmResponse>>(request);
        public Task<ListResponse<UserVmResponse>> ListVirtualMachinesAsync(ListVirtualMachinesRequest request) => _proxy.RequestAsync<ListResponse<UserVmResponse>>(request);
        public ListResponse<UserVmResponse> ListVirtualMachinesAllPages(ListVirtualMachinesRequest request) => _proxy.RequestAllPages<UserVmResponse>(request);
        public Task<ListResponse<UserVmResponse>> ListVirtualMachinesAllPagesAsync(ListVirtualMachinesRequest request) => _proxy.RequestAllPagesAsync<UserVmResponse>(request);
    }
}
