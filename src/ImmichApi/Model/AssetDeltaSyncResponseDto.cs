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
    /// AssetDeltaSyncResponseDto
    /// </summary>
    [DataContract(Name = "AssetDeltaSyncResponseDto")]
    public partial class AssetDeltaSyncResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDeltaSyncResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetDeltaSyncResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDeltaSyncResponseDto" /> class.
        /// </summary>
        /// <param name="deleted">deleted (required).</param>
        /// <param name="needsFullSync">needsFullSync (required).</param>
        /// <param name="upserted">upserted (required).</param>
        public AssetDeltaSyncResponseDto(List<string> deleted = default(List<string>), bool needsFullSync = default(bool), List<AssetResponseDto> upserted = default(List<AssetResponseDto>))
        {
            // to ensure "deleted" is required (not null)
            if (deleted == null)
            {
                throw new ArgumentNullException("deleted is a required property for AssetDeltaSyncResponseDto and cannot be null");
            }
            this.Deleted = deleted;
            this.NeedsFullSync = needsFullSync;
            // to ensure "upserted" is required (not null)
            if (upserted == null)
            {
                throw new ArgumentNullException("upserted is a required property for AssetDeltaSyncResponseDto and cannot be null");
            }
            this.Upserted = upserted;
        }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Deleted { get; set; }

        /// <summary>
        /// Gets or Sets NeedsFullSync
        /// </summary>
        [DataMember(Name = "needsFullSync", IsRequired = true, EmitDefaultValue = true)]
        public bool NeedsFullSync { get; set; }

        /// <summary>
        /// Gets or Sets Upserted
        /// </summary>
        [DataMember(Name = "upserted", IsRequired = true, EmitDefaultValue = true)]
        public List<AssetResponseDto> Upserted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetDeltaSyncResponseDto {\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  NeedsFullSync: ").Append(NeedsFullSync).Append("\n");
            sb.Append("  Upserted: ").Append(Upserted).Append("\n");
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
