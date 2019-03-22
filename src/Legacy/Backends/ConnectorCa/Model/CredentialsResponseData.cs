/* 
 * <auto-generated>
 * Connect CA API
 *
 * mbed Cloud Connect CA API allows services to get device credentials.
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
using SwaggerDateConverter = connector_ca.Client.SwaggerDateConverter;

namespace connector_ca.Model
{
    /// <summary>
    /// CredentialsResponseData
    /// </summary>
    [DataContract]
    public partial class CredentialsResponseData :  IEquatable<CredentialsResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsResponseData" /> class.
        /// </summary>
        /// <param name="Certificate">PEM format X.509 server certificate that will be used to validate the server certificate that will be received during the TLS/DTLS handshake..</param>
        /// <param name="Url">Server URI to which the client needs to connect to..</param>
        public CredentialsResponseData(string Certificate = default(string), string Url = default(string))
        {
            this.Certificate = Certificate;
            this.Url = Url;
        }
        
        /// <summary>
        /// PEM format X.509 server certificate that will be used to validate the server certificate that will be received during the TLS/DTLS handshake.
        /// </summary>
        /// <value>PEM format X.509 server certificate that will be used to validate the server certificate that will be received during the TLS/DTLS handshake.</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Server URI to which the client needs to connect to.
        /// </summary>
        /// <value>Server URI to which the client needs to connect to.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredentialsResponseData {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as CredentialsResponseData);
        }

        /// <summary>
        /// Returns true if CredentialsResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of CredentialsResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredentialsResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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