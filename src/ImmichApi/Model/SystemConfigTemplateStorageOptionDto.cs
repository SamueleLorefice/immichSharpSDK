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
    /// SystemConfigTemplateStorageOptionDto
    /// </summary>
    [DataContract(Name = "SystemConfigTemplateStorageOptionDto")]
    public partial class SystemConfigTemplateStorageOptionDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigTemplateStorageOptionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemConfigTemplateStorageOptionDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigTemplateStorageOptionDto" /> class.
        /// </summary>
        /// <param name="dayOptions">dayOptions (required).</param>
        /// <param name="hourOptions">hourOptions (required).</param>
        /// <param name="minuteOptions">minuteOptions (required).</param>
        /// <param name="monthOptions">monthOptions (required).</param>
        /// <param name="presetOptions">presetOptions (required).</param>
        /// <param name="secondOptions">secondOptions (required).</param>
        /// <param name="weekOptions">weekOptions (required).</param>
        /// <param name="yearOptions">yearOptions (required).</param>
        public SystemConfigTemplateStorageOptionDto(List<string> dayOptions = default(List<string>), List<string> hourOptions = default(List<string>), List<string> minuteOptions = default(List<string>), List<string> monthOptions = default(List<string>), List<string> presetOptions = default(List<string>), List<string> secondOptions = default(List<string>), List<string> weekOptions = default(List<string>), List<string> yearOptions = default(List<string>))
        {
            // to ensure "dayOptions" is required (not null)
            if (dayOptions == null)
            {
                throw new ArgumentNullException("dayOptions is a required property for SystemConfigTemplateStorageOptionDto and cannot be null");
            }
            this.DayOptions = dayOptions;
            // to ensure "hourOptions" is required (not null)
            if (hourOptions == null)
            {
                throw new ArgumentNullException("hourOptions is a required property for SystemConfigTemplateStorageOptionDto and cannot be null");
            }
            this.HourOptions = hourOptions;
            // to ensure "minuteOptions" is required (not null)
            if (minuteOptions == null)
            {
                throw new ArgumentNullException("minuteOptions is a required property for SystemConfigTemplateStorageOptionDto and cannot be null");
            }
            this.MinuteOptions = minuteOptions;
            // to ensure "monthOptions" is required (not null)
            if (monthOptions == null)
            {
                throw new ArgumentNullException("monthOptions is a required property for SystemConfigTemplateStorageOptionDto and cannot be null");
            }
            this.MonthOptions = monthOptions;
            // to ensure "presetOptions" is required (not null)
            if (presetOptions == null)
            {
                throw new ArgumentNullException("presetOptions is a required property for SystemConfigTemplateStorageOptionDto and cannot be null");
            }
            this.PresetOptions = presetOptions;
            // to ensure "secondOptions" is required (not null)
            if (secondOptions == null)
            {
                throw new ArgumentNullException("secondOptions is a required property for SystemConfigTemplateStorageOptionDto and cannot be null");
            }
            this.SecondOptions = secondOptions;
            // to ensure "weekOptions" is required (not null)
            if (weekOptions == null)
            {
                throw new ArgumentNullException("weekOptions is a required property for SystemConfigTemplateStorageOptionDto and cannot be null");
            }
            this.WeekOptions = weekOptions;
            // to ensure "yearOptions" is required (not null)
            if (yearOptions == null)
            {
                throw new ArgumentNullException("yearOptions is a required property for SystemConfigTemplateStorageOptionDto and cannot be null");
            }
            this.YearOptions = yearOptions;
        }

        /// <summary>
        /// Gets or Sets DayOptions
        /// </summary>
        [DataMember(Name = "dayOptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> DayOptions { get; set; }

        /// <summary>
        /// Gets or Sets HourOptions
        /// </summary>
        [DataMember(Name = "hourOptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> HourOptions { get; set; }

        /// <summary>
        /// Gets or Sets MinuteOptions
        /// </summary>
        [DataMember(Name = "minuteOptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> MinuteOptions { get; set; }

        /// <summary>
        /// Gets or Sets MonthOptions
        /// </summary>
        [DataMember(Name = "monthOptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> MonthOptions { get; set; }

        /// <summary>
        /// Gets or Sets PresetOptions
        /// </summary>
        [DataMember(Name = "presetOptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> PresetOptions { get; set; }

        /// <summary>
        /// Gets or Sets SecondOptions
        /// </summary>
        [DataMember(Name = "secondOptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> SecondOptions { get; set; }

        /// <summary>
        /// Gets or Sets WeekOptions
        /// </summary>
        [DataMember(Name = "weekOptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> WeekOptions { get; set; }

        /// <summary>
        /// Gets or Sets YearOptions
        /// </summary>
        [DataMember(Name = "yearOptions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> YearOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemConfigTemplateStorageOptionDto {\n");
            sb.Append("  DayOptions: ").Append(DayOptions).Append("\n");
            sb.Append("  HourOptions: ").Append(HourOptions).Append("\n");
            sb.Append("  MinuteOptions: ").Append(MinuteOptions).Append("\n");
            sb.Append("  MonthOptions: ").Append(MonthOptions).Append("\n");
            sb.Append("  PresetOptions: ").Append(PresetOptions).Append("\n");
            sb.Append("  SecondOptions: ").Append(SecondOptions).Append("\n");
            sb.Append("  WeekOptions: ").Append(WeekOptions).Append("\n");
            sb.Append("  YearOptions: ").Append(YearOptions).Append("\n");
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
