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
    /// CreateAlbumDto
    /// </summary>
    [DataContract(Name = "CreateAlbumDto")]
    public partial class CreateAlbumDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAlbumDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAlbumDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAlbumDto" /> class.
        /// </summary>
        /// <param name="albumName">albumName (required).</param>
        /// <param name="albumUsers">albumUsers.</param>
        /// <param name="assetIds">assetIds.</param>
        /// <param name="description">description.</param>
        public CreateAlbumDto(string albumName = default(string), List<AlbumUserCreateDto> albumUsers = default(List<AlbumUserCreateDto>), List<Guid> assetIds = default(List<Guid>), string description = default(string))
        {
            // to ensure "albumName" is required (not null)
            if (albumName == null)
            {
                throw new ArgumentNullException("albumName is a required property for CreateAlbumDto and cannot be null");
            }
            this.AlbumName = albumName;
            this.AlbumUsers = albumUsers;
            this.AssetIds = assetIds;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets AlbumName
        /// </summary>
        [DataMember(Name = "albumName", IsRequired = true, EmitDefaultValue = true)]
        public string AlbumName { get; set; }

        /// <summary>
        /// Gets or Sets AlbumUsers
        /// </summary>
        [DataMember(Name = "albumUsers", EmitDefaultValue = false)]
        public List<AlbumUserCreateDto> AlbumUsers { get; set; }

        /// <summary>
        /// Gets or Sets AssetIds
        /// </summary>
        [DataMember(Name = "assetIds", EmitDefaultValue = false)]
        public List<Guid> AssetIds { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAlbumDto {\n");
            sb.Append("  AlbumName: ").Append(AlbumName).Append("\n");
            sb.Append("  AlbumUsers: ").Append(AlbumUsers).Append("\n");
            sb.Append("  AssetIds: ").Append(AssetIds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
