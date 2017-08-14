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
    /// MetricHostCounter
    /// </summary>
    [DataContract]
    public partial class MetricHostCounter :  IEquatable<MetricHostCounter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricHostCounter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetricHostCounter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricHostCounter" /> class.
        /// </summary>
        /// <param name="Count">Count (required).</param>
        /// <param name="Host">Host (required).</param>
        public MetricHostCounter(long? Count = default(long?), string Host = default(string))
        {
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for MetricHostCounter and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "Host" is required (not null)
            if (Host == null)
            {
                throw new InvalidDataException("Host is a required property for MetricHostCounter and cannot be null");
            }
            else
            {
                this.Host = Host;
            }
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }
        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricHostCounter {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
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
            return this.Equals(obj as MetricHostCounter);
        }

        /// <summary>
        /// Returns true if MetricHostCounter instances are equal
        /// </summary>
        /// <param name="other">Instance of MetricHostCounter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricHostCounter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Host == other.Host ||
                    this.Host != null &&
                    this.Host.Equals(other.Host)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Host != null)
                    hash = hash * 59 + this.Host.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}