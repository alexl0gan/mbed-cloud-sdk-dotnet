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

namespace mds.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ResourcesData :  IEquatable<ResourcesData>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesData" /> class.
        /// Initializes a new instance of the <see cref="ResourcesData" />class.
        /// </summary>
        /// <param name="Path">Resource&#39;s URI path.</param>
        /// <param name="Rf">Resource type.</param>
        /// <param name="Ct">Content type.</param>
        /// <param name="Obs">Whether the resource is observable or not (true/false).</param>
        /// <param name="_If">Interface description.</param>

        public ResourcesData(string Path = null, string Rf = null, string Ct = null, bool? Obs = null, string _If = null)
        {
            this.Path = Path;
            this.Rf = Rf;
            this.Ct = Ct;
            this.Obs = Obs;
            this._If = _If;
            
        }
        
    
        /// <summary>
        /// Resource&#39;s URI path
        /// </summary>
        /// <value>Resource&#39;s URI path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
    
        /// <summary>
        /// Resource type
        /// </summary>
        /// <value>Resource type</value>
        [DataMember(Name="rf", EmitDefaultValue=false)]
        public string Rf { get; set; }
    
        /// <summary>
        /// Content type
        /// </summary>
        /// <value>Content type</value>
        [DataMember(Name="ct", EmitDefaultValue=false)]
        public string Ct { get; set; }
    
        /// <summary>
        /// Whether the resource is observable or not (true/false)
        /// </summary>
        /// <value>Whether the resource is observable or not (true/false)</value>
        [DataMember(Name="obs", EmitDefaultValue=false)]
        public bool? Obs { get; set; }
    
        /// <summary>
        /// Interface description
        /// </summary>
        /// <value>Interface description</value>
        [DataMember(Name="if", EmitDefaultValue=false)]
        public string _If { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcesData {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Rf: ").Append(Rf).Append("\n");
            sb.Append("  Ct: ").Append(Ct).Append("\n");
            sb.Append("  Obs: ").Append(Obs).Append("\n");
            sb.Append("  _If: ").Append(_If).Append("\n");
            
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
            return this.Equals(obj as ResourcesData);
        }

        /// <summary>
        /// Returns true if ResourcesData instances are equal
        /// </summary>
        /// <param name="other">Instance of ResourcesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourcesData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Rf == other.Rf ||
                    this.Rf != null &&
                    this.Rf.Equals(other.Rf)
                ) && 
                (
                    this.Ct == other.Ct ||
                    this.Ct != null &&
                    this.Ct.Equals(other.Ct)
                ) && 
                (
                    this.Obs == other.Obs ||
                    this.Obs != null &&
                    this.Obs.Equals(other.Obs)
                ) && 
                (
                    this._If == other._If ||
                    this._If != null &&
                    this._If.Equals(other._If)
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
                
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                
                if (this.Rf != null)
                    hash = hash * 59 + this.Rf.GetHashCode();
                
                if (this.Ct != null)
                    hash = hash * 59 + this.Ct.GetHashCode();
                
                if (this.Obs != null)
                    hash = hash * 59 + this.Obs.GetHashCode();
                
                if (this._If != null)
                    hash = hash * 59 + this._If.GetHashCode();
                
                return hash;
            }
        }

    }
}
