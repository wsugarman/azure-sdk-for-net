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
using Azure.ResourceManager.IotHub.Models;

namespace Azure.ResourceManager.IotHub
{
    /// <summary>
    /// A class representing a collection of <see cref="EventHubConsumerGroupInfoResource" /> and their operations.
    /// Each <see cref="EventHubConsumerGroupInfoResource" /> in the collection will belong to the same instance of <see cref="IotHubDescriptionResource" />.
    /// To get an <see cref="EventHubConsumerGroupInfoCollection" /> instance call the GetEventHubConsumerGroupInfos method from an instance of <see cref="IotHubDescriptionResource" />.
    /// </summary>
    public partial class EventHubConsumerGroupInfoCollection : ArmCollection, IEnumerable<EventHubConsumerGroupInfoResource>, IAsyncEnumerable<EventHubConsumerGroupInfoResource>
    {
        private readonly ClientDiagnostics _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics;
        private readonly IotHubResourceRestOperations _eventHubConsumerGroupInfoIotHubResourceRestClient;
        private readonly string _eventHubEndpointName;

        /// <summary> Initializes a new instance of the <see cref="EventHubConsumerGroupInfoCollection"/> class for mocking. </summary>
        protected EventHubConsumerGroupInfoCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubConsumerGroupInfoCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="eventHubEndpointName"> The name of the Event Hub-compatible endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubEndpointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventHubEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        internal EventHubConsumerGroupInfoCollection(ArmClient client, ResourceIdentifier id, string eventHubEndpointName) : base(client, id)
        {
            _eventHubEndpointName = eventHubEndpointName;
            _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotHub", EventHubConsumerGroupInfoResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubConsumerGroupInfoResource.ResourceType, out string eventHubConsumerGroupInfoIotHubResourceApiVersion);
            _eventHubConsumerGroupInfoIotHubResourceRestClient = new IotHubResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubConsumerGroupInfoIotHubResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IotHubDescriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IotHubDescriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Add a consumer group to an Event Hub-compatible endpoint in an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_CreateEventHubConsumerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the consumer group to add. </param>
        /// <param name="content"> The consumer group to add. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubConsumerGroupInfoResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, EventHubConsumerGroupInfoCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics.CreateScope("EventHubConsumerGroupInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubConsumerGroupInfoIotHubResourceRestClient.CreateEventHubConsumerGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName, name, content, cancellationToken).ConfigureAwait(false);
                var operation = new IotHubArmOperation<EventHubConsumerGroupInfoResource>(Response.FromValue(new EventHubConsumerGroupInfoResource(Client, response), response.GetRawResponse()));
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
        /// Add a consumer group to an Event Hub-compatible endpoint in an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_CreateEventHubConsumerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the consumer group to add. </param>
        /// <param name="content"> The consumer group to add. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<EventHubConsumerGroupInfoResource> CreateOrUpdate(WaitUntil waitUntil, string name, EventHubConsumerGroupInfoCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics.CreateScope("EventHubConsumerGroupInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubConsumerGroupInfoIotHubResourceRestClient.CreateEventHubConsumerGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName, name, content, cancellationToken);
                var operation = new IotHubArmOperation<EventHubConsumerGroupInfoResource>(Response.FromValue(new EventHubConsumerGroupInfoResource(Client, response), response.GetRawResponse()));
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
        /// Get a consumer group from the Event Hub-compatible device-to-cloud endpoint for an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_GetEventHubConsumerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the consumer group to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<EventHubConsumerGroupInfoResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics.CreateScope("EventHubConsumerGroupInfoCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubConsumerGroupInfoIotHubResourceRestClient.GetEventHubConsumerGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubConsumerGroupInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a consumer group from the Event Hub-compatible device-to-cloud endpoint for an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_GetEventHubConsumerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the consumer group to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<EventHubConsumerGroupInfoResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics.CreateScope("EventHubConsumerGroupInfoCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubConsumerGroupInfoIotHubResourceRestClient.GetEventHubConsumerGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubConsumerGroupInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of the consumer groups in the Event Hub-compatible device-to-cloud endpoint in an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_ListEventHubConsumerGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubConsumerGroupInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubConsumerGroupInfoResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubConsumerGroupInfoIotHubResourceRestClient.CreateListEventHubConsumerGroupsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubConsumerGroupInfoIotHubResourceRestClient.CreateListEventHubConsumerGroupsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubConsumerGroupInfoResource(Client, EventHubConsumerGroupInfoData.DeserializeEventHubConsumerGroupInfoData(e)), _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics, Pipeline, "EventHubConsumerGroupInfoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of the consumer groups in the Event Hub-compatible device-to-cloud endpoint in an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_ListEventHubConsumerGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubConsumerGroupInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubConsumerGroupInfoResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubConsumerGroupInfoIotHubResourceRestClient.CreateListEventHubConsumerGroupsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubConsumerGroupInfoIotHubResourceRestClient.CreateListEventHubConsumerGroupsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubConsumerGroupInfoResource(Client, EventHubConsumerGroupInfoData.DeserializeEventHubConsumerGroupInfoData(e)), _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics, Pipeline, "EventHubConsumerGroupInfoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_GetEventHubConsumerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the consumer group to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics.CreateScope("EventHubConsumerGroupInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubConsumerGroupInfoIotHubResourceRestClient.GetEventHubConsumerGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_GetEventHubConsumerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the consumer group to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics.CreateScope("EventHubConsumerGroupInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubConsumerGroupInfoIotHubResourceRestClient.GetEventHubConsumerGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_GetEventHubConsumerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the consumer group to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<EventHubConsumerGroupInfoResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics.CreateScope("EventHubConsumerGroupInfoCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubConsumerGroupInfoIotHubResourceRestClient.GetEventHubConsumerGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EventHubConsumerGroupInfoResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubConsumerGroupInfoResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/eventHubEndpoints/{eventHubEndpointName}/ConsumerGroups/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_GetEventHubConsumerGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the consumer group to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<EventHubConsumerGroupInfoResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _eventHubConsumerGroupInfoIotHubResourceClientDiagnostics.CreateScope("EventHubConsumerGroupInfoCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubConsumerGroupInfoIotHubResourceRestClient.GetEventHubConsumerGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _eventHubEndpointName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EventHubConsumerGroupInfoResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubConsumerGroupInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubConsumerGroupInfoResource> IEnumerable<EventHubConsumerGroupInfoResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubConsumerGroupInfoResource> IAsyncEnumerable<EventHubConsumerGroupInfoResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
