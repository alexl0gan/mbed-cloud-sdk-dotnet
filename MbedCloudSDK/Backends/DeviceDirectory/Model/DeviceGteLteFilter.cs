/* 
 * <auto-generated>
 * Device Directory API
 *
 * This is the API Documentation for the Mbed Device Directory service.
 *
 * OpenAPI spec version: 3
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
using SwaggerDateConverter = device_directory.Client.SwaggerDateConverter;

namespace device_directory.Model
{
    /// <summary>
    /// DeviceGteLteFilter
    /// </summary>
    [DataContract]
    public partial class DeviceGteLteFilter :  IEquatable<DeviceGteLteFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGteLteFilter" /> class.
        /// </summary>
        /// <param name="BootstrapExpirationDate">BootstrapExpirationDate.</param>
        /// <param name="BootstrappedTimestamp">BootstrappedTimestamp.</param>
        /// <param name="ConnectorExpirationDate">ConnectorExpirationDate.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="EnrolmentListTimestamp">EnrolmentListTimestamp.</param>
        /// <param name="Etag">Etag.</param>
        /// <param name="ManifestTimestamp">ManifestTimestamp.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public DeviceGteLteFilter(DateTime? BootstrapExpirationDate = default(DateTime?), DateTime? BootstrappedTimestamp = default(DateTime?), DateTime? ConnectorExpirationDate = default(DateTime?), DateTime? CreatedAt = default(DateTime?), DateTime? EnrolmentListTimestamp = default(DateTime?), DateTime? Etag = default(DateTime?), DateTime? ManifestTimestamp = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
        {
            this.BootstrapExpirationDate = BootstrapExpirationDate;
            this.BootstrappedTimestamp = BootstrappedTimestamp;
            this.ConnectorExpirationDate = ConnectorExpirationDate;
            this.CreatedAt = CreatedAt;
            this.EnrolmentListTimestamp = EnrolmentListTimestamp;
            this.Etag = Etag;
            this.ManifestTimestamp = ManifestTimestamp;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets BootstrapExpirationDate
        /// </summary>
        [DataMember(Name="bootstrap_expiration_date", EmitDefaultValue=false)]
        public DateTime? BootstrapExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets BootstrappedTimestamp
        /// </summary>
        [DataMember(Name="bootstrapped_timestamp", EmitDefaultValue=false)]
        public DateTime? BootstrappedTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorExpirationDate
        /// </summary>
        [DataMember(Name="connector_expiration_date", EmitDefaultValue=false)]
        public DateTime? ConnectorExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets EnrolmentListTimestamp
        /// </summary>
        [DataMember(Name="enrolment_list_timestamp", EmitDefaultValue=false)]
        public DateTime? EnrolmentListTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public DateTime? Etag { get; set; }

        /// <summary>
        /// Gets or Sets ManifestTimestamp
        /// </summary>
        [DataMember(Name="manifest_timestamp", EmitDefaultValue=false)]
        public DateTime? ManifestTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceGteLteFilter {\n");
            sb.Append("  BootstrapExpirationDate: ").Append(BootstrapExpirationDate).Append("\n");
            sb.Append("  BootstrappedTimestamp: ").Append(BootstrappedTimestamp).Append("\n");
            sb.Append("  ConnectorExpirationDate: ").Append(ConnectorExpirationDate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EnrolmentListTimestamp: ").Append(EnrolmentListTimestamp).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  ManifestTimestamp: ").Append(ManifestTimestamp).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as DeviceGteLteFilter);
        }

        /// <summary>
        /// Returns true if DeviceGteLteFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceGteLteFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceGteLteFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BootstrapExpirationDate == input.BootstrapExpirationDate ||
                    (this.BootstrapExpirationDate != null &&
                    this.BootstrapExpirationDate.Equals(input.BootstrapExpirationDate))
                ) && 
                (
                    this.BootstrappedTimestamp == input.BootstrappedTimestamp ||
                    (this.BootstrappedTimestamp != null &&
                    this.BootstrappedTimestamp.Equals(input.BootstrappedTimestamp))
                ) && 
                (
                    this.ConnectorExpirationDate == input.ConnectorExpirationDate ||
                    (this.ConnectorExpirationDate != null &&
                    this.ConnectorExpirationDate.Equals(input.ConnectorExpirationDate))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.EnrolmentListTimestamp == input.EnrolmentListTimestamp ||
                    (this.EnrolmentListTimestamp != null &&
                    this.EnrolmentListTimestamp.Equals(input.EnrolmentListTimestamp))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.ManifestTimestamp == input.ManifestTimestamp ||
                    (this.ManifestTimestamp != null &&
                    this.ManifestTimestamp.Equals(input.ManifestTimestamp))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.BootstrapExpirationDate != null)
                    hashCode = hashCode * 59 + this.BootstrapExpirationDate.GetHashCode();
                if (this.BootstrappedTimestamp != null)
                    hashCode = hashCode * 59 + this.BootstrappedTimestamp.GetHashCode();
                if (this.ConnectorExpirationDate != null)
                    hashCode = hashCode * 59 + this.ConnectorExpirationDate.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.EnrolmentListTimestamp != null)
                    hashCode = hashCode * 59 + this.EnrolmentListTimestamp.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.ManifestTimestamp != null)
                    hashCode = hashCode * 59 + this.ManifestTimestamp.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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