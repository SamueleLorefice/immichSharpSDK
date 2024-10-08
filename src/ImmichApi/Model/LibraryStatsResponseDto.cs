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
    /// LibraryStatsResponseDto
    /// </summary>
    [DataContract(Name = "LibraryStatsResponseDto")]
    public partial class LibraryStatsResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryStatsResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LibraryStatsResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryStatsResponseDto" /> class.
        /// </summary>
        /// <param name="photos">photos (required) (default to 0).</param>
        /// <param name="total">total (required) (default to 0).</param>
        /// <param name="usage">usage (required) (default to 0).</param>
        /// <param name="videos">videos (required) (default to 0).</param>
        public LibraryStatsResponseDto(int photos = 0, int total = 0, long usage = 0, int videos = 0)
        {
            this.Photos = photos;
            this.Total = total;
            this.Usage = usage;
            this.Videos = videos;
        }

        /// <summary>
        /// Gets or Sets Photos
        /// </summary>
        [DataMember(Name = "photos", IsRequired = true, EmitDefaultValue = true)]
        public int Photos { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name = "usage", IsRequired = true, EmitDefaultValue = true)]
        public long Usage { get; set; }

        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name = "videos", IsRequired = true, EmitDefaultValue = true)]
        public int Videos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LibraryStatsResponseDto {\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
