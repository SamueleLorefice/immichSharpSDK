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
    /// LogoutResponseDto
    /// </summary>
    [DataContract(Name = "LogoutResponseDto")]
    public partial class LogoutResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoutResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LogoutResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoutResponseDto" /> class.
        /// </summary>
        /// <param name="redirectUri">redirectUri (required).</param>
        /// <param name="successful">successful (required).</param>
        public LogoutResponseDto(string redirectUri = default(string), bool successful = default(bool))
        {
            // to ensure "redirectUri" is required (not null)
            if (redirectUri == null)
            {
                throw new ArgumentNullException("redirectUri is a required property for LogoutResponseDto and cannot be null");
            }
            this.RedirectUri = redirectUri;
            this.Successful = successful;
        }

        /// <summary>
        /// Gets or Sets RedirectUri
        /// </summary>
        [DataMember(Name = "redirectUri", IsRequired = true, EmitDefaultValue = true)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        [DataMember(Name = "successful", IsRequired = true, EmitDefaultValue = true)]
        public bool Successful { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogoutResponseDto {\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
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
