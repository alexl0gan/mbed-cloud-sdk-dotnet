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
    /// CampaignDeviceMetadataPage
    /// </summary>
    [DataContract]
    public partial class CampaignDeviceMetadataPage :  IEquatable<CampaignDeviceMetadataPage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignDeviceMetadataPage" /> class.
        /// </summary>
        /// <param name="After">The entity ID to fetch after the given one..</param>
        /// <param name="HasMore">Flag indicating whether there is more results..</param>
        /// <param name="TotalCount">The total number or records, if requested. It might be returned also for small lists..</param>
        /// <param name="_Object">Entity name: always ‘list’.</param>
        /// <param name="Limit">The number of results to return, (range: 2-1000), or equals to total_count.</param>
        /// <param name="Data">A list of entities.</param>
        public CampaignDeviceMetadataPage(string After = default(string), bool? HasMore = default(bool?), int? TotalCount = default(int?), string _Object = default(string), int? Limit = default(int?), List<CampaignDeviceMetadata> Data = default(List<CampaignDeviceMetadata>))
        {
            this.After = After;
            this.HasMore = HasMore;
            this.TotalCount = TotalCount;
            this._Object = _Object;
            this.Limit = Limit;
            this.Data = Data;
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
        /// Entity name: always ‘list’
        /// </summary>
        /// <value>Entity name: always ‘list’</value>
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
            return this.Equals(obj as CampaignDeviceMetadataPage);
        }

        /// <summary>
        /// Returns true if CampaignDeviceMetadataPage instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignDeviceMetadataPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignDeviceMetadataPage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.After == other.After ||
                    this.After != null &&
                    this.After.Equals(other.After)
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
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
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
                if (this.After != null)
                    hash = hash * 59 + this.After.GetHashCode();
                if (this.HasMore != null)
                    hash = hash * 59 + this.HasMore.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
