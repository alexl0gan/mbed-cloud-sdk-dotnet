/* 
 * <auto-generated>
 * Billing API
 *
 * Billing API allows users to retrieve billing reports and service package details.
 *
 * OpenAPI spec version: 1.4.7
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
using SwaggerDateConverter = billing.Client.SwaggerDateConverter;

namespace billing.Model
{
    /// <summary>
    /// Quota history item.
    /// </summary>
    [DataContract]
    public partial class ServicePackageQuotaHistoryItem :  IEquatable<ServicePackageQuotaHistoryItem>, IValidatableObject
    {
        /// <summary>
        /// Type of quota usage entry.
        /// </summary>
        /// <value>Type of quota usage entry.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum Reservation for "reservation"
            /// </summary>
            [EnumMember(Value = "reservation")]
            Reservation,
            
            /// <summary>
            /// Enum Reservationrelease for "reservation_release"
            /// </summary>
            [EnumMember(Value = "reservation_release")]
            Reservationrelease,
            
            /// <summary>
            /// Enum Reservationtermination for "reservation_termination"
            /// </summary>
            [EnumMember(Value = "reservation_termination")]
            Reservationtermination,
            
            /// <summary>
            /// Enum Packagecreation for "package_creation"
            /// </summary>
            [EnumMember(Value = "package_creation")]
            Packagecreation,
            
            /// <summary>
            /// Enum Packagerenewal for "package_renewal"
            /// </summary>
            [EnumMember(Value = "package_renewal")]
            Packagerenewal,
            
            /// <summary>
            /// Enum Packagetermination for "package_termination"
            /// </summary>
            [EnumMember(Value = "package_termination")]
            Packagetermination
        }

        /// <summary>
        /// Type of quota usage entry.
        /// </summary>
        /// <value>Type of quota usage entry.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePackageQuotaHistoryItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServicePackageQuotaHistoryItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePackageQuotaHistoryItem" /> class.
        /// </summary>
        /// <param name="Added">Added time of quota history entry in RFC3339 date-time with millisecond accuracy and UTC time zone. (required).</param>
        /// <param name="Amount">the amount of quota usage, negative or positive (required).</param>
        /// <param name="Id">Service package quota history ID. (required).</param>
        /// <param name="Reason">Type of quota usage entry. (required).</param>
        /// <param name="Reservation">Reservation details if reason is reservation, reservation_release or reservation_termination..</param>
        /// <param name="ServicePackage">Service package details if reason is package_creation, package_renewal or package_termination.</param>
        public ServicePackageQuotaHistoryItem(DateTime? Added = default(DateTime?), long? Amount = default(long?), string Id = default(string), ReasonEnum? Reason = default(ReasonEnum?), ServicePackageQuotaHistoryReservation Reservation = default(ServicePackageQuotaHistoryReservation), ServicePackageQuotaHistoryServicePackage ServicePackage = default(ServicePackageQuotaHistoryServicePackage))
        {
            // to ensure "Added" is required (not null)
            if (Added == null)
            {
                throw new InvalidDataException("Added is a required property for ServicePackageQuotaHistoryItem and cannot be null");
            }
            else
            {
                this.Added = Added;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for ServicePackageQuotaHistoryItem and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ServicePackageQuotaHistoryItem and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for ServicePackageQuotaHistoryItem and cannot be null");
            }
            else
            {
                this.Reason = Reason;
            }
            this.Reservation = Reservation;
            this.ServicePackage = ServicePackage;
        }
        
        /// <summary>
        /// Added time of quota history entry in RFC3339 date-time with millisecond accuracy and UTC time zone.
        /// </summary>
        /// <value>Added time of quota history entry in RFC3339 date-time with millisecond accuracy and UTC time zone.</value>
        [DataMember(Name="added", EmitDefaultValue=false)]
        public DateTime? Added { get; set; }

        /// <summary>
        /// the amount of quota usage, negative or positive
        /// </summary>
        /// <value>the amount of quota usage, negative or positive</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// Service package quota history ID.
        /// </summary>
        /// <value>Service package quota history ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Reservation details if reason is reservation, reservation_release or reservation_termination.
        /// </summary>
        /// <value>Reservation details if reason is reservation, reservation_release or reservation_termination.</value>
        [DataMember(Name="reservation", EmitDefaultValue=false)]
        public ServicePackageQuotaHistoryReservation Reservation { get; set; }

        /// <summary>
        /// Service package details if reason is package_creation, package_renewal or package_termination
        /// </summary>
        /// <value>Service package details if reason is package_creation, package_renewal or package_termination</value>
        [DataMember(Name="service_package", EmitDefaultValue=false)]
        public ServicePackageQuotaHistoryServicePackage ServicePackage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePackageQuotaHistoryItem {\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Reservation: ").Append(Reservation).Append("\n");
            sb.Append("  ServicePackage: ").Append(ServicePackage).Append("\n");
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
            return this.Equals(input as ServicePackageQuotaHistoryItem);
        }

        /// <summary>
        /// Returns true if ServicePackageQuotaHistoryItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ServicePackageQuotaHistoryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicePackageQuotaHistoryItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Added == input.Added ||
                    (this.Added != null &&
                    this.Added.Equals(input.Added))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Reservation == input.Reservation ||
                    (this.Reservation != null &&
                    this.Reservation.Equals(input.Reservation))
                ) && 
                (
                    this.ServicePackage == input.ServicePackage ||
                    (this.ServicePackage != null &&
                    this.ServicePackage.Equals(input.ServicePackage))
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
                if (this.Added != null)
                    hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Reservation != null)
                    hashCode = hashCode * 59 + this.Reservation.GetHashCode();
                if (this.ServicePackage != null)
                    hashCode = hashCode * 59 + this.ServicePackage.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 32.", new [] { "Id" });
            }

            // Id (string) minLength
            if(this.Id != null && this.Id.Length < 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 32.", new [] { "Id" });
            }

            yield break;
        }
    }

}
