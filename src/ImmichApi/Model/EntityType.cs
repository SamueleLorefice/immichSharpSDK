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
    /// Defines EntityType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityType
    {
        /// <summary>
        /// Enum ASSET for value: ASSET
        /// </summary>
        [EnumMember(Value = "ASSET")]
        ASSET = 1,

        /// <summary>
        /// Enum ALBUM for value: ALBUM
        /// </summary>
        [EnumMember(Value = "ALBUM")]
        ALBUM = 2
    }

}
