// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PeeringManagementClient.
    /// </summary>
    public static partial class PeeringManagementClientExtensions
    {
            /// <summary>
            /// Checks if the peering service provider is present within 1000 miles of
            /// customer's location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringServiceLocation'>
            /// Gets or sets the PeeringServiceLocation
            /// </param>
            /// <param name='peeringServiceProvider'>
            /// Gets or sets the PeeringServiceProvider
            /// </param>
            public static string CheckServiceProviderAvailability(this IPeeringManagementClient operations, string peeringServiceLocation = default(string), string peeringServiceProvider = default(string))
            {
                return operations.CheckServiceProviderAvailabilityAsync(peeringServiceLocation, peeringServiceProvider).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks if the peering service provider is present within 1000 miles of
            /// customer's location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringServiceLocation'>
            /// Gets or sets the PeeringServiceLocation
            /// </param>
            /// <param name='peeringServiceProvider'>
            /// Gets or sets the PeeringServiceProvider
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> CheckServiceProviderAvailabilityAsync(this IPeeringManagementClient operations, string peeringServiceLocation = default(string), string peeringServiceProvider = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckServiceProviderAvailabilityWithHttpMessagesAsync(peeringServiceLocation, peeringServiceProvider, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
