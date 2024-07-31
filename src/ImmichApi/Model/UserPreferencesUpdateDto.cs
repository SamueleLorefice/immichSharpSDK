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
    /// UserPreferencesUpdateDto
    /// </summary>
    [DataContract(Name = "UserPreferencesUpdateDto")]
    public partial class UserPreferencesUpdateDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesUpdateDto" /> class.
        /// </summary>
        /// <param name="avatar">avatar.</param>
        /// <param name="download">download.</param>
        /// <param name="emailNotifications">emailNotifications.</param>
        /// <param name="memories">memories.</param>
        /// <param name="purchase">purchase.</param>
        public UserPreferencesUpdateDto(AvatarUpdate avatar = default(AvatarUpdate), DownloadUpdate download = default(DownloadUpdate), EmailNotificationsUpdate emailNotifications = default(EmailNotificationsUpdate), MemoryUpdate memories = default(MemoryUpdate), PurchaseUpdate purchase = default(PurchaseUpdate))
        {
            this.Avatar = avatar;
            this.Download = download;
            this.EmailNotifications = emailNotifications;
            this.Memories = memories;
            this.Purchase = purchase;
        }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", EmitDefaultValue = false)]
        public AvatarUpdate Avatar { get; set; }

        /// <summary>
        /// Gets or Sets Download
        /// </summary>
        [DataMember(Name = "download", EmitDefaultValue = false)]
        public DownloadUpdate Download { get; set; }

        /// <summary>
        /// Gets or Sets EmailNotifications
        /// </summary>
        [DataMember(Name = "emailNotifications", EmitDefaultValue = false)]
        public EmailNotificationsUpdate EmailNotifications { get; set; }

        /// <summary>
        /// Gets or Sets Memories
        /// </summary>
        [DataMember(Name = "memories", EmitDefaultValue = false)]
        public MemoryUpdate Memories { get; set; }

        /// <summary>
        /// Gets or Sets Purchase
        /// </summary>
        [DataMember(Name = "purchase", EmitDefaultValue = false)]
        public PurchaseUpdate Purchase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserPreferencesUpdateDto {\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  EmailNotifications: ").Append(EmailNotifications).Append("\n");
            sb.Append("  Memories: ").Append(Memories).Append("\n");
            sb.Append("  Purchase: ").Append(Purchase).Append("\n");
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
