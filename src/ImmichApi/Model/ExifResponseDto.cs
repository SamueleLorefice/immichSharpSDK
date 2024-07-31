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
    /// ExifResponseDto
    /// </summary>
    [DataContract(Name = "ExifResponseDto")]
    public partial class ExifResponseDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExifResponseDto" /> class.
        /// </summary>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="dateTimeOriginal">dateTimeOriginal.</param>
        /// <param name="description">description.</param>
        /// <param name="exifImageHeight">exifImageHeight.</param>
        /// <param name="exifImageWidth">exifImageWidth.</param>
        /// <param name="exposureTime">exposureTime.</param>
        /// <param name="fNumber">fNumber.</param>
        /// <param name="fileSizeInByte">fileSizeInByte.</param>
        /// <param name="focalLength">focalLength.</param>
        /// <param name="iso">iso.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="lensModel">lensModel.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="modifyDate">modifyDate.</param>
        /// <param name="orientation">orientation.</param>
        /// <param name="projectionType">projectionType.</param>
        /// <param name="state">state.</param>
        /// <param name="varTimeZone">varTimeZone.</param>
        public ExifResponseDto(string city = default(string), string country = default(string), DateTime? dateTimeOriginal = default(DateTime?), string description = default(string), decimal? exifImageHeight = default(decimal?), decimal? exifImageWidth = default(decimal?), string exposureTime = default(string), decimal? fNumber = default(decimal?), long? fileSizeInByte = default(long?), decimal? focalLength = default(decimal?), decimal? iso = default(decimal?), decimal? latitude = default(decimal?), string lensModel = default(string), decimal? longitude = default(decimal?), string make = default(string), string model = default(string), DateTime? modifyDate = default(DateTime?), string orientation = default(string), string projectionType = default(string), string state = default(string), string varTimeZone = default(string))
        {
            this.City = city;
            this.Country = country;
            this.DateTimeOriginal = dateTimeOriginal;
            this.Description = description;
            this.ExifImageHeight = exifImageHeight;
            this.ExifImageWidth = exifImageWidth;
            this.ExposureTime = exposureTime;
            this.FNumber = fNumber;
            this.FileSizeInByte = fileSizeInByte;
            this.FocalLength = focalLength;
            this.Iso = iso;
            this.Latitude = latitude;
            this.LensModel = lensModel;
            this.Longitude = longitude;
            this.Make = make;
            this.Model = model;
            this.ModifyDate = modifyDate;
            this.Orientation = orientation;
            this.ProjectionType = projectionType;
            this.State = state;
            this.VarTimeZone = varTimeZone;
        }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets DateTimeOriginal
        /// </summary>
        [DataMember(Name = "dateTimeOriginal", EmitDefaultValue = true)]
        public DateTime? DateTimeOriginal { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ExifImageHeight
        /// </summary>
        [DataMember(Name = "exifImageHeight", EmitDefaultValue = true)]
        public decimal? ExifImageHeight { get; set; }

        /// <summary>
        /// Gets or Sets ExifImageWidth
        /// </summary>
        [DataMember(Name = "exifImageWidth", EmitDefaultValue = true)]
        public decimal? ExifImageWidth { get; set; }

        /// <summary>
        /// Gets or Sets ExposureTime
        /// </summary>
        [DataMember(Name = "exposureTime", EmitDefaultValue = true)]
        public string ExposureTime { get; set; }

        /// <summary>
        /// Gets or Sets FNumber
        /// </summary>
        [DataMember(Name = "fNumber", EmitDefaultValue = true)]
        public decimal? FNumber { get; set; }

        /// <summary>
        /// Gets or Sets FileSizeInByte
        /// </summary>
        [DataMember(Name = "fileSizeInByte", EmitDefaultValue = true)]
        public long? FileSizeInByte { get; set; }

        /// <summary>
        /// Gets or Sets FocalLength
        /// </summary>
        [DataMember(Name = "focalLength", EmitDefaultValue = true)]
        public decimal? FocalLength { get; set; }

        /// <summary>
        /// Gets or Sets Iso
        /// </summary>
        [DataMember(Name = "iso", EmitDefaultValue = true)]
        public decimal? Iso { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets LensModel
        /// </summary>
        [DataMember(Name = "lensModel", EmitDefaultValue = true)]
        public string LensModel { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Make
        /// </summary>
        [DataMember(Name = "make", EmitDefaultValue = true)]
        public string Make { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = true)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name = "modifyDate", EmitDefaultValue = true)]
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name = "orientation", EmitDefaultValue = true)]
        public string Orientation { get; set; }

        /// <summary>
        /// Gets or Sets ProjectionType
        /// </summary>
        [DataMember(Name = "projectionType", EmitDefaultValue = true)]
        public string ProjectionType { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets VarTimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public string VarTimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExifResponseDto {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  DateTimeOriginal: ").Append(DateTimeOriginal).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExifImageHeight: ").Append(ExifImageHeight).Append("\n");
            sb.Append("  ExifImageWidth: ").Append(ExifImageWidth).Append("\n");
            sb.Append("  ExposureTime: ").Append(ExposureTime).Append("\n");
            sb.Append("  FNumber: ").Append(FNumber).Append("\n");
            sb.Append("  FileSizeInByte: ").Append(FileSizeInByte).Append("\n");
            sb.Append("  FocalLength: ").Append(FocalLength).Append("\n");
            sb.Append("  Iso: ").Append(Iso).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  LensModel: ").Append(LensModel).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Make: ").Append(Make).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  ProjectionType: ").Append(ProjectionType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
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
