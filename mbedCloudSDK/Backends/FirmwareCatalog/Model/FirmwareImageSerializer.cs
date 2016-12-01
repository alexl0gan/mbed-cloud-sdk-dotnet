using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace firmware_catalog.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class FirmwareImageSerializer :  IEquatable<FirmwareImageSerializer>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareImageSerializer" /> class.
        /// Initializes a new instance of the <see cref="FirmwareImageSerializer" />class.
        /// </summary>
        /// <param name="_Object">API Resource name.</param>
        /// <param name="HasMore">Whether there are more results to display.</param>
        /// <param name="TotalCount">Total number of records.</param>
        /// <param name="After">Entity id for fetch after it.</param>
        /// <param name="Limit">The number of results to return.</param>
        /// <param name="Data">Data.</param>
        /// <param name="Order">Order of returned records.</param>

        public FirmwareImageSerializer(string _Object = null, bool? HasMore = null, int? TotalCount = null, string After = null, int? Limit = null, List<FirmwareImageSerializerData> Data = null, string Order = null)
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
        /// API Resource name
        /// </summary>
        /// <value>API Resource name</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
    
        /// <summary>
        /// Whether there are more results to display
        /// </summary>
        /// <value>Whether there are more results to display</value>
        [DataMember(Name="has_more", EmitDefaultValue=false)]
        public bool? HasMore { get; set; }
    
        /// <summary>
        /// Total number of records
        /// </summary>
        /// <value>Total number of records</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }
    
        /// <summary>
        /// Entity id for fetch after it
        /// </summary>
        /// <value>Entity id for fetch after it</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }
    
        /// <summary>
        /// The number of results to return
        /// </summary>
        /// <value>The number of results to return</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<FirmwareImageSerializerData> Data { get; set; }
    
        /// <summary>
        /// Order of returned records
        /// </summary>
        /// <value>Order of returned records</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirmwareImageSerializer {\n");
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
            return this.Equals(obj as FirmwareImageSerializer);
        }

        /// <summary>
        /// Returns true if FirmwareImageSerializer instances are equal
        /// </summary>
        /// <param name="other">Instance of FirmwareImageSerializer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareImageSerializer other)
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

    }
}
