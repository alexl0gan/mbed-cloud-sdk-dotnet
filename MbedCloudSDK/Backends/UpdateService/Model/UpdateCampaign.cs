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
    /// UpdateCampaign
    /// </summary>
    [DataContract]
    public partial class UpdateCampaign :  IEquatable<UpdateCampaign>, IValidatableObject
    {
        /// <summary>
        /// The state of the campaign
        /// </summary>
        /// <value>The state of the campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Draft for "draft"
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft,
            
            /// <summary>
            /// Enum Scheduled for "scheduled"
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Allocatingquota for "allocatingquota"
            /// </summary>
            [EnumMember(Value = "allocatingquota")]
            Allocatingquota,
            
            /// <summary>
            /// Enum Allocatedquota for "allocatedquota"
            /// </summary>
            [EnumMember(Value = "allocatedquota")]
            Allocatedquota,
            
            /// <summary>
            /// Enum Quotaallocationfailed for "quotaallocationfailed"
            /// </summary>
            [EnumMember(Value = "quotaallocationfailed")]
            Quotaallocationfailed,
            
            /// <summary>
            /// Enum Checkingmanifest for "checkingmanifest"
            /// </summary>
            [EnumMember(Value = "checkingmanifest")]
            Checkingmanifest,
            
            /// <summary>
            /// Enum Checkedmanifest for "checkedmanifest"
            /// </summary>
            [EnumMember(Value = "checkedmanifest")]
            Checkedmanifest,
            
            /// <summary>
            /// Enum Devicefetch for "devicefetch"
            /// </summary>
            [EnumMember(Value = "devicefetch")]
            Devicefetch,
            
            /// <summary>
            /// Enum Devicecopy for "devicecopy"
            /// </summary>
            [EnumMember(Value = "devicecopy")]
            Devicecopy,
            
            /// <summary>
            /// Enum Devicecheck for "devicecheck"
            /// </summary>
            [EnumMember(Value = "devicecheck")]
            Devicecheck,
            
            /// <summary>
            /// Enum Publishing for "publishing"
            /// </summary>
            [EnumMember(Value = "publishing")]
            Publishing,
            
            /// <summary>
            /// Enum Deploying for "deploying"
            /// </summary>
            [EnumMember(Value = "deploying")]
            Deploying,
            
            /// <summary>
            /// Enum Deployed for "deployed"
            /// </summary>
            [EnumMember(Value = "deployed")]
            Deployed,
            
            /// <summary>
            /// Enum Manifestremoved for "manifestremoved"
            /// </summary>
            [EnumMember(Value = "manifestremoved")]
            Manifestremoved,
            
            /// <summary>
            /// Enum Expired for "expired"
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired,
            
            /// <summary>
            /// Enum Stopping for "stopping"
            /// </summary>
            [EnumMember(Value = "stopping")]
            Stopping,
            
            /// <summary>
            /// Enum Autostopped for "autostopped"
            /// </summary>
            [EnumMember(Value = "autostopped")]
            Autostopped,
            
            /// <summary>
            /// Enum Userstopped for "userstopped"
            /// </summary>
            [EnumMember(Value = "userstopped")]
            Userstopped,
            
            /// <summary>
            /// Enum Conflict for "conflict"
            /// </summary>
            [EnumMember(Value = "conflict")]
            Conflict
        }

        /// <summary>
        /// The state of the campaign
        /// </summary>
        /// <value>The state of the campaign</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaign" /> class.
        /// </summary>
        /// <param name="CreatedAt">The time the update campaign was created.</param>
        /// <param name="Description">The optional description of the campaign.</param>
        /// <param name="DeviceFilter">The filter for the devices the campaign will target.</param>
        /// <param name="Etag">The entity instance signature.</param>
        /// <param name="Finished">The campaign finish timestamp.</param>
        /// <param name="Id">The campaign ID.</param>
        /// <param name="Name">The campaign name.</param>
        /// <param name="_Object">The API resource entity.</param>
        /// <param name="RootManifestId">RootManifestId.</param>
        /// <param name="RootManifestUrl">RootManifestUrl.</param>
        /// <param name="StartedAt">StartedAt.</param>
        /// <param name="State">The state of the campaign.</param>
        /// <param name="UpdatedAt">The time the object was updated.</param>
        /// <param name="When">The scheduled start time for the update campaign.</param>
        public UpdateCampaign(DateTime? CreatedAt = default(DateTime?), string Description = default(string), string DeviceFilter = default(string), string Etag = default(string), DateTime? Finished = default(DateTime?), string Id = default(string), string Name = default(string), string _Object = default(string), string RootManifestId = default(string), string RootManifestUrl = default(string), DateTime? StartedAt = default(DateTime?), StateEnum? State = default(StateEnum?), DateTime? UpdatedAt = default(DateTime?), DateTime? When = default(DateTime?))
        {
            this.CreatedAt = CreatedAt;
            this.Description = Description;
            this.DeviceFilter = DeviceFilter;
            this.Etag = Etag;
            this.Finished = Finished;
            this.Id = Id;
            this.Name = Name;
            this._Object = _Object;
            this.RootManifestId = RootManifestId;
            this.RootManifestUrl = RootManifestUrl;
            this.StartedAt = StartedAt;
            this.State = State;
            this.UpdatedAt = UpdatedAt;
            this.When = When;
        }
        
        /// <summary>
        /// The time the update campaign was created
        /// </summary>
        /// <value>The time the update campaign was created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The optional description of the campaign
        /// </summary>
        /// <value>The optional description of the campaign</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The filter for the devices the campaign will target
        /// </summary>
        /// <value>The filter for the devices the campaign will target</value>
        [DataMember(Name="device_filter", EmitDefaultValue=false)]
        public string DeviceFilter { get; set; }

        /// <summary>
        /// The entity instance signature
        /// </summary>
        /// <value>The entity instance signature</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// The campaign finish timestamp
        /// </summary>
        /// <value>The campaign finish timestamp</value>
        [DataMember(Name="finished", EmitDefaultValue=false)]
        public DateTime? Finished { get; set; }

        /// <summary>
        /// The campaign ID
        /// </summary>
        /// <value>The campaign ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The campaign name
        /// </summary>
        /// <value>The campaign name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The API resource entity
        /// </summary>
        /// <value>The API resource entity</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }

        /// <summary>
        /// The current phase of the campaign.
        /// </summary>
        /// <value>The current phase of the campaign.</value>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public string Phase { get; private set; }

        /// <summary>
        /// Gets or Sets RootManifestId
        /// </summary>
        [DataMember(Name="root_manifest_id", EmitDefaultValue=false)]
        public string RootManifestId { get; set; }

        /// <summary>
        /// Gets or Sets RootManifestUrl
        /// </summary>
        [DataMember(Name="root_manifest_url", EmitDefaultValue=false)]
        public string RootManifestUrl { get; set; }

        /// <summary>
        /// Gets or Sets StartedAt
        /// </summary>
        [DataMember(Name="started_at", EmitDefaultValue=false)]
        public DateTime? StartedAt { get; set; }


        /// <summary>
        /// The time the object was updated
        /// </summary>
        /// <value>The time the object was updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The scheduled start time for the update campaign
        /// </summary>
        /// <value>The scheduled start time for the update campaign</value>
        [DataMember(Name="when", EmitDefaultValue=false)]
        public DateTime? When { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCampaign {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeviceFilter: ").Append(DeviceFilter).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  RootManifestId: ").Append(RootManifestId).Append("\n");
            sb.Append("  RootManifestUrl: ").Append(RootManifestUrl).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
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
            return this.Equals(input as UpdateCampaign);
        }

        /// <summary>
        /// Returns true if UpdateCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCampaign input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DeviceFilter == input.DeviceFilter ||
                    (this.DeviceFilter != null &&
                    this.DeviceFilter.Equals(input.DeviceFilter))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Finished == input.Finished ||
                    (this.Finished != null &&
                    this.Finished.Equals(input.Finished))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.RootManifestId == input.RootManifestId ||
                    (this.RootManifestId != null &&
                    this.RootManifestId.Equals(input.RootManifestId))
                ) && 
                (
                    this.RootManifestUrl == input.RootManifestUrl ||
                    (this.RootManifestUrl != null &&
                    this.RootManifestUrl.Equals(input.RootManifestUrl))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.When == input.When ||
                    (this.When != null &&
                    this.When.Equals(input.When))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DeviceFilter != null)
                    hashCode = hashCode * 59 + this.DeviceFilter.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Finished != null)
                    hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.RootManifestId != null)
                    hashCode = hashCode * 59 + this.RootManifestId.GetHashCode();
                if (this.RootManifestUrl != null)
                    hashCode = hashCode * 59 + this.RootManifestUrl.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.When != null)
                    hashCode = hashCode * 59 + this.When.GetHashCode();
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
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 2000.", new [] { "Description" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            yield break;
        }
    }

}