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
    /// UserAdminResponseDto
    /// </summary>
    [DataContract(Name = "UserAdminResponseDto")]
    public partial class UserAdminResponseDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AvatarColor
        /// </summary>
        [DataMember(Name = "avatarColor", IsRequired = true, EmitDefaultValue = true)]
        public UserAvatarColor AvatarColor { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public UserStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAdminResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserAdminResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAdminResponseDto" /> class.
        /// </summary>
        /// <param name="avatarColor">avatarColor (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="deletedAt">deletedAt (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="isAdmin">isAdmin (required).</param>
        /// <param name="license">license (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="oauthId">oauthId (required).</param>
        /// <param name="profileImagePath">profileImagePath (required).</param>
        /// <param name="quotaSizeInBytes">quotaSizeInBytes (required).</param>
        /// <param name="quotaUsageInBytes">quotaUsageInBytes (required).</param>
        /// <param name="shouldChangePassword">shouldChangePassword (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="storageLabel">storageLabel (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public UserAdminResponseDto(UserAvatarColor avatarColor = default(UserAvatarColor), DateTime createdAt = default(DateTime), DateTime? deletedAt = default(DateTime?), string email = default(string), string id = default(string), bool isAdmin = default(bool), UserLicense license = default(UserLicense), string name = default(string), string oauthId = default(string), string profileImagePath = default(string), long? quotaSizeInBytes = default(long?), long? quotaUsageInBytes = default(long?), bool shouldChangePassword = default(bool), UserStatus status = default(UserStatus), string storageLabel = default(string), DateTime updatedAt = default(DateTime))
        {
            this.AvatarColor = avatarColor;
            this.CreatedAt = createdAt;
            // to ensure "deletedAt" is required (not null)
            if (deletedAt == null)
            {
                throw new ArgumentNullException("deletedAt is a required property for UserAdminResponseDto and cannot be null");
            }
            this.DeletedAt = deletedAt;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for UserAdminResponseDto and cannot be null");
            }
            this.Email = email;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for UserAdminResponseDto and cannot be null");
            }
            this.Id = id;
            this.IsAdmin = isAdmin;
            // to ensure "license" is required (not null)
            if (license == null)
            {
                throw new ArgumentNullException("license is a required property for UserAdminResponseDto and cannot be null");
            }
            this.License = license;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UserAdminResponseDto and cannot be null");
            }
            this.Name = name;
            // to ensure "oauthId" is required (not null)
            if (oauthId == null)
            {
                throw new ArgumentNullException("oauthId is a required property for UserAdminResponseDto and cannot be null");
            }
            this.OauthId = oauthId;
            // to ensure "profileImagePath" is required (not null)
            if (profileImagePath == null)
            {
                throw new ArgumentNullException("profileImagePath is a required property for UserAdminResponseDto and cannot be null");
            }
            this.ProfileImagePath = profileImagePath;
            // to ensure "quotaSizeInBytes" is required (not null)
            if (quotaSizeInBytes == null)
            {
                throw new ArgumentNullException("quotaSizeInBytes is a required property for UserAdminResponseDto and cannot be null");
            }
            this.QuotaSizeInBytes = quotaSizeInBytes;
            // to ensure "quotaUsageInBytes" is required (not null)
            if (quotaUsageInBytes == null)
            {
                throw new ArgumentNullException("quotaUsageInBytes is a required property for UserAdminResponseDto and cannot be null");
            }
            this.QuotaUsageInBytes = quotaUsageInBytes;
            this.ShouldChangePassword = shouldChangePassword;
            this.Status = status;
            // to ensure "storageLabel" is required (not null)
            if (storageLabel == null)
            {
                throw new ArgumentNullException("storageLabel is a required property for UserAdminResponseDto and cannot be null");
            }
            this.StorageLabel = storageLabel;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name = "deletedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name = "isAdmin", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets License
        /// </summary>
        [DataMember(Name = "license", IsRequired = true, EmitDefaultValue = true)]
        public UserLicense License { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OauthId
        /// </summary>
        [DataMember(Name = "oauthId", IsRequired = true, EmitDefaultValue = true)]
        public string OauthId { get; set; }

        /// <summary>
        /// Gets or Sets ProfileImagePath
        /// </summary>
        [DataMember(Name = "profileImagePath", IsRequired = true, EmitDefaultValue = true)]
        public string ProfileImagePath { get; set; }

        /// <summary>
        /// Gets or Sets QuotaSizeInBytes
        /// </summary>
        [DataMember(Name = "quotaSizeInBytes", IsRequired = true, EmitDefaultValue = true)]
        public long? QuotaSizeInBytes { get; set; }

        /// <summary>
        /// Gets or Sets QuotaUsageInBytes
        /// </summary>
        [DataMember(Name = "quotaUsageInBytes", IsRequired = true, EmitDefaultValue = true)]
        public long? QuotaUsageInBytes { get; set; }

        /// <summary>
        /// Gets or Sets ShouldChangePassword
        /// </summary>
        [DataMember(Name = "shouldChangePassword", IsRequired = true, EmitDefaultValue = true)]
        public bool ShouldChangePassword { get; set; }

        /// <summary>
        /// Gets or Sets StorageLabel
        /// </summary>
        [DataMember(Name = "storageLabel", IsRequired = true, EmitDefaultValue = true)]
        public string StorageLabel { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAdminResponseDto {\n");
            sb.Append("  AvatarColor: ").Append(AvatarColor).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OauthId: ").Append(OauthId).Append("\n");
            sb.Append("  ProfileImagePath: ").Append(ProfileImagePath).Append("\n");
            sb.Append("  QuotaSizeInBytes: ").Append(QuotaSizeInBytes).Append("\n");
            sb.Append("  QuotaUsageInBytes: ").Append(QuotaUsageInBytes).Append("\n");
            sb.Append("  ShouldChangePassword: ").Append(ShouldChangePassword).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StorageLabel: ").Append(StorageLabel).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
