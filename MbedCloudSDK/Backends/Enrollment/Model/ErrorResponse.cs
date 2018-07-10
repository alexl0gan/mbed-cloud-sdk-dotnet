/* 
 * <auto-generated>
 * Enrollment API
 *
 * Mbed Cloud Connect Enrollment Service allows users to claim the ownership of a device which is not yet assigned to an account. A device without an assigned account can be a device purchased from the open market (OEM dealer) or a device transferred from an account to another. More information in [Device ownership: First-to-claim](https://cloud.mbed.com/docs/current/connecting/device-ownership.html) document. 
 *
 * OpenAPI spec version: 3
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
using SwaggerDateConverter = enrollment.Client.SwaggerDateConverter;

namespace enrollment.Model
{
    /// <summary>
    /// ErrorResponse
    /// </summary>
    [DataContract]
    public partial class ErrorResponse :  IEquatable<ErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Response code.
        /// </summary>
        /// <value>Response code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            
            /// <summary>
            /// Enum NUMBER_400 for 400
            /// </summary>
            [EnumMember(Value = "400")]
            NUMBER_400 = 400,
            
            /// <summary>
            /// Enum NUMBER_401 for 401
            /// </summary>
            [EnumMember(Value = "401")]
            NUMBER_401 = 401,
            
            /// <summary>
            /// Enum NUMBER_404 for 404
            /// </summary>
            [EnumMember(Value = "404")]
            NUMBER_404 = 404
        }

        /// <summary>
        /// Entity name, always &#39;error&#39;.
        /// </summary>
        /// <value>Entity name, always &#39;error&#39;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error
        }

        /// <summary>
        /// Error type.
        /// </summary>
        /// <value>Error type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Validationerror for "validation_error"
            /// </summary>
            [EnumMember(Value = "validation_error")]
            Validationerror,
            
            /// <summary>
            /// Enum Invalidtoken for "invalid_token"
            /// </summary>
            [EnumMember(Value = "invalid_token")]
            Invalidtoken,
            
            /// <summary>
            /// Enum Invalidapikey for "invalid_apikey"
            /// </summary>
            [EnumMember(Value = "invalid_apikey")]
            Invalidapikey,
            
            /// <summary>
            /// Enum Reauthrequired for "reauth_required"
            /// </summary>
            [EnumMember(Value = "reauth_required")]
            Reauthrequired,
            
            /// <summary>
            /// Enum Accessdenied for "access_denied"
            /// </summary>
            [EnumMember(Value = "access_denied")]
            Accessdenied,
            
            /// <summary>
            /// Enum Accountlimitexceeded for "account_limit_exceeded"
            /// </summary>
            [EnumMember(Value = "account_limit_exceeded")]
            Accountlimitexceeded,
            
            /// <summary>
            /// Enum Notfound for "not_found"
            /// </summary>
            [EnumMember(Value = "not_found")]
            Notfound,
            
            /// <summary>
            /// Enum Methodnotsupported for "method_not_supported"
            /// </summary>
            [EnumMember(Value = "method_not_supported")]
            Methodnotsupported,
            
            /// <summary>
            /// Enum Notacceptable for "not_acceptable"
            /// </summary>
            [EnumMember(Value = "not_acceptable")]
            Notacceptable,
            
            /// <summary>
            /// Enum Duplicate for "duplicate"
            /// </summary>
            [EnumMember(Value = "duplicate")]
            Duplicate,
            
            /// <summary>
            /// Enum Preconditionfailed for "precondition_failed"
            /// </summary>
            [EnumMember(Value = "precondition_failed")]
            Preconditionfailed,
            
            /// <summary>
            /// Enum Unsupportedmediatype for "unsupported_media_type"
            /// </summary>
            [EnumMember(Value = "unsupported_media_type")]
            Unsupportedmediatype,
            
            /// <summary>
            /// Enum Ratelimitexceeded for "rate_limit_exceeded"
            /// </summary>
            [EnumMember(Value = "rate_limit_exceeded")]
            Ratelimitexceeded,
            
            /// <summary>
            /// Enum Internalservererror for "internal_server_error"
            /// </summary>
            [EnumMember(Value = "internal_server_error")]
            Internalservererror,
            
            /// <summary>
            /// Enum Systemunavailable for "system_unavailable"
            /// </summary>
            [EnumMember(Value = "system_unavailable")]
            Systemunavailable
        }

        /// <summary>
        /// Response code.
        /// </summary>
        /// <value>Response code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum? Code { get; set; }
        /// <summary>
        /// Entity name, always &#39;error&#39;.
        /// </summary>
        /// <value>Entity name, always &#39;error&#39;.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// Error type.
        /// </summary>
        /// <value>Error type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="Code">Response code..</param>
        /// <param name="Fields">Failed input fields during request object validation..</param>
        /// <param name="Message">A human readable message with detailed info..</param>
        /// <param name="_Object">Entity name, always &#39;error&#39;. (default to ObjectEnum.Error).</param>
        /// <param name="RequestId">Request ID..</param>
        /// <param name="Type">Error type..</param>
        public ErrorResponse(CodeEnum? Code = default(CodeEnum?), List<Field> Fields = default(List<Field>), string Message = default(string), ObjectEnum? _Object = ObjectEnum.Error, string RequestId = default(string), TypeEnum? Type = default(TypeEnum?))
        {
            this.Code = Code;
            this.Fields = Fields;
            this.Message = Message;
            // use default value if no "_Object" provided
            if (_Object == null)
            {
                this._Object = ObjectEnum.Error;
            }
            else
            {
                this._Object = _Object;
            }
            this.RequestId = RequestId;
            this.Type = Type;
        }
        

        /// <summary>
        /// Failed input fields during request object validation.
        /// </summary>
        /// <value>Failed input fields during request object validation.</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// A human readable message with detailed info.
        /// </summary>
        /// <value>A human readable message with detailed info.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Request ID.
        /// </summary>
        /// <value>Request ID.</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }


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
            return this.Equals(input as ErrorResponse);
        }

        /// <summary>
        /// Returns true if ErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorResponse input)
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
            // RequestId (string) pattern
            Regex regexRequestId = new Regex(@"^[A-Za-z0-9]{32}", RegexOptions.CultureInvariant);
            if (false == regexRequestId.Match(this.RequestId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestId, must match a pattern of " + regexRequestId, new [] { "RequestId" });
            }

            yield break;
        }
    }

}
