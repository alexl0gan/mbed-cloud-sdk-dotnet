/* 
 * <auto-generated>
 * Connect API
 *
 * Pelion Device Management Connect API allows web applications to communicate with devices. You can subscribe to device resources and read/write values to them. Device Management Connect allows connectivity to devices by queueing requests and caching resource values.
 *
 * OpenAPI spec version: 2
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
using SwaggerDateConverter = mds.Client.SwaggerDateConverter;

namespace mds.Model
{
    /// <summary>
    /// AsyncID
    /// </summary>
    [DataContract]
    public partial class AsyncID :  IEquatable<AsyncID>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncID" /> class.
        /// </summary>
        /// <param name="AsyncResponseId">Asynchronous response unique ID..</param>
        public AsyncID(string AsyncResponseId = default(string))
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AsyncID);
        }

        /// <summary>
        /// Returns true if AsyncID instances are equal
        /// </summary>
        /// <param name="input">Instance of AsyncID to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncID input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsyncResponseId == input.AsyncResponseId ||
                    (this.AsyncResponseId != null &&
                    this.AsyncResponseId.Equals(input.AsyncResponseId))
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
                if (this.AsyncResponseId != null)
                    hashCode = hashCode * 59 + this.AsyncResponseId.GetHashCode();
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
