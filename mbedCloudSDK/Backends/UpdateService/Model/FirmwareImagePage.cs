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
    /// FirmwareImagePage
    /// </summary>
    [DataContract]
    public partial class FirmwareImagePage :  IEquatable<FirmwareImagePage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareImagePage" /> class.
        /// </summary>
        /// <param name="_Object">_Object.</param>
        /// <param name="HasMore">HasMore.</param>
        /// <param name="TotalCount">TotalCount.</param>
        /// <param name="After">After.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="Data">Data.</param>
        /// <param name="Order">Order.</param>
        public FirmwareImagePage(string _Object = default(string), bool? HasMore = default(bool?), int? TotalCount = default(int?), string After = default(string), int? Limit = default(int?), List<FirmwareImage> Data = default(List<FirmwareImage>), string Order = default(string))
        {
            this._Object = _Object;
            this.HasMore = HasMore;
            this.TotalCount = TotalCount;
            this.After = After;
            this.Limit = Limit;
            this.Data = Data;
            this.Order = Order;
        }
        
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name="has_more", EmitDefaultValue=false)]
        public bool? HasMore { get; set; }
        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }
        /// <summary>
        /// Gets or Sets After
        /// </summary>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<FirmwareImage> Data { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirmwareImagePage {\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as FirmwareImagePage);
        }

        /// <summary>
        /// Returns true if FirmwareImagePage instances are equal
        /// </summary>
        /// <param name="other">Instance of FirmwareImagePage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareImagePage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.HasMore == other.HasMore ||
                    this.HasMore != null &&
                    this.HasMore.Equals(other.HasMore)
                ) && 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                ) && 
                (
                    this.After == other.After ||
                    this.After != null &&
                    this.After.Equals(other.After)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.HasMore != null)
                    hash = hash * 59 + this.HasMore.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                if (this.After != null)
                    hash = hash * 59 + this.After.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
