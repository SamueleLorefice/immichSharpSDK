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
    /// Defines ImageFormat
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageFormat
    {
        /// <summary>
        /// Enum Jpeg for value: jpeg
        /// </summary>
        [EnumMember(Value = "jpeg")]
        Jpeg = 1,

        /// <summary>
        /// Enum Webp for value: webp
        /// </summary>
        [EnumMember(Value = "webp")]
        Webp = 2
    }

}
