// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Application Insights component linked storage accounts
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ComponentLinkedStorageAccounts : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ComponentLinkedStorageAccounts
        /// class.
        /// </summary>
        public ComponentLinkedStorageAccounts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComponentLinkedStorageAccounts
        /// class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="linkedStorageAccount">Linked storage account resource
        /// ID</param>
        public ComponentLinkedStorageAccounts(string id = default(string), string name = default(string), string type = default(string), string linkedStorageAccount = default(string))
            : base(id, name, type)
        {
            LinkedStorageAccount = linkedStorageAccount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets linked storage account resource ID
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkedStorageAccount")]
        public string LinkedStorageAccount { get; set; }

    }
}