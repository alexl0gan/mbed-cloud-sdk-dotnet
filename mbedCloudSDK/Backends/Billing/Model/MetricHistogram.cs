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
    /// A histogram measures the statistical distribution of values in a stream of data.
    /// </summary>
    [DataContract]
    public partial class MetricHistogram :  IEquatable<MetricHistogram>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricHistogram" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetricHistogram() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricHistogram" /> class.
        /// </summary>
        /// <param name="Count">Count (required).</param>
        /// <param name="P98">P98 (required).</param>
        /// <param name="P75">P75 (required).</param>
        /// <param name="P99">P99 (required).</param>
        /// <param name="Min">Min (required).</param>
        /// <param name="Max">Max (required).</param>
        /// <param name="Median">Median (required).</param>
        /// <param name="P95">P95 (required).</param>
        /// <param name="Stddev">Stddev (required).</param>
        /// <param name="P999">P999 (required).</param>
        /// <param name="Mean">Mean (required).</param>
        public MetricHistogram(double? Count = default(double?), double? P98 = default(double?), double? P75 = default(double?), double? P99 = default(double?), double? Min = default(double?), double? Max = default(double?), double? Median = default(double?), double? P95 = default(double?), double? Stddev = default(double?), double? P999 = default(double?), double? Mean = default(double?))
        {
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "P98" is required (not null)
            if (P98 == null)
            {
                throw new InvalidDataException("P98 is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.P98 = P98;
            }
            // to ensure "P75" is required (not null)
            if (P75 == null)
            {
                throw new InvalidDataException("P75 is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.P75 = P75;
            }
            // to ensure "P99" is required (not null)
            if (P99 == null)
            {
                throw new InvalidDataException("P99 is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.P99 = P99;
            }
            // to ensure "Min" is required (not null)
            if (Min == null)
            {
                throw new InvalidDataException("Min is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.Min = Min;
            }
            // to ensure "Max" is required (not null)
            if (Max == null)
            {
                throw new InvalidDataException("Max is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.Max = Max;
            }
            // to ensure "Median" is required (not null)
            if (Median == null)
            {
                throw new InvalidDataException("Median is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.Median = Median;
            }
            // to ensure "P95" is required (not null)
            if (P95 == null)
            {
                throw new InvalidDataException("P95 is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.P95 = P95;
            }
            // to ensure "Stddev" is required (not null)
            if (Stddev == null)
            {
                throw new InvalidDataException("Stddev is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.Stddev = Stddev;
            }
            // to ensure "P999" is required (not null)
            if (P999 == null)
            {
                throw new InvalidDataException("P999 is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.P999 = P999;
            }
            // to ensure "Mean" is required (not null)
            if (Mean == null)
            {
                throw new InvalidDataException("Mean is a required property for MetricHistogram and cannot be null");
            }
            else
            {
                this.Mean = Mean;
            }
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public double? Count { get; set; }
        /// <summary>
        /// Gets or Sets P98
        /// </summary>
        [DataMember(Name="p98", EmitDefaultValue=false)]
        public double? P98 { get; set; }
        /// <summary>
        /// Gets or Sets P75
        /// </summary>
        [DataMember(Name="p75", EmitDefaultValue=false)]
        public double? P75 { get; set; }
        /// <summary>
        /// Gets or Sets P99
        /// </summary>
        [DataMember(Name="p99", EmitDefaultValue=false)]
        public double? P99 { get; set; }
        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public double? Min { get; set; }
        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public double? Max { get; set; }
        /// <summary>
        /// Gets or Sets Median
        /// </summary>
        [DataMember(Name="median", EmitDefaultValue=false)]
        public double? Median { get; set; }
        /// <summary>
        /// Gets or Sets P95
        /// </summary>
        [DataMember(Name="p95", EmitDefaultValue=false)]
        public double? P95 { get; set; }
        /// <summary>
        /// Gets or Sets Stddev
        /// </summary>
        [DataMember(Name="stddev", EmitDefaultValue=false)]
        public double? Stddev { get; set; }
        /// <summary>
        /// Gets or Sets P999
        /// </summary>
        [DataMember(Name="p999", EmitDefaultValue=false)]
        public double? P999 { get; set; }
        /// <summary>
        /// Gets or Sets Mean
        /// </summary>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public double? Mean { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricHistogram {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  P98: ").Append(P98).Append("\n");
            sb.Append("  P75: ").Append(P75).Append("\n");
            sb.Append("  P99: ").Append(P99).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Median: ").Append(Median).Append("\n");
            sb.Append("  P95: ").Append(P95).Append("\n");
            sb.Append("  Stddev: ").Append(Stddev).Append("\n");
            sb.Append("  P999: ").Append(P999).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
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
            return this.Equals(obj as MetricHistogram);
        }

        /// <summary>
        /// Returns true if MetricHistogram instances are equal
        /// </summary>
        /// <param name="other">Instance of MetricHistogram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricHistogram other)
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
                    this.P98 == other.P98 ||
                    this.P98 != null &&
                    this.P98.Equals(other.P98)
                ) && 
                (
                    this.P75 == other.P75 ||
                    this.P75 != null &&
                    this.P75.Equals(other.P75)
                ) && 
                (
                    this.P99 == other.P99 ||
                    this.P99 != null &&
                    this.P99.Equals(other.P99)
                ) && 
                (
                    this.Min == other.Min ||
                    this.Min != null &&
                    this.Min.Equals(other.Min)
                ) && 
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
                ) && 
                (
                    this.Median == other.Median ||
                    this.Median != null &&
                    this.Median.Equals(other.Median)
                ) && 
                (
                    this.P95 == other.P95 ||
                    this.P95 != null &&
                    this.P95.Equals(other.P95)
                ) && 
                (
                    this.Stddev == other.Stddev ||
                    this.Stddev != null &&
                    this.Stddev.Equals(other.Stddev)
                ) && 
                (
                    this.P999 == other.P999 ||
                    this.P999 != null &&
                    this.P999.Equals(other.P999)
                ) && 
                (
                    this.Mean == other.Mean ||
                    this.Mean != null &&
                    this.Mean.Equals(other.Mean)
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
                if (this.P98 != null)
                    hash = hash * 59 + this.P98.GetHashCode();
                if (this.P75 != null)
                    hash = hash * 59 + this.P75.GetHashCode();
                if (this.P99 != null)
                    hash = hash * 59 + this.P99.GetHashCode();
                if (this.Min != null)
                    hash = hash * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();
                if (this.Median != null)
                    hash = hash * 59 + this.Median.GetHashCode();
                if (this.P95 != null)
                    hash = hash * 59 + this.P95.GetHashCode();
                if (this.Stddev != null)
                    hash = hash * 59 + this.Stddev.GetHashCode();
                if (this.P999 != null)
                    hash = hash * 59 + this.P999.GetHashCode();
                if (this.Mean != null)
                    hash = hash * 59 + this.Mean.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}