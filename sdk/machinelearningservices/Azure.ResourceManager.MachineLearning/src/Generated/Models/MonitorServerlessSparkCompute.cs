// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Monitor serverless spark compute definition. </summary>
    public partial class MonitorServerlessSparkCompute : MonitorComputeConfigurationBase
    {
        /// <summary> Initializes a new instance of MonitorServerlessSparkCompute. </summary>
        /// <param name="computeIdentity">
        /// [Required] The identity scheme leveraged to by the spark jobs running on serverless Spark.
        /// Please note <see cref="MonitorComputeIdentityBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlTokenComputeIdentity"/> and <see cref="ManagedComputeIdentity"/>.
        /// </param>
        /// <param name="instanceType"> [Required] The instance type running the Spark job. </param>
        /// <param name="runtimeVersion"> [Required] The Spark runtime version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="computeIdentity"/>, <paramref name="instanceType"/> or <paramref name="runtimeVersion"/> is null. </exception>
        public MonitorServerlessSparkCompute(MonitorComputeIdentityBase computeIdentity, string instanceType, string runtimeVersion)
        {
            Argument.AssertNotNull(computeIdentity, nameof(computeIdentity));
            Argument.AssertNotNull(instanceType, nameof(instanceType));
            Argument.AssertNotNull(runtimeVersion, nameof(runtimeVersion));

            ComputeIdentity = computeIdentity;
            InstanceType = instanceType;
            RuntimeVersion = runtimeVersion;
            ComputeType = MonitorComputeType.ServerlessSpark;
        }

        /// <summary> Initializes a new instance of MonitorServerlessSparkCompute. </summary>
        /// <param name="computeType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="computeIdentity">
        /// [Required] The identity scheme leveraged to by the spark jobs running on serverless Spark.
        /// Please note <see cref="MonitorComputeIdentityBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlTokenComputeIdentity"/> and <see cref="ManagedComputeIdentity"/>.
        /// </param>
        /// <param name="instanceType"> [Required] The instance type running the Spark job. </param>
        /// <param name="runtimeVersion"> [Required] The Spark runtime version. </param>
        internal MonitorServerlessSparkCompute(MonitorComputeType computeType, MonitorComputeIdentityBase computeIdentity, string instanceType, string runtimeVersion) : base(computeType)
        {
            ComputeIdentity = computeIdentity;
            InstanceType = instanceType;
            RuntimeVersion = runtimeVersion;
            ComputeType = computeType;
        }

        /// <summary>
        /// [Required] The identity scheme leveraged to by the spark jobs running on serverless Spark.
        /// Please note <see cref="MonitorComputeIdentityBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlTokenComputeIdentity"/> and <see cref="ManagedComputeIdentity"/>.
        /// </summary>
        public MonitorComputeIdentityBase ComputeIdentity { get; set; }
        /// <summary> [Required] The instance type running the Spark job. </summary>
        public string InstanceType { get; set; }
        /// <summary> [Required] The Spark runtime version. </summary>
        public string RuntimeVersion { get; set; }
    }
}
