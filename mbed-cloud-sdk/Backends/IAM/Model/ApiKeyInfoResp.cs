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

namespace iam.Model
{
    /// <summary>
    /// This object represents an API key in mbed Cloud.
    /// </summary>
    [DataContract]
    public partial class ApiKeyInfoResp :  IEquatable<ApiKeyInfoResp>
    { 
    
        /// <summary>
        /// The status of the API key.
        /// </summary>
        /// <value>The status of the API key.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "INACTIVE")]
            Inactive
        }

    
        /// <summary>
        /// entity name: always 'apikey'
        /// </summary>
        /// <value>entity name: always 'apikey'</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum _ObjectEnum {
            
            [EnumMember(Value = "user")]
            User,
            
            [EnumMember(Value = "apikey")]
            Apikey,
            
            [EnumMember(Value = "group")]
            Group,
            
            [EnumMember(Value = "account")]
            Account,
            
            [EnumMember(Value = "list")]
            List,
            
            [EnumMember(Value = "error")]
            Error
        }

    
        /// <summary>
        /// The status of the API key.
        /// </summary>
        /// <value>The status of the API key.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// entity name: always 'apikey'
        /// </summary>
        /// <value>entity name: always 'apikey'</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public _ObjectEnum? _Object { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInfoResp" /> class.
        /// Initializes a new instance of the <see cref="ApiKeyInfoResp" />class.
        /// </summary>
        /// <param name="Status">The status of the API key..</param>
        /// <param name="Apikey">API key. (required).</param>
        /// <param name="Name">The display name for the API key. (required).</param>
        /// <param name="CreatedAt">Creation UTC time RFC3339..</param>
        /// <param name="_Object">entity name: always &#39;apikey&#39; (required).</param>
        /// <param name="CreationTime">The timestamp of the API key creation in the storage, in milliseconds..</param>
        /// <param name="Etag">API resource entity version. (required).</param>
        /// <param name="Groups">A list of group IDs this API key belongs to..</param>
        /// <param name="Owner">The owner of this API key, who is the creator by default..</param>
        /// <param name="SecretKey">API key secret..</param>
        /// <param name="Id">UUID of the API key. (required).</param>
        /// <param name="LastLoginTime">The timestamp of the latest API key usage, in milliseconds..</param>

        public ApiKeyInfoResp(StatusEnum? Status = null, string Apikey = null, string Name = null, string CreatedAt = null, _ObjectEnum? _Object = null, long? CreationTime = null, string Etag = null, List<string> Groups = null, string Owner = null, string SecretKey = null, string Id = null, long? LastLoginTime = null)
        {
            // to ensure "Apikey" is required (not null)
            if (Apikey == null)
            {
                throw new InvalidDataException("Apikey is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this.Apikey = Apikey;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "Etag" is required (not null)
            if (Etag == null)
            {
                throw new InvalidDataException("Etag is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this.Etag = Etag;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ApiKeyInfoResp and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Status = Status;
            this.CreatedAt = CreatedAt;
            this.CreationTime = CreationTime;
            this.Groups = Groups;
            this.Owner = Owner;
            this.SecretKey = SecretKey;
            this.LastLoginTime = LastLoginTime;
            
        }
        
    
        /// <summary>
        /// API key.
        /// </summary>
        /// <value>API key.</value>
        [DataMember(Name="apikey", EmitDefaultValue=false)]
        public string Apikey { get; set; }
    
        /// <summary>
        /// The display name for the API key.
        /// </summary>
        /// <value>The display name for the API key.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        /// <value>Creation UTC time RFC3339.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
    
        /// <summary>
        /// The timestamp of the API key creation in the storage, in milliseconds.
        /// </summary>
        /// <value>The timestamp of the API key creation in the storage, in milliseconds.</value>
        [DataMember(Name="creation_time", EmitDefaultValue=false)]
        public long? CreationTime { get; set; }
    
        /// <summary>
        /// API resource entity version.
        /// </summary>
        /// <value>API resource entity version.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }
    
        /// <summary>
        /// A list of group IDs this API key belongs to.
        /// </summary>
        /// <value>A list of group IDs this API key belongs to.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }
    
        /// <summary>
        /// The owner of this API key, who is the creator by default.
        /// </summary>
        /// <value>The owner of this API key, who is the creator by default.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }
    
        /// <summary>
        /// API key secret.
        /// </summary>
        /// <value>API key secret.</value>
        [DataMember(Name="secret_key", EmitDefaultValue=false)]
        public string SecretKey { get; set; }
    
        /// <summary>
        /// UUID of the API key.
        /// </summary>
        /// <value>UUID of the API key.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The timestamp of the latest API key usage, in milliseconds.
        /// </summary>
        /// <value>The timestamp of the latest API key usage, in milliseconds.</value>
        [DataMember(Name="last_login_time", EmitDefaultValue=false)]
        public long? LastLoginTime { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKeyInfoResp {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Apikey: ").Append(Apikey).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastLoginTime: ").Append(LastLoginTime).Append("\n");
            
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
            return this.Equals(obj as ApiKeyInfoResp);
        }

        /// <summary>
        /// Returns true if ApiKeyInfoResp instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiKeyInfoResp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyInfoResp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Apikey == other.Apikey ||
                    this.Apikey != null &&
                    this.Apikey.Equals(other.Apikey)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.SecretKey == other.SecretKey ||
                    this.SecretKey != null &&
                    this.SecretKey.Equals(other.SecretKey)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastLoginTime == other.LastLoginTime ||
                    this.LastLoginTime != null &&
                    this.LastLoginTime.Equals(other.LastLoginTime)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Apikey != null)
                    hash = hash * 59 + this.Apikey.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                
                if (this.SecretKey != null)
                    hash = hash * 59 + this.SecretKey.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.LastLoginTime != null)
                    hash = hash * 59 + this.LastLoginTime.GetHashCode();
                
                return hash;
            }
        }

    }
}
