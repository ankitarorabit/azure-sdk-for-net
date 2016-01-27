// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resources
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class PolicyAssignmentsOperationsExtensions
    {
            /// <summary>
            /// Gets policy assignments of the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The name of the resource provider.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource path.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type.
            /// </param>
            /// <param name='resourceName'>
            /// The resource name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<PolicyAssignment> ListForResource(this IPolicyAssignmentsOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string filter = default(string))
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForResourceAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The name of the resource provider.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource path.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type.
            /// </param>
            /// <param name='resourceName'>
            /// The resource name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyAssignment>> ListForResourceAsync( this IPolicyAssignmentsOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceWithHttpMessagesAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<PolicyAssignment> ListForResourceGroup(this IPolicyAssignmentsOperations operations, string resourceGroupName, string filter = default(string))
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForResourceGroupAsync(resourceGroupName, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyAssignment>> ListForResourceGroupAsync( this IPolicyAssignmentsOperations operations, string resourceGroupName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupWithHttpMessagesAsync(resourceGroupName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            public static PolicyAssignment Delete(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).DeleteAsync(scope, policyAssignmentName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> DeleteAsync( this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(scope, policyAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='parameters'>
            /// Policy assignment.
            /// </param>
            public static PolicyAssignment Create(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, PolicyAssignment parameters)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).CreateAsync(scope, policyAssignmentName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='parameters'>
            /// Policy assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> CreateAsync( this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, PolicyAssignment parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(scope, policyAssignmentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get single policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            public static PolicyAssignment Get(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).GetAsync(scope, policyAssignmentName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get single policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> GetAsync( this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, policyAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            public static PolicyAssignment DeleteById(this IPolicyAssignmentsOperations operations, string policyAssignmentId)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).DeleteByIdAsync(policyAssignmentId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> DeleteByIdAsync( this IPolicyAssignmentsOperations operations, string policyAssignmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByIdWithHttpMessagesAsync(policyAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create policy assignment by Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            /// <param name='parameters'>
            /// Policy assignment.
            /// </param>
            public static PolicyAssignment CreateById(this IPolicyAssignmentsOperations operations, string policyAssignmentId, PolicyAssignment parameters)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).CreateByIdAsync(policyAssignmentId, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create policy assignment by Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            /// <param name='parameters'>
            /// Policy assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> CreateByIdAsync( this IPolicyAssignmentsOperations operations, string policyAssignmentId, PolicyAssignment parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateByIdWithHttpMessagesAsync(policyAssignmentId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get single policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            public static PolicyAssignment GetById(this IPolicyAssignmentsOperations operations, string policyAssignmentId)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).GetByIdAsync(policyAssignmentId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get single policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyAssignment> GetByIdAsync( this IPolicyAssignmentsOperations operations, string policyAssignmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(policyAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<PolicyAssignment> List(this IPolicyAssignmentsOperations operations, string filter = default(string))
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListAsync(filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyAssignment>> ListAsync( this IPolicyAssignmentsOperations operations, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<PolicyAssignment> ListForScope(this IPolicyAssignmentsOperations operations, string scope, string filter = default(string))
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForScopeAsync(scope, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyAssignment>> ListForScopeAsync( this IPolicyAssignmentsOperations operations, string scope, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForScopeWithHttpMessagesAsync(scope, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PolicyAssignment> ListForResourceNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForResourceNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the resource.
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
            public static async Task<IPage<PolicyAssignment>> ListForResourceNextAsync( this IPolicyAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PolicyAssignment> ListForResourceGroupNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForResourceGroupNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the resource group.
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
            public static async Task<IPage<PolicyAssignment>> ListForResourceGroupNextAsync( this IPolicyAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PolicyAssignment> ListNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the subscription.
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
            public static async Task<IPage<PolicyAssignment>> ListNextAsync( this IPolicyAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PolicyAssignment> ListForScopeNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForScopeNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the scope.
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
            public static async Task<IPage<PolicyAssignment>> ListForScopeNextAsync( this IPolicyAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
