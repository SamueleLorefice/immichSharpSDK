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
    /// SystemConfigSmtpTransportDto
    /// </summary>
    [DataContract(Name = "SystemConfigSmtpTransportDto")]
    public partial class SystemConfigSmtpTransportDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigSmtpTransportDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemConfigSmtpTransportDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemConfigSmtpTransportDto" /> class.
        /// </summary>
        /// <param name="host">host (required).</param>
        /// <param name="ignoreCert">ignoreCert (required).</param>
        /// <param name="password">password (required).</param>
        /// <param name="port">port (required).</param>
        /// <param name="username">username (required).</param>
        public SystemConfigSmtpTransportDto(string host = default(string), bool ignoreCert = default(bool), string password = default(string), decimal port = default(decimal), string username = default(string))
        {
            // to ensure "host" is required (not null)
            if (host == null)
            {
                throw new ArgumentNullException("host is a required property for SystemConfigSmtpTransportDto and cannot be null");
            }
            this.Host = host;
            this.IgnoreCert = ignoreCert;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for SystemConfigSmtpTransportDto and cannot be null");
            }
            this.Password = password;
            this.Port = port;
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new ArgumentNullException("username is a required property for SystemConfigSmtpTransportDto and cannot be null");
            }
            this.Username = username;
        }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name = "host", IsRequired = true, EmitDefaultValue = true)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreCert
        /// </summary>
        [DataMember(Name = "ignoreCert", IsRequired = true, EmitDefaultValue = true)]
        public bool IgnoreCert { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", IsRequired = true, EmitDefaultValue = true)]
        public decimal Port { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemConfigSmtpTransportDto {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  IgnoreCert: ").Append(IgnoreCert).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            // Port (decimal) maximum
            if (this.Port > (decimal)65535)
            {
                yield return new ValidationResult("Invalid value for Port, must be a value less than or equal to 65535.", new [] { "Port" });
            }

            // Port (decimal) minimum
            if (this.Port < (decimal)0)
            {
                yield return new ValidationResult("Invalid value for Port, must be a value greater than or equal to 0.", new [] { "Port" });
            }

            yield break;
        }
    }

}
