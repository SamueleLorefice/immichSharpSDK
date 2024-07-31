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
    /// PersonWithFacesResponseDto
    /// </summary>
    [DataContract(Name = "PersonWithFacesResponseDto")]
    public partial class PersonWithFacesResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonWithFacesResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PersonWithFacesResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonWithFacesResponseDto" /> class.
        /// </summary>
        /// <param name="birthDate">birthDate (required).</param>
        /// <param name="faces">faces (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="isHidden">isHidden (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="thumbnailPath">thumbnailPath (required).</param>
        /// <param name="updatedAt">This property was added in v1.107.0.</param>
        public PersonWithFacesResponseDto(DateOnly birthDate = default(DateOnly), List<AssetFaceWithoutPersonResponseDto> faces = default(List<AssetFaceWithoutPersonResponseDto>), string id = default(string), bool isHidden = default(bool), string name = default(string), string thumbnailPath = default(string), DateTime updatedAt = default(DateTime))
        {
            // to ensure "birthDate" is required (not null)
            if (birthDate == null)
            {
                throw new ArgumentNullException("birthDate is a required property for PersonWithFacesResponseDto and cannot be null");
            }
            this.BirthDate = birthDate;
            // to ensure "faces" is required (not null)
            if (faces == null)
            {
                throw new ArgumentNullException("faces is a required property for PersonWithFacesResponseDto and cannot be null");
            }
            this.Faces = faces;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PersonWithFacesResponseDto and cannot be null");
            }
            this.Id = id;
            this.IsHidden = isHidden;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PersonWithFacesResponseDto and cannot be null");
            }
            this.Name = name;
            // to ensure "thumbnailPath" is required (not null)
            if (thumbnailPath == null)
            {
                throw new ArgumentNullException("thumbnailPath is a required property for PersonWithFacesResponseDto and cannot be null");
            }
            this.ThumbnailPath = thumbnailPath;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets Faces
        /// </summary>
        [DataMember(Name = "faces", IsRequired = true, EmitDefaultValue = true)]
        public List<AssetFaceWithoutPersonResponseDto> Faces { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsHidden
        /// </summary>
        [DataMember(Name = "isHidden", IsRequired = true, EmitDefaultValue = true)]
        public bool IsHidden { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailPath
        /// </summary>
        [DataMember(Name = "thumbnailPath", IsRequired = true, EmitDefaultValue = true)]
        public string ThumbnailPath { get; set; }

        /// <summary>
        /// This property was added in v1.107.0
        /// </summary>
        /// <value>This property was added in v1.107.0</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonWithFacesResponseDto {\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  Faces: ").Append(Faces).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ThumbnailPath: ").Append(ThumbnailPath).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
