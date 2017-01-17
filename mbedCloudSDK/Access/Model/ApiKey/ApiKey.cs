﻿using iam.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace mbedCloudSDK.Access.Model.ApiKey
{
    /// <summary>
    /// This object represents an API key in mbed Cloud.
    /// </summary>
    public class ApiKey
    {
        /// <summary>
        /// The status of the API key.
        /// </summary>
        /// <value>The status of the API key.</value>
        public ApiKeyStatus? Status { get; private set; }

        /// <summary>
        /// The display name for the API key.
        /// </summary>
        /// <value>The display name for the API key.</value>
        public string Name { get; set; }

        /// <summary>
        /// The owner of this API key, who is the creator by default.
        /// </summary>
        /// <value>The owner of this API key, who is the creator by default.</value>
        public string Owner { get; set; }

        /// <summary>
        /// The API key.
        /// </summary>
        /// <value>The API key.</value>
        public string Apikey { get; private set; }
        
        /// <summary>
        /// Creation UTC time RFC3339.
        /// </summary>
        /// <value>Creation UTC time RFC3339.</value>
        public string CreatedAt { get; private set; }
        
        /// <summary>
        /// The timestamp of the API key creation in the storage, in milliseconds.
        /// </summary>
        /// <value>The timestamp of the API key creation in the storage, in milliseconds.</value>
        public long? CreationTime { get; private set; }
        
        /// <summary>
        /// Gets or Sets CreationTimeMillis
        /// </summary>
        public long? CreationTimeMillis { get; private set; }
        
        /// <summary>
        /// API resource entity version.
        /// </summary>
        /// <value>API resource entity version.</value>
        public string Etag { get; private set; }
        
        /// <summary>
        /// A list of group IDs this API key belongs to.
        /// </summary>
        /// <value>A list of group IDs this API key belongs to.</value>
        public List<string> Groups { get; private set; }
        
        /// <summary>
        /// The UUID of the API key.
        /// </summary>
        /// <value>The UUID of the API key.</value>
        public string Id { get; private set; }
        
        /// <summary>
        /// The timestamp of the latest API key usage, in milliseconds.
        /// </summary>
        /// <value>The timestamp of the latest API key usage, in milliseconds.</value>
        public long? LastLoginTime { get; private set; }

        /// <summary>
        /// Create new instance of api key class.
        /// </summary>
        /// <param name="options">Dictionary containing properties.</param>
        public ApiKey(IDictionary<string, object> options = null)
        {
            if (options != null)
            {
                foreach (KeyValuePair<string, object> item in options)
                {
                    var property = this.GetType().GetProperty(item.Key);
                    if (property != null)
                    {
                        property.SetValue(this, item.Value, null);
                    }
                }
            }
        }
        
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:mbedCloudSDK.Access.Model.ApiKey.ApiKey"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:mbedCloudSDK.Access.Model.ApiKey.ApiKey"/>.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKey {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Apikey: ").Append(Apikey).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  CreationTimeMillis: ").Append(CreationTimeMillis).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastLoginTime: ").Append(LastLoginTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public static ApiKey Map(ApiKeyInfoResp apiKeyInfo)
        {
            ApiKeyStatus apiKeyStatus = (ApiKeyStatus)Enum.Parse(typeof(ApiKeyStatus), apiKeyInfo.Status.ToString());
            var apiKey = new ApiKey();
            apiKey.Status = apiKeyStatus;
            apiKey.Apikey = apiKeyInfo.Key;
            apiKey.Name = apiKeyInfo.Name;
            apiKey.CreatedAt = apiKeyInfo.CreatedAt;
            apiKey.CreationTime = apiKeyInfo.CreationTime;
            apiKey.CreationTimeMillis = apiKeyInfo.CreationTimeMillis;
            apiKey.Etag = apiKeyInfo.Etag;
            apiKey.Groups = apiKeyInfo.Groups;
            apiKey.Owner = apiKeyInfo.Owner;
            apiKey.Id = apiKeyInfo.Id;
            apiKey.LastLoginTime = apiKeyInfo.LastLoginTime;
            return apiKey;
        }
    }
}
