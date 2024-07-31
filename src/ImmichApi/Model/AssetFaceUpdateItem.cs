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
    /// AssetFaceUpdateItem
    /// </summary>
    [DataContract(Name = "AssetFaceUpdateItem")]
    public partial class AssetFaceUpdateItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetFaceUpdateItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetFaceUpdateItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetFaceUpdateItem" /> class.
        /// </summary>
        /// <param name="assetId">assetId (required).</param>
        /// <param name="personId">personId (required).</param>
        public AssetFaceUpdateItem(Guid assetId = default(Guid), Guid personId = default(Guid))
        {
            this.AssetId = assetId;
            this.PersonId = personId;
        }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name = "assetId", IsRequired = true, EmitDefaultValue = true)]
        public Guid AssetId { get; set; }

        /// <summary>
        /// Gets or Sets PersonId
        /// </summary>
        [DataMember(Name = "personId", IsRequired = true, EmitDefaultValue = true)]
        public Guid PersonId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetFaceUpdateItem {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  PersonId: ").Append(PersonId).Append("\n");
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
