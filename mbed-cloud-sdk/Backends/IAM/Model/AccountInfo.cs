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
    /// This object represents an account in requests and responses.
    /// </summary>
    [DataContract]
    public partial class AccountInfo :  IEquatable<AccountInfo>
    { 
    
        /// <summary>
        /// entity name: always 'account'
        /// </summary>
        /// <value>entity name: always 'account'</value>
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
        /// The status of the account.
        /// </summary>
        /// <value>The status of the account.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "SUSPENDED")]
            Suspended,
            
            [EnumMember(Value = "DISABLED")]
            Disabled
        }

    
        /// <summary>
        /// entity name: always 'account'
        /// </summary>
        /// <value>entity name: always 'account'</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public _ObjectEnum? _Object { get; set; }
    
        /// <summary>
        /// The status of the account.
        /// </summary>
        /// <value>The status of the account.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfo" /> class.
        /// Initializes a new instance of the <see cref="AccountInfo" />class.
        /// </summary>
        /// <param name="AddressLine2">Postal address line 2..</param>
        /// <param name="City">The city part of the postal address..</param>
        /// <param name="AddressLine1">Postal address line 1..</param>
        /// <param name="DisplayName">The display name for the account..</param>
        /// <param name="Country">The country part of the postal address..</param>
        /// <param name="Company">The name of the company..</param>
        /// <param name="_Object">entity name: always &#39;account&#39; (required).</param>
        /// <param name="Status">The status of the account. (required).</param>
        /// <param name="Id">Account ID. (required).</param>
        /// <param name="Email">The company email address for this account..</param>
        /// <param name="State">The state part of the postal address..</param>
        /// <param name="Etag">API resource entity version. (required).</param>
        /// <param name="PostalCode">The postal code part of the postal address..</param>
        /// <param name="Contact">The name of the contact person for this account..</param>
        /// <param name="IsProvisioningAllowed">Flag (true/false) indicating whether Factory Tool is allowed to download or not.. (required) (default to false).</param>
        /// <param name="Tier">The tier level of the account; &#39;0&#39;: free tier, &#39;1&#39;: commercial account. Other values are reserved for the future. (required).</param>
        /// <param name="PhoneNumber">The phone number of the company..</param>
        /// <param name="CreatedAt">Creation UTC time RFC3339..</param>
        /// <param name="Aliases">An array of aliases. (required).</param>

        public AccountInfo(string AddressLine2 = null, string City = null, string AddressLine1 = null, string DisplayName = null, string Country = null, string Company = null, _ObjectEnum? _Object = null, StatusEnum? Status = null, string Id = null, string Email = null, string State = null, string Etag = null, string PostalCode = null, string Contact = null, bool? IsProvisioningAllowed = null, string Tier = null, string PhoneNumber = null, string CreatedAt = null, List<string> Aliases = null)
        {
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for AccountInfo and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for AccountInfo and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for AccountInfo and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for AccountInfo and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "IsProvisioningAllowed" is required (not null)
            if (IsProvisioningAllowed == null)
            {
                throw new InvalidDataException("IsProvisioningAllowed is a required property for AccountInfo and cannot be null");
            }
            else
            {
                this.IsProvisioningAllowed = IsProvisioningAllowed;
            }
            // to ensure "Tier" is required (not null)
            if (Tier == null)
            {
                throw new InvalidDataException("Tier is a required property for AccountInfo and cannot be null");
            }
            else
            {
                this.Tier = Tier;
            }
            // to ensure "Aliases" is required (not null)
            if (Aliases == null)
            {
                throw new InvalidDataException("Aliases is a required property for AccountInfo and cannot be null");
            }
            else
            {
                this.Aliases = Aliases;
            }
            this.AddressLine2 = AddressLine2;
            this.City = City;
            this.AddressLine1 = AddressLine1;
            this.DisplayName = DisplayName;
            this.Country = Country;
            this.Company = Company;
            this.Email = Email;
            this.State = State;
            this.PostalCode = PostalCode;
            this.Contact = Contact;
            this.PhoneNumber = PhoneNumber;
            this.CreatedAt = CreatedAt;
            
        }
        
    
        /// <summary>
        /// Postal address line 2.
        /// </summary>
        /// <value>Postal address line 2.</value>
        [DataMember(Name="address_line2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }
    
        /// <summary>
        /// The city part of the postal address.
        /// </summary>
        /// <value>The city part of the postal address.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Postal address line 1.
        /// </summary>
        /// <value>Postal address line 1.</value>
        [DataMember(Name="address_line1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }
    
        /// <summary>
        /// The display name for the account.
        /// </summary>
        /// <value>The display name for the account.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// The country part of the postal address.
        /// </summary>
        /// <value>The country part of the postal address.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
    
        /// <summary>
        /// The name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
    
        /// <summary>
        /// Account ID.
        /// </summary>
        /// <value>Account ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The company email address for this account.
        /// </summary>
        /// <value>The company email address for this account.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// The state part of the postal address.
        /// </summary>
        /// <value>The state part of the postal address.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// API resource entity version.
        /// </summary>
        /// <value>API resource entity version.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }
    
        /// <summary>
        /// The postal code part of the postal address.
        /// </summary>
        /// <value>The postal code part of the postal address.</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// The name of the contact person for this account.
        /// </summary>
        /// <value>The name of the contact person for this account.</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }
    
        /// <summary>
        /// Flag (true/false) indicating whether Factory Tool is allowed to download or not..
        /// </summary>
        /// <value>Flag (true/false) indicating whether Factory Tool is allowed to download or not..</value>
        [DataMember(Name="is_provisioning_allowed", EmitDefaultValue=false)]
        public bool? IsProvisioningAllowed { get; set; }
    
        /// <summary>
        /// The tier level of the account; &#39;0&#39;: free tier, &#39;1&#39;: commercial account. Other values are reserved for the future.
        /// </summary>
        /// <value>The tier level of the account; &#39;0&#39;: free tier, &#39;1&#39;: commercial account. Other values are reserved for the future.</value>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public string Tier { get; set; }
    
        /// <summary>
        /// The phone number of the company.
        /// </summary>
        /// <value>The phone number of the company.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        /// <value>Creation UTC time RFC3339.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
    
        /// <summary>
        /// An array of aliases.
        /// </summary>
        /// <value>An array of aliases.</value>
        [DataMember(Name="aliases", EmitDefaultValue=false)]
        public List<string> Aliases { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountInfo {\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  IsProvisioningAllowed: ").Append(IsProvisioningAllowed).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Aliases: ").Append(Aliases).Append("\n");
            
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
            return this.Equals(obj as AccountInfo);
        }

        /// <summary>
        /// Returns true if AccountInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressLine2 == other.AddressLine2 ||
                    this.AddressLine2 != null &&
                    this.AddressLine2.Equals(other.AddressLine2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.AddressLine1 == other.AddressLine1 ||
                    this.AddressLine1 != null &&
                    this.AddressLine1.Equals(other.AddressLine1)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.IsProvisioningAllowed == other.IsProvisioningAllowed ||
                    this.IsProvisioningAllowed != null &&
                    this.IsProvisioningAllowed.Equals(other.IsProvisioningAllowed)
                ) && 
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Aliases == other.Aliases ||
                    this.Aliases != null &&
                    this.Aliases.SequenceEqual(other.Aliases)
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
                
                if (this.AddressLine2 != null)
                    hash = hash * 59 + this.AddressLine2.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.AddressLine1 != null)
                    hash = hash * 59 + this.AddressLine1.GetHashCode();
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                
                if (this.IsProvisioningAllowed != null)
                    hash = hash * 59 + this.IsProvisioningAllowed.GetHashCode();
                
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this.Aliases != null)
                    hash = hash * 59 + this.Aliases.GetHashCode();
                
                return hash;
            }
        }

    }
}
