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
    /// PurchaseResponse
    /// </summary>
    [DataContract(Name = "PurchaseResponse")]
    public partial class PurchaseResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PurchaseResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseResponse" /> class.
        /// </summary>
        /// <param name="hideBuyButtonUntil">hideBuyButtonUntil (required).</param>
        /// <param name="showSupportBadge">showSupportBadge (required).</param>
        public PurchaseResponse(string hideBuyButtonUntil = default(string), bool showSupportBadge = default(bool))
        {
            // to ensure "hideBuyButtonUntil" is required (not null)
            if (hideBuyButtonUntil == null)
            {
                throw new ArgumentNullException("hideBuyButtonUntil is a required property for PurchaseResponse and cannot be null");
            }
            this.HideBuyButtonUntil = hideBuyButtonUntil;
            this.ShowSupportBadge = showSupportBadge;
        }

        /// <summary>
        /// Gets or Sets HideBuyButtonUntil
        /// </summary>
        [DataMember(Name = "hideBuyButtonUntil", IsRequired = true, EmitDefaultValue = true)]
        public string HideBuyButtonUntil { get; set; }

        /// <summary>
        /// Gets or Sets ShowSupportBadge
        /// </summary>
        [DataMember(Name = "showSupportBadge", IsRequired = true, EmitDefaultValue = true)]
        public bool ShowSupportBadge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PurchaseResponse {\n");
            sb.Append("  HideBuyButtonUntil: ").Append(HideBuyButtonUntil).Append("\n");
            sb.Append("  ShowSupportBadge: ").Append(ShowSupportBadge).Append("\n");
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
