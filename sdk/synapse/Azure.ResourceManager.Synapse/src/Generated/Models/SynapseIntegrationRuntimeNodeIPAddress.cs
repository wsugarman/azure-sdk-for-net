// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The IP address of self-hosted integration runtime node. </summary>
    public partial class SynapseIntegrationRuntimeNodeIPAddress
    {
        /// <summary> Initializes a new instance of SynapseIntegrationRuntimeNodeIPAddress. </summary>
        internal SynapseIntegrationRuntimeNodeIPAddress()
        {
        }

        /// <summary> Initializes a new instance of SynapseIntegrationRuntimeNodeIPAddress. </summary>
        /// <param name="ipAddress"> The IP address of self-hosted integration runtime node. </param>
        internal SynapseIntegrationRuntimeNodeIPAddress(IPAddress ipAddress)
        {
            IPAddress = ipAddress;
        }

        /// <summary> The IP address of self-hosted integration runtime node. </summary>
        public IPAddress IPAddress { get; }
    }
}
