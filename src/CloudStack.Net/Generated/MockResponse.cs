using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MockResponse
    {
        /// <summary>
        /// the mock ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// the Cluster ID scope of the mock
        /// </summary>
        public long ClusterId { get; set; }

        /// <summary>
        /// number of times mock is executed, if not specified then mock remains active till cleaned up
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// the Host ID scope of the mock
        /// </summary>
        public long HostId { get; set; }

        /// <summary>
        /// the agent command to be mocked
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the Pod ID scope of the mock
        /// </summary>
        public long PodId { get; set; }

        /// <summary>
        /// the Zone ID scope of the mock
        /// </summary>
        public long ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
