﻿using System;
using System.Runtime.Serialization;

namespace mbedCloudSDK.Access.Model.ApiKey
{
    /// <summary>
    /// The status of the API key.
    /// </summary>
    /// <value>The status of the API key.</value>
    public enum ApiKeyStatus
    {
        /// <summary>
        /// Enum ACTIVE for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
         
        /// <summary>
        /// Enum INACTIVE for "INACTIVE"
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        INACTIVE
    }
}