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
    /// A snapshot of an app.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SnapshotInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SnapshotInner class.
        /// </summary>
        public SnapshotInner() { }

        /// <summary>
        /// Initializes a new instance of the SnapshotInner class.
        /// </summary>
        /// <param name="time">The time the snapshot was taken.</param>
        public SnapshotInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), System.DateTime? time = default(System.DateTime?))
            : base(location, id, name, type, tags)
        {
            Time = time;
        }

        /// <summary>
        /// Gets the time the snapshot was taken.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.time")]
        public System.DateTime? Time { get; private set; }

    }
}
