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
    /// UpdateStackParentDto
    /// </summary>
    [DataContract(Name = "UpdateStackParentDto")]
    public partial class UpdateStackParentDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStackParentDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateStackParentDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStackParentDto" /> class.
        /// </summary>
        /// <param name="newParentId">newParentId (required).</param>
        /// <param name="oldParentId">oldParentId (required).</param>
        public UpdateStackParentDto(Guid newParentId = default(Guid), Guid oldParentId = default(Guid))
        {
            this.NewParentId = newParentId;
            this.OldParentId = oldParentId;
        }

        /// <summary>
        /// Gets or Sets NewParentId
        /// </summary>
        [DataMember(Name = "newParentId", IsRequired = true, EmitDefaultValue = true)]
        public Guid NewParentId { get; set; }

        /// <summary>
        /// Gets or Sets OldParentId
        /// </summary>
        [DataMember(Name = "oldParentId", IsRequired = true, EmitDefaultValue = true)]
        public Guid OldParentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateStackParentDto {\n");
            sb.Append("  NewParentId: ").Append(NewParentId).Append("\n");
            sb.Append("  OldParentId: ").Append(OldParentId).Append("\n");
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
