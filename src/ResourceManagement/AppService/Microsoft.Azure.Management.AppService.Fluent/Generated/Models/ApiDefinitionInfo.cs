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
    /// Information about the formal API definition for the app.
    /// </summary>
    public partial class ApiDefinitionInfo
    {
        /// <summary>
        /// Initializes a new instance of the ApiDefinitionInfo class.
        /// </summary>
        public ApiDefinitionInfo() { }

        /// <summary>
        /// Initializes a new instance of the ApiDefinitionInfo class.
        /// </summary>
        /// <param name="url">The URL of the API definition.</param>
        public ApiDefinitionInfo(string url = default(string))
        {
            Url = url;
        }

        /// <summary>
        /// Gets or sets the URL of the API definition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}
