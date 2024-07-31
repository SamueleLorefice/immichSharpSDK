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
    /// AssetFaceWithoutPersonResponseDto
    /// </summary>
    [DataContract(Name = "AssetFaceWithoutPersonResponseDto")]
    public partial class AssetFaceWithoutPersonResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetFaceWithoutPersonResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetFaceWithoutPersonResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetFaceWithoutPersonResponseDto" /> class.
        /// </summary>
        /// <param name="boundingBoxX1">boundingBoxX1 (required).</param>
        /// <param name="boundingBoxX2">boundingBoxX2 (required).</param>
        /// <param name="boundingBoxY1">boundingBoxY1 (required).</param>
        /// <param name="boundingBoxY2">boundingBoxY2 (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="imageHeight">imageHeight (required).</param>
        /// <param name="imageWidth">imageWidth (required).</param>
        public AssetFaceWithoutPersonResponseDto(int boundingBoxX1 = default(int), int boundingBoxX2 = default(int), int boundingBoxY1 = default(int), int boundingBoxY2 = default(int), Guid id = default(Guid), int imageHeight = default(int), int imageWidth = default(int))
        {
            this.BoundingBoxX1 = boundingBoxX1;
            this.BoundingBoxX2 = boundingBoxX2;
            this.BoundingBoxY1 = boundingBoxY1;
            this.BoundingBoxY2 = boundingBoxY2;
            this.Id = id;
            this.ImageHeight = imageHeight;
            this.ImageWidth = imageWidth;
        }

        /// <summary>
        /// Gets or Sets BoundingBoxX1
        /// </summary>
        [DataMember(Name = "boundingBoxX1", IsRequired = true, EmitDefaultValue = true)]
        public int BoundingBoxX1 { get; set; }

        /// <summary>
        /// Gets or Sets BoundingBoxX2
        /// </summary>
        [DataMember(Name = "boundingBoxX2", IsRequired = true, EmitDefaultValue = true)]
        public int BoundingBoxX2 { get; set; }

        /// <summary>
        /// Gets or Sets BoundingBoxY1
        /// </summary>
        [DataMember(Name = "boundingBoxY1", IsRequired = true, EmitDefaultValue = true)]
        public int BoundingBoxY1 { get; set; }

        /// <summary>
        /// Gets or Sets BoundingBoxY2
        /// </summary>
        [DataMember(Name = "boundingBoxY2", IsRequired = true, EmitDefaultValue = true)]
        public int BoundingBoxY2 { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ImageHeight
        /// </summary>
        [DataMember(Name = "imageHeight", IsRequired = true, EmitDefaultValue = true)]
        public int ImageHeight { get; set; }

        /// <summary>
        /// Gets or Sets ImageWidth
        /// </summary>
        [DataMember(Name = "imageWidth", IsRequired = true, EmitDefaultValue = true)]
        public int ImageWidth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetFaceWithoutPersonResponseDto {\n");
            sb.Append("  BoundingBoxX1: ").Append(BoundingBoxX1).Append("\n");
            sb.Append("  BoundingBoxX2: ").Append(BoundingBoxX2).Append("\n");
            sb.Append("  BoundingBoxY1: ").Append(BoundingBoxY1).Append("\n");
            sb.Append("  BoundingBoxY2: ").Append(BoundingBoxY2).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageHeight: ").Append(ImageHeight).Append("\n");
            sb.Append("  ImageWidth: ").Append(ImageWidth).Append("\n");
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
