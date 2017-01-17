/* 
 * Firmware Catalog API
 *
 * This is the API Documentation for the mbed firmware catalog service which is part of the update service.
 *
 * OpenAPI spec version: 0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace firmware_catalog.Model
{
    /// <summary>
    /// FirmwareManifestSerializerData
    /// </summary>
    [DataContract]
    public partial class FirmwareManifestSerializerData :  IEquatable<FirmwareManifestSerializerData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareManifestSerializerData" /> class.
        /// </summary>
        /// <param name="Datafile">Datafile.</param>
        /// <param name="ManifestId">DEPRECATED: The ID of the firmware manifest.</param>
        /// <param name="Description">The description of the object.</param>
        /// <param name="Timestamp">The version of the firmware manifest (as a timestamp).</param>
        /// <param name="CreatedAt">The time the object was created.</param>
        /// <param name="_Object">The API resource entity.</param>
        /// <param name="UpdatedAt">The time the object was updated.</param>
        /// <param name="ManifestContents">The contents of the manifest.</param>
        /// <param name="Etag">The entity instance signature.</param>
        /// <param name="DeviceClass">The class of device.</param>
        /// <param name="Id">The ID of the firmware manifest.</param>
        /// <param name="Name">The name of the object.</param>
        public FirmwareManifestSerializerData(string Datafile = default(string), string ManifestId = default(string), string Description = default(string), DateTime? Timestamp = default(DateTime?), DateTime? CreatedAt = default(DateTime?), string _Object = default(string), DateTime? UpdatedAt = default(DateTime?), Object ManifestContents = default(Object), DateTime? Etag = default(DateTime?), string DeviceClass = default(string), string Id = default(string), string Name = default(string))
        {
            this.Datafile = Datafile;
            this.ManifestId = ManifestId;
            this.Description = Description;
            this.Timestamp = Timestamp;
            this.CreatedAt = CreatedAt;
            this._Object = _Object;
            this.UpdatedAt = UpdatedAt;
            this.ManifestContents = ManifestContents;
            this.Etag = Etag;
            this.DeviceClass = DeviceClass;
            this.Id = Id;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets Datafile
        /// </summary>
        [DataMember(Name="datafile", EmitDefaultValue=false)]
        public string Datafile { get; set; }
        /// <summary>
        /// DEPRECATED: The ID of the firmware manifest
        /// </summary>
        /// <value>DEPRECATED: The ID of the firmware manifest</value>
        [DataMember(Name="manifest_id", EmitDefaultValue=false)]
        public string ManifestId { get; set; }
        /// <summary>
        /// The description of the object
        /// </summary>
        /// <value>The description of the object</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The version of the firmware manifest (as a timestamp)
        /// </summary>
        /// <value>The version of the firmware manifest (as a timestamp)</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// The time the object was created
        /// </summary>
        /// <value>The time the object was created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// The API resource entity
        /// </summary>
        /// <value>The API resource entity</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
        /// <summary>
        /// The time the object was updated
        /// </summary>
        /// <value>The time the object was updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// The contents of the manifest
        /// </summary>
        /// <value>The contents of the manifest</value>
        [DataMember(Name="manifest_contents", EmitDefaultValue=false)]
        public Object ManifestContents { get; set; }
        /// <summary>
        /// The entity instance signature
        /// </summary>
        /// <value>The entity instance signature</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public DateTime? Etag { get; set; }
        /// <summary>
        /// The class of device
        /// </summary>
        /// <value>The class of device</value>
        [DataMember(Name="device_class", EmitDefaultValue=false)]
        public string DeviceClass { get; set; }
        /// <summary>
        /// The ID of the firmware manifest
        /// </summary>
        /// <value>The ID of the firmware manifest</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The name of the object
        /// </summary>
        /// <value>The name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirmwareManifestSerializerData {\n");
            sb.Append("  Datafile: ").Append(Datafile).Append("\n");
            sb.Append("  ManifestId: ").Append(ManifestId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ManifestContents: ").Append(ManifestContents).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  DeviceClass: ").Append(DeviceClass).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as FirmwareManifestSerializerData);
        }

        /// <summary>
        /// Returns true if FirmwareManifestSerializerData instances are equal
        /// </summary>
        /// <param name="other">Instance of FirmwareManifestSerializerData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareManifestSerializerData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Datafile == other.Datafile ||
                    this.Datafile != null &&
                    this.Datafile.Equals(other.Datafile)
                ) && 
                (
                    this.ManifestId == other.ManifestId ||
                    this.ManifestId != null &&
                    this.ManifestId.Equals(other.ManifestId)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.ManifestContents == other.ManifestContents ||
                    this.ManifestContents != null &&
                    this.ManifestContents.Equals(other.ManifestContents)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.DeviceClass == other.DeviceClass ||
                    this.DeviceClass != null &&
                    this.DeviceClass.Equals(other.DeviceClass)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Datafile != null)
                    hash = hash * 59 + this.Datafile.GetHashCode();
                if (this.ManifestId != null)
                    hash = hash * 59 + this.ManifestId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.ManifestContents != null)
                    hash = hash * 59 + this.ManifestContents.GetHashCode();
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                if (this.DeviceClass != null)
                    hash = hash * 59 + this.DeviceClass.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}