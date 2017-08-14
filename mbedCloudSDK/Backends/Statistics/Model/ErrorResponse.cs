/* 
 * Connect Statistics API
 *
 * mbed Cloud Connect Statistics API provides statistics about other cloud services through defined counters.
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace statistics.Model
{
    /// <summary>
    /// ErrorResponse
    /// </summary>
    [DataContract]
    public partial class ErrorResponse :  IEquatable<ErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="Code">HTTP response code..</param>
        /// <param name="Fields">Details of the error fields..</param>
        /// <param name="_Object">Response type, always \&quot;error\&quot;..</param>
        /// <param name="RequestId">Request ID..</param>
        /// <param name="Message">Description of the error..</param>
        /// <param name="Type">Type of error..</param>
        public ErrorResponse(int? Code = default(int?), List<Field> Fields = default(List<Field>), string _Object = default(string), string RequestId = default(string), string Message = default(string), string Type = default(string))
        {
            this.Code = Code;
            this.Fields = Fields;
            this._Object = _Object;
            this.RequestId = RequestId;
            this.Message = Message;
            this.Type = Type;
        }
        
        /// <summary>
        /// HTTP response code.
        /// </summary>
        /// <value>HTTP response code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }
        /// <summary>
        /// Details of the error fields.
        /// </summary>
        /// <value>Details of the error fields.</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<Field> Fields { get; set; }
        /// <summary>
        /// Response type, always \&quot;error\&quot;.
        /// </summary>
        /// <value>Response type, always \&quot;error\&quot;.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
        /// <summary>
        /// Request ID.
        /// </summary>
        /// <value>Request ID.</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }
        /// <summary>
        /// Description of the error.
        /// </summary>
        /// <value>Description of the error.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Type of error.
        /// </summary>
        /// <value>Type of error.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as ErrorResponse);
        }

        /// <summary>
        /// Returns true if ErrorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}