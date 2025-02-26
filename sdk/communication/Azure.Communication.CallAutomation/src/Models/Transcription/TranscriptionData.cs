﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Azure.Communication.CallAutomation.Models.Transcription
{
    /// <summary>
    /// Streaming Transcription.
    /// </summary>
    internal class TranscriptionData : TranscriptionPackageBase
    {
        internal TranscriptionData(string text, string format, double confidence, ulong offset, IEnumerable<Word> words, string participantRawID, string resultStatus)
        {
            Text = text;
            Format = ConvertToTextFormatEnum(format);
            Confidence = confidence;
            Offset = offset;
            Words = words;
            if (participantRawID != null)
            {
                Participant = new CommunicationUserIdentifier(participantRawID);
            }
            ResultStatus = ConvertToResultStatusEnum(resultStatus);
        }

        /// <summary>
        /// The display form of the recognized word
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The format of text
        /// </summary>
        public TextFormat Format { get; set; }

        /// <summary>
        /// Confidence of recognition of the whole phrase, from 0.0 (no confidence) to 1.0 (full confidence)
        /// </summary>
        public double Confidence { get; set; }

        /// <summary>
        /// The position of this payload
        /// </summary>

        public ulong Offset { get; set; }

        /// <summary>
        /// The result for each word of the phrase
        /// </summary>
        public IEnumerable<Word> Words { get; set; }

        /// <summary>
        /// The identified speaker based on participant raw ID
        /// </summary>
        public CommunicationUserIdentifier Participant { get; set; }

        /// <summary>
        /// Status of the result of transcription
        /// </summary>
        public ResultStatus ResultStatus { get; set; }

        private static ResultStatus ConvertToResultStatusEnum(string resultStatus)
        {
            switch (resultStatus)
            {
                case "intermediate":
                    return ResultStatus.Intermediate;
                case "final":
                    return ResultStatus.Final;
                default:
                    throw new NotSupportedException(resultStatus);
            }
        }

        private static TextFormat ConvertToTextFormatEnum(string format)
        {
            switch (format)
            {
                case "display":
                    return TextFormat.Display;
                default:
                    throw new NotSupportedException(format);
            }
        }
    }
}
