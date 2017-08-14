﻿using mbedCloudSDK.Common;
using mbedCloudSDK.Common.Query;
using mbedCloudSDK.DeviceDirectory.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExamples.Examples.DeviceDirectory
{
    /// @example
    public class ListLogs
    {
        private Config config;
        
        public ListLogs(Config config)
        {
            this.config = config;
        }

        /// <summary>
        /// List all devicse logs.
        /// </summary>
        public void ListDevicesLogs()
        {
            DeviceDirectoryApi api = new DeviceDirectoryApi(config);
            QueryOptions listParam = new QueryOptions();
            listParam.Limit = 10;
            foreach (var log in api.ListDeviceLogs(listParam))
            {
                Console.WriteLine(log.ToString());
            }
        }
    }
}