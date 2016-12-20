﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbedCloudSDK.Common
{
    /// <summary>
    /// Base API.
    /// </summary>
	public class BaseApi
    {
        protected Config config;
        
		/// <summary>
        /// Initializes a new instance of the <see cref="T:mbedCloudSDK.Common.BaseAPI"/> class.
        /// </summary>
        /// <param name="config">Config.</param>
		public BaseApi(Config config)
        {
            this.config = config;
        }
    }
}