/* 
 * <auto-generated>
 * Connect CA API
 *
 * Connect CA API provides methods to create and get Developer certificate. Also Connect CA provides server-credentials for Bootstarp and LWM2M Server.
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * </auto-generated>
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using connector_ca.Client;
using connector_ca.Model;

namespace connector_ca.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeveloperCertificateApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch an existing developer certificate to connect to the bootstrap server.
        /// </summary>
        /// <remarks>
        /// This REST API is intended to be used by customers to fetch an existing developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server). 
        /// </remarks>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muuid">A unique identifier for the developer certificate. </param>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <returns>DeveloperCertificateResponseData</returns>
        DeveloperCertificateResponseData V3DeveloperCertificatesMuuidGet (string muuid, string authorization);

        /// <summary>
        /// Fetch an existing developer certificate to connect to the bootstrap server.
        /// </summary>
        /// <remarks>
        /// This REST API is intended to be used by customers to fetch an existing developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server). 
        /// </remarks>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muuid">A unique identifier for the developer certificate. </param>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <returns>ApiResponse of DeveloperCertificateResponseData</returns>
        ApiResponse<DeveloperCertificateResponseData> V3DeveloperCertificatesMuuidGetWithHttpInfo (string muuid, string authorization);
        /// <summary>
        /// Create a new developer certificate to connect to the bootstrap server.
        /// </summary>
        /// <remarks>
        /// This REST API is intended to be used by customers to get a developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server).  Limitations:    - One developer certificate allows up to 100 devices to connect to bootstrap server.   - Only 10 developer certificates are allowed per account. 
        /// </remarks>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <param name="body"></param>
        /// <returns>DeveloperCertificateResponseData</returns>
        DeveloperCertificateResponseData V3DeveloperCertificatesPost (string authorization, DeveloperCertificateRequestData body);

        /// <summary>
        /// Create a new developer certificate to connect to the bootstrap server.
        /// </summary>
        /// <remarks>
        /// This REST API is intended to be used by customers to get a developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server).  Limitations:    - One developer certificate allows up to 100 devices to connect to bootstrap server.   - Only 10 developer certificates are allowed per account. 
        /// </remarks>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DeveloperCertificateResponseData</returns>
        ApiResponse<DeveloperCertificateResponseData> V3DeveloperCertificatesPostWithHttpInfo (string authorization, DeveloperCertificateRequestData body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Fetch an existing developer certificate to connect to the bootstrap server.
        /// </summary>
        /// <remarks>
        /// This REST API is intended to be used by customers to fetch an existing developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server). 
        /// </remarks>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muuid">A unique identifier for the developer certificate. </param>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <returns>Task of DeveloperCertificateResponseData</returns>
        System.Threading.Tasks.Task<DeveloperCertificateResponseData> V3DeveloperCertificatesMuuidGetAsync (string muuid, string authorization);

        /// <summary>
        /// Fetch an existing developer certificate to connect to the bootstrap server.
        /// </summary>
        /// <remarks>
        /// This REST API is intended to be used by customers to fetch an existing developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server). 
        /// </remarks>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muuid">A unique identifier for the developer certificate. </param>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <returns>Task of ApiResponse (DeveloperCertificateResponseData)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeveloperCertificateResponseData>> V3DeveloperCertificatesMuuidGetAsyncWithHttpInfo (string muuid, string authorization);
        /// <summary>
        /// Create a new developer certificate to connect to the bootstrap server.
        /// </summary>
        /// <remarks>
        /// This REST API is intended to be used by customers to get a developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server).  Limitations:    - One developer certificate allows up to 100 devices to connect to bootstrap server.   - Only 10 developer certificates are allowed per account. 
        /// </remarks>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <param name="body"></param>
        /// <returns>Task of DeveloperCertificateResponseData</returns>
        System.Threading.Tasks.Task<DeveloperCertificateResponseData> V3DeveloperCertificatesPostAsync (string authorization, DeveloperCertificateRequestData body);

        /// <summary>
        /// Create a new developer certificate to connect to the bootstrap server.
        /// </summary>
        /// <remarks>
        /// This REST API is intended to be used by customers to get a developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server).  Limitations:    - One developer certificate allows up to 100 devices to connect to bootstrap server.   - Only 10 developer certificates are allowed per account. 
        /// </remarks>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DeveloperCertificateResponseData)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeveloperCertificateResponseData>> V3DeveloperCertificatesPostAsyncWithHttpInfo (string authorization, DeveloperCertificateRequestData body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeveloperCertificateApi : IDeveloperCertificateApi
    {
        private connector_ca.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperCertificateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeveloperCertificateApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = connector_ca.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperCertificateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeveloperCertificateApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = connector_ca.Client.Configuration.DefaultExceptionFactory;
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public connector_ca.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Fetch an existing developer certificate to connect to the bootstrap server. This REST API is intended to be used by customers to fetch an existing developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server). 
        /// </summary>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muuid">A unique identifier for the developer certificate. </param>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <returns>DeveloperCertificateResponseData</returns>
        public DeveloperCertificateResponseData V3DeveloperCertificatesMuuidGet (string muuid, string authorization)
        {
             ApiResponse<DeveloperCertificateResponseData> localVarResponse = V3DeveloperCertificatesMuuidGetWithHttpInfo(muuid, authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch an existing developer certificate to connect to the bootstrap server. This REST API is intended to be used by customers to fetch an existing developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server). 
        /// </summary>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muuid">A unique identifier for the developer certificate. </param>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <returns>ApiResponse of DeveloperCertificateResponseData</returns>
        public ApiResponse< DeveloperCertificateResponseData > V3DeveloperCertificatesMuuidGetWithHttpInfo (string muuid, string authorization)
        {
            // verify the required parameter 'muuid' is set
            if (muuid == null)
                throw new ApiException(400, "Missing required parameter 'muuid' when calling DeveloperCertificateApi->V3DeveloperCertificatesMuuidGet");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling DeveloperCertificateApi->V3DeveloperCertificatesMuuidGet");

            var localVarPath = "/v3/developer-certificates/{muuid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (muuid != null) localVarPathParams.Add("muuid", Configuration.ApiClient.ParameterToString(muuid)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter

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

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V3DeveloperCertificatesMuuidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeveloperCertificateResponseData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeveloperCertificateResponseData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeveloperCertificateResponseData)));
        }

        /// <summary>
        /// Fetch an existing developer certificate to connect to the bootstrap server. This REST API is intended to be used by customers to fetch an existing developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server). 
        /// </summary>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muuid">A unique identifier for the developer certificate. </param>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <returns>Task of DeveloperCertificateResponseData</returns>
        public async System.Threading.Tasks.Task<DeveloperCertificateResponseData> V3DeveloperCertificatesMuuidGetAsync (string muuid, string authorization)
        {
             ApiResponse<DeveloperCertificateResponseData> localVarResponse = await V3DeveloperCertificatesMuuidGetAsyncWithHttpInfo(muuid, authorization);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch an existing developer certificate to connect to the bootstrap server. This REST API is intended to be used by customers to fetch an existing developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server). 
        /// </summary>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="muuid">A unique identifier for the developer certificate. </param>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <returns>Task of ApiResponse (DeveloperCertificateResponseData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeveloperCertificateResponseData>> V3DeveloperCertificatesMuuidGetAsyncWithHttpInfo (string muuid, string authorization)
        {
            // verify the required parameter 'muuid' is set
            if (muuid == null)
                throw new ApiException(400, "Missing required parameter 'muuid' when calling DeveloperCertificateApi->V3DeveloperCertificatesMuuidGet");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling DeveloperCertificateApi->V3DeveloperCertificatesMuuidGet");

            var localVarPath = "/v3/developer-certificates/{muuid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (muuid != null) localVarPathParams.Add("muuid", Configuration.ApiClient.ParameterToString(muuid)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter

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

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V3DeveloperCertificatesMuuidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeveloperCertificateResponseData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeveloperCertificateResponseData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeveloperCertificateResponseData)));
        }

        /// <summary>
        /// Create a new developer certificate to connect to the bootstrap server. This REST API is intended to be used by customers to get a developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server).  Limitations:    - One developer certificate allows up to 100 devices to connect to bootstrap server.   - Only 10 developer certificates are allowed per account. 
        /// </summary>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <param name="body"></param>
        /// <returns>DeveloperCertificateResponseData</returns>
        public DeveloperCertificateResponseData V3DeveloperCertificatesPost (string authorization, DeveloperCertificateRequestData body)
        {
             ApiResponse<DeveloperCertificateResponseData> localVarResponse = V3DeveloperCertificatesPostWithHttpInfo(authorization, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new developer certificate to connect to the bootstrap server. This REST API is intended to be used by customers to get a developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server).  Limitations:    - One developer certificate allows up to 100 devices to connect to bootstrap server.   - Only 10 developer certificates are allowed per account. 
        /// </summary>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DeveloperCertificateResponseData</returns>
        public ApiResponse< DeveloperCertificateResponseData > V3DeveloperCertificatesPostWithHttpInfo (string authorization, DeveloperCertificateRequestData body)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling DeveloperCertificateApi->V3DeveloperCertificatesPost");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DeveloperCertificateApi->V3DeveloperCertificatesPost");

            var localVarPath = "/v3/developer-certificates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
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

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V3DeveloperCertificatesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeveloperCertificateResponseData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeveloperCertificateResponseData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeveloperCertificateResponseData)));
        }

        /// <summary>
        /// Create a new developer certificate to connect to the bootstrap server. This REST API is intended to be used by customers to get a developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server).  Limitations:    - One developer certificate allows up to 100 devices to connect to bootstrap server.   - Only 10 developer certificates are allowed per account. 
        /// </summary>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <param name="body"></param>
        /// <returns>Task of DeveloperCertificateResponseData</returns>
        public async System.Threading.Tasks.Task<DeveloperCertificateResponseData> V3DeveloperCertificatesPostAsync (string authorization, DeveloperCertificateRequestData body)
        {
             ApiResponse<DeveloperCertificateResponseData> localVarResponse = await V3DeveloperCertificatesPostAsyncWithHttpInfo(authorization, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new developer certificate to connect to the bootstrap server. This REST API is intended to be used by customers to get a developer certificate (a certificate that can be flashed into multiple devices to connect to bootstrap server).  Limitations:    - One developer certificate allows up to 100 devices to connect to bootstrap server.   - Only 10 developer certificates are allowed per account. 
        /// </summary>
        /// <exception cref="connector_ca.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">Bearer {Access Token}. </param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DeveloperCertificateResponseData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeveloperCertificateResponseData>> V3DeveloperCertificatesPostAsyncWithHttpInfo (string authorization, DeveloperCertificateRequestData body)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling DeveloperCertificateApi->V3DeveloperCertificatesPost");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DeveloperCertificateApi->V3DeveloperCertificatesPost");

            var localVarPath = "/v3/developer-certificates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
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

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V3DeveloperCertificatesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeveloperCertificateResponseData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeveloperCertificateResponseData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeveloperCertificateResponseData)));
        }

    }
}
