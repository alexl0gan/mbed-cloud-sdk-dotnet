// <auto-generated>
//
// Generated by
//                     _                        _
//   /\/\   __ _ _ __ | |__   __ _ ___ ___  ___| |_
//  /    \ / _` | '_ \| '_ \ / _` / __/ __|/ _ \ __|
// / /\/\ \ (_| | | | | | | | (_| \__ \__ \  __/ |_
// \/    \/\__,_|_| |_|_| |_|\__,_|___/___/\___|\__| v 2.0.0
//
// <copyright file="FirmwareManifestRepository.cs" company="Arm">
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
    /// FirmwareManifestRepository
    /// </summary>
    public class FirmwareManifestRepository : Repository, IFirmwareManifestRepository
    {
        public FirmwareManifestRepository()
        {
        }

        public FirmwareManifestRepository(Config config, Client client = null) : base(config, client)
        {
        }

        public async Task<FirmwareManifest> Create(Stream firmwareManifestFile, Stream keyTableFile = null, string description = null, string name = null)
        {
            try
            {
                var fileParams = new Dictionary<string, Stream> { { "datafile", firmwareManifestFile }, { "key_table", keyTableFile }, };
                var formParams = new Dictionary<string, object> { { "description", description }, { "name", name }, };
                return await Client.CallApi<FirmwareManifest>(path: "/v3/firmware-manifests/", fileParams: fileParams, formParams: formParams, method: HttpMethods.POST);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task Delete(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "manifest_id", id }, };
                await Client.CallApi<FirmwareManifest>(path: "/v3/firmware-manifests/{manifest_id}/", pathParams: pathParams, method: HttpMethods.DELETE);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public PaginatedResponse<IFirmwareManifestListOptions, FirmwareManifest> List(IFirmwareManifestListOptions options = null)
        {
            try
            {
                if (options == null)
                {
                    options = new FirmwareManifestListOptions();
                }

                Func<IFirmwareManifestListOptions, Task<ResponsePage<FirmwareManifest>>> paginatedFunc = async (IFirmwareManifestListOptions _options) => { var queryParams = new Dictionary<string, object> { { "after", _options.After }, { "include", _options.Include }, { "limit", _options.Limit }, { "order", _options.Order }, { "created_at__in", _options.Filter.GetEncodedValue("created_at", "$in") }, { "created_at__nin", _options.Filter.GetEncodedValue("created_at", "$nin") }, { "created_at__lte", _options.Filter.GetEncodedValue("created_at", "$lte") }, { "created_at__gte", _options.Filter.GetEncodedValue("created_at", "$gte") }, { "datafile__eq", _options.Filter.GetEncodedValue("datafile_url", "$eq") }, { "datafile__neq", _options.Filter.GetEncodedValue("datafile_url", "$neq") }, { "datafile__in", _options.Filter.GetEncodedValue("datafile_url", "$in") }, { "datafile__nin", _options.Filter.GetEncodedValue("datafile_url", "$nin") }, { "datafile_size__eq", _options.Filter.GetEncodedValue("datafile_size", "$eq") }, { "datafile_size__neq", _options.Filter.GetEncodedValue("datafile_size", "$neq") }, { "datafile_size__in", _options.Filter.GetEncodedValue("datafile_size", "$in") }, { "datafile_size__nin", _options.Filter.GetEncodedValue("datafile_size", "$nin") }, { "description__eq", _options.Filter.GetEncodedValue("description", "$eq") }, { "description__neq", _options.Filter.GetEncodedValue("description", "$neq") }, { "description__in", _options.Filter.GetEncodedValue("description", "$in") }, { "description__nin", _options.Filter.GetEncodedValue("description", "$nin") }, { "device_class__eq", _options.Filter.GetEncodedValue("device_class", "$eq") }, { "device_class__neq", _options.Filter.GetEncodedValue("device_class", "$neq") }, { "device_class__in", _options.Filter.GetEncodedValue("device_class", "$in") }, { "device_class__nin", _options.Filter.GetEncodedValue("device_class", "$nin") }, { "id__eq", _options.Filter.GetEncodedValue("id", "$eq") }, { "id__neq", _options.Filter.GetEncodedValue("id", "$neq") }, { "id__in", _options.Filter.GetEncodedValue("id", "$in") }, { "id__nin", _options.Filter.GetEncodedValue("id", "$nin") }, { "name__eq", _options.Filter.GetEncodedValue("name", "$eq") }, { "name__neq", _options.Filter.GetEncodedValue("name", "$neq") }, { "name__in", _options.Filter.GetEncodedValue("name", "$in") }, { "name__nin", _options.Filter.GetEncodedValue("name", "$nin") }, { "timestamp__in", _options.Filter.GetEncodedValue("timestamp", "$in") }, { "timestamp__nin", _options.Filter.GetEncodedValue("timestamp", "$nin") }, { "timestamp__lte", _options.Filter.GetEncodedValue("timestamp", "$lte") }, { "timestamp__gte", _options.Filter.GetEncodedValue("timestamp", "$gte") }, { "updated_at__in", _options.Filter.GetEncodedValue("updated_at", "$in") }, { "updated_at__nin", _options.Filter.GetEncodedValue("updated_at", "$nin") }, { "updated_at__lte", _options.Filter.GetEncodedValue("updated_at", "$lte") }, { "updated_at__gte", _options.Filter.GetEncodedValue("updated_at", "$gte") }, }; return await Client.CallApi<ResponsePage<FirmwareManifest>>(path: "/v3/firmware-manifests/", queryParams: queryParams, method: HttpMethods.GET); };
                return new PaginatedResponse<IFirmwareManifestListOptions, FirmwareManifest>(paginatedFunc, options);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        public async Task<FirmwareManifest> Read(string id)
        {
            try
            {
                var pathParams = new Dictionary<string, object> { { "manifest_id", id }, };
                return await Client.CallApi<FirmwareManifest>(path: "/v3/firmware-manifests/{manifest_id}/", pathParams: pathParams, method: HttpMethods.GET);
            }
            catch (ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }
    }
}