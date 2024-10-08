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
    /// Defines TimeBucketSize
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeBucketSize
    {
        /// <summary>
        /// Enum DAY for value: DAY
        /// </summary>
        [EnumMember(Value = "DAY")]
        DAY = 1,

        /// <summary>
        /// Enum MONTH for value: MONTH
        /// </summary>
        [EnumMember(Value = "MONTH")]
        MONTH = 2
    }

}
