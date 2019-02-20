// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="SubtenantUser.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using System.Collections.Generic;
    using Mbed.Cloud.Foundation.Entities;
    using System;
    using Mbed.Cloud.Foundation.Enums;

    /// <summary>
    /// SubtenantUser
    /// </summary>
    public class SubtenantUser : Entity
    {
        internal static Dictionary<string, string> Renames = new Dictionary<string, string>() { { "MarketingAccepted", "is_marketing_accepted" }, { "TermsAccepted", "is_gtc_accepted" }, { "TwoFactorAuthentication", "is_totp_enabled" }, };

        /// <summary>
        /// account_id
        /// </summary>
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>
        /// active_sessions
        /// </summary>
        public List<ActiveSession> ActiveSessions
        {
            get;
            internal set;
        }

        /// <summary>
        /// address
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            internal set;
        }

        /// <summary>
        /// creation_time
        /// </summary>
        public long? CreationTime
        {
            get;
            internal set;
        }

        /// <summary>
        /// custom_fields
        /// </summary>
        public Dictionary<string, string> CustomFields
        {
            get;
            internal set;
        }

        /// <summary>
        /// email
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// email_verified
        /// </summary>
        public bool? EmailVerified
        {
            get;
            internal set;
        }

        /// <summary>
        /// full_name
        /// </summary>
        public string FullName
        {
            get;
            set;
        }

        /// <summary>
        /// last_login_time
        /// </summary>
        public long? LastLoginTime
        {
            get;
            internal set;
        }

        /// <summary>
        /// login_history
        /// </summary>
        public List<LoginHistory> LoginHistory
        {
            get;
            internal set;
        }

        /// <summary>
        /// login_profiles
        /// </summary>
        public List<LoginProfile> LoginProfiles
        {
            get;
            set;
        }

        /// <summary>
        /// marketing_accepted
        /// </summary>
        public bool? MarketingAccepted
        {
            get;
            set;
        }

        /// <summary>
        /// password
        /// </summary>
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// password_changed_time
        /// </summary>
        public long? PasswordChangedTime
        {
            get;
            internal set;
        }

        /// <summary>
        /// phone_number
        /// </summary>
        public string PhoneNumber
        {
            get;
            set;
        }

        /// <summary>
        /// status
        /// </summary>
        public SubtenantUserStatus? Status
        {
            get;
            set;
        }

        /// <summary>
        /// terms_accepted
        /// </summary>
        public bool? TermsAccepted
        {
            get;
            set;
        }

        /// <summary>
        /// totp_scratch_codes
        /// </summary>
        public List<string> TotpScratchCodes
        {
            get;
            internal set;
        }

        /// <summary>
        /// two_factor_authentication
        /// </summary>
        public bool? TwoFactorAuthentication
        {
            get;
            set;
        }

        /// <summary>
        /// updated_at
        /// </summary>
        public DateTime? UpdatedAt
        {
            get;
            internal set;
        }

        /// <summary>
        /// username
        /// </summary>
        public string Username
        {
            get;
            set;
        }
    }
}