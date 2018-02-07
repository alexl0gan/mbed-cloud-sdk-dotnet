/* 
 * <auto-generated>
 * Account Management API
 *
 * API for managing accounts, users, creating API keys, uploading trusted certificates
 *
 * OpenAPI spec version: v3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * </auto-generated>
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = iam.Client.SwaggerDateConverter;

namespace iam.Model
{
    /// <summary>
    /// This object represents an entry in login history.
    /// </summary>
    [DataContract]
    public partial class LoginHistory :  IEquatable<LoginHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginHistory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoginHistory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginHistory" /> class.
        /// </summary>
        /// <param name="Date">UTC time RFC3339 for this login attempt. (required).</param>
        /// <param name="IpAddress">IP address of the client. (required).</param>
        /// <param name="UserAgent">User Agent header from the login request. (required).</param>
        /// <param name="Success">Flag indicating whether login attempt was successful or not. (required).</param>
        public LoginHistory(DateTime? Date = default(DateTime?), string IpAddress = default(string), string UserAgent = default(string), bool? Success = default(bool?))
        {
            // to ensure "Date" is required (not null)
            if (Date == null)
            {
                throw new InvalidDataException("Date is a required property for LoginHistory and cannot be null");
            }
            else
            {
                this.Date = Date;
            }
            // to ensure "IpAddress" is required (not null)
            if (IpAddress == null)
            {
                throw new InvalidDataException("IpAddress is a required property for LoginHistory and cannot be null");
            }
            else
            {
                this.IpAddress = IpAddress;
            }
            // to ensure "UserAgent" is required (not null)
            if (UserAgent == null)
            {
                throw new InvalidDataException("UserAgent is a required property for LoginHistory and cannot be null");
            }
            else
            {
                this.UserAgent = UserAgent;
            }
            // to ensure "Success" is required (not null)
            if (Success == null)
            {
                throw new InvalidDataException("Success is a required property for LoginHistory and cannot be null");
            }
            else
            {
                this.Success = Success;
            }
        }
        
        /// <summary>
        /// UTC time RFC3339 for this login attempt.
        /// </summary>
        /// <value>UTC time RFC3339 for this login attempt.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// IP address of the client.
        /// </summary>
        /// <value>IP address of the client.</value>
        [DataMember(Name="ip_address", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// User Agent header from the login request.
        /// </summary>
        /// <value>User Agent header from the login request.</value>
        [DataMember(Name="user_agent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Flag indicating whether login attempt was successful or not.
        /// </summary>
        /// <value>Flag indicating whether login attempt was successful or not.</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginHistory {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoginHistory);
        }

        /// <summary>
        /// Returns true if LoginHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of LoginHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
