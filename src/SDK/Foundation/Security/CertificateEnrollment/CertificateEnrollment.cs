// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="CertificateEnrollment.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using System;
    using Mbed.Cloud.Foundation.Enums;

    /// <summary>
    /// CertificateEnrollment
    /// </summary>
    public class CertificateEnrollment : Entity, ICertificateEnrollment
    {
        /// <summary>
        /// certificate_name
        /// </summary>
        public string CertificateName
        {
            get;
            private set;
        }

        /// <summary>
        /// created_at
        /// </summary>
        public DateTime? CreatedAt
        {
            get;
            private set;
        }

        /// <summary>
        /// device_id
        /// </summary>
        public string DeviceId
        {
            get;
            private set;
        }

        /// <summary>
        /// enroll_result
        /// </summary>
        public CertificateEnrollmentEnrollResult? EnrollResult
        {
            get;
            private set;
        }

        /// <summary>
        /// enroll_status
        /// </summary>
        public CertificateEnrollmentEnrollStatus? EnrollStatus
        {
            get;
            private set;
        }

        /// <summary>
        /// updated_at
        /// </summary>
        public DateTime? UpdatedAt
        {
            get;
            private set;
        }
    }
}