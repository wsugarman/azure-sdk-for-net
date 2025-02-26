// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The cloudwatch to kinesis connection configuration. </summary>
    internal partial class DefenderForContainersAwsOfferingCloudWatchToKinesis
    {
        /// <summary> Initializes a new instance of DefenderForContainersAwsOfferingCloudWatchToKinesis. </summary>
        public DefenderForContainersAwsOfferingCloudWatchToKinesis()
        {
        }

        /// <summary> Initializes a new instance of DefenderForContainersAwsOfferingCloudWatchToKinesis. </summary>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS used by CloudWatch to transfer data into Kinesis. </param>
        internal DefenderForContainersAwsOfferingCloudWatchToKinesis(string cloudRoleArn)
        {
            CloudRoleArn = cloudRoleArn;
        }

        /// <summary> The cloud role ARN in AWS used by CloudWatch to transfer data into Kinesis. </summary>
        public string CloudRoleArn { get; set; }
    }
}
