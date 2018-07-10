/* 
 * <auto-generated>
 * Enrollment API
 *
 * Mbed Cloud Connect Enrollment Service allows users to claim the ownership of a device which is not yet assigned to an account. A device without an assigned account can be a device purchased from the open market (OEM dealer) or a device transferred from an account to another. More information in [Device ownership: First-to-claim](https://cloud.mbed.com/docs/current/connecting/device-ownership.html) document. 
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
using SwaggerDateConverter = enrollment.Client.SwaggerDateConverter;

namespace enrollment.Model
{
    /// <summary>
    /// BulkResponse
    /// </summary>
    [DataContract]
    public partial class BulkResponse :  IEquatable<BulkResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            
            /// <summary>
            /// Enum Uploads for "enrollment-identity-bulk-uploads"
            /// </summary>
            [EnumMember(Value = "enrollment-identity-bulk-uploads")]
            Uploads
        }

        /// <summary>
        /// The state of the process is &#39;new&#39; at the time of creation. If the creation is still in progress, the state is shown as &#39;processing&#39;. When the request has been fully processed, the state changes to &#39;completed&#39;. 
        /// </summary>
        /// <value>The state of the process is &#39;new&#39; at the time of creation. If the creation is still in progress, the state is shown as &#39;processing&#39;. When the request has been fully processed, the state changes to &#39;completed&#39;. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum New for "new"
            /// </summary>
            [EnumMember(Value = "new")]
            New,
            
            /// <summary>
            /// Enum Processing for "processing"
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing,
            
            /// <summary>
            /// Enum Completed for "completed"
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed
        }

        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// The state of the process is &#39;new&#39; at the time of creation. If the creation is still in progress, the state is shown as &#39;processing&#39;. When the request has been fully processed, the state changes to &#39;completed&#39;. 
        /// </summary>
        /// <value>The state of the process is &#39;new&#39; at the time of creation. If the creation is still in progress, the state is shown as &#39;processing&#39;. When the request has been fully processed, the state changes to &#39;completed&#39;. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResponse" /> class.
        /// </summary>
        /// <param name="AccountId">ID (required).</param>
        /// <param name="CompletedAt">The time of completing the bulk creation task. .</param>
        /// <param name="CreatedAt">The time of receiving the bulk creation task.  (required).</param>
        /// <param name="ErrorsCount">The number of enrollment identities with failed processing.  (required).</param>
        /// <param name="ErrorsReportFile">ErrorsReportFile.</param>
        /// <param name="Etag">etag (required).</param>
        /// <param name="FullReportFile">FullReportFile.</param>
        /// <param name="Id">Bulk ID (required).</param>
        /// <param name="_Object">_Object (required).</param>
        /// <param name="ProcessedCount">The number of enrollment identities processed until now.  (required).</param>
        /// <param name="Status">The state of the process is &#39;new&#39; at the time of creation. If the creation is still in progress, the state is shown as &#39;processing&#39;. When the request has been fully processed, the state changes to &#39;completed&#39;.  (required) (default to StatusEnum.New).</param>
        /// <param name="TotalCount">Total number of enrollment identities found in the input CSV.  (required).</param>
        public BulkResponse(string AccountId = default(string), DateTime? CompletedAt = default(DateTime?), DateTime? CreatedAt = default(DateTime?), int? ErrorsCount = default(int?), string ErrorsReportFile = default(string), string Etag = default(string), string FullReportFile = default(string), string Id = default(string), ObjectEnum? _Object = default(ObjectEnum?), int? ProcessedCount = default(int?), StatusEnum? Status = StatusEnum.New, int? TotalCount = default(int?))
        {
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for BulkResponse and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for BulkResponse and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "ErrorsCount" is required (not null)
            if (ErrorsCount == null)
            {
                throw new InvalidDataException("ErrorsCount is a required property for BulkResponse and cannot be null");
            }
            else
            {
                this.ErrorsCount = ErrorsCount;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for BulkResponse and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for BulkResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for BulkResponse and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "ProcessedCount" is required (not null)
            if (ProcessedCount == null)
            {
                throw new InvalidDataException("ProcessedCount is a required property for BulkResponse and cannot be null");
            }
            else
            {
                this.ProcessedCount = ProcessedCount;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for BulkResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "TotalCount" is required (not null)
            if (TotalCount == null)
            {
                throw new InvalidDataException("TotalCount is a required property for BulkResponse and cannot be null");
            }
            else
            {
                this.TotalCount = TotalCount;
            }
            this.CompletedAt = CompletedAt;
            this.ErrorsReportFile = ErrorsReportFile;
            this.FullReportFile = FullReportFile;
        }
        
        /// <summary>
        /// ID
        /// </summary>
        /// <value>ID</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The time of completing the bulk creation task. 
        /// </summary>
        /// <value>The time of completing the bulk creation task. </value>
        [DataMember(Name="completed_at", EmitDefaultValue=false)]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The time of receiving the bulk creation task. 
        /// </summary>
        /// <value>The time of receiving the bulk creation task. </value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The number of enrollment identities with failed processing. 
        /// </summary>
        /// <value>The number of enrollment identities with failed processing. </value>
        [DataMember(Name="errors_count", EmitDefaultValue=false)]
        public int? ErrorsCount { get; set; }

        /// <summary>
        /// Gets or Sets ErrorsReportFile
        /// </summary>
        [DataMember(Name="errors_report_file", EmitDefaultValue=false)]
        public string ErrorsReportFile { get; set; }

        /// <summary>
        /// etag
        /// </summary>
        /// <value>etag</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets FullReportFile
        /// </summary>
        [DataMember(Name="full_report_file", EmitDefaultValue=false)]
        public string FullReportFile { get; set; }

        /// <summary>
        /// Bulk ID
        /// </summary>
        /// <value>Bulk ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// The number of enrollment identities processed until now. 
        /// </summary>
        /// <value>The number of enrollment identities processed until now. </value>
        [DataMember(Name="processed_count", EmitDefaultValue=false)]
        public int? ProcessedCount { get; set; }


        /// <summary>
        /// Total number of enrollment identities found in the input CSV. 
        /// </summary>
        /// <value>Total number of enrollment identities found in the input CSV. </value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkResponse {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ErrorsCount: ").Append(ErrorsCount).Append("\n");
            sb.Append("  ErrorsReportFile: ").Append(ErrorsReportFile).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  FullReportFile: ").Append(FullReportFile).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  ProcessedCount: ").Append(ProcessedCount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as BulkResponse);
        }

        /// <summary>
        /// Returns true if BulkResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ErrorsCount == input.ErrorsCount ||
                    (this.ErrorsCount != null &&
                    this.ErrorsCount.Equals(input.ErrorsCount))
                ) && 
                (
                    this.ErrorsReportFile == input.ErrorsReportFile ||
                    (this.ErrorsReportFile != null &&
                    this.ErrorsReportFile.Equals(input.ErrorsReportFile))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.FullReportFile == input.FullReportFile ||
                    (this.FullReportFile != null &&
                    this.FullReportFile.Equals(input.FullReportFile))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.ProcessedCount == input.ProcessedCount ||
                    (this.ProcessedCount != null &&
                    this.ProcessedCount.Equals(input.ProcessedCount))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.CompletedAt != null)
                    hashCode = hashCode * 59 + this.CompletedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ErrorsCount != null)
                    hashCode = hashCode * 59 + this.ErrorsCount.GetHashCode();
                if (this.ErrorsReportFile != null)
                    hashCode = hashCode * 59 + this.ErrorsReportFile.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.FullReportFile != null)
                    hashCode = hashCode * 59 + this.FullReportFile.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.ProcessedCount != null)
                    hashCode = hashCode * 59 + this.ProcessedCount.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            // Etag (string) pattern
            Regex regexEtag = new Regex(@"[A-Za-z0-9]{0,256}", RegexOptions.CultureInvariant);
            if (false == regexEtag.Match(this.Etag).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Etag, must match a pattern of " + regexEtag, new [] { "Etag" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[A-Za-z0-9]{32}", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
