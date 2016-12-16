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
    /// MachineKey of an app.
    /// </summary>
    public partial class SiteMachineKey
    {
        /// <summary>
        /// Initializes a new instance of the SiteMachineKey class.
        /// </summary>
        public SiteMachineKey() { }

        /// <summary>
        /// Initializes a new instance of the SiteMachineKey class.
        /// </summary>
        /// <param name="validation">MachineKey validation.</param>
        /// <param name="validationKey">Validation key.</param>
        /// <param name="decryption">Decryption.</param>
        /// <param name="decryptionKey">Decryption key.</param>
        public SiteMachineKey(string validation = default(string), string validationKey = default(string), string decryption = default(string), string decryptionKey = default(string))
        {
            Validation = validation;
            ValidationKey = validationKey;
            Decryption = decryption;
            DecryptionKey = decryptionKey;
        }

        /// <summary>
        /// Gets or sets machineKey validation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "validation")]
        public string Validation { get; set; }

        /// <summary>
        /// Gets or sets validation key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "validationKey")]
        public string ValidationKey { get; set; }

        /// <summary>
        /// Gets or sets decryption.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "decryption")]
        public string Decryption { get; set; }

        /// <summary>
        /// Gets or sets decryption key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "decryptionKey")]
        public string DecryptionKey { get; set; }

    }
}
