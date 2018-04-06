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
    /// This object represents a user in requests towards mbed Cloud.
    /// </summary>
    [DataContract]
    public partial class AdminUserUpdateReq :  IEquatable<AdminUserUpdateReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUserUpdateReq" /> class.
        /// </summary>
        /// <param name="PhoneNumber">Phone number, not longer than 100 characters..</param>
        /// <param name="Username">A username containing alphanumerical letters and -,._@+&#x3D; characters. It must be at least 4 but not more than 30 character long..</param>
        /// <param name="Groups">A list of group IDs this user belongs to..</param>
        /// <param name="IsMarketingAccepted">A flag indicating that receiving marketing information has been accepted..</param>
        /// <param name="UserProperties">User&#39;s account specific custom properties..</param>
        /// <param name="IsGtcAccepted">A flag indicating that the General Terms and Conditions has been accepted..</param>
        /// <param name="IsTotpEnabled">A flag indicating whether 2-factor authentication (TOTP) has to be enabled or disabled..</param>
        /// <param name="NotificationProperties">Users notification properties for root admins. Currently supported; &#39;agreement_acceptance_notification&#39;, which controls whether notification should be sent upon accepting an agreement in an account. Possible values are: &#39;always_notify&#39;, &#39;only_first&#39; and &#39;not_interested&#39;..</param>
        /// <param name="Status">The status of the user..</param>
        /// <param name="FullName">The full name of the user, not longer than 100 characters..</param>
        /// <param name="Address">Address, not longer than 100 characters..</param>
        /// <param name="Password">The password when creating a new user. It will be generated when not present in the request..</param>
        /// <param name="Email">The email address, not longer than 254 characters..</param>
        public AdminUserUpdateReq(string PhoneNumber = default(string), string Username = default(string), List<string> Groups = default(List<string>), bool? IsMarketingAccepted = default(bool?), Dictionary<string, Dictionary<string, string>> UserProperties = default(Dictionary<string, Dictionary<string, string>>), bool? IsGtcAccepted = default(bool?), bool? IsTotpEnabled = default(bool?), Dictionary<string, string> NotificationProperties = default(Dictionary<string, string>), string Status = default(string), string FullName = default(string), string Address = default(string), string Password = default(string), string Email = default(string))
        {
            this.PhoneNumber = PhoneNumber;
            this.Username = Username;
            this.Groups = Groups;
            this.IsMarketingAccepted = IsMarketingAccepted;
            this.UserProperties = UserProperties;
            this.IsGtcAccepted = IsGtcAccepted;
            this.IsTotpEnabled = IsTotpEnabled;
            this.NotificationProperties = NotificationProperties;
            this.Status = Status;
            this.FullName = FullName;
            this.Address = Address;
            this.Password = Password;
            this.Email = Email;
        }
        
        /// <summary>
        /// Phone number, not longer than 100 characters.
        /// </summary>
        /// <value>Phone number, not longer than 100 characters.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// A username containing alphanumerical letters and -,._@+&#x3D; characters. It must be at least 4 but not more than 30 character long.
        /// </summary>
        /// <value>A username containing alphanumerical letters and -,._@+&#x3D; characters. It must be at least 4 but not more than 30 character long.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// A list of group IDs this user belongs to.
        /// </summary>
        /// <value>A list of group IDs this user belongs to.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// A flag indicating that receiving marketing information has been accepted.
        /// </summary>
        /// <value>A flag indicating that receiving marketing information has been accepted.</value>
        [DataMember(Name="is_marketing_accepted", EmitDefaultValue=false)]
        public bool? IsMarketingAccepted { get; set; }

        /// <summary>
        /// User&#39;s account specific custom properties.
        /// </summary>
        /// <value>User&#39;s account specific custom properties.</value>
        [DataMember(Name="user_properties", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, string>> UserProperties { get; set; }

        /// <summary>
        /// A flag indicating that the General Terms and Conditions has been accepted.
        /// </summary>
        /// <value>A flag indicating that the General Terms and Conditions has been accepted.</value>
        [DataMember(Name="is_gtc_accepted", EmitDefaultValue=false)]
        public bool? IsGtcAccepted { get; set; }

        /// <summary>
        /// A flag indicating whether 2-factor authentication (TOTP) has to be enabled or disabled.
        /// </summary>
        /// <value>A flag indicating whether 2-factor authentication (TOTP) has to be enabled or disabled.</value>
        [DataMember(Name="is_totp_enabled", EmitDefaultValue=false)]
        public bool? IsTotpEnabled { get; set; }

        /// <summary>
        /// Users notification properties for root admins. Currently supported; &#39;agreement_acceptance_notification&#39;, which controls whether notification should be sent upon accepting an agreement in an account. Possible values are: &#39;always_notify&#39;, &#39;only_first&#39; and &#39;not_interested&#39;.
        /// </summary>
        /// <value>Users notification properties for root admins. Currently supported; &#39;agreement_acceptance_notification&#39;, which controls whether notification should be sent upon accepting an agreement in an account. Possible values are: &#39;always_notify&#39;, &#39;only_first&#39; and &#39;not_interested&#39;.</value>
        [DataMember(Name="notification_properties", EmitDefaultValue=false)]
        public Dictionary<string, string> NotificationProperties { get; set; }

        /// <summary>
        /// The status of the user.
        /// </summary>
        /// <value>The status of the user.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The full name of the user, not longer than 100 characters.
        /// </summary>
        /// <value>The full name of the user, not longer than 100 characters.</value>
        [DataMember(Name="full_name", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Address, not longer than 100 characters.
        /// </summary>
        /// <value>Address, not longer than 100 characters.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// The password when creating a new user. It will be generated when not present in the request.
        /// </summary>
        /// <value>The password when creating a new user. It will be generated when not present in the request.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// The email address, not longer than 254 characters.
        /// </summary>
        /// <value>The email address, not longer than 254 characters.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminUserUpdateReq {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  IsMarketingAccepted: ").Append(IsMarketingAccepted).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  IsGtcAccepted: ").Append(IsGtcAccepted).Append("\n");
            sb.Append("  IsTotpEnabled: ").Append(IsTotpEnabled).Append("\n");
            sb.Append("  NotificationProperties: ").Append(NotificationProperties).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as AdminUserUpdateReq);
        }

        /// <summary>
        /// Returns true if AdminUserUpdateReq instances are equal
        /// </summary>
        /// <param name="input">Instance of AdminUserUpdateReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminUserUpdateReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.IsMarketingAccepted == input.IsMarketingAccepted ||
                    (this.IsMarketingAccepted != null &&
                    this.IsMarketingAccepted.Equals(input.IsMarketingAccepted))
                ) && 
                (
                    this.UserProperties == input.UserProperties ||
                    this.UserProperties != null &&
                    this.UserProperties.SequenceEqual(input.UserProperties)
                ) && 
                (
                    this.IsGtcAccepted == input.IsGtcAccepted ||
                    (this.IsGtcAccepted != null &&
                    this.IsGtcAccepted.Equals(input.IsGtcAccepted))
                ) && 
                (
                    this.IsTotpEnabled == input.IsTotpEnabled ||
                    (this.IsTotpEnabled != null &&
                    this.IsTotpEnabled.Equals(input.IsTotpEnabled))
                ) && 
                (
                    this.NotificationProperties == input.NotificationProperties ||
                    this.NotificationProperties != null &&
                    this.NotificationProperties.SequenceEqual(input.NotificationProperties)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.IsMarketingAccepted != null)
                    hashCode = hashCode * 59 + this.IsMarketingAccepted.GetHashCode();
                if (this.UserProperties != null)
                    hashCode = hashCode * 59 + this.UserProperties.GetHashCode();
                if (this.IsGtcAccepted != null)
                    hashCode = hashCode * 59 + this.IsGtcAccepted.GetHashCode();
                if (this.IsTotpEnabled != null)
                    hashCode = hashCode * 59 + this.IsTotpEnabled.GetHashCode();
                if (this.NotificationProperties != null)
                    hashCode = hashCode * 59 + this.NotificationProperties.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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