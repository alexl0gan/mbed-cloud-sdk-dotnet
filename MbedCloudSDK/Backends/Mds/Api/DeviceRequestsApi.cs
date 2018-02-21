/* 
 * <auto-generated>
 * Connect API
 *
 * Mbed Cloud Connect API allows web applications to communicate with devices. You can subscribe to device resources and read/write values to them. mbed Cloud Connect makes connectivity to devices easy by queuing requests and caching resource values.
 *
 * OpenAPI spec version: 2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * </auto-generated>
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using mds.Client;
using mds.Model;

namespace mds.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeviceRequestsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send an async request to device
        /// </summary>
        /// <remarks>
        /// This API enables you to receive asyncronous responses with asyncId defined by you. Another major difference to the  existing [/v2/endpoints/{device-id}/{resourcePath}](/docs/v1.2/service-api-references/connect-api.html#v2EndpointsDeviceIdResourcePathGet) API is that the data is always provided (also cached resource values) via the [event notification channel](/docs/v1.2/connecting/event-notification.html)  instead of the request response.  This can help you to streamline your application as you can use existing indentifiers as the asyncID. For example, you can use the  web application&#39;s session ID along the device ID combined with the resource path as asyncID. You do not need to have a separate  mapping from asyncID to your application data model. Also as the data is always provided via the event notification channel, you can  implement only one data handling logic for resource read.  The provided async-id is present in the [AsyncIDResponse](/docs/v1.2/service-api-references/connect-api.html#AsyncIDResponse).   &#x60;&#x60;&#x60; Example URI: POST /v2/device-requests/015f2fa34d310000000000010030036c?async-id&#x3D;123e4567-e89b-12d3-a456-426655440000  Example payloads: { \&quot;method\&quot;: \&quot;GET\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1\&quot; } { \&quot;method\&quot;: \&quot;PUT\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1%20?k1&#x3D;v1&amp;k2&#x3D;v2%22\&quot;, \&quot;accept\&quot;: \&quot;text/plain\&quot;, \&quot;content-type\&quot;: \&quot;text/plain\&quot;, \&quot;payload-b64\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot; }  Example notification payload (AsyncIDResponse): { \&quot;async-responses\&quot;: [ { \&quot;id\&quot;: \&quot;123e4567-e89b-12d3-a456-426655440000\&quot;, \&quot;status\&quot;: 200, \&quot;payload\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot;, \&quot;ct\&quot;: \&quot;text/plain\&quot;, \&quot;max-age\&quot;: 600 } ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The device ID generated by Mbed Cloud.</param>
        /// <param name="asyncId">The client-generated ID for matching the correct response delivered via a notification.</param>
        /// <param name="body">Device request to send.</param>
        /// <returns></returns>
        void V2DeviceRequestsDeviceIdPost (string deviceId, string asyncId, DeviceRequest body);

        /// <summary>
        /// Send an async request to device
        /// </summary>
        /// <remarks>
        /// This API enables you to receive asyncronous responses with asyncId defined by you. Another major difference to the  existing [/v2/endpoints/{device-id}/{resourcePath}](/docs/v1.2/service-api-references/connect-api.html#v2EndpointsDeviceIdResourcePathGet) API is that the data is always provided (also cached resource values) via the [event notification channel](/docs/v1.2/connecting/event-notification.html)  instead of the request response.  This can help you to streamline your application as you can use existing indentifiers as the asyncID. For example, you can use the  web application&#39;s session ID along the device ID combined with the resource path as asyncID. You do not need to have a separate  mapping from asyncID to your application data model. Also as the data is always provided via the event notification channel, you can  implement only one data handling logic for resource read.  The provided async-id is present in the [AsyncIDResponse](/docs/v1.2/service-api-references/connect-api.html#AsyncIDResponse).   &#x60;&#x60;&#x60; Example URI: POST /v2/device-requests/015f2fa34d310000000000010030036c?async-id&#x3D;123e4567-e89b-12d3-a456-426655440000  Example payloads: { \&quot;method\&quot;: \&quot;GET\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1\&quot; } { \&quot;method\&quot;: \&quot;PUT\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1%20?k1&#x3D;v1&amp;k2&#x3D;v2%22\&quot;, \&quot;accept\&quot;: \&quot;text/plain\&quot;, \&quot;content-type\&quot;: \&quot;text/plain\&quot;, \&quot;payload-b64\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot; }  Example notification payload (AsyncIDResponse): { \&quot;async-responses\&quot;: [ { \&quot;id\&quot;: \&quot;123e4567-e89b-12d3-a456-426655440000\&quot;, \&quot;status\&quot;: 200, \&quot;payload\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot;, \&quot;ct\&quot;: \&quot;text/plain\&quot;, \&quot;max-age\&quot;: 600 } ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The device ID generated by Mbed Cloud.</param>
        /// <param name="asyncId">The client-generated ID for matching the correct response delivered via a notification.</param>
        /// <param name="body">Device request to send.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V2DeviceRequestsDeviceIdPostWithHttpInfo (string deviceId, string asyncId, DeviceRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Send an async request to device
        /// </summary>
        /// <remarks>
        /// This API enables you to receive asyncronous responses with asyncId defined by you. Another major difference to the  existing [/v2/endpoints/{device-id}/{resourcePath}](/docs/v1.2/service-api-references/connect-api.html#v2EndpointsDeviceIdResourcePathGet) API is that the data is always provided (also cached resource values) via the [event notification channel](/docs/v1.2/connecting/event-notification.html)  instead of the request response.  This can help you to streamline your application as you can use existing indentifiers as the asyncID. For example, you can use the  web application&#39;s session ID along the device ID combined with the resource path as asyncID. You do not need to have a separate  mapping from asyncID to your application data model. Also as the data is always provided via the event notification channel, you can  implement only one data handling logic for resource read.  The provided async-id is present in the [AsyncIDResponse](/docs/v1.2/service-api-references/connect-api.html#AsyncIDResponse).   &#x60;&#x60;&#x60; Example URI: POST /v2/device-requests/015f2fa34d310000000000010030036c?async-id&#x3D;123e4567-e89b-12d3-a456-426655440000  Example payloads: { \&quot;method\&quot;: \&quot;GET\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1\&quot; } { \&quot;method\&quot;: \&quot;PUT\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1%20?k1&#x3D;v1&amp;k2&#x3D;v2%22\&quot;, \&quot;accept\&quot;: \&quot;text/plain\&quot;, \&quot;content-type\&quot;: \&quot;text/plain\&quot;, \&quot;payload-b64\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot; }  Example notification payload (AsyncIDResponse): { \&quot;async-responses\&quot;: [ { \&quot;id\&quot;: \&quot;123e4567-e89b-12d3-a456-426655440000\&quot;, \&quot;status\&quot;: 200, \&quot;payload\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot;, \&quot;ct\&quot;: \&quot;text/plain\&quot;, \&quot;max-age\&quot;: 600 } ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The device ID generated by Mbed Cloud.</param>
        /// <param name="asyncId">The client-generated ID for matching the correct response delivered via a notification.</param>
        /// <param name="body">Device request to send.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V2DeviceRequestsDeviceIdPostAsync (string deviceId, string asyncId, DeviceRequest body);

        /// <summary>
        /// Send an async request to device
        /// </summary>
        /// <remarks>
        /// This API enables you to receive asyncronous responses with asyncId defined by you. Another major difference to the  existing [/v2/endpoints/{device-id}/{resourcePath}](/docs/v1.2/service-api-references/connect-api.html#v2EndpointsDeviceIdResourcePathGet) API is that the data is always provided (also cached resource values) via the [event notification channel](/docs/v1.2/connecting/event-notification.html)  instead of the request response.  This can help you to streamline your application as you can use existing indentifiers as the asyncID. For example, you can use the  web application&#39;s session ID along the device ID combined with the resource path as asyncID. You do not need to have a separate  mapping from asyncID to your application data model. Also as the data is always provided via the event notification channel, you can  implement only one data handling logic for resource read.  The provided async-id is present in the [AsyncIDResponse](/docs/v1.2/service-api-references/connect-api.html#AsyncIDResponse).   &#x60;&#x60;&#x60; Example URI: POST /v2/device-requests/015f2fa34d310000000000010030036c?async-id&#x3D;123e4567-e89b-12d3-a456-426655440000  Example payloads: { \&quot;method\&quot;: \&quot;GET\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1\&quot; } { \&quot;method\&quot;: \&quot;PUT\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1%20?k1&#x3D;v1&amp;k2&#x3D;v2%22\&quot;, \&quot;accept\&quot;: \&quot;text/plain\&quot;, \&quot;content-type\&quot;: \&quot;text/plain\&quot;, \&quot;payload-b64\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot; }  Example notification payload (AsyncIDResponse): { \&quot;async-responses\&quot;: [ { \&quot;id\&quot;: \&quot;123e4567-e89b-12d3-a456-426655440000\&quot;, \&quot;status\&quot;: 200, \&quot;payload\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot;, \&quot;ct\&quot;: \&quot;text/plain\&quot;, \&quot;max-age\&quot;: 600 } ] } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The device ID generated by Mbed Cloud.</param>
        /// <param name="asyncId">The client-generated ID for matching the correct response delivered via a notification.</param>
        /// <param name="body">Device request to send.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V2DeviceRequestsDeviceIdPostAsyncWithHttpInfo (string deviceId, string asyncId, DeviceRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeviceRequestsApi : IDeviceRequestsApi
    {
        private mds.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRequestsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeviceRequestsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = mds.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRequestsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeviceRequestsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = mds.Client.Configuration.DefaultExceptionFactory;
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
        public mds.Client.ExceptionFactory ExceptionFactory
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
        /// Send an async request to device This API enables you to receive asyncronous responses with asyncId defined by you. Another major difference to the  existing [/v2/endpoints/{device-id}/{resourcePath}](/docs/v1.2/service-api-references/connect-api.html#v2EndpointsDeviceIdResourcePathGet) API is that the data is always provided (also cached resource values) via the [event notification channel](/docs/v1.2/connecting/event-notification.html)  instead of the request response.  This can help you to streamline your application as you can use existing indentifiers as the asyncID. For example, you can use the  web application&#39;s session ID along the device ID combined with the resource path as asyncID. You do not need to have a separate  mapping from asyncID to your application data model. Also as the data is always provided via the event notification channel, you can  implement only one data handling logic for resource read.  The provided async-id is present in the [AsyncIDResponse](/docs/v1.2/service-api-references/connect-api.html#AsyncIDResponse).   &#x60;&#x60;&#x60; Example URI: POST /v2/device-requests/015f2fa34d310000000000010030036c?async-id&#x3D;123e4567-e89b-12d3-a456-426655440000  Example payloads: { \&quot;method\&quot;: \&quot;GET\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1\&quot; } { \&quot;method\&quot;: \&quot;PUT\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1%20?k1&#x3D;v1&amp;k2&#x3D;v2%22\&quot;, \&quot;accept\&quot;: \&quot;text/plain\&quot;, \&quot;content-type\&quot;: \&quot;text/plain\&quot;, \&quot;payload-b64\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot; }  Example notification payload (AsyncIDResponse): { \&quot;async-responses\&quot;: [ { \&quot;id\&quot;: \&quot;123e4567-e89b-12d3-a456-426655440000\&quot;, \&quot;status\&quot;: 200, \&quot;payload\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot;, \&quot;ct\&quot;: \&quot;text/plain\&quot;, \&quot;max-age\&quot;: 600 } ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The device ID generated by Mbed Cloud.</param>
        /// <param name="asyncId">The client-generated ID for matching the correct response delivered via a notification.</param>
        /// <param name="body">Device request to send.</param>
        /// <returns></returns>
        public void V2DeviceRequestsDeviceIdPost (string deviceId, string asyncId, DeviceRequest body)
        {
             V2DeviceRequestsDeviceIdPostWithHttpInfo(deviceId, asyncId, body);
        }

        /// <summary>
        /// Send an async request to device This API enables you to receive asyncronous responses with asyncId defined by you. Another major difference to the  existing [/v2/endpoints/{device-id}/{resourcePath}](/docs/v1.2/service-api-references/connect-api.html#v2EndpointsDeviceIdResourcePathGet) API is that the data is always provided (also cached resource values) via the [event notification channel](/docs/v1.2/connecting/event-notification.html)  instead of the request response.  This can help you to streamline your application as you can use existing indentifiers as the asyncID. For example, you can use the  web application&#39;s session ID along the device ID combined with the resource path as asyncID. You do not need to have a separate  mapping from asyncID to your application data model. Also as the data is always provided via the event notification channel, you can  implement only one data handling logic for resource read.  The provided async-id is present in the [AsyncIDResponse](/docs/v1.2/service-api-references/connect-api.html#AsyncIDResponse).   &#x60;&#x60;&#x60; Example URI: POST /v2/device-requests/015f2fa34d310000000000010030036c?async-id&#x3D;123e4567-e89b-12d3-a456-426655440000  Example payloads: { \&quot;method\&quot;: \&quot;GET\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1\&quot; } { \&quot;method\&quot;: \&quot;PUT\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1%20?k1&#x3D;v1&amp;k2&#x3D;v2%22\&quot;, \&quot;accept\&quot;: \&quot;text/plain\&quot;, \&quot;content-type\&quot;: \&quot;text/plain\&quot;, \&quot;payload-b64\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot; }  Example notification payload (AsyncIDResponse): { \&quot;async-responses\&quot;: [ { \&quot;id\&quot;: \&quot;123e4567-e89b-12d3-a456-426655440000\&quot;, \&quot;status\&quot;: 200, \&quot;payload\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot;, \&quot;ct\&quot;: \&quot;text/plain\&quot;, \&quot;max-age\&quot;: 600 } ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The device ID generated by Mbed Cloud.</param>
        /// <param name="asyncId">The client-generated ID for matching the correct response delivered via a notification.</param>
        /// <param name="body">Device request to send.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V2DeviceRequestsDeviceIdPostWithHttpInfo (string deviceId, string asyncId, DeviceRequest body)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DeviceRequestsApi->V2DeviceRequestsDeviceIdPost");
            // verify the required parameter 'asyncId' is set
            if (asyncId == null)
                throw new ApiException(400, "Missing required parameter 'asyncId' when calling DeviceRequestsApi->V2DeviceRequestsDeviceIdPost");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DeviceRequestsApi->V2DeviceRequestsDeviceIdPost");

            var localVarPath = "/v2/device-requests/{deviceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            if (asyncId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "asyncId", asyncId)); // query parameter
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
                Exception exception = ExceptionFactory("V2DeviceRequestsDeviceIdPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Send an async request to device This API enables you to receive asyncronous responses with asyncId defined by you. Another major difference to the  existing [/v2/endpoints/{device-id}/{resourcePath}](/docs/v1.2/service-api-references/connect-api.html#v2EndpointsDeviceIdResourcePathGet) API is that the data is always provided (also cached resource values) via the [event notification channel](/docs/v1.2/connecting/event-notification.html)  instead of the request response.  This can help you to streamline your application as you can use existing indentifiers as the asyncID. For example, you can use the  web application&#39;s session ID along the device ID combined with the resource path as asyncID. You do not need to have a separate  mapping from asyncID to your application data model. Also as the data is always provided via the event notification channel, you can  implement only one data handling logic for resource read.  The provided async-id is present in the [AsyncIDResponse](/docs/v1.2/service-api-references/connect-api.html#AsyncIDResponse).   &#x60;&#x60;&#x60; Example URI: POST /v2/device-requests/015f2fa34d310000000000010030036c?async-id&#x3D;123e4567-e89b-12d3-a456-426655440000  Example payloads: { \&quot;method\&quot;: \&quot;GET\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1\&quot; } { \&quot;method\&quot;: \&quot;PUT\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1%20?k1&#x3D;v1&amp;k2&#x3D;v2%22\&quot;, \&quot;accept\&quot;: \&quot;text/plain\&quot;, \&quot;content-type\&quot;: \&quot;text/plain\&quot;, \&quot;payload-b64\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot; }  Example notification payload (AsyncIDResponse): { \&quot;async-responses\&quot;: [ { \&quot;id\&quot;: \&quot;123e4567-e89b-12d3-a456-426655440000\&quot;, \&quot;status\&quot;: 200, \&quot;payload\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot;, \&quot;ct\&quot;: \&quot;text/plain\&quot;, \&quot;max-age\&quot;: 600 } ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The device ID generated by Mbed Cloud.</param>
        /// <param name="asyncId">The client-generated ID for matching the correct response delivered via a notification.</param>
        /// <param name="body">Device request to send.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V2DeviceRequestsDeviceIdPostAsync (string deviceId, string asyncId, DeviceRequest body)
        {
             await V2DeviceRequestsDeviceIdPostAsyncWithHttpInfo(deviceId, asyncId, body);

        }

        /// <summary>
        /// Send an async request to device This API enables you to receive asyncronous responses with asyncId defined by you. Another major difference to the  existing [/v2/endpoints/{device-id}/{resourcePath}](/docs/v1.2/service-api-references/connect-api.html#v2EndpointsDeviceIdResourcePathGet) API is that the data is always provided (also cached resource values) via the [event notification channel](/docs/v1.2/connecting/event-notification.html)  instead of the request response.  This can help you to streamline your application as you can use existing indentifiers as the asyncID. For example, you can use the  web application&#39;s session ID along the device ID combined with the resource path as asyncID. You do not need to have a separate  mapping from asyncID to your application data model. Also as the data is always provided via the event notification channel, you can  implement only one data handling logic for resource read.  The provided async-id is present in the [AsyncIDResponse](/docs/v1.2/service-api-references/connect-api.html#AsyncIDResponse).   &#x60;&#x60;&#x60; Example URI: POST /v2/device-requests/015f2fa34d310000000000010030036c?async-id&#x3D;123e4567-e89b-12d3-a456-426655440000  Example payloads: { \&quot;method\&quot;: \&quot;GET\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1\&quot; } { \&quot;method\&quot;: \&quot;PUT\&quot;, \&quot;uri\&quot;: \&quot;/5/0/1%20?k1&#x3D;v1&amp;k2&#x3D;v2%22\&quot;, \&quot;accept\&quot;: \&quot;text/plain\&quot;, \&quot;content-type\&quot;: \&quot;text/plain\&quot;, \&quot;payload-b64\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot; }  Example notification payload (AsyncIDResponse): { \&quot;async-responses\&quot;: [ { \&quot;id\&quot;: \&quot;123e4567-e89b-12d3-a456-426655440000\&quot;, \&quot;status\&quot;: 200, \&quot;payload\&quot;: \&quot;dmFsdWUxCg&#x3D;&#x3D;\&quot;, \&quot;ct\&quot;: \&quot;text/plain\&quot;, \&quot;max-age\&quot;: 600 } ] } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="mds.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceId">The device ID generated by Mbed Cloud.</param>
        /// <param name="asyncId">The client-generated ID for matching the correct response delivered via a notification.</param>
        /// <param name="body">Device request to send.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V2DeviceRequestsDeviceIdPostAsyncWithHttpInfo (string deviceId, string asyncId, DeviceRequest body)
        {
            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new ApiException(400, "Missing required parameter 'deviceId' when calling DeviceRequestsApi->V2DeviceRequestsDeviceIdPost");
            // verify the required parameter 'asyncId' is set
            if (asyncId == null)
                throw new ApiException(400, "Missing required parameter 'asyncId' when calling DeviceRequestsApi->V2DeviceRequestsDeviceIdPost");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DeviceRequestsApi->V2DeviceRequestsDeviceIdPost");

            var localVarPath = "/v2/device-requests/{deviceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (deviceId != null) localVarPathParams.Add("deviceId", Configuration.ApiClient.ParameterToString(deviceId)); // path parameter
            if (asyncId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "asyncId", asyncId)); // query parameter
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
                Exception exception = ExceptionFactory("V2DeviceRequestsDeviceIdPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
