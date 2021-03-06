/* 
 * <auto-generated>
 * Update Service API
 *
 * This is the API documentation for the Device Management deployment service, which is part of the Update service.
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
    /// CampaignMetrics
    /// </summary>
    [DataContract]
    public partial class CampaignMetrics :  IEquatable<CampaignMetrics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignMetrics" /> class.
        /// </summary>
        /// <param name="CreatedAt">The time the metrics were created..</param>
        /// <param name="FailedCount">Running total of devices that could not be updated..</param>
        /// <param name="_Object">Entity name: always &#39;update-campaign-metrics&#39;.</param>
        /// <param name="PendingCount">Running total of devices that have yet to receive an update or are applying an update..</param>
        /// <param name="SuccessCount">Running total of successfully updated devices..</param>
        /// <param name="TotalCount">Number of devices in the campaign..</param>
        public CampaignMetrics(DateTime? CreatedAt = default(DateTime?), int? FailedCount = default(int?), string _Object = default(string), int? PendingCount = default(int?), int? SuccessCount = default(int?), int? TotalCount = default(int?))
        {
            this.CreatedAt = CreatedAt;
            this.FailedCount = FailedCount;
            this._Object = _Object;
            this.PendingCount = PendingCount;
            this.SuccessCount = SuccessCount;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// The time the metrics were created.
        /// </summary>
        /// <value>The time the metrics were created.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Running total of devices that could not be updated.
        /// </summary>
        /// <value>Running total of devices that could not be updated.</value>
        [DataMember(Name="failed_count", EmitDefaultValue=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// Entity name: always &#39;update-campaign-metrics&#39;
        /// </summary>
        /// <value>Entity name: always &#39;update-campaign-metrics&#39;</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }

        /// <summary>
        /// Running total of devices that have yet to receive an update or are applying an update.
        /// </summary>
        /// <value>Running total of devices that have yet to receive an update or are applying an update.</value>
        [DataMember(Name="pending_count", EmitDefaultValue=false)]
        public int? PendingCount { get; set; }

        /// <summary>
        /// Running total of successfully updated devices.
        /// </summary>
        /// <value>Running total of successfully updated devices.</value>
        [DataMember(Name="success_count", EmitDefaultValue=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// Number of devices in the campaign.
        /// </summary>
        /// <value>Number of devices in the campaign.</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignMetrics {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  FailedCount: ").Append(FailedCount).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  PendingCount: ").Append(PendingCount).Append("\n");
            sb.Append("  SuccessCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as CampaignMetrics);
        }

        /// <summary>
        /// Returns true if CampaignMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignMetrics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.FailedCount == input.FailedCount ||
                    (this.FailedCount != null &&
                    this.FailedCount.Equals(input.FailedCount))
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.PendingCount == input.PendingCount ||
                    (this.PendingCount != null &&
                    this.PendingCount.Equals(input.PendingCount))
                ) && 
                (
                    this.SuccessCount == input.SuccessCount ||
                    (this.SuccessCount != null &&
                    this.SuccessCount.Equals(input.SuccessCount))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.FailedCount != null)
                    hashCode = hashCode * 59 + this.FailedCount.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.PendingCount != null)
                    hashCode = hashCode * 59 + this.PendingCount.GetHashCode();
                if (this.SuccessCount != null)
                    hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
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
