﻿// --------------------------------------------------------------------------------------------------------------------
// SPDX-FileCopyrightText: 2023 Siemens AG
//
//  SPDX-License-Identifier: MIT

// -------------------------------------------------------------------------------------------------------------------- 

using Newtonsoft.Json;
using System.Collections.Generic;

namespace LCT.APICommunications.Model
{
    /// <summary>
    /// The ReleasesInfo model
    /// </summary>

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class ReleasesInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("clearingState")]
        public string ClearingState { get; set; }

        [JsonProperty("sourceCodeDownloadurl")]
        public string SourceCodeDownloadUrl { get; set; }


        [JsonProperty("binaryDownloadurl")]
        public string BinaryDownloadUrl { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("eccInformation")]
        public EccInformation EccInformation { get; set; }

        [JsonProperty("_links")]
        public ReleaseLinks Links { get; set; }

        [JsonProperty("additionalData")]
        public Dictionary<string, string> AdditionalData { get; set; }

        [JsonProperty("externalIds")]
        public Dictionary<string, string> ExternalIds { get; set; }

        [JsonProperty("_embedded")]
        public AttachmentEmbedded Embedded { get; set; }
    }
}
