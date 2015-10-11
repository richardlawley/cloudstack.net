using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBaremetalRctRequest : APIRequest
    {
        public AddBaremetalRctRequest() : base("addBaremetalRct") {}

        /// <summary>
        /// http url to baremetal RCT configuration
        /// </summary>
        public String Baremetalrcturl {
            get { return (String) Parameters[nameof(Baremetalrcturl).ToLower()]; }
            set { Parameters[nameof(Baremetalrcturl).ToLower()] = value; }
        }

    }
    /// <summary>
    /// adds baremetal rack configuration text
    /// </summary>
    /// <summary>
    /// adds baremetal rack configuration text
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BaremetalRctResponse AddBaremetalRct(AddBaremetalRctRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BaremetalRctResponse AddBaremetalRct(AddBaremetalRctRequest request) => _proxy.Request<BaremetalRctResponse>(request);
    }
}
