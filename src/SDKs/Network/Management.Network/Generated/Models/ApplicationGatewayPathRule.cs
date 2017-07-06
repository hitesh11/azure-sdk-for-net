// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Path rule of URL path map of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayPathRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayPathRule class.
        /// </summary>
        public ApplicationGatewayPathRule()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayPathRule class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="paths">Path rules of URL path map.</param>
        /// <param name="backendAddressPool">Backend address pool resource of
        /// URL path map path rule.</param>
        /// <param name="backendHttpSettings">Backend http settings resource of
        /// URL path map path rule.</param>
        /// <param name="redirectConfiguration">Redirect configuration resource
        /// of URL path map path rule.</param>
        /// <param name="provisioningState">Path rule of URL path map resource.
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayPathRule(string id = default(string), IList<string> paths = default(IList<string>), SubResource backendAddressPool = default(SubResource), SubResource backendHttpSettings = default(SubResource), SubResource redirectConfiguration = default(SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            Paths = paths;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            RedirectConfiguration = redirectConfiguration;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets path rules of URL path map.
        /// </summary>
        [JsonProperty(PropertyName = "properties.paths")]
        public IList<string> Paths { get; set; }

        /// <summary>
        /// Gets or sets backend address pool resource of URL path map path
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets backend http settings resource of URL path map path
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettings")]
        public SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets redirect configuration resource of URL path map path
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.redirectConfiguration")]
        public SubResource RedirectConfiguration { get; set; }

        /// <summary>
        /// Gets or sets path rule of URL path map resource. Possible values
        /// are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
