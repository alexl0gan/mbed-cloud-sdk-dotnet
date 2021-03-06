﻿// <copyright file="DeviceDirectoryApi.Devices.cs" company="Arm">
// Copyright (c) Arm. All rights reserved.
// </copyright>

namespace MbedCloudSDK.DeviceDirectory.Api
{
    using System.Linq;
    using System.Threading.Tasks;
    using device_directory.Model;
    using Mbed.Cloud.Common;
    using MbedCloudSDK.Common.Extensions;
    using MbedCloudSDK.DeviceDirectory.Model.Device;
    using MbedCloudSDK.Exceptions;
    using QueryOptions = Common.QueryOptions;


    /// <summary>
    /// Device Directory Api
    /// </summary>
    public partial class DeviceDirectoryApi
    {
        /// <summary>
        /// Lists the devices.
        /// </summary>
        /// <returns>The devices.</returns>
        /// <param name="options"><see cref="QueryOptions"/></param>
        /// <exception cref="CloudApiException">CloudApiException</exception>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var options = new QueryOptions()
        ///     {
        ///         Limit = 5,
        ///     };
        ///     var devices = deviceApi.ListDevices(options).Data;
        ///     foreach (var item in devices)
        ///     {
        ///         Console.WriteLine(item);
        ///     }
        ///     return devices;
        /// }
        /// catch (CloudApiExeption)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        public PaginatedResponse<QueryOptions, Device> ListDevices(QueryOptions options = null)
        {
            if (options == null)
            {
                options = new QueryOptions();
            }

            try
            {
                return new PaginatedResponse<QueryOptions, Device>(ListDevicesFunc, options);
            }
            catch (CloudApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        private async Task<ResponsePage<Device>> ListDevicesFunc(QueryOptions options = null)
        {
            if (options == null)
            {
                options = new QueryOptions();
            }

            try
            {
                var resp = await Api.DeviceListAsync(limit: options.Limit, order: options.Order, after: options.After, filter: options.Filter?.FilterString, include: options.Include);
                var respDevices = new ResponsePage<Device>(resp.After, resp.HasMore, resp.TotalCount);
                foreach (var device in resp.Data)
                {
                    respDevices.Add(Device.Map(device, this));
                }

                return respDevices;
            }
            catch (device_directory.Client.ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
        }

        /// <summary>
        /// Get device details from catalog.
        /// </summary>
        /// <param name="deviceId">Id</param>
        /// <returns><see cref="Device"/></returns>
        /// <exception cref="CloudApiException">CloudApiException</exception>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var device = deviceApi.GetDevice("015c5ed320c0000000000001001000f0");
        ///     return device;
        /// }
        /// catch (CloudApiExeption)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        public Device GetDevice(string deviceId)
        {
            try
            {
                var response = Api.DeviceRetrieve(deviceId);
                return Device.Map(response);
            }
            catch (device_directory.Client.ApiException ex)
            {
                throw new CloudApiException(ex.ErrorCode, ex.Message, ex.ErrorContent);
            }
        }

        /// <summary>
        /// Add a new device to catalog.
        /// </summary>
        /// <param name="device">The <see cref="Device"/> to add to catalog.</param>
        /// <returns><see cref="Device"/></returns>
        /// <exception cref="CloudApiException">CloudApiException</exception>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var device = new Device()
        ///     {
        ///         Name = "NewDevice",
        ///         CertificateFingerprint = "07:7A:EB:67:37:42:4D:11:5C:3E:99:07:1E:EB:44:...",
        ///         CertificateIssuerId = "015c3c457b2002420a01041603c00000",
        ///     };
        ///     var newDevice = deviceApi.AddDevice(device);
        ///     return newDevice;
        /// }
        /// catch (CloudApiExeption)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        public Device AddDevice(Device device)
        {
            try
            {
                var response = Api.DeviceCreate(Device.CreatePostRequest(device));
                return GetDevice(response.Id);
            }
            catch (device_directory.Client.ApiException ex)
            {
                throw new CloudApiException(ex.ErrorCode, ex.Message, ex.ErrorContent);
            }
        }

        /// <summary>
        /// Update existing device in catalog.
        /// </summary>
        /// <param name="deviceId">Id</param>
        /// <param name="deviceToUpdate"><see cref="Device"/> to update</param>
        /// <returns><see cref="Device"/></returns>
        /// <exception cref="CloudApiException">CloudApiException</exception>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var device = deviceApi.GetDevice(device);
        ///     var fieldsToUpdate = new Device
        ///     {
        ///         CertificateIssuerId = "015c5ed320c0000000000001001000f0",
        ///     };
        ///     var updatedDevice = deviceApi.UpdateDevice(device.Id, fieldsToUpdate);
        ///     return updatedDevice;
        /// }
        /// catch (CloudApiExeption)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        public Device UpdateDevice(string deviceId, Device deviceToUpdate)
        {
            var originalDevice = GetDevice(deviceId);
            var device = originalDevice.MapToUpdate(deviceToUpdate) as Device;
            try
            {
                var response = Api.DeviceUpdate(deviceId, Device.CreatePutRequest(device));
                return GetDevice(deviceId);
            }
            catch (device_directory.Client.ApiException ex)
            {
                throw new CloudApiException(ex.ErrorCode, ex.Message, ex.ErrorContent);
            }
        }

        /// <summary>
        /// Deletes the device.
        /// </summary>
        /// <param name="deviceId">Id</param>
        /// <exception cref="CloudApiException">CloudApiException</exception>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     deviceApi.DeleteDevice("015c5ed320c0000000000001001000f0");
        /// }
        /// catch (CloudApiExeption)
        /// {
        ///     throw;
        /// }
        /// </code>
        /// </example>
        public void DeleteDevice(string deviceId)
        {
            try
            {
                Api.DeviceDestroy(deviceId);
            }
            catch (device_directory.Client.ApiException ex)
            {
                throw new CloudApiException(ex.ErrorCode, ex.Message, ex.ErrorContent);
            }
        }
    }
}
