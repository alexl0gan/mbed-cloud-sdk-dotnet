/* 
 * Firmware Catalog API
 *
 * This is the API Documentation for the mbed firmware catalog service which is part of the update service.
 *
 * OpenAPI spec version: 0.1
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

namespace firmware_catalog.Model
{
    /// <summary>
    /// WriteFirmwareImagePage
    /// </summary>
    [DataContract]
    public partial class WriteFirmwareImagePage :  IEquatable<WriteFirmwareImagePage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteFirmwareImagePage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WriteFirmwareImagePage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteFirmwareImagePage" /> class.
        /// </summary>
        /// <param name="Limit">Limit (required).</param>
        /// <param name="After">After (required).</param>
        /// <param name="Data">Data (required).</param>
        /// <param name="Order">Order (required).</param>
        public WriteFirmwareImagePage(long? Limit = null, string After = null, List<FirmwareImage> Data = null, string Order = null)
        {
            // to ensure "Limit" is required (not null)
            if (Limit == null)
            {
                throw new InvalidDataException("Limit is a required property for WriteFirmwareImagePage and cannot be null");
            }
            else
            {
                this.Limit = Limit;
            }
            // to ensure "After" is required (not null)
            if (After == null)
            {
                throw new InvalidDataException("After is a required property for WriteFirmwareImagePage and cannot be null");
            }
            else
            {
                this.After = After;
            }
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for WriteFirmwareImagePage and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            // to ensure "Order" is required (not null)
            if (Order == null)
            {
                throw new InvalidDataException("Order is a required property for WriteFirmwareImagePage and cannot be null");
            }
            else
            {
                this.Order = Order;
            }
        }
        
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }
        /// <summary>
        /// Gets or Sets After
        /// </summary>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<FirmwareImage> Data { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WriteFirmwareImagePage {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as WriteFirmwareImagePage);
        }

        /// <summary>
        /// Returns true if WriteFirmwareImagePage instances are equal
        /// </summary>
        /// <param name="other">Instance of WriteFirmwareImagePage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteFirmwareImagePage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.After == other.After ||
                    this.After != null &&
                    this.After.Equals(other.After)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.After != null)
                    hash = hash * 59 + this.After.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                return hash;
            }
        }
    }

}
