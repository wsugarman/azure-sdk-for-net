// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Self-hosted integration runtime. </summary>
    public partial class SelfHostedIntegrationRuntime : DataFactoryIntegrationRuntimeProperties
    {
        /// <summary> Initializes a new instance of SelfHostedIntegrationRuntime. </summary>
        public SelfHostedIntegrationRuntime()
        {
            IntegrationRuntimeType = IntegrationRuntimeType.SelfHosted;
        }

        /// <summary> Initializes a new instance of SelfHostedIntegrationRuntime. </summary>
        /// <param name="integrationRuntimeType"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedInfo">
        /// The base definition of a linked integration runtime.
        /// Please note <see cref="LinkedIntegrationRuntimeType"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LinkedIntegrationRuntimeKeyAuthorization"/> and <see cref="LinkedIntegrationRuntimeRbacAuthorization"/>.
        /// </param>
        /// <param name="isSelfContainedInteractiveAuthoringEnabled"> An alternative option to ensure interactive authoring function when your self-hosted integration runtime is unable to establish a connection with Azure Relay. </param>
        internal SelfHostedIntegrationRuntime(IntegrationRuntimeType integrationRuntimeType, string description, IDictionary<string, BinaryData> additionalProperties, LinkedIntegrationRuntimeType linkedInfo, bool? isSelfContainedInteractiveAuthoringEnabled) : base(integrationRuntimeType, description, additionalProperties)
        {
            LinkedInfo = linkedInfo;
            IsSelfContainedInteractiveAuthoringEnabled = isSelfContainedInteractiveAuthoringEnabled;
            IntegrationRuntimeType = integrationRuntimeType;
        }

        /// <summary>
        /// The base definition of a linked integration runtime.
        /// Please note <see cref="LinkedIntegrationRuntimeType"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LinkedIntegrationRuntimeKeyAuthorization"/> and <see cref="LinkedIntegrationRuntimeRbacAuthorization"/>.
        /// </summary>
        public LinkedIntegrationRuntimeType LinkedInfo { get; set; }
        /// <summary> An alternative option to ensure interactive authoring function when your self-hosted integration runtime is unable to establish a connection with Azure Relay. </summary>
        public bool? IsSelfContainedInteractiveAuthoringEnabled { get; set; }
    }
}
