/* 
 * <auto-generated>
 * Update Service API
 *
 * This is the API documentation for the Mbed deployment service, which is part of the update service.
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
    /// CampaignDeviceMetadataPage
    /// </summary>
    [DataContract]
    public partial class CampaignDeviceMetadataPage :  IEquatable<CampaignDeviceMetadataPage>, IValidatableObject
    {
        /// <summary>
        /// The order of the records to return. Acceptable values: ASC, DESC. Default: ASC
        /// </summary>
        /// <value>The order of the records to return. Acceptable values: ASC, DESC. Default: ASC</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            
            /// <summary>
            /// Enum ASC for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            ASC,
            
            /// <summary>
            /// Enum DESC for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            DESC
        }

        /// <summary>
        /// The order of the records to return. Acceptable values: ASC, DESC. Default: ASC
        /// </summary>
        /// <value>The order of the records to return. Acceptable values: ASC, DESC. Default: ASC</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDeviceMetadataPage" /> class.
        /// </summary>
        /// <param name="After">The entity ID to fetch after the given one.</param>
        /// <param name="HasMore">Flag indicating whether there are more results.</param>
        /// <param name="TotalCount">The total number or records, if requested. It might be returned also for small lists..</param>
        /// <param name="_Object">Entity name: always &#39;list&#39;.</param>
        /// <param name="Limit">The number of results to return, (range: 2-1000), or equals to total_count.</param>
        /// <param name="Data">A list of entities.</param>
        /// <param name="Order">The order of the records to return. Acceptable values: ASC, DESC. Default: ASC.</param>
        public CampaignDeviceMetadataPage(string After = default(string), bool? HasMore = default(bool?), int? TotalCount = default(int?), string _Object = default(string), int? Limit = default(int?), List<CampaignDeviceMetadata> Data = default(List<CampaignDeviceMetadata>), OrderEnum? Order = default(OrderEnum?))
        {
            this.After = After;
            this.HasMore = HasMore;
            this.TotalCount = TotalCount;
            this._Object = _Object;
            this.Limit = Limit;
            this.Data = Data;
            this.Order = Order;
        }
        
        /// <summary>
        /// The entity ID to fetch after the given one
        /// </summary>
        /// <value>The entity ID to fetch after the given one</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }

        /// <summary>
        /// Flag indicating whether there are more results
        /// </summary>
        /// <value>Flag indicating whether there are more results</value>
        [DataMember(Name="has_more", EmitDefaultValue=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// The total number or records, if requested. It might be returned also for small lists.
        /// </summary>
        /// <value>The total number or records, if requested. It might be returned also for small lists.</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Entity name: always &#39;list&#39;
        /// </summary>
        /// <value>Entity name: always &#39;list&#39;</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }

        /// <summary>
        /// The number of results to return, (range: 2-1000), or equals to total_count
        /// </summary>
        /// <value>The number of results to return, (range: 2-1000), or equals to total_count</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// A list of entities
        /// </summary>
        /// <value>A list of entities</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<CampaignDeviceMetadata> Data { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignDeviceMetadataPage {\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CampaignDeviceMetadataPage);
        }

        /// <summary>
        /// Returns true if CampaignDeviceMetadataPage instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignDeviceMetadataPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignDeviceMetadataPage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.After == input.After ||
                    (this.After != null &&
                    this.After.Equals(input.After))
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    (this.HasMore != null &&
                    this.HasMore.Equals(input.HasMore))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.After != null)
                    hashCode = hashCode * 59 + this.After.GetHashCode();
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
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
