// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="ICertificateIssuerRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using Mbed.Cloud.Foundation;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// CertificateIssuerRepository
    /// </summary>
    public interface ICertificateIssuerRepository
    {
        Task<CertificateIssuer> Create(CertificateIssuer request, Dictionary<string, string> issuerCredentials);
        Task Delete(string id);
        PaginatedResponse<ICertificateIssuerListOptions, CertificateIssuer> List(ICertificateIssuerListOptions options = null);
        Task<CertificateIssuer> Read(string id);
        Task<CertificateIssuer> Update(string id, CertificateIssuer request, Dictionary<string, string> issuerCredentials = null);
        Task<VerificationResponse> Verify(string id);
    }
}