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
    /// ServerMediaTypesResponseDto
    /// </summary>
    [DataContract(Name = "ServerMediaTypesResponseDto")]
    public partial class ServerMediaTypesResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMediaTypesResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServerMediaTypesResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMediaTypesResponseDto" /> class.
        /// </summary>
        /// <param name="image">image (required).</param>
        /// <param name="sidecar">sidecar (required).</param>
        /// <param name="video">video (required).</param>
        public ServerMediaTypesResponseDto(List<string> image = default(List<string>), List<string> sidecar = default(List<string>), List<string> video = default(List<string>))
        {
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for ServerMediaTypesResponseDto and cannot be null");
            }
            this.Image = image;
            // to ensure "sidecar" is required (not null)
            if (sidecar == null)
            {
                throw new ArgumentNullException("sidecar is a required property for ServerMediaTypesResponseDto and cannot be null");
            }
            this.Sidecar = sidecar;
            // to ensure "video" is required (not null)
            if (video == null)
            {
                throw new ArgumentNullException("video is a required property for ServerMediaTypesResponseDto and cannot be null");
            }
            this.Video = video;
        }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Image { get; set; }

        /// <summary>
        /// Gets or Sets Sidecar
        /// </summary>
        [DataMember(Name = "sidecar", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Sidecar { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name = "video", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Video { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServerMediaTypesResponseDto {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Sidecar: ").Append(Sidecar).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
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
