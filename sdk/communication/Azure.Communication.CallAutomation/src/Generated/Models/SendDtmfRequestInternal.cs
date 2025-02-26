// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The SendDtmfRequest. </summary>
    internal partial class SendDtmfRequestInternal
    {
        /// <summary> Initializes a new instance of SendDtmfRequestInternal. </summary>
        /// <param name="tones"> List of tones to be sent to target participant. </param>
        /// <param name="targetParticipant"> Target participant of send DTMF. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tones"/> or <paramref name="targetParticipant"/> is null. </exception>
        public SendDtmfRequestInternal(IEnumerable<DtmfTone> tones, CommunicationIdentifierModel targetParticipant)
        {
            Argument.AssertNotNull(tones, nameof(tones));
            Argument.AssertNotNull(targetParticipant, nameof(targetParticipant));

            Tones = tones.ToList();
            TargetParticipant = targetParticipant;
        }

        /// <summary> List of tones to be sent to target participant. </summary>
        public IList<DtmfTone> Tones { get; }
        /// <summary> Target participant of send DTMF. </summary>
        public CommunicationIdentifierModel TargetParticipant { get; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; set; }
        /// <summary> The callback URI to override the main callback URI. </summary>
        public string CallbackUri { get; set; }
    }
}
