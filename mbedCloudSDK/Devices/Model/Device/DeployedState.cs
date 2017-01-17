﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mbedCloudSDK.Devices.Model.Device
{
    /// <summary>
    /// The state of the device's deployment
    /// </summary>
    /// <value>The state of the device's deployment</value>
    public enum DeployedState
    {
        /// <summary>
        /// Enum Development for "development"
        /// </summary>
        [EnumMember(Value = "development")]
        Development,

        /// <summary>
        /// Enum Production for "production"
        /// </summary>
        [EnumMember(Value = "production")]
        Production
    }
}