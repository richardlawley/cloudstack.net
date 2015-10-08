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
        public string AccountName { get; set; }

        /// <summary>
        /// list vms by affinity group
        /// </summary>
        public Guid AffinityGroupId { get; set; }

        /// <summary>
        /// comma separated list of host details requested, value can be a list of [all, group, nics, stats, secgrp, tmpl, servoff, diskoff, iso, volume, min, affgrp]. If no parameter is passed in, the details will be defaulted to all
        /// </summary>
        public IList<string> ViewDetails { get; set; }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list by network type; true if need to list vms using Virtual Network, false otherwise
        /// </summary>
        public bool? ForVirtualNetwork { get; set; }

        /// <summary>
        /// the group ID
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// the target hypervisor for the template
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the IDs of the virtual machines, mutually exclusive with id
        /// </summary>
        public IList<long> Ids { get; set; }

        /// <summary>
        /// list vms by iso
        /// </summary>
        public Guid IsoId { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// list vms by ssh keypair name
        /// </summary>
        public string Keypair { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        /// <summary>
        /// name of the virtual machine (a substring match is made against the parameter value, data for all matching VMs will be returned)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// list by network id
        /// </summary>
        public Guid NetworkId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the pod ID
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// list by the service offering
        /// </summary>
        public Guid ServiceOffId { get; set; }

        /// <summary>
        /// state of the virtual machine. Possible values are: Running, Stopped, Present, Destroyed, Expunged. Present is used for the state equal not destroyed.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the storage ID where vm's volumes belong to
        /// </summary>
        public Guid StorageId { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// list vms by template
        /// </summary>
        public Guid TemplateId { get; set; }

        /// <summary>
        /// the user ID that created the VM and is under the account that owns the VM
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// list vms by vpc
        /// </summary>
        public Guid VpcId { get; set; }

        /// <summary>
        /// the availability zone ID
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// List the virtual machines owned by the account.
    /// </summary>
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
