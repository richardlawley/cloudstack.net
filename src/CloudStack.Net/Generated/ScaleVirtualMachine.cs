using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ScaleVirtualMachineRequest : APIRequest
    {
        public ScaleVirtualMachineRequest() : base("scaleVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the service offering for the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return (Guid) Parameters[nameof(ServiceOfferingId).ToLower()]; }
            set { Parameters[nameof(ServiceOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// name value pairs of custom parameters for cpu,memory and cpunumber. example details[i].name=value
        /// </summary>
        public IDictionary<string, string> Details {
            get { return (IDictionary<string, string>) Parameters[nameof(Details).ToLower()]; }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Scales the virtual machine to a new service offering.
    /// </summary>
    /// <summary>
    /// Scales the virtual machine to a new service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ScaleVirtualMachine(ScaleVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ScaleVirtualMachine(ScaleVirtualMachineRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
