// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> OData page of project resources. </summary>
    internal partial class ProjectList
    {
        /// <summary> Initializes a new instance of ProjectList. </summary>
        internal ProjectList()
        {
            Value = new ChangeTrackingList<ProjectData>();
        }

        /// <summary> Initializes a new instance of ProjectList. </summary>
        /// <param name="value"> List of projects. </param>
        /// <param name="nextLink"> URL to load the next page of projects. </param>
        internal ProjectList(IReadOnlyList<ProjectData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of projects. </summary>
        public IReadOnlyList<ProjectData> Value { get; }
        /// <summary> URL to load the next page of projects. </summary>
        public string NextLink { get; }
    }
}
