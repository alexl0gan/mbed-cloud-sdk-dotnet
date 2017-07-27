/* 
 * Update Service API
 *
 * This is the API Documentation for the mbed deployment service which is part of the update service.
 *
 * OpenAPI spec version: 3
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

namespace update_service.Model
{
    /// <summary>
    /// ManifestContentsPayloadInfoEncryptionInfo
    /// </summary>
    [DataContract]
    public partial class ManifestContentsPayloadInfoEncryptionInfo :  IEquatable<ManifestContentsPayloadInfoEncryptionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestContentsPayloadInfoEncryptionInfo" /> class.
        /// </summary>
        /// <param name="EncryptedPayloadHash">EncryptedPayloadHash.</param>
        /// <param name="Config">Config.</param>
        /// <param name="Mode">Mode.</param>
        public ManifestContentsPayloadInfoEncryptionInfo(string EncryptedPayloadHash = default(string), string Config = default(string), string Mode = default(string))
        {
            this.EncryptedPayloadHash = EncryptedPayloadHash;
            this.Config = Config;
            this.Mode = Mode;
        }
        
        /// <summary>
        /// Gets or Sets EncryptedPayloadHash
        /// </summary>
        [DataMember(Name="encryptedPayloadHash", EmitDefaultValue=false)]
        public string EncryptedPayloadHash { get; set; }
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public string Config { get; set; }
        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManifestContentsPayloadInfoEncryptionInfo {\n");
            sb.Append("  EncryptedPayloadHash: ").Append(EncryptedPayloadHash).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
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
            return this.Equals(obj as ManifestContentsPayloadInfoEncryptionInfo);
        }

        /// <summary>
        /// Returns true if ManifestContentsPayloadInfoEncryptionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ManifestContentsPayloadInfoEncryptionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManifestContentsPayloadInfoEncryptionInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EncryptedPayloadHash == other.EncryptedPayloadHash ||
                    this.EncryptedPayloadHash != null &&
                    this.EncryptedPayloadHash.Equals(other.EncryptedPayloadHash)
                ) && 
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
                ) && 
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
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
                if (this.EncryptedPayloadHash != null)
                    hash = hash * 59 + this.EncryptedPayloadHash.GetHashCode();
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}