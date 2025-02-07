// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    /// <summary> The upgrade to apply to a ManagedCluster. </summary>
    public partial class FleetManagedClusterUpgradeSpec
    {
        /// <summary> Initializes a new instance of FleetManagedClusterUpgradeSpec. </summary>
        /// <param name="upgradeType">
        /// The upgrade type.
        /// Full requires the KubernetesVersion property to be set.
        /// NodeImageOnly requires the KubernetesVersion property not to be set.
        /// </param>
        public FleetManagedClusterUpgradeSpec(FleetManagedClusterUpgradeType upgradeType)
        {
            UpgradeType = upgradeType;
        }

        /// <summary> Initializes a new instance of FleetManagedClusterUpgradeSpec. </summary>
        /// <param name="upgradeType">
        /// The upgrade type.
        /// Full requires the KubernetesVersion property to be set.
        /// NodeImageOnly requires the KubernetesVersion property not to be set.
        /// </param>
        /// <param name="kubernetesVersion"> The Kubernetes version to upgrade the member clusters to. </param>
        internal FleetManagedClusterUpgradeSpec(FleetManagedClusterUpgradeType upgradeType, string kubernetesVersion)
        {
            UpgradeType = upgradeType;
            KubernetesVersion = kubernetesVersion;
        }

        /// <summary>
        /// The upgrade type.
        /// Full requires the KubernetesVersion property to be set.
        /// NodeImageOnly requires the KubernetesVersion property not to be set.
        /// </summary>
        public FleetManagedClusterUpgradeType UpgradeType { get; set; }
        /// <summary> The Kubernetes version to upgrade the member clusters to. </summary>
        public string KubernetesVersion { get; set; }
    }
}
