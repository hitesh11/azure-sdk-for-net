// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApplicationGatewaysOperations.
    /// </summary>
    public static partial class ApplicationGatewaysOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Delete(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                operations.DeleteAsync(resourceGroupName, applicationGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static ApplicationGateway Get(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                return operations.GetAsync(resourceGroupName, applicationGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGateway> GetAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update application gateway operation.
            /// </param>
            public static ApplicationGateway CreateOrUpdate(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, applicationGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update application gateway operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGateway> CreateOrUpdateAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all application gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<ApplicationGateway> List(this IApplicationGatewaysOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all application gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationGateway>> ListAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the application gateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ApplicationGateway> ListAll(this IApplicationGatewaysOperations operations)
            {
                return operations.ListAllAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the application gateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationGateway>> ListAllAsync(this IApplicationGatewaysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Starts the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Start(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                operations.StartAsync(resourceGroupName, applicationGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StartWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stops the specified application gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Stop(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                operations.StopAsync(resourceGroupName, applicationGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops the specified application gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StopWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the backend health of the specified application gateway in a resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='expand'>
            /// Expands BackendAddressPool and BackendHttpSettings referenced in backend
            /// health.
            /// </param>
            public static ApplicationGatewayBackendHealth BackendHealth(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, string expand = default(string))
            {
                return operations.BackendHealthAsync(resourceGroupName, applicationGatewayName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the backend health of the specified application gateway in a resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='expand'>
            /// Expands BackendAddressPool and BackendHttpSettings referenced in backend
            /// health.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayBackendHealth> BackendHealthAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BackendHealthWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all available web application firewall rule sets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ApplicationGatewayAvailableWafRuleSetsResult ListAvailableWafRuleSets(this IApplicationGatewaysOperations operations)
            {
                return operations.ListAvailableWafRuleSetsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all available web application firewall rule sets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayAvailableWafRuleSetsResult> ListAvailableWafRuleSetsAsync(this IApplicationGatewaysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAvailableWafRuleSetsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists available Ssl options for configuring Ssl policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ApplicationGatewayAvailableSslOptions ListAvailableSslOptions(this IApplicationGatewaysOperations operations)
            {
                return operations.ListAvailableSslOptionsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists available Ssl options for configuring Ssl policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayAvailableSslOptions> ListAvailableSslOptionsAsync(this IApplicationGatewaysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAvailableSslOptionsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all SSL predefined policies for configuring Ssl policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ApplicationGatewaySslPredefinedPolicy> ListAvailableSslPredefinedPolicies(this IApplicationGatewaysOperations operations)
            {
                return operations.ListAvailableSslPredefinedPoliciesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all SSL predefined policies for configuring Ssl policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationGatewaySslPredefinedPolicy>> ListAvailableSslPredefinedPoliciesAsync(this IApplicationGatewaysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAvailableSslPredefinedPoliciesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets Ssl predefined policy with the specified policy name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='predefinedPolicyName'>
            /// Name of Ssl predefined policy.
            /// </param>
            public static ApplicationGatewaySslPredefinedPolicy GetSslPredefinedPolicy(this IApplicationGatewaysOperations operations, string predefinedPolicyName)
            {
                return operations.GetSslPredefinedPolicyAsync(predefinedPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets Ssl predefined policy with the specified policy name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='predefinedPolicyName'>
            /// Name of Ssl predefined policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGatewaySslPredefinedPolicy> GetSslPredefinedPolicyAsync(this IApplicationGatewaysOperations operations, string predefinedPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSslPredefinedPolicyWithHttpMessagesAsync(predefinedPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginDelete(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                operations.BeginDeleteAsync(resourceGroupName, applicationGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update application gateway operation.
            /// </param>
            public static ApplicationGateway BeginCreateOrUpdate(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, applicationGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update application gateway operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGateway> BeginCreateOrUpdateAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Starts the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginStart(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                operations.BeginStartAsync(resourceGroupName, applicationGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts the specified application gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stops the specified application gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginStop(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                operations.BeginStopAsync(resourceGroupName, applicationGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops the specified application gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStopAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the backend health of the specified application gateway in a resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='expand'>
            /// Expands BackendAddressPool and BackendHttpSettings referenced in backend
            /// health.
            /// </param>
            public static ApplicationGatewayBackendHealth BeginBackendHealth(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, string expand = default(string))
            {
                return operations.BeginBackendHealthAsync(resourceGroupName, applicationGatewayName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the backend health of the specified application gateway in a resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='expand'>
            /// Expands BackendAddressPool and BackendHttpSettings referenced in backend
            /// health.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayBackendHealth> BeginBackendHealthAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginBackendHealthWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all application gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationGateway> ListNext(this IApplicationGatewaysOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all application gateways in a resource group.
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
            public static async Task<IPage<ApplicationGateway>> ListNextAsync(this IApplicationGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the application gateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationGateway> ListAllNext(this IApplicationGatewaysOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the application gateways in a subscription.
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
            public static async Task<IPage<ApplicationGateway>> ListAllNextAsync(this IApplicationGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all SSL predefined policies for configuring Ssl policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApplicationGatewaySslPredefinedPolicy> ListAvailableSslPredefinedPoliciesNext(this IApplicationGatewaysOperations operations, string nextPageLink)
            {
                return operations.ListAvailableSslPredefinedPoliciesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all SSL predefined policies for configuring Ssl policy.
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
            public static async Task<IPage<ApplicationGatewaySslPredefinedPolicy>> ListAvailableSslPredefinedPoliciesNextAsync(this IApplicationGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAvailableSslPredefinedPoliciesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
