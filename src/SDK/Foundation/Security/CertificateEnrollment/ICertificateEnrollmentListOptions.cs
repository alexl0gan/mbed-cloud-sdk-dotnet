// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ICertificateEnrollmentListOptions.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Common.Filters;
    using Mbed.Cloud.Foundation.Enums;
    using System;

    /// <summary>
    /// CertificateEnrollmentListOptions
    /// </summary>
    public interface ICertificateEnrollmentListOptions : IQueryOptions
    {
        /// <summary>
        /// Filter object
        /// </summary>
        Filter Filter
        {
            get;
            set;
        }

        CertificateEnrollmentListOptions DeviceIdEqualTo(string value);
        CertificateEnrollmentListOptions CertificateNameEqualTo(string value);
        CertificateEnrollmentListOptions EnrollStatusNotEqualTo(CertificateEnrollmentEnrollStatus value);
        CertificateEnrollmentListOptions EnrollStatusEqualTo(CertificateEnrollmentEnrollStatus value);
        CertificateEnrollmentListOptions EnrollResultNotEqualTo(CertificateEnrollmentEnrollResult value);
        CertificateEnrollmentListOptions EnrollResultEqualTo(CertificateEnrollmentEnrollResult value);
        CertificateEnrollmentListOptions CreatedAtLessThan(DateTime value);
        CertificateEnrollmentListOptions CreatedAtGreaterThan(DateTime value);
        CertificateEnrollmentListOptions UpdatedAtLessThan(DateTime value);
        CertificateEnrollmentListOptions UpdatedAtGreaterThan(DateTime value);
    }
}