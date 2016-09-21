// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans.Models
{
    using System.Linq;

    /// <summary>
    /// The SKU of a resource.
    /// </summary>
    public partial class ResourceSku
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        public ResourceSku() { }

        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        /// <param name="capacity">The scale-out capacity of the resource. 1
        /// is 1x, 2 is 2x, etc. This impacts the quantities and cost of any
        /// commitment plan resource.</param>
        /// <param name="name">The SKU name. Along with tier, uniquely
        /// identifies the SKU.</param>
        /// <param name="tier">The SKU tier. Along with name, uniquely
        /// identifies the SKU.</param>
        public ResourceSku(int? capacity = default(int?), string name = default(string), string tier = default(string))
        {
            Capacity = capacity;
            Name = name;
            Tier = tier;
        }

        /// <summary>
        /// Gets or sets the scale-out capacity of the resource. 1 is 1x, 2 is
        /// 2x, etc. This impacts the quantities and cost of any commitment
        /// plan resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or sets the SKU name. Along with tier, uniquely identifies
        /// the SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the SKU tier. Along with name, uniquely identifies
        /// the SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

    }
}