// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Deep created origins within a CDN endpoint.
    /// </summary>
    [JsonTransformation]
    public partial class DeepCreatedOrigin : IResource
    {
        /// <summary>
        /// Initializes a new instance of the DeepCreatedOrigin class.
        /// </summary>
        public DeepCreatedOrigin() { }

        /// <summary>
        /// Initializes a new instance of the DeepCreatedOrigin class.
        /// </summary>
        public DeepCreatedOrigin(string name, string hostName, int? httpPort = default(int?), int? httpsPort = default(int?))
        {
            Name = name;
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
        }

        /// <summary>
        /// Origin name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6
        /// addresses are supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// The value of the HTTP port. Must be between 1 and 65535
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpPort")]
        public int? HttpPort { get; set; }

        /// <summary>
        /// The value of the HTTPS port. Must be between 1 and 65535
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpsPort")]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (HostName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostName");
            }
        }
    }
}
