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
    /// UserAdminDeleteDto
    /// </summary>
    [DataContract(Name = "UserAdminDeleteDto")]
    public partial class UserAdminDeleteDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAdminDeleteDto" /> class.
        /// </summary>
        /// <param name="force">force.</param>
        public UserAdminDeleteDto(bool force = default(bool))
        {
            this.Force = force;
        }

        /// <summary>
        /// Gets or Sets Force
        /// </summary>
        [DataMember(Name = "force", EmitDefaultValue = true)]
        public bool Force { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAdminDeleteDto {\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
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
