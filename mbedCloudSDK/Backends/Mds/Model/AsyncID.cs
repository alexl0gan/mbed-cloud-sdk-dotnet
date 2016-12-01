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
    public partial class AsyncID :  IEquatable<AsyncID>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncID" /> class.
        /// Initializes a new instance of the <see cref="AsyncID" />class.
        /// </summary>
        /// <param name="AsyncResponseId">Asynchronous response unique ID..</param>

        public AsyncID(string AsyncResponseId = null)
        {
            this.AsyncResponseId = AsyncResponseId;
            
        }
        
    
        /// <summary>
        /// Asynchronous response unique ID.
        /// </summary>
        /// <value>Asynchronous response unique ID.</value>
        [DataMember(Name="async-response-id", EmitDefaultValue=false)]
        public string AsyncResponseId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncID {\n");
            sb.Append("  AsyncResponseId: ").Append(AsyncResponseId).Append("\n");
            
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
            return this.Equals(obj as AsyncID);
        }

        /// <summary>
        /// Returns true if AsyncID instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncID to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncID other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AsyncResponseId == other.AsyncResponseId ||
                    this.AsyncResponseId != null &&
                    this.AsyncResponseId.Equals(other.AsyncResponseId)
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
                
                if (this.AsyncResponseId != null)
                    hash = hash * 59 + this.AsyncResponseId.GetHashCode();
                
                return hash;
            }
        }

    }
}
