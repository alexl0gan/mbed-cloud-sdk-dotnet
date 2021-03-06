// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="SubtenantLightThemeImageRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using System.IO;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// SubtenantLightThemeImageRepository
    /// </summary>
    public class SubtenantLightThemeImageRepository : Repository, ISubtenantLightThemeImageRepository
    {
        public SubtenantLightThemeImageRepository()
        {
        }

        public SubtenantLightThemeImageRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<SubtenantLightThemeImage> Delete(string accountId, string reference)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", accountId }, { "reference", reference }, };
                return await Client.CallApi<SubtenantLightThemeImage>(path: "/v3/accounts/{account_id}/branding-images/light/{reference}/clear", pathParams: pathParams, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<SubtenantLightThemeImage> Read(string accountId, string reference)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", accountId }, { "reference", reference }, };
                return await Client.CallApi<SubtenantLightThemeImage>(path: "/v3/accounts/{account_id}/branding-images/light/{reference}", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<SubtenantLightThemeImage> Update(string accountId, string reference, Stream image)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "account_id", accountId }, { "reference", reference }, };
                var fileParams = new Dictionary<string, Stream> { { "image", image }, };
                return await Client.CallApi<SubtenantLightThemeImage>(path: "/v3/accounts/{account_id}/branding-images/light/{reference}/upload-multipart", pathParams: pathParams, fileParams: fileParams, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}