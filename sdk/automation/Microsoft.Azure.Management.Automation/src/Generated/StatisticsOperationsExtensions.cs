// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StatisticsOperations.
    /// </summary>
    public static partial class StatisticsOperationsExtensions
    {
            /// <summary>
            /// Retrieve the statistics for the account.
            /// <see href="http://aka.ms/azureautomationsdk/statisticsoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IEnumerable<Statistics> ListByAutomationAccount(this IStatisticsOperations operations, string resourceGroupName, string automationAccountName, string filter = default(string))
            {
                return operations.ListByAutomationAccountAsync(resourceGroupName, automationAccountName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the statistics for the account.
            /// <see href="http://aka.ms/azureautomationsdk/statisticsoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Statistics>> ListByAutomationAccountAsync(this IStatisticsOperations operations, string resourceGroupName, string automationAccountName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountWithHttpMessagesAsync(resourceGroupName, automationAccountName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
