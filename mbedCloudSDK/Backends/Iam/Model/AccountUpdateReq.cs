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
    /// This object represents an account update request.
    /// </summary>
    [DataContract]
    public partial class AccountUpdateReq :  IEquatable<AccountUpdateReq>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUpdateReq" /> class.
        /// Initializes a new instance of the <see cref="AccountUpdateReq" />class.
        /// </summary>
        /// <param name="AddressLine2">Postal address line 2..</param>
        /// <param name="City">The city part of the postal address..</param>
        /// <param name="AddressLine1">Postal address line 1..</param>
        /// <param name="DisplayName">The display name for the account..</param>
        /// <param name="Country">The country part of the postal address..</param>
        /// <param name="Company">The name of the company..</param>
        /// <param name="State">The state part of the postal address..</param>
        /// <param name="Contact">The name of the contact person for this account..</param>
        /// <param name="PostalCode">The postal code part of the postal address..</param>
        /// <param name="PhoneNumber">The phone number of the company..</param>
        /// <param name="Email">The company email address for this account..</param>
        /// <param name="Aliases">An array of aliases. (required).</param>

        public AccountUpdateReq(string AddressLine2 = null, string City = null, string AddressLine1 = null, string DisplayName = null, string Country = null, string Company = null, string State = null, string Contact = null, string PostalCode = null, string PhoneNumber = null, string Email = null, List<string> Aliases = null)
        {
            // to ensure "Aliases" is required (not null)
            if (Aliases == null)
            {
                throw new InvalidDataException("Aliases is a required property for AccountUpdateReq and cannot be null");
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
            this.State = State;
            this.Contact = Contact;
            this.PostalCode = PostalCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            
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
        /// The state part of the postal address.
        /// </summary>
        /// <value>The state part of the postal address.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// The name of the contact person for this account.
        /// </summary>
        /// <value>The name of the contact person for this account.</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }
    
        /// <summary>
        /// The postal code part of the postal address.
        /// </summary>
        /// <value>The postal code part of the postal address.</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// The phone number of the company.
        /// </summary>
        /// <value>The phone number of the company.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// The company email address for this account.
        /// </summary>
        /// <value>The company email address for this account.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
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
            sb.Append("class AccountUpdateReq {\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(obj as AccountUpdateReq);
        }

        /// <summary>
        /// Returns true if AccountUpdateReq instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountUpdateReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountUpdateReq other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Aliases != null)
                    hash = hash * 59 + this.Aliases.GetHashCode();
                
                return hash;
            }
        }

    }
}
