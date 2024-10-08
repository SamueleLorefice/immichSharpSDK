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
    /// Defines LogLevel
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LogLevel
    {
        /// <summary>
        /// Enum Verbose for value: verbose
        /// </summary>
        [EnumMember(Value = "verbose")]
        Verbose = 1,

        /// <summary>
        /// Enum Debug for value: debug
        /// </summary>
        [EnumMember(Value = "debug")]
        Debug = 2,

        /// <summary>
        /// Enum Log for value: log
        /// </summary>
        [EnumMember(Value = "log")]
        Log = 3,

        /// <summary>
        /// Enum Warn for value: warn
        /// </summary>
        [EnumMember(Value = "warn")]
        Warn = 4,

        /// <summary>
        /// Enum Error for value: error
        /// </summary>
        [EnumMember(Value = "error")]
        Error = 5,

        /// <summary>
        /// Enum Fatal for value: fatal
        /// </summary>
        [EnumMember(Value = "fatal")]
        Fatal = 6
    }

}
