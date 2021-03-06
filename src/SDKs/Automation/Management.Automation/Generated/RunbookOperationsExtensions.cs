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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RunbookOperations.
    /// </summary>
    public static partial class RunbookOperationsExtensions
    {
            /// <summary>
            /// Retrieve the content of runbook identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            public static string GetContent(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName)
            {
                return operations.GetContentAsync(resourceGroupName, automationAccountName, runbookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the content of runbook identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetContentAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetContentWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve the runbook identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            public static Runbook Get(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, runbookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the runbook identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Runbook> GetAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create the runbook identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='parameters'>
            /// The create or update parameters for runbook. Provide either content link
            /// for a published runbook or draft, not both.
            /// </param>
            public static Runbook CreateOrUpdate(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName, RunbookCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, automationAccountName, runbookName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create the runbook identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='parameters'>
            /// The create or update parameters for runbook. Provide either content link
            /// for a published runbook or draft, not both.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Runbook> CreateOrUpdateAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName, RunbookCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the runbook identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='parameters'>
            /// The update parameters for runbook.
            /// </param>
            public static Runbook Update(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName, RunbookUpdateParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, automationAccountName, runbookName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the runbook identified by runbook name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='parameters'>
            /// The update parameters for runbook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Runbook> UpdateAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName, RunbookUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the runbook by name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            public static void Delete(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName)
            {
                operations.DeleteAsync(resourceGroupName, automationAccountName, runbookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the runbook by name.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='runbookName'>
            /// The runbook name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, string runbookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, automationAccountName, runbookName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve a list of runbooks.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            public static IPage<Runbook> ListByAutomationAccount(this IRunbookOperations operations, string resourceGroupName, string automationAccountName)
            {
                return operations.ListByAutomationAccountAsync(resourceGroupName, automationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of runbooks.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Runbook>> ListByAutomationAccountAsync(this IRunbookOperations operations, string resourceGroupName, string automationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountWithHttpMessagesAsync(resourceGroupName, automationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of runbooks.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Runbook> ListByAutomationAccountNext(this IRunbookOperations operations, string nextPageLink)
            {
                return operations.ListByAutomationAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of runbooks.
            /// <see href="http://aka.ms/azureautomationsdk/runbookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Runbook>> ListByAutomationAccountNextAsync(this IRunbookOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
