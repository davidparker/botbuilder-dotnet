﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace Microsoft.Bot.Builder.Ai.Translation.Model
{
    public class TranslationModel
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("alignment")]
        public Alignment Alignment { get; set; }

        [JsonProperty("sentLen")]
        public SentencesLength SentencesLength { get; set; }
    }
}