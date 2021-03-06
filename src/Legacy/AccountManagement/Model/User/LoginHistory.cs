// <copyright file="LoginHistory.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.AccountManagement.Model.User
{
    using System;
    using MbedCloudSDK.Common;
    using MbedCloudSDK.Common.Extensions;
    using Newtonsoft.Json;

    /// <summary>
    /// Login History
    /// </summary>
    public class LoginHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginHistory"/> class.
        /// Login History
        /// </summary>
        /// <param name="date">Date</param>
        /// <param name="userAgent">User Agent</param>
        /// <param name="ipAddress">IpAddress</param>
        /// <param name="success">Success</param>
        public LoginHistory(DateTime? date = null, string userAgent = null, string ipAddress = null, bool? success = null)
        {
            Date = date;
            UserAgent = userAgent;
            IpAddress = ipAddress;
            Success = success;
        }

        /// <summary>
        /// Gets date of login
        /// </summary>
        [JsonProperty]
        public DateTime? Date { get; private set; }

        /// <summary>
        /// Gets user agent used for login
        /// </summary>
        [JsonProperty]
        public string UserAgent { get; private set; }

        /// <summary>
        /// Gets IP Address for the login
        /// </summary>
        [JsonProperty]
        public string IpAddress { get; private set; }

        /// <summary>
        /// Gets whether login was successful
        /// </summary>
        [JsonProperty]
        public bool? Success { get; private set; }

        /// <summary>
        /// Login History
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns>Login history</returns>
        public static LoginHistory Map(iam.Model.LoginHistory data)
        {
            return new LoginHistory(data.Date, data.UserAgent, data.IpAddress, data.Success);
        }

        /// <summary>
        /// Returns the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
            => this.DebugDump();
    }
}
