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
    /// AssetIdsDto
    /// </summary>
    [DataContract(Name = "AssetIdsDto")]
    public partial class AssetIdsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetIdsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetIdsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetIdsDto" /> class.
        /// </summary>
        /// <param name="assetIds">assetIds (required).</param>
        public AssetIdsDto(List<Guid> assetIds = default(List<Guid>))
        {
            // to ensure "assetIds" is required (not null)
            if (assetIds == null)
            {
                throw new ArgumentNullException("assetIds is a required property for AssetIdsDto and cannot be null");
            }
            this.AssetIds = assetIds;
        }

        /// <summary>
        /// Gets or Sets AssetIds
        /// </summary>
        [DataMember(Name = "assetIds", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> AssetIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetIdsDto {\n");
            sb.Append("  AssetIds: ").Append(AssetIds).Append("\n");
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
