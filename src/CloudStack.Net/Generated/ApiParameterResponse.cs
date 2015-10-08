using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApiParameterResponse
    {
        /// <summary>
        /// description of the api parameter
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// length of the parameter
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// the name of the api parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// comma separated related apis to get the parameter
        /// </summary>
        public string Related { get; set; }

        /// <summary>
        /// true if this parameter is required for the api request
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// version of CloudStack the api was introduced in
        /// </summary>
        public string Since { get; set; }

        /// <summary>
        /// parameter type
        /// </summary>
        public string Type { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
