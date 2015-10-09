using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    /// <summary>
    /// Response class for all CloudStack API calls which return a list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListResponse<T>
    {
        public int Count { get; set; }

        public IList<T> Results { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
