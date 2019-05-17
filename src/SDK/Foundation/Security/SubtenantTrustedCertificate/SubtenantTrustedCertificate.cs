// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="SubtenantTrustedCertificate.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Newtonsoft.Json;
    using System;
    using Mbed.Cloud.Foundation.Enums;

    /// <summary>
    /// SubtenantTrustedCertificate
    /// </summary>
    public class SubtenantTrustedCertificate : Entity, ISubtenantTrustedCertificate
    {
        internal bool isDeveloperCertificate;

        /// <summary>
        /// account_id
        /// </summary>
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>
        /// certificate
        /// </summary>
        public string Certificate
        {
            get;
            set;
        }

        /// <summary>
        /// certificate_fingerprint
        /// </summary>
        public string CertificateFingerprint
        {
            get;
            internal set;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            internal set;
        }

        /// <summary>
        /// description
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// device_execution_mode
        /// </summary>
        public int? DeviceExecutionMode
        {
            get;
            internal set;
        }

        /// <summary>
        /// enrollment_mode
        /// </summary>
        public bool? EnrollmentMode
        {
            get;
            set;
        }

        /// <summary>
        /// is_developer_certificate
        /// </summary>
        public bool? IsDeveloperCertificate
        {
            get
            {
                return CustomFunctions.IsDeveloperCertificateGetter(this);
            }
        }

        /// <summary>
        /// issuer
        /// </summary>
        public string Issuer
        {
            get;
            internal set;
        }

        /// <summary>
        /// name
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// owner_id
        /// </summary>
        public string OwnerId
        {
            get;
            internal set;
        }

        /// <summary>
        /// service
        /// </summary>
        public SubtenantTrustedCertificateService? Service
        {
            get;
            set;
        }

        /// <summary>
        /// status
        /// </summary>
        public SubtenantTrustedCertificateStatus? Status
        {
            get;
            set;
        }

        /// <summary>
        /// subject
        /// </summary>
        public string Subject
        {
            get;
            internal set;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// updated_at
        /// </summary>
        public DateTime? UpdatedAt
        {
            get;
            internal set;
        }

        /// <summary>
        /// valid
        /// </summary>
        public bool? Valid
        {
            get;
            internal set;
        }
        [JsonConverter(typeof(CustomDateConverter), "yyyy-MM-dd'T'HH:mm:ss.fffZ")]
        /// <summary>
        /// validity
        /// </summary>
        public DateTime? Validity
        {
            get;
            internal set;
        }
    }
}