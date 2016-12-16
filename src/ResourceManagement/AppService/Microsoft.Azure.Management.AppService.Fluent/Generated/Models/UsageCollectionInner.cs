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
    /// Collection of usages.
    /// </summary>
    public partial class UsageCollectionInner
    {
        /// <summary>
        /// Initializes a new instance of the UsageCollectionInner class.
        /// </summary>
        public UsageCollectionInner() { }

        /// <summary>
        /// Initializes a new instance of the UsageCollectionInner class.
        /// </summary>
        /// <param name="value">Collection of resources.</param>
        /// <param name="nextLink">Link to next page of resources.</param>
        public UsageCollectionInner(System.Collections.Generic.IList<UsageInner> value, string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets collection of resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<UsageInner> Value { get; set; }

        /// <summary>
        /// Gets or sets link to next page of resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
