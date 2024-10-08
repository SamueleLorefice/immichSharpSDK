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
    /// SearchAssetResponseDto
    /// </summary>
    [DataContract(Name = "SearchAssetResponseDto")]
    public partial class SearchAssetResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAssetResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchAssetResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAssetResponseDto" /> class.
        /// </summary>
        /// <param name="count">count (required).</param>
        /// <param name="facets">facets (required).</param>
        /// <param name="items">items (required).</param>
        /// <param name="nextPage">nextPage (required).</param>
        /// <param name="total">total (required).</param>
        public SearchAssetResponseDto(int count = default(int), List<SearchFacetResponseDto> facets = default(List<SearchFacetResponseDto>), List<AssetResponseDto> items = default(List<AssetResponseDto>), string nextPage = default(string), int total = default(int))
        {
            this.Count = count;
            // to ensure "facets" is required (not null)
            if (facets == null)
            {
                throw new ArgumentNullException("facets is a required property for SearchAssetResponseDto and cannot be null");
            }
            this.Facets = facets;
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for SearchAssetResponseDto and cannot be null");
            }
            this.Items = items;
            // to ensure "nextPage" is required (not null)
            if (nextPage == null)
            {
                throw new ArgumentNullException("nextPage is a required property for SearchAssetResponseDto and cannot be null");
            }
            this.NextPage = nextPage;
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Facets
        /// </summary>
        [DataMember(Name = "facets", IsRequired = true, EmitDefaultValue = true)]
        public List<SearchFacetResponseDto> Facets { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<AssetResponseDto> Items { get; set; }

        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name = "nextPage", IsRequired = true, EmitDefaultValue = true)]
        public string NextPage { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchAssetResponseDto {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
