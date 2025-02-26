// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Synapse notebook reference type. </summary>
    public partial class SynapseNotebookReference
    {
        /// <summary> Initializes a new instance of SynapseNotebookReference. </summary>
        /// <param name="notebookReferenceType"> Synapse notebook reference type. </param>
        /// <param name="referenceName"> Reference notebook name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public SynapseNotebookReference(NotebookReferenceType notebookReferenceType, DataFactoryElement<string> referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            NotebookReferenceType = notebookReferenceType;
            ReferenceName = referenceName;
        }

        /// <summary> Synapse notebook reference type. </summary>
        public NotebookReferenceType NotebookReferenceType { get; set; }
        /// <summary> Reference notebook name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ReferenceName { get; set; }
    }
}
