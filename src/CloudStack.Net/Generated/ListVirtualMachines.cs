using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVirtualMachinesRequest : APIRequest
    {
        public ListVirtualMachinesRequest() : base("listVirtualMachines") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list vms by affinity group
        /// </summary>
        public Guid AffinityGroupId {
            get { return (Guid) Parameters[nameof(AffinityGroupId).ToLower()]; }
            set { Parameters[nameof(AffinityGroupId).ToLower()] = value; }
        }

        /// <summary>
        /// comma separated list of host details requested, value can be a list of [all, group, nics, stats, secgrp, tmpl, servoff, diskoff, iso, volume, min, affgrp]. If no parameter is passed in, the details will be defaulted to all
        /// </summary>
        public IList<string> Details {
            get { return (IList<string>) Parameters[nameof(Details).ToLower()]; }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Displayvm {
            get { return (bool?) Parameters[nameof(Displayvm).ToLower()]; }
            set { Parameters[nameof(Displayvm).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// list by network type; true if need to list vms using Virtual Network, false otherwise
        /// </summary>
        public bool? ForVirtualNetwork {
            get { return (bool?) Parameters[nameof(ForVirtualNetwork).ToLower()]; }
            set { Parameters[nameof(ForVirtualNetwork).ToLower()] = value; }
        }

        /// <summary>
        /// the group ID
        /// </summary>
        public Guid GroupId {
            get { return (Guid) Parameters[nameof(GroupId).ToLower()]; }
            set { Parameters[nameof(GroupId).ToLower()] = value; }
        }

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

        /// <summary>
        /// the target hypervisor for the template
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the IDs of the virtual machines, mutually exclusive with id
        /// </summary>
        public IList<Guid> Ids {
            get { return (IList<Guid>) Parameters[nameof(Ids).ToLower()]; }
            set { Parameters[nameof(Ids).ToLower()] = value; }
        }

        /// <summary>
        /// list vms by iso
        /// </summary>
        public Guid IsoId {
            get { return (Guid) Parameters[nameof(IsoId).ToLower()]; }
            set { Parameters[nameof(IsoId).ToLower()] = value; }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return (bool?) Parameters[nameof(Isrecursive).ToLower()]; }
            set { Parameters[nameof(Isrecursive).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return (bool?) Parameters[nameof(ListAll).ToLower()]; }
            set { Parameters[nameof(ListAll).ToLower()] = value; }
        }

        /// <summary>
        /// name of the virtual machine (a substring match is made against the parameter value, data for all matching VMs will be returned)
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// list by network id
        /// </summary>
        public Guid NetworkId {
            get { return (Guid) Parameters[nameof(NetworkId).ToLower()]; }
            set { Parameters[nameof(NetworkId).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// the pod ID
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// list by the service offering
        /// </summary>
        public Guid Serviceofferingid {
            get { return (Guid) Parameters[nameof(Serviceofferingid).ToLower()]; }
            set { Parameters[nameof(Serviceofferingid).ToLower()] = value; }
        }

        /// <summary>
        /// state of the virtual machine
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

        /// <summary>
        /// the storage ID where vm's volumes belong to
        /// </summary>
        public Guid StorageId {
            get { return (Guid) Parameters[nameof(StorageId).ToLower()]; }
            set { Parameters[nameof(StorageId).ToLower()] = value; }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return (IList<IDictionary<string, object>>) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// list vms by template
        /// </summary>
        public Guid TemplateId {
            get { return (Guid) Parameters[nameof(TemplateId).ToLower()]; }
            set { Parameters[nameof(TemplateId).ToLower()] = value; }
        }

        /// <summary>
        /// list vms by vpc
        /// </summary>
        public Guid VpcId {
            get { return (Guid) Parameters[nameof(VpcId).ToLower()]; }
            set { Parameters[nameof(VpcId).ToLower()] = value; }
        }

        /// <summary>
        /// the availability zone ID
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List the virtual machines owned by the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UserVmResponse> ListVirtualMachines(ListVirtualMachinesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UserVmResponse> ListVirtualMachines(ListVirtualMachinesRequest request) => _proxy.Request<ListResponse<UserVmResponse>>(request);
    }
}
