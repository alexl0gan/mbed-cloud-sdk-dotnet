using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace iam.Model
{
    /// <summary>
    /// This object represents a user in mbed Cloud.
    /// </summary>
    [DataContract]
    public partial class UserInfoResp :  IEquatable<UserInfoResp>
    { 
    
        /// <summary>
        /// The status of the user. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately.
        /// </summary>
        /// <value>The status of the user. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INVITED")]
            Invited,
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "RESET")]
            Reset,
            
            [EnumMember(Value = "INACTIVE")]
            Inactive
        }

    
        /// <summary>
        /// entity name: always 'user'
        /// </summary>
        /// <value>entity name: always 'user'</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum _ObjectEnum {
            
            [EnumMember(Value = "user")]
            User,
            
            [EnumMember(Value = "apikey")]
            Apikey,
            
            [EnumMember(Value = "group")]
            Group,
            
            [EnumMember(Value = "account")]
            Account,
            
            [EnumMember(Value = "list")]
            List,
            
            [EnumMember(Value = "error")]
            Error
        }

    
        /// <summary>
        /// The status of the user. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately.
        /// </summary>
        /// <value>The status of the user. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// entity name: always 'user'
        /// </summary>
        /// <value>entity name: always 'user'</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public _ObjectEnum? _Object { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoResp" /> class.
        /// Initializes a new instance of the <see cref="UserInfoResp" />class.
        /// </summary>
        /// <param name="Status">The status of the user. INVITED means that the user has not accepted the invitation request. RESET means that the password must be changed immediately. (required).</param>
        /// <param name="Username">A username containing alphanumerical letters and -,._@+= characters. (required).</param>
        /// <param name="EmailVerified">A flag indicating whether the user&#39;s email address has been verified or not. (default to false).</param>
        /// <param name="AccountId">The UUID of the account. (required).</param>
        /// <param name="PasswordChangedTime">A timestamp of the latest change of the user password, in milliseconds..</param>
        /// <param name="Groups">A list of IDs of the groups this user belongs to..</param>
        /// <param name="CreatedAt">Creation UTC time RFC3339..</param>
        /// <param name="_Object">entity name: always &#39;user&#39; (required).</param>
        /// <param name="IsGtcAccepted">A flag indicating that the General Terms and Conditions has been accepted. (default to false).</param>
        /// <param name="Email">Email address. (required).</param>
        /// <param name="IsMarketingAccepted">A flag indicating that receiving marketing information has been accepted. (default to false).</param>
        /// <param name="Etag">API resource entity version. (required).</param>
        /// <param name="FullName">The full name of the user..</param>
        /// <param name="Address">Address..</param>
        /// <param name="CreationTime">A timestamp of the user creation in the storage, in milliseconds..</param>
        /// <param name="Password">The password when creating a new user. It will will generated when not present in the request..</param>
        /// <param name="PhoneNumber">Phone number..</param>
        /// <param name="Id">The UUID of the user. (required).</param>
        /// <param name="LastLoginTime">A timestamp of the latest login of the user, in milliseconds..</param>

        public UserInfoResp(StatusEnum? Status = null, string Username = null, bool? EmailVerified = null, string AccountId = null, long? PasswordChangedTime = null, List<string> Groups = null, string CreatedAt = null, _ObjectEnum? _Object = null, bool? IsGtcAccepted = null, string Email = null, bool? IsMarketingAccepted = null, string Etag = null, string FullName = null, string Address = null, long? CreationTime = null, string Password = null, string PhoneNumber = null, string Id = null, long? LastLoginTime = null)
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for UserInfoResp and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for UserInfoResp and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for UserInfoResp and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for UserInfoResp and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UserInfoResp and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for UserInfoResp and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for UserInfoResp and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // use default value if no "EmailVerified" provided
            if (EmailVerified == null)
            {
                this.EmailVerified = false;
            }
            else
            {
                this.EmailVerified = EmailVerified;
            }
            this.PasswordChangedTime = PasswordChangedTime;
            this.Groups = Groups;
            this.CreatedAt = CreatedAt;
            // use default value if no "IsGtcAccepted" provided
            if (IsGtcAccepted == null)
            {
                this.IsGtcAccepted = false;
            }
            else
            {
                this.IsGtcAccepted = IsGtcAccepted;
            }
            // use default value if no "IsMarketingAccepted" provided
            if (IsMarketingAccepted == null)
            {
                this.IsMarketingAccepted = false;
            }
            else
            {
                this.IsMarketingAccepted = IsMarketingAccepted;
            }
            this.FullName = FullName;
            this.Address = Address;
            this.CreationTime = CreationTime;
            this.Password = Password;
            this.PhoneNumber = PhoneNumber;
            this.LastLoginTime = LastLoginTime;
            
        }
        
    
        /// <summary>
        /// A username containing alphanumerical letters and -,._@+= characters.
        /// </summary>
        /// <value>A username containing alphanumerical letters and -,._@+= characters.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
    
        /// <summary>
        /// A flag indicating whether the user&#39;s email address has been verified or not.
        /// </summary>
        /// <value>A flag indicating whether the user&#39;s email address has been verified or not.</value>
        [DataMember(Name="email_verified", EmitDefaultValue=false)]
        public bool? EmailVerified { get; set; }
    
        /// <summary>
        /// The UUID of the account.
        /// </summary>
        /// <value>The UUID of the account.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }
    
        /// <summary>
        /// A timestamp of the latest change of the user password, in milliseconds.
        /// </summary>
        /// <value>A timestamp of the latest change of the user password, in milliseconds.</value>
        [DataMember(Name="password_changed_time", EmitDefaultValue=false)]
        public long? PasswordChangedTime { get; set; }
    
        /// <summary>
        /// A list of IDs of the groups this user belongs to.
        /// </summary>
        /// <value>A list of IDs of the groups this user belongs to.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }
    
        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        /// <value>Creation UTC time RFC3339.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
    
        /// <summary>
        /// A flag indicating that the General Terms and Conditions has been accepted.
        /// </summary>
        /// <value>A flag indicating that the General Terms and Conditions has been accepted.</value>
        [DataMember(Name="is_gtc_accepted", EmitDefaultValue=false)]
        public bool? IsGtcAccepted { get; set; }
    
        /// <summary>
        /// Email address.
        /// </summary>
        /// <value>Email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// A flag indicating that receiving marketing information has been accepted.
        /// </summary>
        /// <value>A flag indicating that receiving marketing information has been accepted.</value>
        [DataMember(Name="is_marketing_accepted", EmitDefaultValue=false)]
        public bool? IsMarketingAccepted { get; set; }
    
        /// <summary>
        /// API resource entity version.
        /// </summary>
        /// <value>API resource entity version.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }
    
        /// <summary>
        /// The full name of the user.
        /// </summary>
        /// <value>The full name of the user.</value>
        [DataMember(Name="full_name", EmitDefaultValue=false)]
        public string FullName { get; set; }
    
        /// <summary>
        /// Address.
        /// </summary>
        /// <value>Address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
    
        /// <summary>
        /// A timestamp of the user creation in the storage, in milliseconds.
        /// </summary>
        /// <value>A timestamp of the user creation in the storage, in milliseconds.</value>
        [DataMember(Name="creation_time", EmitDefaultValue=false)]
        public long? CreationTime { get; set; }
    
        /// <summary>
        /// The password when creating a new user. It will will generated when not present in the request.
        /// </summary>
        /// <value>The password when creating a new user. It will will generated when not present in the request.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
    
        /// <summary>
        /// Phone number.
        /// </summary>
        /// <value>Phone number.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// The UUID of the user.
        /// </summary>
        /// <value>The UUID of the user.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// A timestamp of the latest login of the user, in milliseconds.
        /// </summary>
        /// <value>A timestamp of the latest login of the user, in milliseconds.</value>
        [DataMember(Name="last_login_time", EmitDefaultValue=false)]
        public long? LastLoginTime { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfoResp {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  PasswordChangedTime: ").Append(PasswordChangedTime).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  IsGtcAccepted: ").Append(IsGtcAccepted).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsMarketingAccepted: ").Append(IsMarketingAccepted).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastLoginTime: ").Append(LastLoginTime).Append("\n");
            
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserInfoResp);
        }

        /// <summary>
        /// Returns true if UserInfoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of UserInfoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfoResp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.EmailVerified == other.EmailVerified ||
                    this.EmailVerified != null &&
                    this.EmailVerified.Equals(other.EmailVerified)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.PasswordChangedTime == other.PasswordChangedTime ||
                    this.PasswordChangedTime != null &&
                    this.PasswordChangedTime.Equals(other.PasswordChangedTime)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.IsGtcAccepted == other.IsGtcAccepted ||
                    this.IsGtcAccepted != null &&
                    this.IsGtcAccepted.Equals(other.IsGtcAccepted)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.IsMarketingAccepted == other.IsMarketingAccepted ||
                    this.IsMarketingAccepted != null &&
                    this.IsMarketingAccepted.Equals(other.IsMarketingAccepted)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastLoginTime == other.LastLoginTime ||
                    this.LastLoginTime != null &&
                    this.LastLoginTime.Equals(other.LastLoginTime)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                
                if (this.EmailVerified != null)
                    hash = hash * 59 + this.EmailVerified.GetHashCode();
                
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                
                if (this.PasswordChangedTime != null)
                    hash = hash * 59 + this.PasswordChangedTime.GetHashCode();
                
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                
                if (this.IsGtcAccepted != null)
                    hash = hash * 59 + this.IsGtcAccepted.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.IsMarketingAccepted != null)
                    hash = hash * 59 + this.IsMarketingAccepted.GetHashCode();
                
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.LastLoginTime != null)
                    hash = hash * 59 + this.LastLoginTime.GetHashCode();
                
                return hash;
            }
        }

    }
}
