using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AccountResponse
    {
        /// <summary>
        /// the id of the account
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// details for the account
        /// </summary>
        public IDictionary<string, string> Accountdetails { get; set; }

        /// <summary>
        /// account type (admin, domain-admin, user)
        /// </summary>
        public short AccountType { get; set; }

        /// <summary>
        /// the total number of cpu cores available to be created for this account
        /// </summary>
        public string CpuAvailable { get; set; }

        /// <summary>
        /// the total number of cpu cores the account can own
        /// </summary>
        public string CpuLimit { get; set; }

        /// <summary>
        /// the total number of cpu cores owned by account
        /// </summary>
        public long CpuTotal { get; set; }

        /// <summary>
        /// the default zone of the account
        /// </summary>
        public string DefaultZoneId { get; set; }

        /// <summary>
        /// name of the Domain the account belongs too
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// id of the Domain the account belongs too
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the list of acl groups that account belongs to
        /// </summary>
        public IList<string> Groups { get; set; }

        /// <summary>
        /// the total number of public ip addresses available for this account to acquire
        /// </summary>
        public string IpAvailable { get; set; }

        /// <summary>
        /// the total number of public ip addresses this account can acquire
        /// </summary>
        public string IpLimit { get; set; }

        /// <summary>
        /// the total number of public ip addresses allocated for this account
        /// </summary>
        public long IpTotal { get; set; }

        /// <summary>
        /// true if the account requires cleanup
        /// </summary>
        public bool Iscleanuprequired { get; set; }

        /// <summary>
        /// true if account is default, false otherwise
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// the total memory (in MB) available to be created for this account
        /// </summary>
        public string MemoryAvailable { get; set; }

        /// <summary>
        /// the total memory (in MB) the account can own
        /// </summary>
        public string MemoryLimit { get; set; }

        /// <summary>
        /// the total memory (in MB) owned by account
        /// </summary>
        public long MemoryTotal { get; set; }

        /// <summary>
        /// the name of the account
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the total number of networks available to be created for this account
        /// </summary>
        public string NetworkAvailable { get; set; }

        /// <summary>
        /// the network domain
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// the total number of networks the account can own
        /// </summary>
        public string NetworkLimit { get; set; }

        /// <summary>
        /// the total number of networks owned by account
        /// </summary>
        public long NetworkTotal { get; set; }

        /// <summary>
        /// the total primary storage space (in GiB) available to be used for this account
        /// </summary>
        public string PrimaryStorageAvailable { get; set; }

        /// <summary>
        /// the total primary storage space (in GiB) the account can own
        /// </summary>
        public string PrimaryStorageLimit { get; set; }

        /// <summary>
        /// the total primary storage space (in GiB) owned by account
        /// </summary>
        public long PrimaryStorageTotal { get; set; }

        /// <summary>
        /// the total number of projects available for administration by this account
        /// </summary>
        public string ProjectAvailable { get; set; }

        /// <summary>
        /// the total number of projects the account can own
        /// </summary>
        public string ProjectLimit { get; set; }

        /// <summary>
        /// the total number of projects being administrated by this account
        /// </summary>
        public long ProjectTotal { get; set; }

        /// <summary>
        /// the total number of network traffic bytes received
        /// </summary>
        public long Receivedbytes { get; set; }

        /// <summary>
        /// the total secondary storage space (in GiB) available to be used for this account
        /// </summary>
        public string SecondaryStorageAvailable { get; set; }

        /// <summary>
        /// the total secondary storage space (in GiB) the account can own
        /// </summary>
        public string SecondaryStorageLimit { get; set; }

        /// <summary>
        /// the total secondary storage space (in GiB) owned by account
        /// </summary>
        public long SecondaryStorageTotal { get; set; }

        /// <summary>
        /// the total number of network traffic bytes sent
        /// </summary>
        public long Sentbytes { get; set; }

        /// <summary>
        /// the total number of snapshots available for this account
        /// </summary>
        public string SnapshotAvailable { get; set; }

        /// <summary>
        /// the total number of snapshots which can be stored by this account
        /// </summary>
        public string SnapshotLimit { get; set; }

        /// <summary>
        /// the total number of snapshots stored by this account
        /// </summary>
        public long SnapshotTotal { get; set; }

        /// <summary>
        /// the state of the account
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the total number of templates available to be created by this account
        /// </summary>
        public string TemplateAvailable { get; set; }

        /// <summary>
        /// the total number of templates which can be created by this account
        /// </summary>
        public string TemplateLimit { get; set; }

        /// <summary>
        /// the total number of templates which have been created by this account
        /// </summary>
        public long TemplateTotal { get; set; }

        /// <summary>
        /// the total number of virtual machines available for this account to acquire
        /// </summary>
        public string VmAvailable { get; set; }

        /// <summary>
        /// the total number of virtual machines that can be deployed by this account
        /// </summary>
        public string VmLimit { get; set; }

        /// <summary>
        /// the total number of virtual machines running for this account
        /// </summary>
        public int? VmRunning { get; set; }

        /// <summary>
        /// the total number of virtual machines stopped for this account
        /// </summary>
        public int? VmStopped { get; set; }

        /// <summary>
        /// the total number of virtual machines deployed by this account
        /// </summary>
        public long VmTotal { get; set; }

        /// <summary>
        /// the total volume available for this account
        /// </summary>
        public string VolumeAvailable { get; set; }

        /// <summary>
        /// the total volume which can be used by this account
        /// </summary>
        public string VolumeLimit { get; set; }

        /// <summary>
        /// the total volume being used by this account
        /// </summary>
        public long VolumeTotal { get; set; }

        /// <summary>
        /// the total number of vpcs available to be created for this account
        /// </summary>
        public string VpcAvailable { get; set; }

        /// <summary>
        /// the total number of vpcs the account can own
        /// </summary>
        public string VpcLimit { get; set; }

        /// <summary>
        /// the total number of vpcs owned by account
        /// </summary>
        public long VpcTotal { get; set; }

        /// <summary>
        /// the list of users associated with account
        /// </summary>
        public IList<UserResponse> User { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
