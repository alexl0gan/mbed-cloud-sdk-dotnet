/* 
 * <auto-generated>
 * Third party CA management API
 *
 * API for managing third party CA for creating certificates on Pelion Device Management
 *
 * OpenAPI spec version: v3
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
using SwaggerDateConverter = external_ca.Client.SwaggerDateConverter;

namespace external_ca.Model
{
    /// <summary>
    /// ErrorObjectResponse
    /// </summary>
    [DataContract]
    public partial class ErrorObjectResponse :  IEquatable<ErrorObjectResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorObjectResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorObjectResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorObjectResponse" /> class.
        /// </summary>
        /// <param name="Code">Error code. Correlates with response status code. (required).</param>
        /// <param name="Fields">A list of request fields that failed the validation. (required).</param>
        /// <param name="Message">Error message. (required).</param>
        /// <param name="_Object">entity name: &#39;error&#39; (required).</param>
        /// <param name="RequestId">Request ID from JWT. (required).</param>
        /// <param name="Type">Error type. (required).</param>
        public ErrorObjectResponse(int? Code = default(int?), List<FieldMessageEntry> Fields = default(List<FieldMessageEntry>), string Message = default(string), string _Object = default(string), string RequestId = default(string), string Type = default(string))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for ErrorObjectResponse and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Fields" is required (not null)
            if (Fields == null)
            {
                throw new InvalidDataException("Fields is a required property for ErrorObjectResponse and cannot be null");
            }
            else
            {
                this.Fields = Fields;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for ErrorObjectResponse and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for ErrorObjectResponse and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            // to ensure "RequestId" is required (not null)
            if (RequestId == null)
            {
                throw new InvalidDataException("RequestId is a required property for ErrorObjectResponse and cannot be null");
            }
            else
            {
                this.RequestId = RequestId;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ErrorObjectResponse and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
        }
        
        /// <summary>
        /// Error code. Correlates with response status code.
        /// </summary>
        /// <value>Error code. Correlates with response status code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }

        /// <summary>
        /// A list of request fields that failed the validation.
        /// </summary>
        /// <value>A list of request fields that failed the validation.</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldMessageEntry> Fields { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        /// <value>Error message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// entity name: &#39;error&#39;
        /// </summary>
        /// <value>entity name: &#39;error&#39;</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }

        /// <summary>
        /// Request ID from JWT.
        /// </summary>
        /// <value>Request ID from JWT.</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Error type.
        /// </summary>
        /// <value>Error type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorObjectResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorObjectResponse);
        }

        /// <summary>
        /// Returns true if ErrorObjectResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorObjectResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorObjectResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
