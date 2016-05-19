// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A redis item in CreateOrUpdate Operation response.
    /// </summary>
    [JsonTransformation]
    public partial class RedisResourceWithAccessKey : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RedisResourceWithAccessKey class.
        /// </summary>
        public RedisResourceWithAccessKey() { }

        /// <summary>
        /// Initializes a new instance of the RedisResourceWithAccessKey class.
        /// </summary>
        public RedisResourceWithAccessKey(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string redisVersion = default(string), IDictionary<string, string> redisConfiguration = default(IDictionary<string, string>), bool? enableNonSslPort = default(bool?), IDictionary<string, string> tenantSettings = default(IDictionary<string, string>), int? shardCount = default(int?), string subnetId = default(string), string staticIP = default(string), string provisioningState = default(string), string hostName = default(string), int? port = default(int?), int? sslPort = default(int?), RedisAccessKeys accessKeys = default(RedisAccessKeys))
            : base(location, id, name, type, tags)
        {
            RedisVersion = redisVersion;
            Sku = sku;
            RedisConfiguration = redisConfiguration;
            EnableNonSslPort = enableNonSslPort;
            TenantSettings = tenantSettings;
            ShardCount = shardCount;
            SubnetId = subnetId;
            StaticIP = staticIP;
            ProvisioningState = provisioningState;
            HostName = hostName;
            Port = port;
            SslPort = sslPort;
            AccessKeys = accessKeys;
        }

        /// <summary>
        /// RedisVersion parameter has been deprecated. As such, it is no
        /// longer necessary to provide this parameter and any value
        /// specified is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.redisVersion")]
        public string RedisVersion { get; set; }

        /// <summary>
        /// What sku of redis cache to deploy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// All Redis Settings. Few possible keys:
        /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
        /// etc.
        /// </summary>
        [JsonProperty(PropertyName = "properties.redisConfiguration")]
        public IDictionary<string, string> RedisConfiguration { get; set; }

        /// <summary>
        /// If the value is true, then the non-ssl redis server port (6379)
        /// will be enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableNonSslPort")]
        public bool? EnableNonSslPort { get; set; }

        /// <summary>
        /// tenantSettings
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantSettings")]
        public IDictionary<string, string> TenantSettings { get; set; }

        /// <summary>
        /// The number of shards to be created on a Premium Cluster Cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.shardCount")]
        public int? ShardCount { get; set; }

        /// <summary>
        /// The full resource ID of a subnet in a virtual network to deploy
        /// the redis cache in. Example format:
        /// /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Required when deploying a redis cache inside an existing Azure
        /// Virtual Network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.staticIP")]
        public string StaticIP { get; set; }

        /// <summary>
        /// Redis instance provisioning status
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Redis host name
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Redis non-ssl port
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Redis ssl port
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslPort")]
        public int? SslPort { get; set; }

        /// <summary>
        /// Redis cache access keys.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessKeys")]
        public RedisAccessKeys AccessKeys { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
        }
    }
}
