// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="CampaignDeviceMetadataRepository.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>
// </auto-generated>

namespace Mbed.Cloud.Foundation
{
    using Mbed.Cloud.Common;
    using System.Threading.Tasks;
    using MbedCloudSDK.Exceptions;
    using System.Collections.Generic;
    using System;
    using Mbed.Cloud.RestClient;

    /// <summary>
    /// CampaignDeviceMetadataRepository
    /// </summary>
    public class CampaignDeviceMetadataRepository : Repository, ICampaignDeviceMetadataRepository
    {
        public CampaignDeviceMetadataRepository()
        {
        }

        public CampaignDeviceMetadataRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<CampaignDeviceMetadata> Read(string campaignId, string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "campaign_id", campaignId }, { "campaign_device_metadata_id", id }, };
                return await Client.CallApi<CampaignDeviceMetadata>(path: "/v3/update-campaigns/{campaign_id}/campaign-device-metadata/{campaign_device_metadata_id}/", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}