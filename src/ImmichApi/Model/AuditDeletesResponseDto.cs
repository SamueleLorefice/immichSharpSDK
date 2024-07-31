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
    /// AuditDeletesResponseDto
    /// </summary>
    [DataContract(Name = "AuditDeletesResponseDto")]
    public partial class AuditDeletesResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditDeletesResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditDeletesResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditDeletesResponseDto" /> class.
        /// </summary>
        /// <param name="ids">ids (required).</param>
        /// <param name="needsFullSync">needsFullSync (required).</param>
        public AuditDeletesResponseDto(List<string> ids = default(List<string>), bool needsFullSync = default(bool))
        {
            // to ensure "ids" is required (not null)
            if (ids == null)
            {
                throw new ArgumentNullException("ids is a required property for AuditDeletesResponseDto and cannot be null");
            }
            this.Ids = ids;
            this.NeedsFullSync = needsFullSync;
        }

        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name = "ids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Gets or Sets NeedsFullSync
        /// </summary>
        [DataMember(Name = "needsFullSync", IsRequired = true, EmitDefaultValue = true)]
        public bool NeedsFullSync { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuditDeletesResponseDto {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  NeedsFullSync: ").Append(NeedsFullSync).Append("\n");
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
