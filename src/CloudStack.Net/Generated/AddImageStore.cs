using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddImageStoreRequest : APIRequest
    {
        public AddImageStoreRequest() : base("addImageStore") {}

        /// <summary>
        /// the image store provider name
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// the details for the image store. Example: details[0].key=accesskey&details[0].value=s389ddssaa&details[1].key=secretkey&details[1].value=8dshfsss
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the name for the image store
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the URL for the image store
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the image store
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds backup image store.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse AddImageStore(AddImageStoreRequest request);
        Task<ImageStoreResponse> AddImageStoreAsync(AddImageStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse AddImageStore(AddImageStoreRequest request) => _proxy.Request<ImageStoreResponse>(request);
        public Task<ImageStoreResponse> AddImageStoreAsync(AddImageStoreRequest request) => _proxy.RequestAsync<ImageStoreResponse>(request);
    }
}
