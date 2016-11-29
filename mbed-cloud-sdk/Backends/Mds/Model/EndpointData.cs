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
    public partial class EndpointData :  IEquatable<EndpointData>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointData" /> class.
        /// Initializes a new instance of the <see cref="EndpointData" />class.
        /// </summary>
        /// <param name="Q">Queue mode (default value is false).</param>
        /// <param name="Ept">Endpoint type.</param>
        /// <param name="Ep">Endpoint name.</param>
        /// <param name="Resources">Resources.</param>

        public EndpointData(bool? Q = null, string Ept = null, string Ep = null, List<ResourcesData> Resources = null)
        {
            this.Q = Q;
            this.Ept = Ept;
            this.Ep = Ep;
            this.Resources = Resources;
            
        }
        
    
        /// <summary>
        /// Queue mode (default value is false)
        /// </summary>
        /// <value>Queue mode (default value is false)</value>
        [DataMember(Name="q", EmitDefaultValue=false)]
        public bool? Q { get; set; }
    
        /// <summary>
        /// Endpoint type
        /// </summary>
        /// <value>Endpoint type</value>
        [DataMember(Name="ept", EmitDefaultValue=false)]
        public string Ept { get; set; }
    
        /// <summary>
        /// Endpoint name
        /// </summary>
        /// <value>Endpoint name</value>
        [DataMember(Name="ep", EmitDefaultValue=false)]
        public string Ep { get; set; }
    
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public List<ResourcesData> Resources { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointData {\n");
            sb.Append("  Q: ").Append(Q).Append("\n");
            sb.Append("  Ept: ").Append(Ept).Append("\n");
            sb.Append("  Ep: ").Append(Ep).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            
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
            return this.Equals(obj as EndpointData);
        }

        /// <summary>
        /// Returns true if EndpointData instances are equal
        /// </summary>
        /// <param name="other">Instance of EndpointData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Q == other.Q ||
                    this.Q != null &&
                    this.Q.Equals(other.Q)
                ) && 
                (
                    this.Ept == other.Ept ||
                    this.Ept != null &&
                    this.Ept.Equals(other.Ept)
                ) && 
                (
                    this.Ep == other.Ep ||
                    this.Ep != null &&
                    this.Ep.Equals(other.Ep)
                ) && 
                (
                    this.Resources == other.Resources ||
                    this.Resources != null &&
                    this.Resources.SequenceEqual(other.Resources)
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
                
                if (this.Q != null)
                    hash = hash * 59 + this.Q.GetHashCode();
                
                if (this.Ept != null)
                    hash = hash * 59 + this.Ept.GetHashCode();
                
                if (this.Ep != null)
                    hash = hash * 59 + this.Ep.GetHashCode();
                
                if (this.Resources != null)
                    hash = hash * 59 + this.Resources.GetHashCode();
                
                return hash;
            }
        }

    }
}
