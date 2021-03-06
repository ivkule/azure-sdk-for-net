// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the resource that was assessed
    /// </summary>
    [Newtonsoft.Json.JsonObject("Aws")]
    public partial class AwsResourceDetails : ResourceDetails
    {
        /// <summary>
        /// Initializes a new instance of the AwsResourceDetails class.
        /// </summary>
        public AwsResourceDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AwsResourceDetails class.
        /// </summary>
        /// <param name="accountId">AWS account ID</param>
        /// <param name="awsResourceId">AWS resource ID. can be ARN or
        /// other</param>
        public AwsResourceDetails(string accountId = default(string), string awsResourceId = default(string))
        {
            AccountId = accountId;
            AwsResourceId = awsResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets AWS account ID
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Gets AWS resource ID. can be ARN or other
        /// </summary>
        [JsonProperty(PropertyName = "awsResourceId")]
        public string AwsResourceId { get; private set; }

    }
}
