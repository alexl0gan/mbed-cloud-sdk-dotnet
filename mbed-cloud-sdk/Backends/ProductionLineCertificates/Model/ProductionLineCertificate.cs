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

namespace production_line_certificates.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ProductionLineCertificate :  IEquatable<ProductionLineCertificate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionLineCertificate" /> class.
        /// Initializes a new instance of the <see cref="ProductionLineCertificate" />class.
        /// </summary>
        /// <param name="Comment">Comment of the production line certificate..</param>
        /// <param name="CreatedAt">UTC time of the entity creation..</param>
        /// <param name="_Object">Entity name = \&quot;production-line-certificate\&quot;.</param>
        /// <param name="Etag">Currently not used..</param>
        /// <param name="PublicSigningKeyHash">SHA256 hash of the production line certificate (public signing key)..</param>
        /// <param name="Active">Production line certificate active..</param>
        /// <param name="ProductionLineCertificate">Production line certificate (public signing key)..</param>
        /// <param name="Id">Entity ID..</param>

        public ProductionLineCertificate(string Comment = null, string CreatedAt = null, string _Object = null, string Etag = null, string PublicSigningKeyHash = null, bool? Active = null, string ProductionLineCertificate = null, string Id = null)
        {
            this.Comment = Comment;
            this.CreatedAt = CreatedAt;
            this._Object = _Object;
            this.Etag = Etag;
            this.PublicSigningKeyHash = PublicSigningKeyHash;
            this.Active = Active;
            this.ProductionLineCert = ProductionLineCertificate;
            this.Id = Id;
            
        }
        
    
        /// <summary>
        /// Comment of the production line certificate.
        /// </summary>
        /// <value>Comment of the production line certificate.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
    
        /// <summary>
        /// UTC time of the entity creation.
        /// </summary>
        /// <value>UTC time of the entity creation.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
    
        /// <summary>
        /// Entity name = \&quot;production-line-certificate\&quot;
        /// </summary>
        /// <value>Entity name = \&quot;production-line-certificate\&quot;</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
    
        /// <summary>
        /// Currently not used.
        /// </summary>
        /// <value>Currently not used.</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }
    
        /// <summary>
        /// SHA256 hash of the production line certificate (public signing key).
        /// </summary>
        /// <value>SHA256 hash of the production line certificate (public signing key).</value>
        [DataMember(Name="publicSigningKeyHash", EmitDefaultValue=false)]
        public string PublicSigningKeyHash { get; set; }
    
        /// <summary>
        /// Production line certificate active.
        /// </summary>
        /// <value>Production line certificate active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
    
        /// <summary>
        /// Production line certificate (public signing key).
        /// </summary>
        /// <value>Production line certificate (public signing key).</value>
        [DataMember(Name="production-line-certificate", EmitDefaultValue=false)]
        public string ProductionLineCert { get; set; }
    
        /// <summary>
        /// Entity ID.
        /// </summary>
        /// <value>Entity ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductionLineCertificate {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  PublicSigningKeyHash: ").Append(PublicSigningKeyHash).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ProductionLineCertificate: ").Append(ProductionLineCert).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            
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
            return this.Equals(obj as ProductionLineCertificate);
        }

        /// <summary>
        /// Returns true if ProductionLineCertificate instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductionLineCertificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductionLineCertificate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
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
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.PublicSigningKeyHash == other.PublicSigningKeyHash ||
                    this.PublicSigningKeyHash != null &&
                    this.PublicSigningKeyHash.Equals(other.PublicSigningKeyHash)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.ProductionLineCert == other.ProductionLineCert ||
                    this.ProductionLineCert != null &&
                    this.ProductionLineCert.Equals(other.ProductionLineCert)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                
                if (this.PublicSigningKeyHash != null)
                    hash = hash * 59 + this.PublicSigningKeyHash.GetHashCode();
                
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                
                if (this.ProductionLineCert != null)
                    hash = hash * 59 + this.ProductionLineCert.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                return hash;
            }
        }

    }
}
