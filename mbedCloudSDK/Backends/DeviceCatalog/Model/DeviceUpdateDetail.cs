/* 
 * Device Catalog API
 *
 * This is the API Documentation for the mbed device catalog update service.
 *
 * OpenAPI spec version: 0.1
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

namespace device_catalog.Model
{
    /// <summary>
    /// DeviceUpdateDetail
    /// </summary>
    [DataContract]
    public partial class DeviceUpdateDetail :  IEquatable<DeviceUpdateDetail>, IValidatableObject
    {
        /// <summary>
        /// The ID of the channel used to communicate with the device
        /// </summary>
        /// <value>The ID of the channel used to communicate with the device</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MechanismEnum
        {
            
            /// <summary>
            /// Enum Connector for "connector"
            /// </summary>
            [EnumMember(Value = "connector")]
            Connector,
            
            /// <summary>
            /// Enum Direct for "direct"
            /// </summary>
            [EnumMember(Value = "direct")]
            Direct
        }

        /// <summary>
        /// The ID of the channel used to communicate with the device
        /// </summary>
        /// <value>The ID of the channel used to communicate with the device</value>
        [DataMember(Name="mechanism", EmitDefaultValue=false)]
        public MechanismEnum? Mechanism { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUpdateDetail" /> class.
        /// </summary>
        /// <param name="AccountId">The owning IAM account ID.</param>
        /// <param name="Name">The name of the object.</param>
        /// <param name="AutoUpdate">Mark this device for auto firmware update.</param>
        /// <param name="VendorId">The device vendor ID.</param>
        /// <param name="CustomAttributes">Up to 5 custom JSON attributes.</param>
        /// <param name="Manifest">URL for the current device manifest.</param>
        /// <param name="TrustClass">The device trust class.</param>
        /// <param name="ProvisionKey">The key used to provision the device.</param>
        /// <param name="Mechanism">The ID of the channel used to communicate with the device.</param>
        /// <param name="DeviceClass">The device class.</param>
        /// <param name="MechanismUrl">The address of the connector to use.</param>
        /// <param name="SerialNumber">The serial number of the device.</param>
        /// <param name="TrustLevel">The device trust level.</param>
        /// <param name="Description">The description of the object.</param>
        public DeviceUpdateDetail(string AccountId = default(string), string Name = default(string), bool? AutoUpdate = default(bool?), string VendorId = default(string), Object CustomAttributes = default(Object), string Manifest = default(string), long? TrustClass = default(long?), string ProvisionKey = default(string), MechanismEnum? Mechanism = default(MechanismEnum?), string DeviceClass = default(string), string MechanismUrl = default(string), string SerialNumber = default(string), long? TrustLevel = default(long?), string Description = default(string))
        {
            this.AccountId = AccountId;
            this.Name = Name;
            this.AutoUpdate = AutoUpdate;
            this.VendorId = VendorId;
            this.CustomAttributes = CustomAttributes;
            this.Manifest = Manifest;
            this.TrustClass = TrustClass;
            this.ProvisionKey = ProvisionKey;
            this.Mechanism = Mechanism;
            this.DeviceClass = DeviceClass;
            this.MechanismUrl = MechanismUrl;
            this.SerialNumber = SerialNumber;
            this.TrustLevel = TrustLevel;
            this.Description = Description;
        }
        
        /// <summary>
        /// The owning IAM account ID
        /// </summary>
        /// <value>The owning IAM account ID</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// The name of the object
        /// </summary>
        /// <value>The name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Mark this device for auto firmware update
        /// </summary>
        /// <value>Mark this device for auto firmware update</value>
        [DataMember(Name="auto_update", EmitDefaultValue=false)]
        public bool? AutoUpdate { get; set; }
        /// <summary>
        /// The device vendor ID
        /// </summary>
        /// <value>The device vendor ID</value>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public string VendorId { get; set; }
        /// <summary>
        /// Up to 5 custom JSON attributes
        /// </summary>
        /// <value>Up to 5 custom JSON attributes</value>
        [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
        public Object CustomAttributes { get; set; }
        /// <summary>
        /// URL for the current device manifest
        /// </summary>
        /// <value>URL for the current device manifest</value>
        [DataMember(Name="manifest", EmitDefaultValue=false)]
        public string Manifest { get; set; }
        /// <summary>
        /// The device trust class
        /// </summary>
        /// <value>The device trust class</value>
        [DataMember(Name="trust_class", EmitDefaultValue=false)]
        public long? TrustClass { get; set; }
        /// <summary>
        /// The key used to provision the device
        /// </summary>
        /// <value>The key used to provision the device</value>
        [DataMember(Name="provision_key", EmitDefaultValue=false)]
        public string ProvisionKey { get; set; }
        /// <summary>
        /// The device class
        /// </summary>
        /// <value>The device class</value>
        [DataMember(Name="device_class", EmitDefaultValue=false)]
        public string DeviceClass { get; set; }
        /// <summary>
        /// The address of the connector to use
        /// </summary>
        /// <value>The address of the connector to use</value>
        [DataMember(Name="mechanism_url", EmitDefaultValue=false)]
        public string MechanismUrl { get; set; }
        /// <summary>
        /// The serial number of the device
        /// </summary>
        /// <value>The serial number of the device</value>
        [DataMember(Name="serial_number", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }
        /// <summary>
        /// The device trust level
        /// </summary>
        /// <value>The device trust level</value>
        [DataMember(Name="trust_level", EmitDefaultValue=false)]
        public long? TrustLevel { get; set; }
        /// <summary>
        /// The description of the object
        /// </summary>
        /// <value>The description of the object</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceUpdateDetail {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AutoUpdate: ").Append(AutoUpdate).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  TrustClass: ").Append(TrustClass).Append("\n");
            sb.Append("  ProvisionKey: ").Append(ProvisionKey).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  DeviceClass: ").Append(DeviceClass).Append("\n");
            sb.Append("  MechanismUrl: ").Append(MechanismUrl).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  TrustLevel: ").Append(TrustLevel).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as DeviceUpdateDetail);
        }

        /// <summary>
        /// Returns true if DeviceUpdateDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceUpdateDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceUpdateDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AutoUpdate == other.AutoUpdate ||
                    this.AutoUpdate != null &&
                    this.AutoUpdate.Equals(other.AutoUpdate)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.CustomAttributes == other.CustomAttributes ||
                    this.CustomAttributes != null &&
                    this.CustomAttributes.Equals(other.CustomAttributes)
                ) && 
                (
                    this.Manifest == other.Manifest ||
                    this.Manifest != null &&
                    this.Manifest.Equals(other.Manifest)
                ) && 
                (
                    this.TrustClass == other.TrustClass ||
                    this.TrustClass != null &&
                    this.TrustClass.Equals(other.TrustClass)
                ) && 
                (
                    this.ProvisionKey == other.ProvisionKey ||
                    this.ProvisionKey != null &&
                    this.ProvisionKey.Equals(other.ProvisionKey)
                ) && 
                (
                    this.Mechanism == other.Mechanism ||
                    this.Mechanism != null &&
                    this.Mechanism.Equals(other.Mechanism)
                ) && 
                (
                    this.DeviceClass == other.DeviceClass ||
                    this.DeviceClass != null &&
                    this.DeviceClass.Equals(other.DeviceClass)
                ) && 
                (
                    this.MechanismUrl == other.MechanismUrl ||
                    this.MechanismUrl != null &&
                    this.MechanismUrl.Equals(other.MechanismUrl)
                ) && 
                (
                    this.SerialNumber == other.SerialNumber ||
                    this.SerialNumber != null &&
                    this.SerialNumber.Equals(other.SerialNumber)
                ) && 
                (
                    this.TrustLevel == other.TrustLevel ||
                    this.TrustLevel != null &&
                    this.TrustLevel.Equals(other.TrustLevel)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AutoUpdate != null)
                    hash = hash * 59 + this.AutoUpdate.GetHashCode();
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                if (this.CustomAttributes != null)
                    hash = hash * 59 + this.CustomAttributes.GetHashCode();
                if (this.Manifest != null)
                    hash = hash * 59 + this.Manifest.GetHashCode();
                if (this.TrustClass != null)
                    hash = hash * 59 + this.TrustClass.GetHashCode();
                if (this.ProvisionKey != null)
                    hash = hash * 59 + this.ProvisionKey.GetHashCode();
                if (this.Mechanism != null)
                    hash = hash * 59 + this.Mechanism.GetHashCode();
                if (this.DeviceClass != null)
                    hash = hash * 59 + this.DeviceClass.GetHashCode();
                if (this.MechanismUrl != null)
                    hash = hash * 59 + this.MechanismUrl.GetHashCode();
                if (this.SerialNumber != null)
                    hash = hash * 59 + this.SerialNumber.GetHashCode();
                if (this.TrustLevel != null)
                    hash = hash * 59 + this.TrustLevel.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // TrustClass (long?) maximum
            if(this.TrustClass > (long?)2147483647)
            {
                yield return new ValidationResult("Invalid value for TrustClass, must be a value less than or equal to 2147483647.", new [] { "TrustClass" });
            }

            // TrustClass (long?) minimum
            if(this.TrustClass < (long?)-2147483648)
            {
                yield return new ValidationResult("Invalid value for TrustClass, must be a value greater than or equal to -2147483648.", new [] { "TrustClass" });
            }

            // TrustLevel (long?) maximum
            if(this.TrustLevel > (long?)2147483647)
            {
                yield return new ValidationResult("Invalid value for TrustLevel, must be a value less than or equal to 2147483647.", new [] { "TrustLevel" });
            }

            // TrustLevel (long?) minimum
            if(this.TrustLevel < (long?)-2147483648)
            {
                yield return new ValidationResult("Invalid value for TrustLevel, must be a value greater than or equal to -2147483648.", new [] { "TrustLevel" });
            }

            yield break;
        }
    }

}