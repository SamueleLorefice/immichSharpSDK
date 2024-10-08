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
    /// AdminOnboardingUpdateDto
    /// </summary>
    [DataContract(Name = "AdminOnboardingUpdateDto")]
    public partial class AdminOnboardingUpdateDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminOnboardingUpdateDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminOnboardingUpdateDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminOnboardingUpdateDto" /> class.
        /// </summary>
        /// <param name="isOnboarded">isOnboarded (required).</param>
        public AdminOnboardingUpdateDto(bool isOnboarded = default(bool))
        {
            this.IsOnboarded = isOnboarded;
        }

        /// <summary>
        /// Gets or Sets IsOnboarded
        /// </summary>
        [DataMember(Name = "isOnboarded", IsRequired = true, EmitDefaultValue = true)]
        public bool IsOnboarded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdminOnboardingUpdateDto {\n");
            sb.Append("  IsOnboarded: ").Append(IsOnboarded).Append("\n");
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
