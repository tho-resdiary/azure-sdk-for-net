// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of a DigitalTwinsInstance.
    /// </summary>
    public partial class DigitalTwinsPatchProperties
    {
        /// <summary>
        /// Initializes a new instance of the DigitalTwinsPatchProperties
        /// class.
        /// </summary>
        public DigitalTwinsPatchProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DigitalTwinsPatchProperties
        /// class.
        /// </summary>
        /// <param name="publicNetworkAccess">Public network access for the
        /// DigitalTwinsInstance. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public DigitalTwinsPatchProperties(string publicNetworkAccess = default(string))
        {
            PublicNetworkAccess = publicNetworkAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets public network access for the DigitalTwinsInstance.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

    }
}
