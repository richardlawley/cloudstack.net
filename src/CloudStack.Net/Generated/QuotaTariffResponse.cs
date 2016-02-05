using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaTariffResponse
    {
        /// <summary>
        /// currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the date on/after which this quota value will be effective
        /// </summary>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// tariffValue
        /// </summary>
        public decimal TariffValue { get; set; }

        /// <summary>
        /// usageDiscriminator
        /// </summary>
        public string UsageDiscriminator { get; set; }

        /// <summary>
        /// usageName
        /// </summary>
        public string UsageName { get; set; }

        /// <summary>
        /// usageType
        /// </summary>
        public int UsageType { get; set; }

        /// <summary>
        /// usageUnit
        /// </summary>
        public string UsageUnit { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
