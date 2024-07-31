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
    /// DownloadArchiveInfo
    /// </summary>
    [DataContract(Name = "DownloadArchiveInfo")]
    public partial class DownloadArchiveInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadArchiveInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DownloadArchiveInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadArchiveInfo" /> class.
        /// </summary>
        /// <param name="assetIds">assetIds (required).</param>
        /// <param name="size">size (required).</param>
        public DownloadArchiveInfo(List<string> assetIds = default(List<string>), int size = default(int))
        {
            // to ensure "assetIds" is required (not null)
            if (assetIds == null)
            {
                throw new ArgumentNullException("assetIds is a required property for DownloadArchiveInfo and cannot be null");
            }
            this.AssetIds = assetIds;
            this.Size = size;
        }

        /// <summary>
        /// Gets or Sets AssetIds
        /// </summary>
        [DataMember(Name = "assetIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> AssetIds { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = true)]
        public int Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DownloadArchiveInfo {\n");
            sb.Append("  AssetIds: ").Append(AssetIds).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
