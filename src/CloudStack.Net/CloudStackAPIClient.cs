using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudStack.Net
{
    public partial interface ICloudStackAPIClient { }

    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        private readonly ICloudStackAPIProxy _proxy;

        public CloudStackAPIClient(ICloudStackAPIProxy proxy)
        {
            _proxy = proxy;
        }

        public CloudStackAPIClient(string serviceUrl, string apiKey, string secretKey)
            : this(new CloudStackAPIProxy(serviceUrl, apiKey, secretKey))
        { }
    }
}
