using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using deployment_service.Client;
using deployment_service.Model;

namespace deployment_service.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;Reads the deploy_info.json file and returns the Build and Git ID to the caller.&lt;/p&gt;\n&lt;p&gt;Will return a 500 error if the file is missing, cannot be parsed or the keys are missing.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        Object DeployInfoGET ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;Reads the deploy_info.json file and returns the Build and Git ID to the caller.&lt;/p&gt;\n&lt;p&gt;Will return a 500 error if the file is missing, cannot be parsed or the keys are missing.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeployInfoGETWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Create update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>UpdateCampaignSerializer</returns>
        UpdateCampaignSerializer UpdateCampaignCreate (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Create update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        ApiResponse<UpdateCampaignSerializer> UpdateCampaignCreateWithHttpInfo (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Delete update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>UpdateCampaignSerializer</returns>
        UpdateCampaignSerializer UpdateCampaignDestroy (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Delete update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        ApiResponse<UpdateCampaignSerializer> UpdateCampaignDestroyWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;List all update campaigns&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="campaignId"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="page">The page number to retrieve. If not given, then defaults to first page. (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>List&lt;UpdateCampaignSerializer&gt;</returns>
        List<UpdateCampaignSerializer> UpdateCampaignList (string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string campaignId = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, int? page = null, string rootManifestUrl = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;List all update campaigns&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="campaignId"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="page">The page number to retrieve. If not given, then defaults to first page. (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>ApiResponse of List&lt;UpdateCampaignSerializer&gt;</returns>
        ApiResponse<List<UpdateCampaignSerializer>> UpdateCampaignListWithHttpInfo (string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string campaignId = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, int? page = null, string rootManifestUrl = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="name">A name for this campaign (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>UpdateCampaignSerializer</returns>
        UpdateCampaignSerializer UpdateCampaignPartialUpdate (string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="name">A name for this campaign (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        ApiResponse<UpdateCampaignSerializer> UpdateCampaignPartialUpdateWithHttpInfo (string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Retrieve campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>UpdateCampaignSerializer</returns>
        UpdateCampaignSerializer UpdateCampaignRetrieve (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, string rootManifestUrl = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Retrieve campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        ApiResponse<UpdateCampaignSerializer> UpdateCampaignRetrieveWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, string rootManifestUrl = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Show the status of an update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>UpdateCampaignStatusSerializer</returns>
        UpdateCampaignStatusSerializer UpdateCampaignStatus (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Show the status of an update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>ApiResponse of UpdateCampaignStatusSerializer</returns>
        ApiResponse<UpdateCampaignStatusSerializer> UpdateCampaignStatusWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>UpdateCampaignSerializer</returns>
        UpdateCampaignSerializer UpdateCampaignUpdate (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        ApiResponse<UpdateCampaignSerializer> UpdateCampaignUpdateWithHttpInfo (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;Reads the deploy_info.json file and returns the Build and Git ID to the caller.&lt;/p&gt;\n&lt;p&gt;Will return a 500 error if the file is missing, cannot be parsed or the keys are missing.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeployInfoGETAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;Reads the deploy_info.json file and returns the Build and Git ID to the caller.&lt;/p&gt;\n&lt;p&gt;Will return a 500 error if the file is missing, cannot be parsed or the keys are missing.&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeployInfoGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Create update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignCreateAsync (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Create update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignCreateAsyncWithHttpInfo (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Delete update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignDestroyAsync (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Delete update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignDestroyAsyncWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;List all update campaigns&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="campaignId"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="page">The page number to retrieve. If not given, then defaults to first page. (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>Task of List&lt;UpdateCampaignSerializer&gt;</returns>
        System.Threading.Tasks.Task<List<UpdateCampaignSerializer>> UpdateCampaignListAsync (string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string campaignId = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, int? page = null, string rootManifestUrl = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;List all update campaigns&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="campaignId"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="page">The page number to retrieve. If not given, then defaults to first page. (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;UpdateCampaignSerializer&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UpdateCampaignSerializer>>> UpdateCampaignListAsyncWithHttpInfo (string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string campaignId = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, int? page = null, string rootManifestUrl = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="name">A name for this campaign (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignPartialUpdateAsync (string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign fields&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="name">A name for this campaign (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignPartialUpdateAsyncWithHttpInfo (string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Retrieve campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignRetrieveAsync (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, string rootManifestUrl = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Retrieve campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignRetrieveAsyncWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, string rootManifestUrl = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Show the status of an update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>Task of UpdateCampaignStatusSerializer</returns>
        System.Threading.Tasks.Task<UpdateCampaignStatusSerializer> UpdateCampaignStatusAsync (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Show the status of an update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignStatusSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateCampaignStatusSerializer>> UpdateCampaignStatusAsyncWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignUpdateAsync (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign&lt;/p&gt;
        /// </remarks>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignUpdateAsyncWithHttpInfo (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
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
        ///  &lt;p&gt;Reads the deploy_info.json file and returns the Build and Git ID to the caller.&lt;/p&gt;\n&lt;p&gt;Will return a 500 error if the file is missing, cannot be parsed or the keys are missing.&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        public Object DeployInfoGET ()
        {
             ApiResponse<Object> localVarResponse = DeployInfoGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;Reads the deploy_info.json file and returns the Build and Git ID to the caller.&lt;/p&gt;\n&lt;p&gt;Will return a 500 error if the file is missing, cannot be parsed or the keys are missing.&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DeployInfoGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/ds_deploy_info";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeployInfoGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeployInfoGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;Reads the deploy_info.json file and returns the Build and Git ID to the caller.&lt;/p&gt;\n&lt;p&gt;Will return a 500 error if the file is missing, cannot be parsed or the keys are missing.&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeployInfoGETAsync ()
        {
             ApiResponse<Object> localVarResponse = await DeployInfoGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;Reads the deploy_info.json file and returns the Build and Git ID to the caller.&lt;/p&gt;\n&lt;p&gt;Will return a 500 error if the file is missing, cannot be parsed or the keys are missing.&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeployInfoGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/v3/ds_deploy_info";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeployInfoGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeployInfoGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Create update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param> 
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param> 
        /// <param name="description">An optional description of the campaign (optional)</param> 
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param> 
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state">The state of the campaign (optional)</param> 
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param> 
        /// <returns>UpdateCampaignSerializer</returns>
        public UpdateCampaignSerializer UpdateCampaignCreate (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = UpdateCampaignCreateWithHttpInfo(name, campaignId, description, deviceFilter, finished, _object, rootManifestId, state, when);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Create update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param> 
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param> 
        /// <param name="description">An optional description of the campaign (optional)</param> 
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param> 
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state">The state of the campaign (optional)</param> 
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param> 
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        public ApiResponse< UpdateCampaignSerializer > UpdateCampaignCreateWithHttpInfo (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling DefaultApi->UpdateCampaignCreate");
            
    
            var localVarPath = "/v3/update-campaigns/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (campaignId != null) localVarFormParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // form parameter
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (deviceFilter != null) localVarFormParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // form parameter
            if (finished != null) localVarFormParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (rootManifestId != null) localVarFormParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // form parameter
            if (state != null) localVarFormParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // form parameter
            if (when != null) localVarFormParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // form parameter
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignCreate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignCreate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Create update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        public async System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignCreateAsync (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = await UpdateCampaignCreateAsyncWithHttpInfo(name, campaignId, description, deviceFilter, finished, _object, rootManifestId, state, when);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Create update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignCreateAsyncWithHttpInfo (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UpdateCampaignCreate");
            
    
            var localVarPath = "/v3/update-campaigns/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (campaignId != null) localVarFormParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // form parameter
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (deviceFilter != null) localVarFormParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // form parameter
            if (finished != null) localVarFormParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (rootManifestId != null) localVarFormParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // form parameter
            if (state != null) localVarFormParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // form parameter
            if (when != null) localVarFormParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // form parameter
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignCreate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignCreate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Delete update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param> 
        /// <param name="updatingRequestId"> (optional)</param> 
        /// <param name="updatingIpAddress"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="attempts"> (optional)</param> 
        /// <param name="description"> (optional)</param> 
        /// <param name="deviceFilter"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="finished"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state"> (optional)</param> 
        /// <param name="when"> (optional)</param> 
        /// <returns>UpdateCampaignSerializer</returns>
        public UpdateCampaignSerializer UpdateCampaignDestroy (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = UpdateCampaignDestroyWithHttpInfo(campaignId, updatingRequestId, updatingIpAddress, createdAt, updatedAt, attempts, description, deviceFilter, etag, finished, name, _object, rootManifestId, state, when);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Delete update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param> 
        /// <param name="updatingRequestId"> (optional)</param> 
        /// <param name="updatingIpAddress"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="attempts"> (optional)</param> 
        /// <param name="description"> (optional)</param> 
        /// <param name="deviceFilter"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="finished"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state"> (optional)</param> 
        /// <param name="when"> (optional)</param> 
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        public ApiResponse< UpdateCampaignSerializer > UpdateCampaignDestroyWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling DefaultApi->UpdateCampaignDestroy");
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            if (updatingRequestId != null) localVarQueryParams.Add("updating_request_id", Configuration.ApiClient.ParameterToString(updatingRequestId)); // query parameter
            if (updatingIpAddress != null) localVarQueryParams.Add("updating_ip_address", Configuration.ApiClient.ParameterToString(updatingIpAddress)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (attempts != null) localVarQueryParams.Add("attempts", Configuration.ApiClient.ParameterToString(attempts)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (deviceFilter != null) localVarQueryParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (finished != null) localVarQueryParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (rootManifestId != null) localVarQueryParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (when != null) localVarQueryParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignDestroy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignDestroy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Delete update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        public async System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignDestroyAsync (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = await UpdateCampaignDestroyAsyncWithHttpInfo(campaignId, updatingRequestId, updatingIpAddress, createdAt, updatedAt, attempts, description, deviceFilter, etag, finished, name, _object, rootManifestId, state, when);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Delete update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignDestroyAsyncWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling UpdateCampaignDestroy");
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            if (updatingRequestId != null) localVarQueryParams.Add("updating_request_id", Configuration.ApiClient.ParameterToString(updatingRequestId)); // query parameter
            if (updatingIpAddress != null) localVarQueryParams.Add("updating_ip_address", Configuration.ApiClient.ParameterToString(updatingIpAddress)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (attempts != null) localVarQueryParams.Add("attempts", Configuration.ApiClient.ParameterToString(attempts)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (deviceFilter != null) localVarQueryParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (finished != null) localVarQueryParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (rootManifestId != null) localVarQueryParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (when != null) localVarQueryParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignDestroy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignDestroy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;List all update campaigns&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatingRequestId"> (optional)</param> 
        /// <param name="updatingIpAddress"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="attempts"> (optional)</param> 
        /// <param name="campaignId"> (optional)</param> 
        /// <param name="description"> (optional)</param> 
        /// <param name="deviceFilter"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="finished"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state"> (optional)</param> 
        /// <param name="when"> (optional)</param> 
        /// <param name="page">The page number to retrieve. If not given, then defaults to first page. (optional)</param> 
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param> 
        /// <returns>List&lt;UpdateCampaignSerializer&gt;</returns>
        public List<UpdateCampaignSerializer> UpdateCampaignList (string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string campaignId = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, int? page = null, string rootManifestUrl = null)
        {
             ApiResponse<List<UpdateCampaignSerializer>> localVarResponse = UpdateCampaignListWithHttpInfo(updatingRequestId, updatingIpAddress, createdAt, updatedAt, attempts, campaignId, description, deviceFilter, etag, finished, name, _object, rootManifestId, state, when, page, rootManifestUrl);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;List all update campaigns&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatingRequestId"> (optional)</param> 
        /// <param name="updatingIpAddress"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="attempts"> (optional)</param> 
        /// <param name="campaignId"> (optional)</param> 
        /// <param name="description"> (optional)</param> 
        /// <param name="deviceFilter"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="finished"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state"> (optional)</param> 
        /// <param name="when"> (optional)</param> 
        /// <param name="page">The page number to retrieve. If not given, then defaults to first page. (optional)</param> 
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param> 
        /// <returns>ApiResponse of List&lt;UpdateCampaignSerializer&gt;</returns>
        public ApiResponse< List<UpdateCampaignSerializer> > UpdateCampaignListWithHttpInfo (string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string campaignId = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, int? page = null, string rootManifestUrl = null)
        {
            
    
            var localVarPath = "/v3/update-campaigns/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (updatingRequestId != null) localVarQueryParams.Add("updating_request_id", Configuration.ApiClient.ParameterToString(updatingRequestId)); // query parameter
            if (updatingIpAddress != null) localVarQueryParams.Add("updating_ip_address", Configuration.ApiClient.ParameterToString(updatingIpAddress)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (attempts != null) localVarQueryParams.Add("attempts", Configuration.ApiClient.ParameterToString(attempts)); // query parameter
            if (campaignId != null) localVarQueryParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (deviceFilter != null) localVarQueryParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (finished != null) localVarQueryParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (rootManifestId != null) localVarQueryParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (when != null) localVarQueryParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (rootManifestUrl != null) localVarQueryParams.Add("root_manifest_url", Configuration.ApiClient.ParameterToString(rootManifestUrl)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<UpdateCampaignSerializer>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UpdateCampaignSerializer>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UpdateCampaignSerializer>)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;List all update campaigns&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="campaignId"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="page">The page number to retrieve. If not given, then defaults to first page. (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>Task of List&lt;UpdateCampaignSerializer&gt;</returns>
        public async System.Threading.Tasks.Task<List<UpdateCampaignSerializer>> UpdateCampaignListAsync (string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string campaignId = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, int? page = null, string rootManifestUrl = null)
        {
             ApiResponse<List<UpdateCampaignSerializer>> localVarResponse = await UpdateCampaignListAsyncWithHttpInfo(updatingRequestId, updatingIpAddress, createdAt, updatedAt, attempts, campaignId, description, deviceFilter, etag, finished, name, _object, rootManifestId, state, when, page, rootManifestUrl);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;List all update campaigns&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="campaignId"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="page">The page number to retrieve. If not given, then defaults to first page. (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;UpdateCampaignSerializer&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UpdateCampaignSerializer>>> UpdateCampaignListAsyncWithHttpInfo (string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string campaignId = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, int? page = null, string rootManifestUrl = null)
        {
            
    
            var localVarPath = "/v3/update-campaigns/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (updatingRequestId != null) localVarQueryParams.Add("updating_request_id", Configuration.ApiClient.ParameterToString(updatingRequestId)); // query parameter
            if (updatingIpAddress != null) localVarQueryParams.Add("updating_ip_address", Configuration.ApiClient.ParameterToString(updatingIpAddress)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (attempts != null) localVarQueryParams.Add("attempts", Configuration.ApiClient.ParameterToString(attempts)); // query parameter
            if (campaignId != null) localVarQueryParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (deviceFilter != null) localVarQueryParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (finished != null) localVarQueryParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (rootManifestId != null) localVarQueryParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (when != null) localVarQueryParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (rootManifestUrl != null) localVarQueryParams.Add("root_manifest_url", Configuration.ApiClient.ParameterToString(rootManifestUrl)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignList: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignList: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<UpdateCampaignSerializer>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UpdateCampaignSerializer>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UpdateCampaignSerializer>)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param> 
        /// <param name="description">An optional description of the campaign (optional)</param> 
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param> 
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param> 
        /// <param name="name">A name for this campaign (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state">The state of the campaign (optional)</param> 
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param> 
        /// <returns>UpdateCampaignSerializer</returns>
        public UpdateCampaignSerializer UpdateCampaignPartialUpdate (string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = UpdateCampaignPartialUpdateWithHttpInfo(campaignId, description, deviceFilter, finished, name, _object, rootManifestId, state, when);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param> 
        /// <param name="description">An optional description of the campaign (optional)</param> 
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param> 
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param> 
        /// <param name="name">A name for this campaign (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state">The state of the campaign (optional)</param> 
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param> 
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        public ApiResponse< UpdateCampaignSerializer > UpdateCampaignPartialUpdateWithHttpInfo (string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (campaignId != null) localVarFormParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // form parameter
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (deviceFilter != null) localVarFormParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // form parameter
            if (finished != null) localVarFormParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (rootManifestId != null) localVarFormParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // form parameter
            if (state != null) localVarFormParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // form parameter
            if (when != null) localVarFormParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // form parameter
            
            

            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignPartialUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignPartialUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="name">A name for this campaign (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        public async System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignPartialUpdateAsync (string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = await UpdateCampaignPartialUpdateAsyncWithHttpInfo(campaignId, description, deviceFilter, finished, name, _object, rootManifestId, state, when);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign fields&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="name">A name for this campaign (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignPartialUpdateAsyncWithHttpInfo (string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (campaignId != null) localVarFormParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // form parameter
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (deviceFilter != null) localVarFormParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // form parameter
            if (finished != null) localVarFormParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (rootManifestId != null) localVarFormParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // form parameter
            if (state != null) localVarFormParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // form parameter
            if (when != null) localVarFormParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // form parameter
            
            

            
            // authentication (Bearer) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignPartialUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignPartialUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Retrieve campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the campaign</param> 
        /// <param name="updatingRequestId"> (optional)</param> 
        /// <param name="updatingIpAddress"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="attempts"> (optional)</param> 
        /// <param name="description"> (optional)</param> 
        /// <param name="deviceFilter"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="finished"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state"> (optional)</param> 
        /// <param name="when"> (optional)</param> 
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param> 
        /// <returns>UpdateCampaignSerializer</returns>
        public UpdateCampaignSerializer UpdateCampaignRetrieve (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, string rootManifestUrl = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = UpdateCampaignRetrieveWithHttpInfo(campaignId, updatingRequestId, updatingIpAddress, createdAt, updatedAt, attempts, description, deviceFilter, etag, finished, name, _object, rootManifestId, state, when, rootManifestUrl);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Retrieve campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the campaign</param> 
        /// <param name="updatingRequestId"> (optional)</param> 
        /// <param name="updatingIpAddress"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="attempts"> (optional)</param> 
        /// <param name="description"> (optional)</param> 
        /// <param name="deviceFilter"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="finished"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state"> (optional)</param> 
        /// <param name="when"> (optional)</param> 
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param> 
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        public ApiResponse< UpdateCampaignSerializer > UpdateCampaignRetrieveWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, string rootManifestUrl = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling DefaultApi->UpdateCampaignRetrieve");
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (updatingRequestId != null) localVarQueryParams.Add("updating_request_id", Configuration.ApiClient.ParameterToString(updatingRequestId)); // query parameter
            if (updatingIpAddress != null) localVarQueryParams.Add("updating_ip_address", Configuration.ApiClient.ParameterToString(updatingIpAddress)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (attempts != null) localVarQueryParams.Add("attempts", Configuration.ApiClient.ParameterToString(attempts)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (deviceFilter != null) localVarQueryParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (finished != null) localVarQueryParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (rootManifestId != null) localVarQueryParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (when != null) localVarQueryParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // query parameter
            if (rootManifestUrl != null) localVarQueryParams.Add("root_manifest_url", Configuration.ApiClient.ParameterToString(rootManifestUrl)); // query parameter
            
            
            if (campaignId != null) localVarFormParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // form parameter
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignRetrieve: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignRetrieve: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Retrieve campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        public async System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignRetrieveAsync (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, string rootManifestUrl = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = await UpdateCampaignRetrieveAsyncWithHttpInfo(campaignId, updatingRequestId, updatingIpAddress, createdAt, updatedAt, attempts, description, deviceFilter, etag, finished, name, _object, rootManifestId, state, when, rootManifestUrl);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Retrieve campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <param name="rootManifestUrl">The firmware catalog URL for the manifest that will be sent to the device as part of the campaign (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignRetrieveAsyncWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null, string rootManifestUrl = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling UpdateCampaignRetrieve");
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (updatingRequestId != null) localVarQueryParams.Add("updating_request_id", Configuration.ApiClient.ParameterToString(updatingRequestId)); // query parameter
            if (updatingIpAddress != null) localVarQueryParams.Add("updating_ip_address", Configuration.ApiClient.ParameterToString(updatingIpAddress)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (attempts != null) localVarQueryParams.Add("attempts", Configuration.ApiClient.ParameterToString(attempts)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (deviceFilter != null) localVarQueryParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (finished != null) localVarQueryParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (rootManifestId != null) localVarQueryParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (when != null) localVarQueryParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // query parameter
            if (rootManifestUrl != null) localVarQueryParams.Add("root_manifest_url", Configuration.ApiClient.ParameterToString(rootManifestUrl)); // query parameter
            
            
            if (campaignId != null) localVarFormParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // form parameter
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignRetrieve: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignRetrieve: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Show the status of an update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param> 
        /// <param name="updatingRequestId"> (optional)</param> 
        /// <param name="updatingIpAddress"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="attempts"> (optional)</param> 
        /// <param name="description"> (optional)</param> 
        /// <param name="deviceFilter"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="finished"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state"> (optional)</param> 
        /// <param name="when"> (optional)</param> 
        /// <returns>UpdateCampaignStatusSerializer</returns>
        public UpdateCampaignStatusSerializer UpdateCampaignStatus (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null)
        {
             ApiResponse<UpdateCampaignStatusSerializer> localVarResponse = UpdateCampaignStatusWithHttpInfo(campaignId, updatingRequestId, updatingIpAddress, createdAt, updatedAt, attempts, description, deviceFilter, etag, finished, name, _object, rootManifestId, state, when);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Show the status of an update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param> 
        /// <param name="updatingRequestId"> (optional)</param> 
        /// <param name="updatingIpAddress"> (optional)</param> 
        /// <param name="createdAt"> (optional)</param> 
        /// <param name="updatedAt"> (optional)</param> 
        /// <param name="attempts"> (optional)</param> 
        /// <param name="description"> (optional)</param> 
        /// <param name="deviceFilter"> (optional)</param> 
        /// <param name="etag"> (optional)</param> 
        /// <param name="finished"> (optional)</param> 
        /// <param name="name"> (optional)</param> 
        /// <param name="_object"> (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state"> (optional)</param> 
        /// <param name="when"> (optional)</param> 
        /// <returns>ApiResponse of UpdateCampaignStatusSerializer</returns>
        public ApiResponse< UpdateCampaignStatusSerializer > UpdateCampaignStatusWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling DefaultApi->UpdateCampaignStatus");
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/status/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            if (updatingRequestId != null) localVarQueryParams.Add("updating_request_id", Configuration.ApiClient.ParameterToString(updatingRequestId)); // query parameter
            if (updatingIpAddress != null) localVarQueryParams.Add("updating_ip_address", Configuration.ApiClient.ParameterToString(updatingIpAddress)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (attempts != null) localVarQueryParams.Add("attempts", Configuration.ApiClient.ParameterToString(attempts)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (deviceFilter != null) localVarQueryParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (finished != null) localVarQueryParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (rootManifestId != null) localVarQueryParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (when != null) localVarQueryParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UpdateCampaignStatusSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignStatusSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignStatusSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Show the status of an update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>Task of UpdateCampaignStatusSerializer</returns>
        public async System.Threading.Tasks.Task<UpdateCampaignStatusSerializer> UpdateCampaignStatusAsync (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null)
        {
             ApiResponse<UpdateCampaignStatusSerializer> localVarResponse = await UpdateCampaignStatusAsyncWithHttpInfo(campaignId, updatingRequestId, updatingIpAddress, createdAt, updatedAt, attempts, description, deviceFilter, etag, finished, name, _object, rootManifestId, state, when);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Show the status of an update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">The ID of the update campaign</param>
        /// <param name="updatingRequestId"> (optional)</param>
        /// <param name="updatingIpAddress"> (optional)</param>
        /// <param name="createdAt"> (optional)</param>
        /// <param name="updatedAt"> (optional)</param>
        /// <param name="attempts"> (optional)</param>
        /// <param name="description"> (optional)</param>
        /// <param name="deviceFilter"> (optional)</param>
        /// <param name="etag"> (optional)</param>
        /// <param name="finished"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="_object"> (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state"> (optional)</param>
        /// <param name="when"> (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignStatusSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateCampaignStatusSerializer>> UpdateCampaignStatusAsyncWithHttpInfo (string campaignId, string updatingRequestId = null, string updatingIpAddress = null, string createdAt = null, string updatedAt = null, string attempts = null, string description = null, string deviceFilter = null, string etag = null, string finished = null, string name = null, string _object = null, string rootManifestId = null, string state = null, string when = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling UpdateCampaignStatus");
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/status/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            if (updatingRequestId != null) localVarQueryParams.Add("updating_request_id", Configuration.ApiClient.ParameterToString(updatingRequestId)); // query parameter
            if (updatingIpAddress != null) localVarQueryParams.Add("updating_ip_address", Configuration.ApiClient.ParameterToString(updatingIpAddress)); // query parameter
            if (createdAt != null) localVarQueryParams.Add("created_at", Configuration.ApiClient.ParameterToString(createdAt)); // query parameter
            if (updatedAt != null) localVarQueryParams.Add("updated_at", Configuration.ApiClient.ParameterToString(updatedAt)); // query parameter
            if (attempts != null) localVarQueryParams.Add("attempts", Configuration.ApiClient.ParameterToString(attempts)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (deviceFilter != null) localVarQueryParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // query parameter
            if (etag != null) localVarQueryParams.Add("etag", Configuration.ApiClient.ParameterToString(etag)); // query parameter
            if (finished != null) localVarQueryParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (_object != null) localVarQueryParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // query parameter
            if (rootManifestId != null) localVarQueryParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // query parameter
            if (state != null) localVarQueryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (when != null) localVarQueryParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UpdateCampaignStatusSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignStatusSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignStatusSerializer)));
            
        }
        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param> 
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param> 
        /// <param name="description">An optional description of the campaign (optional)</param> 
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param> 
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state">The state of the campaign (optional)</param> 
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param> 
        /// <returns>UpdateCampaignSerializer</returns>
        public UpdateCampaignSerializer UpdateCampaignUpdate (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = UpdateCampaignUpdateWithHttpInfo(name, campaignId, description, deviceFilter, finished, _object, rootManifestId, state, when);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param> 
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param> 
        /// <param name="description">An optional description of the campaign (optional)</param> 
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param> 
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param> 
        /// <param name="_object">The API resource entity (optional)</param> 
        /// <param name="rootManifestId"> (optional)</param> 
        /// <param name="state">The state of the campaign (optional)</param> 
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param> 
        /// <returns>ApiResponse of UpdateCampaignSerializer</returns>
        public ApiResponse< UpdateCampaignSerializer > UpdateCampaignUpdateWithHttpInfo (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
            
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling DefaultApi->UpdateCampaignUpdate");
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (campaignId != null) localVarFormParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // form parameter
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (deviceFilter != null) localVarFormParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // form parameter
            if (finished != null) localVarFormParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (rootManifestId != null) localVarFormParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // form parameter
            if (state != null) localVarFormParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // form parameter
            if (when != null) localVarFormParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // form parameter
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }

        
        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of UpdateCampaignSerializer</returns>
        public async System.Threading.Tasks.Task<UpdateCampaignSerializer> UpdateCampaignUpdateAsync (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
             ApiResponse<UpdateCampaignSerializer> localVarResponse = await UpdateCampaignUpdateAsyncWithHttpInfo(name, campaignId, description, deviceFilter, finished, _object, rootManifestId, state, when);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  &lt;p&gt;The APIs for creating and manipulating update campaigns. Update campaigns are used to control firmware update\nto a list of devices specified by a filter.  &lt;/p&gt;\n&lt;p&gt;Update campaign&lt;/p&gt;
        /// </summary>
        /// <exception cref="deployment_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">A name for this campaign</param>
        /// <param name="campaignId">DEPRECATED: The ID of the campaign (optional)</param>
        /// <param name="description">An optional description of the campaign (optional)</param>
        /// <param name="deviceFilter">The filter for the devices the campaign will target (optional)</param>
        /// <param name="finished">The timestamp when the update campaign finished (optional)</param>
        /// <param name="_object">The API resource entity (optional)</param>
        /// <param name="rootManifestId"> (optional)</param>
        /// <param name="state">The state of the campaign (optional)</param>
        /// <param name="when">The timestamp at which update campaign scheduled to start (optional)</param>
        /// <returns>Task of ApiResponse (UpdateCampaignSerializer)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateCampaignSerializer>> UpdateCampaignUpdateAsyncWithHttpInfo (string name, string campaignId = null, string description = null, string deviceFilter = null, DateTime? finished = null, string _object = null, string rootManifestId = null, string state = null, DateTime? when = null)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UpdateCampaignUpdate");
            
    
            var localVarPath = "/v3/update-campaigns/{campaign_id}/";
    
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
                
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (campaignId != null) localVarFormParams.Add("campaign_id", Configuration.ApiClient.ParameterToString(campaignId)); // form parameter
            if (description != null) localVarFormParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // form parameter
            if (deviceFilter != null) localVarFormParams.Add("device_filter", Configuration.ApiClient.ParameterToString(deviceFilter)); // form parameter
            if (finished != null) localVarFormParams.Add("finished", Configuration.ApiClient.ParameterToString(finished)); // form parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (_object != null) localVarFormParams.Add("object", Configuration.ApiClient.ParameterToString(_object)); // form parameter
            if (rootManifestId != null) localVarFormParams.Add("root_manifest_id", Configuration.ApiClient.ParameterToString(rootManifestId)); // form parameter
            if (state != null) localVarFormParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // form parameter
            if (when != null) localVarFormParams.Add("when", Configuration.ApiClient.ParameterToString(when)); // form parameter
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignUpdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCampaignUpdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UpdateCampaignSerializer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UpdateCampaignSerializer) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateCampaignSerializer)));
            
        }
        
    }
    
}
