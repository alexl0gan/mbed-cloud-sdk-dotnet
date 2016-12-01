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

namespace deployment_service.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class WriteUpdateCampaignSerializer :  IEquatable<WriteUpdateCampaignSerializer>
    { 
    
        /// <summary>
        /// The state of the campaign
        /// </summary>
        /// <value>The state of the campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum {
            
            [EnumMember(Value = "draft")]
            Draft,
            
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            [EnumMember(Value = "devicefetch")]
            Devicefetch,
            
            [EnumMember(Value = "devicecopy")]
            Devicecopy,
            
            [EnumMember(Value = "devicecopycomplete")]
            Devicecopycomplete,
            
            [EnumMember(Value = "publishing")]
            Publishing,
            
            [EnumMember(Value = "deploying")]
            Deploying,
            
            [EnumMember(Value = "deployed")]
            Deployed,
            
            [EnumMember(Value = "manifestremoved")]
            Manifestremoved,
            
            [EnumMember(Value = "expired")]
            Expired
        }

    
        /// <summary>
        /// The state of the campaign
        /// </summary>
        /// <value>The state of the campaign</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteUpdateCampaignSerializer" /> class.
        /// Initializes a new instance of the <see cref="WriteUpdateCampaignSerializer" />class.
        /// </summary>
        /// <param name="Name">A name for this campaign (required).</param>
        /// <param name="State">The state of the campaign.</param>
        /// <param name="UpdatingUserId">The updating IAM user ID.</param>
        /// <param name="_Object">The API resource entity.</param>
        /// <param name="RootManifestId">RootManifestId.</param>
        /// <param name="CampaignId">DEPRECATED: The ID of the campaign.</param>
        /// <param name="UpdatingApiKey">The gateway client API key.</param>
        /// <param name="When">The timestamp at which update campaign scheduled to start.</param>
        /// <param name="Finished">The timestamp when the update campaign finished.</param>
        /// <param name="UpdatingAccountId">The updating account ID.</param>
        /// <param name="DeviceFilter">The filter for the devices the campaign will target.</param>
        /// <param name="Description">An optional description of the campaign.</param>

        public WriteUpdateCampaignSerializer(string Name = null, StateEnum? State = null, string UpdatingUserId = null, string _Object = null, string RootManifestId = null, string CampaignId = null, string UpdatingApiKey = null, DateTime? When = null, DateTime? Finished = null, string UpdatingAccountId = null, string DeviceFilter = null, string Description = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for WriteUpdateCampaignSerializer and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.State = State;
            this.UpdatingUserId = UpdatingUserId;
            this._Object = _Object;
            this.RootManifestId = RootManifestId;
            this.CampaignId = CampaignId;
            this.UpdatingApiKey = UpdatingApiKey;
            this.When = When;
            this.Finished = Finished;
            this.UpdatingAccountId = UpdatingAccountId;
            this.DeviceFilter = DeviceFilter;
            this.Description = Description;
            
        }
        
    
        /// <summary>
        /// A name for this campaign
        /// </summary>
        /// <value>A name for this campaign</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// The updating IAM user ID
        /// </summary>
        /// <value>The updating IAM user ID</value>
        [DataMember(Name="updating_user_id", EmitDefaultValue=false)]
        public string UpdatingUserId { get; set; }
    
        /// <summary>
        /// The API resource entity
        /// </summary>
        /// <value>The API resource entity</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
    
        /// <summary>
        /// Gets or Sets RootManifestId
        /// </summary>
        [DataMember(Name="root_manifest_id", EmitDefaultValue=false)]
        public string RootManifestId { get; set; }
    
        /// <summary>
        /// DEPRECATED: The ID of the campaign
        /// </summary>
        /// <value>DEPRECATED: The ID of the campaign</value>
        [DataMember(Name="campaign_id", EmitDefaultValue=false)]
        public string CampaignId { get; set; }
    
        /// <summary>
        /// The gateway client API key
        /// </summary>
        /// <value>The gateway client API key</value>
        [DataMember(Name="updating_api_key", EmitDefaultValue=false)]
        public string UpdatingApiKey { get; set; }
    
        /// <summary>
        /// The timestamp at which update campaign scheduled to start
        /// </summary>
        /// <value>The timestamp at which update campaign scheduled to start</value>
        [DataMember(Name="when", EmitDefaultValue=false)]
        public DateTime? When { get; set; }
    
        /// <summary>
        /// The timestamp when the update campaign finished
        /// </summary>
        /// <value>The timestamp when the update campaign finished</value>
        [DataMember(Name="finished", EmitDefaultValue=false)]
        public DateTime? Finished { get; set; }
    
        /// <summary>
        /// The updating account ID
        /// </summary>
        /// <value>The updating account ID</value>
        [DataMember(Name="updating_account_id", EmitDefaultValue=false)]
        public string UpdatingAccountId { get; set; }
    
        /// <summary>
        /// The filter for the devices the campaign will target
        /// </summary>
        /// <value>The filter for the devices the campaign will target</value>
        [DataMember(Name="device_filter", EmitDefaultValue=false)]
        public string DeviceFilter { get; set; }
    
        /// <summary>
        /// An optional description of the campaign
        /// </summary>
        /// <value>An optional description of the campaign</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WriteUpdateCampaignSerializer {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UpdatingUserId: ").Append(UpdatingUserId).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  RootManifestId: ").Append(RootManifestId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  UpdatingApiKey: ").Append(UpdatingApiKey).Append("\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  UpdatingAccountId: ").Append(UpdatingAccountId).Append("\n");
            sb.Append("  DeviceFilter: ").Append(DeviceFilter).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            
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
            return this.Equals(obj as WriteUpdateCampaignSerializer);
        }

        /// <summary>
        /// Returns true if WriteUpdateCampaignSerializer instances are equal
        /// </summary>
        /// <param name="other">Instance of WriteUpdateCampaignSerializer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteUpdateCampaignSerializer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.UpdatingUserId == other.UpdatingUserId ||
                    this.UpdatingUserId != null &&
                    this.UpdatingUserId.Equals(other.UpdatingUserId)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.RootManifestId == other.RootManifestId ||
                    this.RootManifestId != null &&
                    this.RootManifestId.Equals(other.RootManifestId)
                ) && 
                (
                    this.CampaignId == other.CampaignId ||
                    this.CampaignId != null &&
                    this.CampaignId.Equals(other.CampaignId)
                ) && 
                (
                    this.UpdatingApiKey == other.UpdatingApiKey ||
                    this.UpdatingApiKey != null &&
                    this.UpdatingApiKey.Equals(other.UpdatingApiKey)
                ) && 
                (
                    this.When == other.When ||
                    this.When != null &&
                    this.When.Equals(other.When)
                ) && 
                (
                    this.Finished == other.Finished ||
                    this.Finished != null &&
                    this.Finished.Equals(other.Finished)
                ) && 
                (
                    this.UpdatingAccountId == other.UpdatingAccountId ||
                    this.UpdatingAccountId != null &&
                    this.UpdatingAccountId.Equals(other.UpdatingAccountId)
                ) && 
                (
                    this.DeviceFilter == other.DeviceFilter ||
                    this.DeviceFilter != null &&
                    this.DeviceFilter.Equals(other.DeviceFilter)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.UpdatingUserId != null)
                    hash = hash * 59 + this.UpdatingUserId.GetHashCode();
                
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                
                if (this.RootManifestId != null)
                    hash = hash * 59 + this.RootManifestId.GetHashCode();
                
                if (this.CampaignId != null)
                    hash = hash * 59 + this.CampaignId.GetHashCode();
                
                if (this.UpdatingApiKey != null)
                    hash = hash * 59 + this.UpdatingApiKey.GetHashCode();
                
                if (this.When != null)
                    hash = hash * 59 + this.When.GetHashCode();
                
                if (this.Finished != null)
                    hash = hash * 59 + this.Finished.GetHashCode();
                
                if (this.UpdatingAccountId != null)
                    hash = hash * 59 + this.UpdatingAccountId.GetHashCode();
                
                if (this.DeviceFilter != null)
                    hash = hash * 59 + this.DeviceFilter.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                return hash;
            }
        }

    }
}
