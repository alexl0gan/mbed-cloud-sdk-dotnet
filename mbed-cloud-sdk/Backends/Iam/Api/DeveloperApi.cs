using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using iam.Client;
using iam.Model;

namespace iam.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeveloperApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a new API key.
        /// </summary>
        /// <remarks>
        /// Endpoint for creating the new API key.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The details of the API key to be created.</param>
        /// <returns>ApiKeyInfoResp</returns>
        ApiKeyInfoResp CreateApiKey (ApiKeyInfoReq body);
  
        /// <summary>
        /// Create a new API key.
        /// </summary>
        /// <remarks>
        /// Endpoint for creating the new API key.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The details of the API key to be created.</param>
        /// <returns>ApiResponse of ApiKeyInfoResp</returns>
        ApiResponse<ApiKeyInfoResp> CreateApiKeyWithHttpInfo (ApiKeyInfoReq body);
        
        /// <summary>
        /// Delete API key.
        /// </summary>
        /// <remarks>
        /// Endpoint for deleting the API key.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be deleted.</param>
        /// <returns></returns>
        void DeleteApiKey (string apiKey);
  
        /// <summary>
        /// Delete API key.
        /// </summary>
        /// <remarks>
        /// Endpoint for deleting the API key.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteApiKeyWithHttpInfo (string apiKey);
        
        /// <summary>
        /// Get all API keys
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving API keys in an array, optionally filtered by the owner.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Owner name filter. (optional)</param>
        /// <returns>ApiKeyInfoRespList</returns>
        ApiKeyInfoRespList GetAllApiKeys (string owner = null);
  
        /// <summary>
        /// Get all API keys
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving API keys in an array, optionally filtered by the owner.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Owner name filter. (optional)</param>
        /// <returns>ApiResponse of ApiKeyInfoRespList</returns>
        ApiResponse<ApiKeyInfoRespList> GetAllApiKeysWithHttpInfo (string owner = null);
        
        /// <summary>
        /// Get all group information.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving all group information.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GroupSummaryList</returns>
        GroupSummaryList GetAllGroups ();
  
        /// <summary>
        /// Get all group information.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving all group information.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GroupSummaryList</returns>
        ApiResponse<GroupSummaryList> GetAllGroupsWithHttpInfo ();
        
        /// <summary>
        /// Get API key details.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving API key details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be retrieved.</param>
        /// <returns>ApiKeyInfoResp</returns>
        ApiKeyInfoResp GetApiKey (string apiKey);
  
        /// <summary>
        /// Get API key details.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving API key details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be retrieved.</param>
        /// <returns>ApiResponse of ApiKeyInfoResp</returns>
        ApiResponse<ApiKeyInfoResp> GetApiKeyWithHttpInfo (string apiKey);
        
        /// <summary>
        /// Get account info.
        /// </summary>
        /// <remarks>
        /// Returns detailed information about the account.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AccountInfo</returns>
        AccountInfo GetMyAccountInfo ();
  
        /// <summary>
        /// Get account info.
        /// </summary>
        /// <remarks>
        /// Returns detailed information about the account.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AccountInfo</returns>
        ApiResponse<AccountInfo> GetMyAccountInfoWithHttpInfo ();
        
        /// <summary>
        /// Details of the current user.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of the logged in user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserInfoResp</returns>
        UserInfoResp GetMyUser ();
  
        /// <summary>
        /// Details of the current user.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of the logged in user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserInfoResp</returns>
        ApiResponse<UserInfoResp> GetMyUserWithHttpInfo ();
        
        /// <summary>
        /// Update API key details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating API key details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be updated.</param>
        /// <param name="body">New API key attributes to be stored.</param>
        /// <returns>ApiKeyInfoResp</returns>
        ApiKeyInfoResp UpdateApiKey (string apiKey, ApiKeyInfoReq body);
  
        /// <summary>
        /// Update API key details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating API key details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be updated.</param>
        /// <param name="body">New API key attributes to be stored.</param>
        /// <returns>ApiResponse of ApiKeyInfoResp</returns>
        ApiResponse<ApiKeyInfoResp> UpdateApiKeyWithHttpInfo (string apiKey, ApiKeyInfoReq body);
        
        /// <summary>
        /// Update user details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating the details of the logged in user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New attributes for the logged in user.</param>
        /// <returns>UserInfoResp</returns>
        UserInfoResp UpdateMyUser (UserInfoReq body);
  
        /// <summary>
        /// Update user details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating the details of the logged in user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New attributes for the logged in user.</param>
        /// <returns>ApiResponse of UserInfoResp</returns>
        ApiResponse<UserInfoResp> UpdateMyUserWithHttpInfo (UserInfoReq body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a new API key.
        /// </summary>
        /// <remarks>
        /// Endpoint for creating the new API key.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The details of the API key to be created.</param>
        /// <returns>Task of ApiKeyInfoResp</returns>
        System.Threading.Tasks.Task<ApiKeyInfoResp> CreateApiKeyAsync (ApiKeyInfoReq body);

        /// <summary>
        /// Create a new API key.
        /// </summary>
        /// <remarks>
        /// Endpoint for creating the new API key.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The details of the API key to be created.</param>
        /// <returns>Task of ApiResponse (ApiKeyInfoResp)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiKeyInfoResp>> CreateApiKeyAsyncWithHttpInfo (ApiKeyInfoReq body);
        
        /// <summary>
        /// Delete API key.
        /// </summary>
        /// <remarks>
        /// Endpoint for deleting the API key.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteApiKeyAsync (string apiKey);

        /// <summary>
        /// Delete API key.
        /// </summary>
        /// <remarks>
        /// Endpoint for deleting the API key.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteApiKeyAsyncWithHttpInfo (string apiKey);
        
        /// <summary>
        /// Get all API keys
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving API keys in an array, optionally filtered by the owner.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Owner name filter. (optional)</param>
        /// <returns>Task of ApiKeyInfoRespList</returns>
        System.Threading.Tasks.Task<ApiKeyInfoRespList> GetAllApiKeysAsync (string owner = null);

        /// <summary>
        /// Get all API keys
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving API keys in an array, optionally filtered by the owner.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Owner name filter. (optional)</param>
        /// <returns>Task of ApiResponse (ApiKeyInfoRespList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiKeyInfoRespList>> GetAllApiKeysAsyncWithHttpInfo (string owner = null);
        
        /// <summary>
        /// Get all group information.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving all group information.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GroupSummaryList</returns>
        System.Threading.Tasks.Task<GroupSummaryList> GetAllGroupsAsync ();

        /// <summary>
        /// Get all group information.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving all group information.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GroupSummaryList)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupSummaryList>> GetAllGroupsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get API key details.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving API key details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be retrieved.</param>
        /// <returns>Task of ApiKeyInfoResp</returns>
        System.Threading.Tasks.Task<ApiKeyInfoResp> GetApiKeyAsync (string apiKey);

        /// <summary>
        /// Get API key details.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving API key details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be retrieved.</param>
        /// <returns>Task of ApiResponse (ApiKeyInfoResp)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiKeyInfoResp>> GetApiKeyAsyncWithHttpInfo (string apiKey);
        
        /// <summary>
        /// Get account info.
        /// </summary>
        /// <remarks>
        /// Returns detailed information about the account.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AccountInfo</returns>
        System.Threading.Tasks.Task<AccountInfo> GetMyAccountInfoAsync ();

        /// <summary>
        /// Get account info.
        /// </summary>
        /// <remarks>
        /// Returns detailed information about the account.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AccountInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountInfo>> GetMyAccountInfoAsyncWithHttpInfo ();
        
        /// <summary>
        /// Details of the current user.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of the logged in user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserInfoResp</returns>
        System.Threading.Tasks.Task<UserInfoResp> GetMyUserAsync ();

        /// <summary>
        /// Details of the current user.
        /// </summary>
        /// <remarks>
        /// Endpoint for retrieving the details of the logged in user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> GetMyUserAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update API key details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating API key details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be updated.</param>
        /// <param name="body">New API key attributes to be stored.</param>
        /// <returns>Task of ApiKeyInfoResp</returns>
        System.Threading.Tasks.Task<ApiKeyInfoResp> UpdateApiKeyAsync (string apiKey, ApiKeyInfoReq body);

        /// <summary>
        /// Update API key details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating API key details.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be updated.</param>
        /// <param name="body">New API key attributes to be stored.</param>
        /// <returns>Task of ApiResponse (ApiKeyInfoResp)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiKeyInfoResp>> UpdateApiKeyAsyncWithHttpInfo (string apiKey, ApiKeyInfoReq body);
        
        /// <summary>
        /// Update user details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating the details of the logged in user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New attributes for the logged in user.</param>
        /// <returns>Task of UserInfoResp</returns>
        System.Threading.Tasks.Task<UserInfoResp> UpdateMyUserAsync (UserInfoReq body);

        /// <summary>
        /// Update user details.
        /// </summary>
        /// <remarks>
        /// Endpoint for updating the details of the logged in user.
        /// </remarks>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New attributes for the logged in user.</param>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> UpdateMyUserAsyncWithHttpInfo (UserInfoReq body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DeveloperApi : IDeveloperApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeveloperApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeveloperApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Create a new API key. Endpoint for creating the new API key.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The details of the API key to be created.</param> 
        /// <returns>ApiKeyInfoResp</returns>
        public ApiKeyInfoResp CreateApiKey (ApiKeyInfoReq body)
        {
             ApiResponse<ApiKeyInfoResp> localVarResponse = CreateApiKeyWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new API key. Endpoint for creating the new API key.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The details of the API key to be created.</param> 
        /// <returns>ApiResponse of ApiKeyInfoResp</returns>
        public ApiResponse< ApiKeyInfoResp > CreateApiKeyWithHttpInfo (ApiKeyInfoReq body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DeveloperApi->CreateApiKey");
            
    
            var localVarPath = "/v3/api-keys";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ApiKeyInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiKeyInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyInfoResp)));
            
        }

        
        /// <summary>
        /// Create a new API key. Endpoint for creating the new API key.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The details of the API key to be created.</param>
        /// <returns>Task of ApiKeyInfoResp</returns>
        public async System.Threading.Tasks.Task<ApiKeyInfoResp> CreateApiKeyAsync (ApiKeyInfoReq body)
        {
             ApiResponse<ApiKeyInfoResp> localVarResponse = await CreateApiKeyAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new API key. Endpoint for creating the new API key.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The details of the API key to be created.</param>
        /// <returns>Task of ApiResponse (ApiKeyInfoResp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiKeyInfoResp>> CreateApiKeyAsyncWithHttpInfo (ApiKeyInfoReq body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateApiKey");
            
    
            var localVarPath = "/v3/api-keys";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiKeyInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiKeyInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyInfoResp)));
            
        }
        
        /// <summary>
        /// Delete API key. Endpoint for deleting the API key.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be deleted.</param> 
        /// <returns></returns>
        public void DeleteApiKey (string apiKey)
        {
             DeleteApiKeyWithHttpInfo(apiKey);
        }

        /// <summary>
        /// Delete API key. Endpoint for deleting the API key.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteApiKeyWithHttpInfo (string apiKey)
        {
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling DeveloperApi->DeleteApiKey");
            
    
            var localVarPath = "/v3/api-keys/{apiKey}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (apiKey != null) localVarPathParams.Add("apiKey", Configuration.ApiClient.ParameterToString(apiKey)); // path parameter
            
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete API key. Endpoint for deleting the API key.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteApiKeyAsync (string apiKey)
        {
             await DeleteApiKeyAsyncWithHttpInfo(apiKey);

        }

        /// <summary>
        /// Delete API key. Endpoint for deleting the API key.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteApiKeyAsyncWithHttpInfo (string apiKey)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling DeleteApiKey");
            
    
            var localVarPath = "/v3/api-keys/{apiKey}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (apiKey != null) localVarPathParams.Add("apiKey", Configuration.ApiClient.ParameterToString(apiKey)); // path parameter
            
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get all API keys Endpoint for retrieving API keys in an array, optionally filtered by the owner.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Owner name filter. (optional)</param> 
        /// <returns>ApiKeyInfoRespList</returns>
        public ApiKeyInfoRespList GetAllApiKeys (string owner = null)
        {
             ApiResponse<ApiKeyInfoRespList> localVarResponse = GetAllApiKeysWithHttpInfo(owner);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all API keys Endpoint for retrieving API keys in an array, optionally filtered by the owner.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Owner name filter. (optional)</param> 
        /// <returns>ApiResponse of ApiKeyInfoRespList</returns>
        public ApiResponse< ApiKeyInfoRespList > GetAllApiKeysWithHttpInfo (string owner = null)
        {
            
    
            var localVarPath = "/v3/api-keys";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (owner != null) localVarQueryParams.Add("owner", Configuration.ApiClient.ParameterToString(owner)); // query parameter
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAllApiKeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllApiKeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ApiKeyInfoRespList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiKeyInfoRespList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyInfoRespList)));
            
        }

        
        /// <summary>
        /// Get all API keys Endpoint for retrieving API keys in an array, optionally filtered by the owner.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Owner name filter. (optional)</param>
        /// <returns>Task of ApiKeyInfoRespList</returns>
        public async System.Threading.Tasks.Task<ApiKeyInfoRespList> GetAllApiKeysAsync (string owner = null)
        {
             ApiResponse<ApiKeyInfoRespList> localVarResponse = await GetAllApiKeysAsyncWithHttpInfo(owner);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all API keys Endpoint for retrieving API keys in an array, optionally filtered by the owner.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Owner name filter. (optional)</param>
        /// <returns>Task of ApiResponse (ApiKeyInfoRespList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiKeyInfoRespList>> GetAllApiKeysAsyncWithHttpInfo (string owner = null)
        {
            
    
            var localVarPath = "/v3/api-keys";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (owner != null) localVarQueryParams.Add("owner", Configuration.ApiClient.ParameterToString(owner)); // query parameter
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAllApiKeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllApiKeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiKeyInfoRespList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiKeyInfoRespList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyInfoRespList)));
            
        }
        
        /// <summary>
        /// Get all group information. Endpoint for retrieving all group information.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GroupSummaryList</returns>
        public GroupSummaryList GetAllGroups ()
        {
             ApiResponse<GroupSummaryList> localVarResponse = GetAllGroupsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all group information. Endpoint for retrieving all group information.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GroupSummaryList</returns>
        public ApiResponse< GroupSummaryList > GetAllGroupsWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/policy-groups";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAllGroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<GroupSummaryList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupSummaryList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupSummaryList)));
            
        }

        
        /// <summary>
        /// Get all group information. Endpoint for retrieving all group information.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GroupSummaryList</returns>
        public async System.Threading.Tasks.Task<GroupSummaryList> GetAllGroupsAsync ()
        {
             ApiResponse<GroupSummaryList> localVarResponse = await GetAllGroupsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all group information. Endpoint for retrieving all group information.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GroupSummaryList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GroupSummaryList>> GetAllGroupsAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/policy-groups";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAllGroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GroupSummaryList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupSummaryList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupSummaryList)));
            
        }
        
        /// <summary>
        /// Get API key details. Endpoint for retrieving API key details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be retrieved.</param> 
        /// <returns>ApiKeyInfoResp</returns>
        public ApiKeyInfoResp GetApiKey (string apiKey)
        {
             ApiResponse<ApiKeyInfoResp> localVarResponse = GetApiKeyWithHttpInfo(apiKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get API key details. Endpoint for retrieving API key details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be retrieved.</param> 
        /// <returns>ApiResponse of ApiKeyInfoResp</returns>
        public ApiResponse< ApiKeyInfoResp > GetApiKeyWithHttpInfo (string apiKey)
        {
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling DeveloperApi->GetApiKey");
            
    
            var localVarPath = "/v3/api-keys/{apiKey}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (apiKey != null) localVarPathParams.Add("apiKey", Configuration.ApiClient.ParameterToString(apiKey)); // path parameter
            
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ApiKeyInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiKeyInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyInfoResp)));
            
        }

        
        /// <summary>
        /// Get API key details. Endpoint for retrieving API key details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be retrieved.</param>
        /// <returns>Task of ApiKeyInfoResp</returns>
        public async System.Threading.Tasks.Task<ApiKeyInfoResp> GetApiKeyAsync (string apiKey)
        {
             ApiResponse<ApiKeyInfoResp> localVarResponse = await GetApiKeyAsyncWithHttpInfo(apiKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get API key details. Endpoint for retrieving API key details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be retrieved.</param>
        /// <returns>Task of ApiResponse (ApiKeyInfoResp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiKeyInfoResp>> GetApiKeyAsyncWithHttpInfo (string apiKey)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling GetApiKey");
            
    
            var localVarPath = "/v3/api-keys/{apiKey}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (apiKey != null) localVarPathParams.Add("apiKey", Configuration.ApiClient.ParameterToString(apiKey)); // path parameter
            
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiKeyInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiKeyInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyInfoResp)));
            
        }
        
        /// <summary>
        /// Get account info. Returns detailed information about the account.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AccountInfo</returns>
        public AccountInfo GetMyAccountInfo ()
        {
             ApiResponse<AccountInfo> localVarResponse = GetMyAccountInfoWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get account info. Returns detailed information about the account.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AccountInfo</returns>
        public ApiResponse< AccountInfo > GetMyAccountInfoWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/accounts/me";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMyAccountInfo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMyAccountInfo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AccountInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountInfo)));
            
        }

        
        /// <summary>
        /// Get account info. Returns detailed information about the account.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AccountInfo</returns>
        public async System.Threading.Tasks.Task<AccountInfo> GetMyAccountInfoAsync ()
        {
             ApiResponse<AccountInfo> localVarResponse = await GetMyAccountInfoAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get account info. Returns detailed information about the account.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AccountInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountInfo>> GetMyAccountInfoAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/accounts/me";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMyAccountInfo: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMyAccountInfo: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AccountInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountInfo)));
            
        }
        
        /// <summary>
        /// Details of the current user. Endpoint for retrieving the details of the logged in user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserInfoResp</returns>
        public UserInfoResp GetMyUser ()
        {
             ApiResponse<UserInfoResp> localVarResponse = GetMyUserWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Details of the current user. Endpoint for retrieving the details of the logged in user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserInfoResp</returns>
        public ApiResponse< UserInfoResp > GetMyUserWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/users/me";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMyUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMyUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }

        
        /// <summary>
        /// Details of the current user. Endpoint for retrieving the details of the logged in user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserInfoResp</returns>
        public async System.Threading.Tasks.Task<UserInfoResp> GetMyUserAsync ()
        {
             ApiResponse<UserInfoResp> localVarResponse = await GetMyUserAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Details of the current user. Endpoint for retrieving the details of the logged in user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> GetMyUserAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/users/me";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMyUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMyUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }
        
        /// <summary>
        /// Update API key details. Endpoint for updating API key details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be updated.</param> 
        /// <param name="body">New API key attributes to be stored.</param> 
        /// <returns>ApiKeyInfoResp</returns>
        public ApiKeyInfoResp UpdateApiKey (string apiKey, ApiKeyInfoReq body)
        {
             ApiResponse<ApiKeyInfoResp> localVarResponse = UpdateApiKeyWithHttpInfo(apiKey, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update API key details. Endpoint for updating API key details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be updated.</param> 
        /// <param name="body">New API key attributes to be stored.</param> 
        /// <returns>ApiResponse of ApiKeyInfoResp</returns>
        public ApiResponse< ApiKeyInfoResp > UpdateApiKeyWithHttpInfo (string apiKey, ApiKeyInfoReq body)
        {
            
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling DeveloperApi->UpdateApiKey");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DeveloperApi->UpdateApiKey");
            
    
            var localVarPath = "/v3/api-keys/{apiKey}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (apiKey != null) localVarPathParams.Add("apiKey", Configuration.ApiClient.ParameterToString(apiKey)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ApiKeyInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiKeyInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyInfoResp)));
            
        }

        
        /// <summary>
        /// Update API key details. Endpoint for updating API key details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be updated.</param>
        /// <param name="body">New API key attributes to be stored.</param>
        /// <returns>Task of ApiKeyInfoResp</returns>
        public async System.Threading.Tasks.Task<ApiKeyInfoResp> UpdateApiKeyAsync (string apiKey, ApiKeyInfoReq body)
        {
             ApiResponse<ApiKeyInfoResp> localVarResponse = await UpdateApiKeyAsyncWithHttpInfo(apiKey, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update API key details. Endpoint for updating API key details.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">The ID of the API key to be updated.</param>
        /// <param name="body">New API key attributes to be stored.</param>
        /// <returns>Task of ApiResponse (ApiKeyInfoResp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiKeyInfoResp>> UpdateApiKeyAsyncWithHttpInfo (string apiKey, ApiKeyInfoReq body)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null) throw new ApiException(400, "Missing required parameter 'apiKey' when calling UpdateApiKey");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateApiKey");
            
    
            var localVarPath = "/v3/api-keys/{apiKey}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (apiKey != null) localVarPathParams.Add("apiKey", Configuration.ApiClient.ParameterToString(apiKey)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiKeyInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiKeyInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiKeyInfoResp)));
            
        }
        
        /// <summary>
        /// Update user details. Endpoint for updating the details of the logged in user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New attributes for the logged in user.</param> 
        /// <returns>UserInfoResp</returns>
        public UserInfoResp UpdateMyUser (UserInfoReq body)
        {
             ApiResponse<UserInfoResp> localVarResponse = UpdateMyUserWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update user details. Endpoint for updating the details of the logged in user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New attributes for the logged in user.</param> 
        /// <returns>ApiResponse of UserInfoResp</returns>
        public ApiResponse< UserInfoResp > UpdateMyUserWithHttpInfo (UserInfoReq body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DeveloperApi->UpdateMyUser");
            
    
            var localVarPath = "/v3/users/me";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateMyUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateMyUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }

        
        /// <summary>
        /// Update user details. Endpoint for updating the details of the logged in user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New attributes for the logged in user.</param>
        /// <returns>Task of UserInfoResp</returns>
        public async System.Threading.Tasks.Task<UserInfoResp> UpdateMyUserAsync (UserInfoReq body)
        {
             ApiResponse<UserInfoResp> localVarResponse = await UpdateMyUserAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update user details. Endpoint for updating the details of the logged in user.
        /// </summary>
        /// <exception cref="iam.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New attributes for the logged in user.</param>
        /// <returns>Task of ApiResponse (UserInfoResp)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserInfoResp>> UpdateMyUserAsyncWithHttpInfo (UserInfoReq body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMyUser");
            
    
            var localVarPath = "/v3/users/me";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateMyUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateMyUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserInfoResp>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserInfoResp) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserInfoResp)));
            
        }
        
    }
    
}
