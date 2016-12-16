﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using developer_certificate.Api;
using developer_certificate.Client;
using developer_certificate.Model;
using mbedCloudSDK.Common;
using mbedCloudSDK.Exceptions;

namespace mbedCloudSDK.Development
{
    /// <summary>
    /// Expose Developer Certificate functionality.
    /// </summary>
	public class Development: BaseAPI
    {
        private string auth;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:mbedCloudSDK.Development.Development"/> class.
		/// </summary>
		/// <param name="config">Config.</param>
        public Development(Config config): base(config)
        {
            if (config.Host != string.Empty)
            {
                Configuration.Default.ApiClient = new ApiClient(config.Host);
            }
            Configuration.Default.ApiKey["Authorization"] = config.ApiKey;
            Configuration.Default.ApiKeyPrefix["Authorization"] = config.AuthorizationPrefix;
            this.auth = string.Format("{0} {1}", config.AuthorizationPrefix, config.ApiKey);
        }

        /// <summary>
        /// Gets the certificate.
        /// </summary>
        /// <returns>The certificate.</returns>
        /// <param name="certificateId">Certificate identifier.</param>
        public DeveloperCertificate getCertificate(string certificateId)
        {
            var api = new DefaultApi();
			try
			{
				return api.V3DeveloperCertificateGet(certificateId);
			}
			catch (ApiException e)
			{
				throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
			}
        }

        /// <summary>
        /// Revokes the certificate.
        /// </summary>
        /// <returns><c>true</c>, if certificate was revoked, <c>false</c> otherwise.</returns>
        /// <param name="certificateId">Certificate identifier.</param>
        public bool RevokeCertificate(string certificateId)
        {
            var api = new DefaultApi();
            bool success = false;
            try
            {
                api.V3DeveloperCertificateDelete(certificateId);
                success = true;
            }
            catch(ApiException e)
            {
                throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
            }
            return success;
        }

        /// <summary>
        /// Creates the certificate.
        /// </summary>
        /// <returns>The certificate.</returns>
        /// <param name="publicKey">Public key.</param>
        public DeveloperCertificate CreateCertificate(string publicKey)
        {
            var api = new DefaultApi();
            var body = new Body();
            body.PubKey = publicKey;
			try
			{
				return api.V3DeveloperCertificatePost(this.auth, body);
			}
			catch (ApiException e)
			{
				throw new CloudApiException(e.ErrorCode, e.Message, e.ErrorContent);
			}
        }
    }
}
