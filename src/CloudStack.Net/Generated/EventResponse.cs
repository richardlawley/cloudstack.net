using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EventResponse
    {
        /// <summary>
        /// the ID of the event
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account name for the account that owns the object being acted on in the event (e.g. the owner of the virtual machine, ip address, or security group)
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the date the event was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// a brief description of the event
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the name of the account's domain
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the id of the account's domain
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the event level (INFO, WARN, ERROR)
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// whether the event is parented
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// the project name of the address
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the ipaddress
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the state of the event
        /// </summary>
        public EventState State { get; set; }

        /// <summary>
        /// the type of the event (see event types)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// the name of the user who performed the action (can be different from the account if an admin is performing an action for a user, e.g. starting/stopping a user's virtual machine)
        /// </summary>
        public string Username { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
