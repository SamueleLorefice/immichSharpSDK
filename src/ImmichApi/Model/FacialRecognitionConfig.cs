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
    /// FacialRecognitionConfig
    /// </summary>
    [DataContract(Name = "FacialRecognitionConfig")]
    public partial class FacialRecognitionConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacialRecognitionConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FacialRecognitionConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FacialRecognitionConfig" /> class.
        /// </summary>
        /// <param name="enabled">enabled (required).</param>
        /// <param name="maxDistance">maxDistance (required).</param>
        /// <param name="minFaces">minFaces (required).</param>
        /// <param name="minScore">minScore (required).</param>
        /// <param name="modelName">modelName (required).</param>
        public FacialRecognitionConfig(bool enabled = default(bool), double maxDistance = default(double), int minFaces = default(int), double minScore = default(double), string modelName = default(string))
        {
            this.Enabled = enabled;
            this.MaxDistance = maxDistance;
            this.MinFaces = minFaces;
            this.MinScore = minScore;
            // to ensure "modelName" is required (not null)
            if (modelName == null)
            {
                throw new ArgumentNullException("modelName is a required property for FacialRecognitionConfig and cannot be null");
            }
            this.ModelName = modelName;
        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets MaxDistance
        /// </summary>
        [DataMember(Name = "maxDistance", IsRequired = true, EmitDefaultValue = true)]
        public double MaxDistance { get; set; }

        /// <summary>
        /// Gets or Sets MinFaces
        /// </summary>
        [DataMember(Name = "minFaces", IsRequired = true, EmitDefaultValue = true)]
        public int MinFaces { get; set; }

        /// <summary>
        /// Gets or Sets MinScore
        /// </summary>
        [DataMember(Name = "minScore", IsRequired = true, EmitDefaultValue = true)]
        public double MinScore { get; set; }

        /// <summary>
        /// Gets or Sets ModelName
        /// </summary>
        [DataMember(Name = "modelName", IsRequired = true, EmitDefaultValue = true)]
        public string ModelName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FacialRecognitionConfig {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MaxDistance: ").Append(MaxDistance).Append("\n");
            sb.Append("  MinFaces: ").Append(MinFaces).Append("\n");
            sb.Append("  MinScore: ").Append(MinScore).Append("\n");
            sb.Append("  ModelName: ").Append(ModelName).Append("\n");
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
            // MaxDistance (double) maximum
            if (this.MaxDistance > (double)2)
            {
                yield return new ValidationResult("Invalid value for MaxDistance, must be a value less than or equal to 2.", new [] { "MaxDistance" });
            }

            // MaxDistance (double) minimum
            if (this.MaxDistance < (double)0)
            {
                yield return new ValidationResult("Invalid value for MaxDistance, must be a value greater than or equal to 0.", new [] { "MaxDistance" });
            }

            // MinFaces (int) minimum
            if (this.MinFaces < (int)1)
            {
                yield return new ValidationResult("Invalid value for MinFaces, must be a value greater than or equal to 1.", new [] { "MinFaces" });
            }

            // MinScore (double) maximum
            if (this.MinScore > (double)1)
            {
                yield return new ValidationResult("Invalid value for MinScore, must be a value less than or equal to 1.", new [] { "MinScore" });
            }

            // MinScore (double) minimum
            if (this.MinScore < (double)0)
            {
                yield return new ValidationResult("Invalid value for MinScore, must be a value greater than or equal to 0.", new [] { "MinScore" });
            }

            yield break;
        }
    }

}
