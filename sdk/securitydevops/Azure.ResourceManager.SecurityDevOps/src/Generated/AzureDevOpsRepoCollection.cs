// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary>
    /// A class representing a collection of <see cref="AzureDevOpsRepoResource" /> and their operations.
    /// Each <see cref="AzureDevOpsRepoResource" /> in the collection will belong to the same instance of <see cref="AzureDevOpsProjectResource" />.
    /// To get an <see cref="AzureDevOpsRepoCollection" /> instance call the GetAzureDevOpsRepos method from an instance of <see cref="AzureDevOpsProjectResource" />.
    /// </summary>
    public partial class AzureDevOpsRepoCollection : ArmCollection, IEnumerable<AzureDevOpsRepoResource>, IAsyncEnumerable<AzureDevOpsRepoResource>
    {
        private readonly ClientDiagnostics _azureDevOpsRepoClientDiagnostics;
        private readonly AzureDevOpsRepoRestOperations _azureDevOpsRepoRestClient;

        /// <summary> Initializes a new instance of the <see cref="AzureDevOpsRepoCollection"/> class for mocking. </summary>
        protected AzureDevOpsRepoCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AzureDevOpsRepoCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AzureDevOpsRepoCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _azureDevOpsRepoClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityDevOps", AzureDevOpsRepoResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AzureDevOpsRepoResource.ResourceType, out string azureDevOpsRepoApiVersion);
            _azureDevOpsRepoRestClient = new AzureDevOpsRepoRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, azureDevOpsRepoApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AzureDevOpsProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AzureDevOpsProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates an Azure DevOps Repo.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="data"> Azure DevOps Repo resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AzureDevOpsRepoResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string azureDevOpsRepoName, AzureDevOpsRepoData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsRepoName, nameof(azureDevOpsRepoName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureDevOpsRepoClientDiagnostics.CreateScope("AzureDevOpsRepoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _azureDevOpsRepoRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityDevOpsArmOperation<AzureDevOpsRepoResource>(new AzureDevOpsRepoOperationSource(Client), _azureDevOpsRepoClientDiagnostics, Pipeline, _azureDevOpsRepoRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an Azure DevOps Repo.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="data"> Azure DevOps Repo resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AzureDevOpsRepoResource> CreateOrUpdate(WaitUntil waitUntil, string azureDevOpsRepoName, AzureDevOpsRepoData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsRepoName, nameof(azureDevOpsRepoName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _azureDevOpsRepoClientDiagnostics.CreateScope("AzureDevOpsRepoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _azureDevOpsRepoRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, data, cancellationToken);
                var operation = new SecurityDevOpsArmOperation<AzureDevOpsRepoResource>(new AzureDevOpsRepoOperationSource(Client), _azureDevOpsRepoClientDiagnostics, Pipeline, _azureDevOpsRepoRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Project resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> is null. </exception>
        public virtual async Task<Response<AzureDevOpsRepoResource>> GetAsync(string azureDevOpsRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsRepoName, nameof(azureDevOpsRepoName));

            using var scope = _azureDevOpsRepoClientDiagnostics.CreateScope("AzureDevOpsRepoCollection.Get");
            scope.Start();
            try
            {
                var response = await _azureDevOpsRepoRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsRepoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Project resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> is null. </exception>
        public virtual Response<AzureDevOpsRepoResource> Get(string azureDevOpsRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsRepoName, nameof(azureDevOpsRepoName));

            using var scope = _azureDevOpsRepoClientDiagnostics.CreateScope("AzureDevOpsRepoCollection.Get");
            scope.Start();
            try
            {
                var response = _azureDevOpsRepoRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsRepoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureDevOpsRepoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureDevOpsRepoResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureDevOpsRepoRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureDevOpsRepoRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AzureDevOpsRepoResource(Client, AzureDevOpsRepoData.DeserializeAzureDevOpsRepoData(e)), _azureDevOpsRepoClientDiagnostics, Pipeline, "AzureDevOpsRepoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureDevOpsRepoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureDevOpsRepoResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _azureDevOpsRepoRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _azureDevOpsRepoRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AzureDevOpsRepoResource(Client, AzureDevOpsRepoData.DeserializeAzureDevOpsRepoData(e)), _azureDevOpsRepoClientDiagnostics, Pipeline, "AzureDevOpsRepoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string azureDevOpsRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsRepoName, nameof(azureDevOpsRepoName));

            using var scope = _azureDevOpsRepoClientDiagnostics.CreateScope("AzureDevOpsRepoCollection.Exists");
            scope.Start();
            try
            {
                var response = await _azureDevOpsRepoRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> is null. </exception>
        public virtual Response<bool> Exists(string azureDevOpsRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsRepoName, nameof(azureDevOpsRepoName));

            using var scope = _azureDevOpsRepoClientDiagnostics.CreateScope("AzureDevOpsRepoCollection.Exists");
            scope.Start();
            try
            {
                var response = _azureDevOpsRepoRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> is null. </exception>
        public virtual async Task<NullableResponse<AzureDevOpsRepoResource>> GetIfExistsAsync(string azureDevOpsRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsRepoName, nameof(azureDevOpsRepoName));

            using var scope = _azureDevOpsRepoClientDiagnostics.CreateScope("AzureDevOpsRepoCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _azureDevOpsRepoRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AzureDevOpsRepoResource>(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsRepoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}/orgs/{azureDevOpsOrgName}/projects/{azureDevOpsProjectName}/repos/{azureDevOpsRepoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepo_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsRepoName"> Name of the AzureDevOps Repo. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsRepoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsRepoName"/> is null. </exception>
        public virtual NullableResponse<AzureDevOpsRepoResource> GetIfExists(string azureDevOpsRepoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureDevOpsRepoName, nameof(azureDevOpsRepoName));

            using var scope = _azureDevOpsRepoClientDiagnostics.CreateScope("AzureDevOpsRepoCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _azureDevOpsRepoRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, azureDevOpsRepoName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AzureDevOpsRepoResource>(response.GetRawResponse());
                return Response.FromValue(new AzureDevOpsRepoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AzureDevOpsRepoResource> IEnumerable<AzureDevOpsRepoResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AzureDevOpsRepoResource> IAsyncEnumerable<AzureDevOpsRepoResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
