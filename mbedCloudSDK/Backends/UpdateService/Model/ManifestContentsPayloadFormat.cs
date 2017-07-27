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
    /// ManifestContentsPayloadFormat
    /// </summary>
    [DataContract]
    public partial class ManifestContentsPayloadFormat :  IEquatable<ManifestContentsPayloadFormat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestContentsPayloadFormat" /> class.
        /// </summary>
        /// <param name="_Enum">Format of the payload. Can be: 1: raw-binary 2: cbor 3: hex-location-length-data 4: elf .</param>
        public ManifestContentsPayloadFormat(int? _Enum = default(int?))
        {
            this._Enum = _Enum;
        }
        
        /// <summary>
        /// Format of the payload. Can be: 1: raw-binary 2: cbor 3: hex-location-length-data 4: elf 
        /// </summary>
        /// <value>Format of the payload. Can be: 1: raw-binary 2: cbor 3: hex-location-length-data 4: elf </value>
        [DataMember(Name="enum", EmitDefaultValue=false)]
        public int? _Enum { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManifestContentsPayloadFormat {\n");
            sb.Append("  _Enum: ").Append(_Enum).Append("\n");
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
            return this.Equals(obj as ManifestContentsPayloadFormat);
        }

        /// <summary>
        /// Returns true if ManifestContentsPayloadFormat instances are equal
        /// </summary>
        /// <param name="other">Instance of ManifestContentsPayloadFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManifestContentsPayloadFormat other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Enum == other._Enum ||
                    this._Enum != null &&
                    this._Enum.Equals(other._Enum)
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
                if (this._Enum != null)
                    hash = hash * 59 + this._Enum.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
