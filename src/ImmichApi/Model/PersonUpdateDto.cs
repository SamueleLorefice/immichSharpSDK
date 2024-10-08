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
    /// PersonUpdateDto
    /// </summary>
    [DataContract(Name = "PersonUpdateDto")]
    public partial class PersonUpdateDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonUpdateDto" /> class.
        /// </summary>
        /// <param name="birthDate">Person date of birth. Note: the mobile app cannot currently set the birth date to null..</param>
        /// <param name="featureFaceAssetId">Asset is used to get the feature face thumbnail..</param>
        /// <param name="isHidden">Person visibility.</param>
        /// <param name="name">Person name..</param>
        public PersonUpdateDto(DateOnly? birthDate = null, string featureFaceAssetId = default(string), bool isHidden = default(bool), string name = default(string))
        {
            this.BirthDate = birthDate;
            this.FeatureFaceAssetId = featureFaceAssetId;
            this.IsHidden = isHidden;
            this.Name = name;
        }

        /// <summary>
        /// Person date of birth. Note: the mobile app cannot currently set the birth date to null.
        /// </summary>
        /// <value>Person date of birth. Note: the mobile app cannot currently set the birth date to null.</value>
        [DataMember(Name = "birthDate", EmitDefaultValue = false)]
        public DateOnly? BirthDate { get; set; }

        /// <summary>
        /// Asset is used to get the feature face thumbnail.
        /// </summary>
        /// <value>Asset is used to get the feature face thumbnail.</value>
        [DataMember(Name = "featureFaceAssetId", EmitDefaultValue = false)]
        public string FeatureFaceAssetId { get; set; }

        /// <summary>
        /// Person visibility
        /// </summary>
        /// <value>Person visibility</value>
        [DataMember(Name = "isHidden", EmitDefaultValue = true)]
        public bool IsHidden { get; set; }

        /// <summary>
        /// Person name.
        /// </summary>
        /// <value>Person name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonUpdateDto {\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  FeatureFaceAssetId: ").Append(FeatureFaceAssetId).Append("\n");
            sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
