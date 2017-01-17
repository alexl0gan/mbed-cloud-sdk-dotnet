/* 
 * IAM Identities REST API
 *
 * REST API to manage accounts, groups, users and API keys
 *
 * OpenAPI spec version: v3
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

namespace iam.Model
{
    /// <summary>
    /// This object represents a verify request during service sign-up process.
    /// </summary>
    [DataContract]
    public partial class AccountSignupVerify :  IEquatable<AccountSignupVerify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSignupVerify" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountSignupVerify() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSignupVerify" /> class.
        /// </summary>
        /// <param name="Code">Verification code, also required while checking account aliases. (required).</param>
        /// <param name="Aliases">Account alias array to be checked for being unique..</param>
        public AccountSignupVerify(string Code = default(string), List<string> Aliases = default(List<string>))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for AccountSignupVerify and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            this.Aliases = Aliases;
        }
        
        /// <summary>
        /// Verification code, also required while checking account aliases.
        /// </summary>
        /// <value>Verification code, also required while checking account aliases.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// Account alias array to be checked for being unique.
        /// </summary>
        /// <value>Account alias array to be checked for being unique.</value>
        [DataMember(Name="aliases", EmitDefaultValue=false)]
        public List<string> Aliases { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSignupVerify {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Aliases: ").Append(Aliases).Append("\n");
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
            return this.Equals(obj as AccountSignupVerify);
        }

        /// <summary>
        /// Returns true if AccountSignupVerify instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSignupVerify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSignupVerify other)
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
                    this.Aliases == other.Aliases ||
                    this.Aliases != null &&
                    this.Aliases.SequenceEqual(other.Aliases)
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
                if (this.Aliases != null)
                    hash = hash * 59 + this.Aliases.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}