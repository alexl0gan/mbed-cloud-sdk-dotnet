/* 
 * Provisioning endpoints - production line certificates.
 *
 * A producton line certificate is used to associate a specific installation of the Factory Tool with an mbed Cloud account.  The production line certificate is generated by the Factory Tool, and needs to be uploaded using these APIs. 
 *
 * OpenAPI spec version: 0.8
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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
    /// Body1
    /// </summary>
    [DataContract]
    public partial class Body1 :  IEquatable<Body1>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Body1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Body1" /> class.
        /// </summary>
        /// <param name="Comment">Updated comment for the production line certificate (max length: 256 characters). (required).</param>
        public Body1(string Comment = null)
        {
            // to ensure "Comment" is required (not null)
            if (Comment == null)
            {
                throw new InvalidDataException("Comment is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Comment = Comment;
            }
        }
        
        /// <summary>
        /// Updated comment for the production line certificate (max length: 256 characters).
        /// </summary>
        /// <value>Updated comment for the production line certificate (max length: 256 characters).</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body1 {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(obj as Body1);
        }

        /// <summary>
        /// Returns true if Body1 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
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
                return hash;
            }
        }
    }

}
