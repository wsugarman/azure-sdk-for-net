// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownMonitoringAlertNotificationSettingsBase. </summary>
    internal partial class UnknownMonitoringAlertNotificationSettingsBase : MonitoringAlertNotificationSettingsBase
    {
        /// <summary> Initializes a new instance of UnknownMonitoringAlertNotificationSettingsBase. </summary>
        /// <param name="alertNotificationType"> [Required] Specifies the type of signal to monitor. </param>
        internal UnknownMonitoringAlertNotificationSettingsBase(MonitoringAlertNotificationType alertNotificationType) : base(alertNotificationType)
        {
            AlertNotificationType = alertNotificationType;
        }
    }
}
