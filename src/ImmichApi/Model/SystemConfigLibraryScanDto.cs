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
    /// SystemConfigLibraryScanDto
    /// </summary>
    [DataContract(Name = "SystemConfigLibraryScanDto")]
    public partial class SystemConfigLibraryScanDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigLibraryScanDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemConfigLibraryScanDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigLibraryScanDto" /> class.
        /// </summary>
        /// <param name="cronExpression">cronExpression (required).</param>
        /// <param name="enabled">enabled (required).</param>
        public SystemConfigLibraryScanDto(string cronExpression = default(string), bool enabled = default(bool))
        {
            // to ensure "cronExpression" is required (not null)
            if (cronExpression == null)
            {
                throw new ArgumentNullException("cronExpression is a required property for SystemConfigLibraryScanDto and cannot be null");
            }
            this.CronExpression = cronExpression;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets or Sets CronExpression
        /// </summary>
        [DataMember(Name = "cronExpression", IsRequired = true, EmitDefaultValue = true)]
        public string CronExpression { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemConfigLibraryScanDto {\n");
            sb.Append("  CronExpression: ").Append(CronExpression).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
