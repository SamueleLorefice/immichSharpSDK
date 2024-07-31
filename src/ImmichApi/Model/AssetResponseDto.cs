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
    /// AssetResponseDto
    /// </summary>
    [DataContract(Name = "AssetResponseDto")]
    public partial class AssetResponseDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public AssetTypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponseDto" /> class.
        /// </summary>
        /// <param name="checksum">base64 encoded sha1 hash (required).</param>
        /// <param name="deviceAssetId">deviceAssetId (required).</param>
        /// <param name="deviceId">deviceId (required).</param>
        /// <param name="duplicateId">duplicateId.</param>
        /// <param name="duration">duration (required).</param>
        /// <param name="exifInfo">exifInfo.</param>
        /// <param name="fileCreatedAt">fileCreatedAt (required).</param>
        /// <param name="fileModifiedAt">fileModifiedAt (required).</param>
        /// <param name="hasMetadata">hasMetadata (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="isArchived">isArchived (required).</param>
        /// <param name="isFavorite">isFavorite (required).</param>
        /// <param name="isOffline">isOffline (required).</param>
        /// <param name="isTrashed">isTrashed (required).</param>
        /// <param name="libraryId">This property was deprecated in v1.106.0.</param>
        /// <param name="livePhotoVideoId">livePhotoVideoId.</param>
        /// <param name="localDateTime">localDateTime (required).</param>
        /// <param name="originalFileName">originalFileName (required).</param>
        /// <param name="originalMimeType">originalMimeType.</param>
        /// <param name="originalPath">originalPath (required).</param>
        /// <param name="owner">owner.</param>
        /// <param name="ownerId">ownerId (required).</param>
        /// <param name="people">people.</param>
        /// <param name="resized">resized (required).</param>
        /// <param name="smartInfo">smartInfo.</param>
        /// <param name="stack">stack.</param>
        /// <param name="stackCount">stackCount (required).</param>
        /// <param name="stackParentId">stackParentId.</param>
        /// <param name="tags">tags.</param>
        /// <param name="thumbhash">thumbhash (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="unassignedFaces">unassignedFaces.</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public AssetResponseDto(string checksum = default(string), string deviceAssetId = default(string), string deviceId = default(string), string duplicateId = default(string), string duration = default(string), ExifResponseDto exifInfo = default(ExifResponseDto), DateTime fileCreatedAt = default(DateTime), DateTime fileModifiedAt = default(DateTime), bool hasMetadata = default(bool), string id = default(string), bool isArchived = default(bool), bool isFavorite = default(bool), bool isOffline = default(bool), bool isTrashed = default(bool), string libraryId = default(string), string livePhotoVideoId = default(string), DateTime localDateTime = default(DateTime), string originalFileName = default(string), string originalMimeType = default(string), string originalPath = default(string), UserResponseDto owner = default(UserResponseDto), string ownerId = default(string), List<PersonWithFacesResponseDto> people = default(List<PersonWithFacesResponseDto>), bool resized = default(bool), SmartInfoResponseDto smartInfo = default(SmartInfoResponseDto), List<AssetResponseDto> stack = default(List<AssetResponseDto>), int? stackCount = default(int?), string stackParentId = default(string), List<TagResponseDto> tags = default(List<TagResponseDto>), string thumbhash = default(string), AssetTypeEnum type = default(AssetTypeEnum), List<AssetFaceWithoutPersonResponseDto> unassignedFaces = default(List<AssetFaceWithoutPersonResponseDto>), DateTime updatedAt = default(DateTime))
        {
            // to ensure "checksum" is required (not null)
            if (checksum == null)
            {
                throw new ArgumentNullException("checksum is a required property for AssetResponseDto and cannot be null");
            }
            this.Checksum = checksum;
            // to ensure "deviceAssetId" is required (not null)
            if (deviceAssetId == null)
            {
                throw new ArgumentNullException("deviceAssetId is a required property for AssetResponseDto and cannot be null");
            }
            this.DeviceAssetId = deviceAssetId;
            // to ensure "deviceId" is required (not null)
            if (deviceId == null)
            {
                throw new ArgumentNullException("deviceId is a required property for AssetResponseDto and cannot be null");
            }
            this.DeviceId = deviceId;
            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new ArgumentNullException("duration is a required property for AssetResponseDto and cannot be null");
            }
            this.Duration = duration;
            this.FileCreatedAt = fileCreatedAt;
            this.FileModifiedAt = fileModifiedAt;
            this.HasMetadata = hasMetadata;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AssetResponseDto and cannot be null");
            }
            this.Id = id;
            this.IsArchived = isArchived;
            this.IsFavorite = isFavorite;
            this.IsOffline = isOffline;
            this.IsTrashed = isTrashed;
            this.LocalDateTime = localDateTime;
            // to ensure "originalFileName" is required (not null)
            if (originalFileName == null)
            {
                throw new ArgumentNullException("originalFileName is a required property for AssetResponseDto and cannot be null");
            }
            this.OriginalFileName = originalFileName;
            // to ensure "originalPath" is required (not null)
            if (originalPath == null)
            {
                throw new ArgumentNullException("originalPath is a required property for AssetResponseDto and cannot be null");
            }
            this.OriginalPath = originalPath;
            // to ensure "ownerId" is required (not null)
            if (ownerId == null)
            {
                throw new ArgumentNullException("ownerId is a required property for AssetResponseDto and cannot be null");
            }
            this.OwnerId = ownerId;
            this.Resized = resized;
            // to ensure "stackCount" is required (not null)
            if (stackCount == null)
            {
                throw new ArgumentNullException("stackCount is a required property for AssetResponseDto and cannot be null");
            }
            this.StackCount = stackCount;
            // to ensure "thumbhash" is required (not null)
            if (thumbhash == null)
            {
                throw new ArgumentNullException("thumbhash is a required property for AssetResponseDto and cannot be null");
            }
            this.Thumbhash = thumbhash;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.DuplicateId = duplicateId;
            this.ExifInfo = exifInfo;
            this.LibraryId = libraryId;
            this.LivePhotoVideoId = livePhotoVideoId;
            this.OriginalMimeType = originalMimeType;
            this.Owner = owner;
            this.People = people;
            this.SmartInfo = smartInfo;
            this.Stack = stack;
            this.StackParentId = stackParentId;
            this.Tags = tags;
            this.UnassignedFaces = unassignedFaces;
        }

        /// <summary>
        /// base64 encoded sha1 hash
        /// </summary>
        /// <value>base64 encoded sha1 hash</value>
        [DataMember(Name = "checksum", IsRequired = true, EmitDefaultValue = true)]
        public string Checksum { get; set; }

        /// <summary>
        /// Gets or Sets DeviceAssetId
        /// </summary>
        [DataMember(Name = "deviceAssetId", IsRequired = true, EmitDefaultValue = true)]
        public string DeviceAssetId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", IsRequired = true, EmitDefaultValue = true)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets DuplicateId
        /// </summary>
        [DataMember(Name = "duplicateId", EmitDefaultValue = true)]
        public string DuplicateId { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or Sets ExifInfo
        /// </summary>
        [DataMember(Name = "exifInfo", EmitDefaultValue = false)]
        public ExifResponseDto ExifInfo { get; set; }

        /// <summary>
        /// Gets or Sets FileCreatedAt
        /// </summary>
        [DataMember(Name = "fileCreatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime FileCreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FileModifiedAt
        /// </summary>
        [DataMember(Name = "fileModifiedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime FileModifiedAt { get; set; }

        /// <summary>
        /// Gets or Sets HasMetadata
        /// </summary>
        [DataMember(Name = "hasMetadata", IsRequired = true, EmitDefaultValue = true)]
        public bool HasMetadata { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsArchived
        /// </summary>
        [DataMember(Name = "isArchived", IsRequired = true, EmitDefaultValue = true)]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Gets or Sets IsFavorite
        /// </summary>
        [DataMember(Name = "isFavorite", IsRequired = true, EmitDefaultValue = true)]
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Gets or Sets IsOffline
        /// </summary>
        [DataMember(Name = "isOffline", IsRequired = true, EmitDefaultValue = true)]
        public bool IsOffline { get; set; }

        /// <summary>
        /// Gets or Sets IsTrashed
        /// </summary>
        [DataMember(Name = "isTrashed", IsRequired = true, EmitDefaultValue = true)]
        public bool IsTrashed { get; set; }

        /// <summary>
        /// This property was deprecated in v1.106.0
        /// </summary>
        /// <value>This property was deprecated in v1.106.0</value>
        [DataMember(Name = "libraryId", EmitDefaultValue = true)]
        [Obsolete]
        public string LibraryId { get; set; }

        /// <summary>
        /// Gets or Sets LivePhotoVideoId
        /// </summary>
        [DataMember(Name = "livePhotoVideoId", EmitDefaultValue = true)]
        public string LivePhotoVideoId { get; set; }

        /// <summary>
        /// Gets or Sets LocalDateTime
        /// </summary>
        [DataMember(Name = "localDateTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime LocalDateTime { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFileName
        /// </summary>
        [DataMember(Name = "originalFileName", IsRequired = true, EmitDefaultValue = true)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or Sets OriginalMimeType
        /// </summary>
        [DataMember(Name = "originalMimeType", EmitDefaultValue = false)]
        public string OriginalMimeType { get; set; }

        /// <summary>
        /// Gets or Sets OriginalPath
        /// </summary>
        [DataMember(Name = "originalPath", IsRequired = true, EmitDefaultValue = true)]
        public string OriginalPath { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public UserResponseDto Owner { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name = "ownerId", IsRequired = true, EmitDefaultValue = true)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets People
        /// </summary>
        [DataMember(Name = "people", EmitDefaultValue = false)]
        public List<PersonWithFacesResponseDto> People { get; set; }

        /// <summary>
        /// Gets or Sets Resized
        /// </summary>
        [DataMember(Name = "resized", IsRequired = true, EmitDefaultValue = true)]
        public bool Resized { get; set; }

        /// <summary>
        /// Gets or Sets SmartInfo
        /// </summary>
        [DataMember(Name = "smartInfo", EmitDefaultValue = false)]
        public SmartInfoResponseDto SmartInfo { get; set; }

        /// <summary>
        /// Gets or Sets Stack
        /// </summary>
        [DataMember(Name = "stack", EmitDefaultValue = false)]
        public List<AssetResponseDto> Stack { get; set; }

        /// <summary>
        /// Gets or Sets StackCount
        /// </summary>
        [DataMember(Name = "stackCount", IsRequired = true, EmitDefaultValue = true)]
        public int? StackCount { get; set; }

        /// <summary>
        /// Gets or Sets StackParentId
        /// </summary>
        [DataMember(Name = "stackParentId", EmitDefaultValue = true)]
        public string StackParentId { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<TagResponseDto> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Thumbhash
        /// </summary>
        [DataMember(Name = "thumbhash", IsRequired = true, EmitDefaultValue = true)]
        public string Thumbhash { get; set; }

        /// <summary>
        /// Gets or Sets UnassignedFaces
        /// </summary>
        [DataMember(Name = "unassignedFaces", EmitDefaultValue = false)]
        public List<AssetFaceWithoutPersonResponseDto> UnassignedFaces { get; set; }

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
            sb.Append("class AssetResponseDto {\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  DeviceAssetId: ").Append(DeviceAssetId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  DuplicateId: ").Append(DuplicateId).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ExifInfo: ").Append(ExifInfo).Append("\n");
            sb.Append("  FileCreatedAt: ").Append(FileCreatedAt).Append("\n");
            sb.Append("  FileModifiedAt: ").Append(FileModifiedAt).Append("\n");
            sb.Append("  HasMetadata: ").Append(HasMetadata).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  IsOffline: ").Append(IsOffline).Append("\n");
            sb.Append("  IsTrashed: ").Append(IsTrashed).Append("\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
            sb.Append("  LivePhotoVideoId: ").Append(LivePhotoVideoId).Append("\n");
            sb.Append("  LocalDateTime: ").Append(LocalDateTime).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  OriginalMimeType: ").Append(OriginalMimeType).Append("\n");
            sb.Append("  OriginalPath: ").Append(OriginalPath).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  Resized: ").Append(Resized).Append("\n");
            sb.Append("  SmartInfo: ").Append(SmartInfo).Append("\n");
            sb.Append("  Stack: ").Append(Stack).Append("\n");
            sb.Append("  StackCount: ").Append(StackCount).Append("\n");
            sb.Append("  StackParentId: ").Append(StackParentId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Thumbhash: ").Append(Thumbhash).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnassignedFaces: ").Append(UnassignedFaces).Append("\n");
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
