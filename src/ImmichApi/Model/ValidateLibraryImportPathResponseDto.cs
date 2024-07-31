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
    /// ValidateLibraryImportPathResponseDto
    /// </summary>
    [DataContract(Name = "ValidateLibraryImportPathResponseDto")]
    public partial class ValidateLibraryImportPathResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateLibraryImportPathResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidateLibraryImportPathResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateLibraryImportPathResponseDto" /> class.
        /// </summary>
        /// <param name="importPath">importPath (required).</param>
        /// <param name="isValid">isValid (required) (default to false).</param>
        /// <param name="message">message.</param>
        public ValidateLibraryImportPathResponseDto(string importPath = default(string), bool isValid = false, string message = default(string))
        {
            // to ensure "importPath" is required (not null)
            if (importPath == null)
            {
                throw new ArgumentNullException("importPath is a required property for ValidateLibraryImportPathResponseDto and cannot be null");
            }
            this.ImportPath = importPath;
            this.IsValid = isValid;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets ImportPath
        /// </summary>
        [DataMember(Name = "importPath", IsRequired = true, EmitDefaultValue = true)]
        public string ImportPath { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "isValid", IsRequired = true, EmitDefaultValue = true)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidateLibraryImportPathResponseDto {\n");
            sb.Append("  ImportPath: ").Append(ImportPath).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
