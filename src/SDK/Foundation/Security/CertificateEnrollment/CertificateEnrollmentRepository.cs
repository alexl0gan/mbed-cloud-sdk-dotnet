// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="CertificateEnrollmentRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation.Entities
{
    using Mbed.Cloud.Foundation.Common;
    using Mbed.Cloud.Foundation.ListOptions;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.Foundation.RestClient;

    /// <summary>
    /// CertificateEnrollmentRepository
    /// </summary>
    public class CertificateEnrollmentRepository : Repository, ICertificateEnrollmentRepository
    {
        public CertificateEnrollmentRepository()
        {
        }

        public CertificateEnrollmentRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<CertificateEnrollment> Get(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "certificate-enrollment-id", id }, };
                return await Client.CallApi<CertificateEnrollment>(path: "/v3/certificate-enrollments/{certificate-enrollment-id}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<ICertificateEnrollmentListOptions, CertificateEnrollment> List(ICertificateEnrollmentListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new CertificateEnrollmentListOptions();
                }

                Func<ICertificateEnrollmentListOptions, Task<ResponsePage<CertificateEnrollment>>> paginatedFunc = async (ICertificateEnrollmentListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, }; return await Client.CallApi<ResponsePage<CertificateEnrollment>>(path: "/v3/certificate-enrollments", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<ICertificateEnrollmentListOptions, CertificateEnrollment>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}