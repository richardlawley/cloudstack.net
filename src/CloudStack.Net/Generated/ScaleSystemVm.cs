using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ScaleSystemVmRequest : APIRequest
    {
        public ScaleSystemVmRequest() : base("scaleSystemVm") {}

        /// <summary>
        /// The ID of the system vm
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the service offering ID to apply to the system vm
        /// </summary>
        public Guid ServiceOfferingId {
            get { return (Guid) Parameters[nameof(ServiceOfferingId).ToLower()]; }
            set { Parameters[nameof(ServiceOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// name value pairs of custom parameters for cpu, memory and cpunumber. example details[i].name=value
        /// </summary>
        public IDictionary<string, string> Details {
            get { return (IDictionary<string, string>) Parameters[nameof(Details).ToLower()]; }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Scale the service offering for a system vm (console proxy or secondary storage). The system vm must be in a "Stopped" state for this command to take effect.
    /// </summary>
    /// <summary>
    /// Scale the service offering for a system vm (console proxy or secondary storage). The system vm must be in a "Stopped" state for this command to take effect.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SystemVmResponse ScaleSystemVm(ScaleSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SystemVmResponse ScaleSystemVm(ScaleSystemVmRequest request) => _proxy.Request<SystemVmResponse>(request);
    }
}
