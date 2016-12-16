// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Metrics availability and retention.
    /// </summary>
    public partial class ResourceMetricAvailability
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricAvailability class.
        /// </summary>
        public ResourceMetricAvailability() { }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricAvailability class.
        /// </summary>
        /// <param name="timeGrain">Time grain .</param>
        /// <param name="retention">Retention period for the current time
        /// grain.</param>
        public ResourceMetricAvailability(string timeGrain = default(string), string retention = default(string))
        {
            TimeGrain = timeGrain;
            Retention = retention;
        }

        /// <summary>
        /// Gets time grain .
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; private set; }

        /// <summary>
        /// Gets retention period for the current time grain.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retention")]
        public string Retention { get; private set; }

    }
}
