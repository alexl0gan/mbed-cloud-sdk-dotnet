/* 
 * <auto-generated>
 * Account Management API
 *
 * API for managing accounts, users, creating API keys, uploading trusted certificates
 *
 * OpenAPI spec version: v3
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
using SwaggerDateConverter = iam.Client.SwaggerDateConverter;

namespace iam.Model
{
    /// <summary>
    /// GroupSummaryList
    /// </summary>
    [DataContract]
    public partial class GroupSummaryList :  IEquatable<GroupSummaryList>, IValidatableObject
    {
        /// <summary>
        /// Entity name: always &#39;list&#39;
        /// </summary>
        /// <value>Entity name: always &#39;list&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum ApiKey for "api-key"
            /// </summary>
            [EnumMember(Value = "api-key")]
            ApiKey,
            
            /// <summary>
            /// Enum Group for "group"
            /// </summary>
            [EnumMember(Value = "group")]
            Group,
            
            /// <summary>
            /// Enum Account for "account"
            /// </summary>
            [EnumMember(Value = "account")]
            Account,
            
            /// <summary>
            /// Enum AccountTemplate for "account-template"
            /// </summary>
            [EnumMember(Value = "account-template")]
            AccountTemplate,
            
            /// <summary>
            /// Enum TrustedCert for "trusted-cert"
            /// </summary>
            [EnumMember(Value = "trusted-cert")]
            TrustedCert,
            
            /// <summary>
            /// Enum List for "list"
            /// </summary>
            [EnumMember(Value = "list")]
            List,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error
        }

        /// <summary>
        /// The order of the records to return based on creation time. Available values: ASC, DESC; by default ASC.
        /// </summary>
        /// <value>The order of the records to return based on creation time. Available values: ASC, DESC; by default ASC.</value>
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
        /// Entity name: always &#39;list&#39;
        /// </summary>
        /// <value>Entity name: always &#39;list&#39;</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// The order of the records to return based on creation time. Available values: ASC, DESC; by default ASC.
        /// </summary>
        /// <value>The order of the records to return based on creation time. Available values: ASC, DESC; by default ASC.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSummaryList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupSummaryList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSummaryList" /> class.
        /// </summary>
        /// <param name="After">The entity ID to fetch after the given one..</param>
        /// <param name="HasMore">Flag indicating whether there is more results. (required).</param>
        /// <param name="TotalCount">The total number or records, if requested. It might be returned also for small lists. (required).</param>
        /// <param name="_Object">Entity name: always &#39;list&#39; (required).</param>
        /// <param name="Limit">The number of results to return, (range: 2-1000), or equals to &#x60;total_count&#x60; (required).</param>
        /// <param name="Data">A list of entities. (required).</param>
        /// <param name="Order">The order of the records to return based on creation time. Available values: ASC, DESC; by default ASC..</param>
        public GroupSummaryList(string After = default(string), bool? HasMore = default(bool?), int? TotalCount = default(int?), ObjectEnum? _Object = default(ObjectEnum?), int? Limit = default(int?), List<GroupSummary> Data = default(List<GroupSummary>), OrderEnum? Order = default(OrderEnum?))
        {
            // to ensure "HasMore" is required (not null)
            if (HasMore == null)
            {
                throw new InvalidDataException("HasMore is a required property for GroupSummaryList and cannot be null");
            }
            else
            {
                this.HasMore = HasMore;
            }
            // to ensure "TotalCount" is required (not null)
            if (TotalCount == null)
            {
                throw new InvalidDataException("TotalCount is a required property for GroupSummaryList and cannot be null");
            }
            else
            {
                this.TotalCount = TotalCount;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for GroupSummaryList and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "Limit" is required (not null)
            if (Limit == null)
            {
                throw new InvalidDataException("Limit is a required property for GroupSummaryList and cannot be null");
            }
            else
            {
                this.Limit = Limit;
            }
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for GroupSummaryList and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            this.After = After;
            this.Order = Order;
        }
        
        /// <summary>
        /// The entity ID to fetch after the given one.
        /// </summary>
        /// <value>The entity ID to fetch after the given one.</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }

        /// <summary>
        /// Flag indicating whether there is more results.
        /// </summary>
        /// <value>Flag indicating whether there is more results.</value>
        [DataMember(Name="has_more", EmitDefaultValue=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// The total number or records, if requested. It might be returned also for small lists.
        /// </summary>
        /// <value>The total number or records, if requested. It might be returned also for small lists.</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }


        /// <summary>
        /// The number of results to return, (range: 2-1000), or equals to &#x60;total_count&#x60;
        /// </summary>
        /// <value>The number of results to return, (range: 2-1000), or equals to &#x60;total_count&#x60;</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// A list of entities.
        /// </summary>
        /// <value>A list of entities.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<GroupSummary> Data { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupSummaryList {\n");
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
            return this.Equals(input as GroupSummaryList);
        }

        /// <summary>
        /// Returns true if GroupSummaryList instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupSummaryList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSummaryList input)
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
