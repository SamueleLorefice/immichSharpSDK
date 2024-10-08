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
    /// PeopleUpdateDto
    /// </summary>
    [DataContract(Name = "PeopleUpdateDto")]
    public partial class PeopleUpdateDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleUpdateDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PeopleUpdateDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleUpdateDto" /> class.
        /// </summary>
        /// <param name="people">people (required).</param>
        public PeopleUpdateDto(List<PeopleUpdateItem> people = default(List<PeopleUpdateItem>))
        {
            // to ensure "people" is required (not null)
            if (people == null)
            {
                throw new ArgumentNullException("people is a required property for PeopleUpdateDto and cannot be null");
            }
            this.People = people;
        }

        /// <summary>
        /// Gets or Sets People
        /// </summary>
        [DataMember(Name = "people", IsRequired = true, EmitDefaultValue = true)]
        public List<PeopleUpdateItem> People { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PeopleUpdateDto {\n");
            sb.Append("  People: ").Append(People).Append("\n");
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
