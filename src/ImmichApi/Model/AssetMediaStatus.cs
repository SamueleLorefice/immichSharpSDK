/*
 * Immich
 *
 * Immich API
 *
 * The version of the OpenAPI document: 1.110.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ImmichApi.Client.OpenAPIDateConverter;

namespace ImmichApi.Model
{
    /// <summary>
    /// Defines AssetMediaStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssetMediaStatus
    {
        /// <summary>
        /// Enum Created for value: created
        /// </summary>
        [EnumMember(Value = "created")]
        Created = 1,

        /// <summary>
        /// Enum Replaced for value: replaced
        /// </summary>
        [EnumMember(Value = "replaced")]
        Replaced = 2,

        /// <summary>
        /// Enum Duplicate for value: duplicate
        /// </summary>
        [EnumMember(Value = "duplicate")]
        Duplicate = 3
    }

}
