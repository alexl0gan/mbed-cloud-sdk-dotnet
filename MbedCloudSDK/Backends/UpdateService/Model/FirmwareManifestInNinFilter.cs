/* 
 * <auto-generated>
 * Update Service API
 *
 * This is the API documentation for the Device Management deployment service, which is part of the Update service.
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
using SwaggerDateConverter = update_service.Client.SwaggerDateConverter;

namespace update_service.Model
{
    /// <summary>
    /// FirmwareManifestInNinFilter
    /// </summary>
    [DataContract]
    public partial class FirmwareManifestInNinFilter :  IEquatable<FirmwareManifestInNinFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareManifestInNinFilter" /> class.
        /// </summary>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Datafile">Datafile.</param>
        /// <param name="DatafileSize">DatafileSize.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DeviceClass">DeviceClass.</param>
        /// <param name="Etag">Etag.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public FirmwareManifestInNinFilter(DateTime? CreatedAt = default(DateTime?), string Datafile = default(string), int? DatafileSize = default(int?), string Description = default(string), string DeviceClass = default(string), DateTime? Etag = default(DateTime?), string Id = default(string), string Name = default(string), DateTime? Timestamp = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
        {
            this.CreatedAt = CreatedAt;
            this.Datafile = Datafile;
            this.DatafileSize = DatafileSize;
            this.Description = Description;
            this.DeviceClass = DeviceClass;
            this.Etag = Etag;
            this.Id = Id;
            this.Name = Name;
            this.Timestamp = Timestamp;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Datafile
        /// </summary>
        [DataMember(Name="datafile", EmitDefaultValue=false)]
        public string Datafile { get; set; }

        /// <summary>
        /// Gets or Sets DatafileSize
        /// </summary>
        [DataMember(Name="datafile_size", EmitDefaultValue=false)]
        public int? DatafileSize { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DeviceClass
        /// </summary>
        [DataMember(Name="device_class", EmitDefaultValue=false)]
        public string DeviceClass { get; set; }

        /// <summary>
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public DateTime? Etag { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

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
            sb.Append("class FirmwareManifestInNinFilter {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Datafile: ").Append(Datafile).Append("\n");
            sb.Append("  DatafileSize: ").Append(DatafileSize).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeviceClass: ").Append(DeviceClass).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as FirmwareManifestInNinFilter);
        }

        /// <summary>
        /// Returns true if FirmwareManifestInNinFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of FirmwareManifestInNinFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareManifestInNinFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Datafile == input.Datafile ||
                    (this.Datafile != null &&
                    this.Datafile.Equals(input.Datafile))
                ) && 
                (
                    this.DatafileSize == input.DatafileSize ||
                    (this.DatafileSize != null &&
                    this.DatafileSize.Equals(input.DatafileSize))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DeviceClass == input.DeviceClass ||
                    (this.DeviceClass != null &&
                    this.DeviceClass.Equals(input.DeviceClass))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Datafile != null)
                    hashCode = hashCode * 59 + this.Datafile.GetHashCode();
                if (this.DatafileSize != null)
                    hashCode = hashCode * 59 + this.DatafileSize.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DeviceClass != null)
                    hashCode = hashCode * 59 + this.DeviceClass.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
