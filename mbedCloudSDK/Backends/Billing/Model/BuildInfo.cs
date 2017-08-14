/* 
 * mbed-billing REST API documentation for API-server
 *
 * This document contains the public REST API definitions of the mbed-billing service's API server component.
 *
 * OpenAPI spec version: 1.3.7-SNAPSHOT
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

namespace billing.Model
{
    /// <summary>
    /// BuildInfo
    /// </summary>
    [DataContract]
    public partial class BuildInfo :  IEquatable<BuildInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildInfo" /> class.
        /// </summary>
        /// <param name="BuildTimestamp">BuildTimestamp.</param>
        /// <param name="BuiltBy">BuiltBy.</param>
        /// <param name="BuildNumber">BuildNumber.</param>
        /// <param name="BuildTag">BuildTag.</param>
        /// <param name="BuildVersion">BuildVersion.</param>
        public BuildInfo(DateTime? BuildTimestamp = default(DateTime?), string BuiltBy = default(string), string BuildNumber = default(string), string BuildTag = default(string), string BuildVersion = default(string))
        {
            this.BuildTimestamp = BuildTimestamp;
            this.BuiltBy = BuiltBy;
            this.BuildNumber = BuildNumber;
            this.BuildTag = BuildTag;
            this.BuildVersion = BuildVersion;
        }
        
        /// <summary>
        /// Gets or Sets BuildTimestamp
        /// </summary>
        [DataMember(Name="build-timestamp", EmitDefaultValue=false)]
        public DateTime? BuildTimestamp { get; set; }
        /// <summary>
        /// Gets or Sets BuiltBy
        /// </summary>
        [DataMember(Name="built-by", EmitDefaultValue=false)]
        public string BuiltBy { get; set; }
        /// <summary>
        /// Gets or Sets BuildNumber
        /// </summary>
        [DataMember(Name="build-number", EmitDefaultValue=false)]
        public string BuildNumber { get; set; }
        /// <summary>
        /// Gets or Sets BuildTag
        /// </summary>
        [DataMember(Name="build-tag", EmitDefaultValue=false)]
        public string BuildTag { get; set; }
        /// <summary>
        /// Gets or Sets BuildVersion
        /// </summary>
        [DataMember(Name="build-version", EmitDefaultValue=false)]
        public string BuildVersion { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildInfo {\n");
            sb.Append("  BuildTimestamp: ").Append(BuildTimestamp).Append("\n");
            sb.Append("  BuiltBy: ").Append(BuiltBy).Append("\n");
            sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("  BuildTag: ").Append(BuildTag).Append("\n");
            sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
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
            return this.Equals(obj as BuildInfo);
        }

        /// <summary>
        /// Returns true if BuildInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of BuildInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BuildTimestamp == other.BuildTimestamp ||
                    this.BuildTimestamp != null &&
                    this.BuildTimestamp.Equals(other.BuildTimestamp)
                ) && 
                (
                    this.BuiltBy == other.BuiltBy ||
                    this.BuiltBy != null &&
                    this.BuiltBy.Equals(other.BuiltBy)
                ) && 
                (
                    this.BuildNumber == other.BuildNumber ||
                    this.BuildNumber != null &&
                    this.BuildNumber.Equals(other.BuildNumber)
                ) && 
                (
                    this.BuildTag == other.BuildTag ||
                    this.BuildTag != null &&
                    this.BuildTag.Equals(other.BuildTag)
                ) && 
                (
                    this.BuildVersion == other.BuildVersion ||
                    this.BuildVersion != null &&
                    this.BuildVersion.Equals(other.BuildVersion)
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
                if (this.BuildTimestamp != null)
                    hash = hash * 59 + this.BuildTimestamp.GetHashCode();
                if (this.BuiltBy != null)
                    hash = hash * 59 + this.BuiltBy.GetHashCode();
                if (this.BuildNumber != null)
                    hash = hash * 59 + this.BuildNumber.GetHashCode();
                if (this.BuildTag != null)
                    hash = hash * 59 + this.BuildTag.GetHashCode();
                if (this.BuildVersion != null)
                    hash = hash * 59 + this.BuildVersion.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}