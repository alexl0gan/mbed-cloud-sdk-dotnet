// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 1.0.0
//
// <copyright file="SubtenantUser.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace MbedCloud.SDK.Entities
{
    using MbedCloud.SDK.Common;
    using MbedCloud.SDK.Client;
    using System.Collections.Generic;
    using System;
    using MbedCloud.SDK.Entities;
    using MbedCloud.SDK.Enums;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;

    /// <summary>
    /// SubtenantUser
    /// </summary>
    public class SubtenantUser : BaseEntity
    {
        public SubtenantUser()
        {
        }

        public SubtenantUser(Config config) : base(config)
        {
        }

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
            set;
        }

        /// <summary>
        /// creation_time
        /// </summary>
        public long? CreationTime
        {
            get;
            set;
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
            set;
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
        /// groups
        /// </summary>
        public List<string> Groups
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
            set;
        }

        /// <summary>
        /// login_history
        /// </summary>
        public List<LoginHistory> LoginHistory
        {
            get;
            set;
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
            set;
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
        public SubtenantUserStatusEnum? Status
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
            set;
        }

        /// <summary>
        /// username
        /// </summary>
        public string Username
        {
            get;
            set;
        }

        public async Task<SubtenantUser> Create(string action = null)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", AccountId }, };
                var queryParams = new Dictionary<string, object> { { "action", action }, };
                var bodyParams = new SubtenantUser { Address = Address, Email = Email, FullName = FullName, Groups = Groups, LoginProfiles = LoginProfiles, MarketingAccepted = MarketingAccepted, Password = Password, PhoneNumber = PhoneNumber, TermsAccepted = TermsAccepted, Username = Username, };
                return await Client.CallApi<SubtenantUser>(path: "/v3/accounts/{account_id}/users", pathParams: pathParams, queryParams: queryParams, bodyParams: bodyParams, method: HttpMethods.POST, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<SubtenantUser> Delete()
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", AccountId }, { "user_id", Id }, };
                return await Client.CallApi<SubtenantUser>(path: "/v3/accounts/{account_id}/users/{user_id}", pathParams: pathParams, method: HttpMethods.DELETE, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<SubtenantUser> Get()
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", AccountId }, { "user_id", Id }, };
                return await Client.CallApi<SubtenantUser>(path: "/v3/accounts/{account_id}/users/{user_id}", pathParams: pathParams, method: HttpMethods.GET, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<SubtenantUser> Update()
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", AccountId }, { "user_id", Id }, };
                var bodyParams = new SubtenantUser { Address = Address, FullName = FullName, Groups = Groups, LoginProfiles = LoginProfiles, MarketingAccepted = MarketingAccepted, PhoneNumber = PhoneNumber, TermsAccepted = TermsAccepted, TwoFactorAuthentication = TwoFactorAuthentication, Username = Username, };
                return await Client.CallApi<SubtenantUser>(path: "/v3/accounts/{account_id}/users/{user_id}", pathParams: pathParams, bodyParams: bodyParams, method: HttpMethods.PUT, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<SubtenantUser> ValidateEmail()
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", AccountId }, { "user_id", Id }, };
                return await Client.CallApi<SubtenantUser>(path: "/v3/accounts/{account_id}/users/{user_id}/validate-email", pathParams: pathParams, method: HttpMethods.POST, objectToUnpack: this);
            }
            catch (MbedCloud.SDK.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}