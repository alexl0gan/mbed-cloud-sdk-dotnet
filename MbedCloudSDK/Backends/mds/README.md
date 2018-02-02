# mds - the C# library for the Connect API

Mbed Cloud Connect API allows web applications to communicate with devices. You can subscribe to device resources and read/write values to them. mbed Cloud Connect makes connectivity to devices easy by queuing requests and caching resource values.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using mds.Api;
using mds.Client;
using mds.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out mds.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using mds.Api;
using mds.Client;
using mds.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Bearer
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // Delete callback URL
                apiInstance.V2NotificationCallbackDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V2NotificationCallbackDelete: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.us-east-1.mbedcloud.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**V2NotificationCallbackDelete**](docs/DefaultApi.md#v2notificationcallbackdelete) | **DELETE** /v2/notification/callback | Delete callback URL
*DefaultApi* | [**V2NotificationCallbackGet**](docs/DefaultApi.md#v2notificationcallbackget) | **GET** /v2/notification/callback | Check callback URL
*EndpointsApi* | [**V2EndpointsDeviceIdGet**](docs/EndpointsApi.md#v2endpointsdeviceidget) | **GET** /v2/endpoints/{device-id} | List the resources on an endpoint
*EndpointsApi* | [**V2EndpointsGet**](docs/EndpointsApi.md#v2endpointsget) | **GET** /v2/endpoints | (DEPRECATED) List registered endpoints. The number of returned endpoints is currently limited to 200.
*NotificationsApi* | [**V2NotificationCallbackPut**](docs/NotificationsApi.md#v2notificationcallbackput) | **PUT** /v2/notification/callback | Register a callback URL
*NotificationsApi* | [**V2NotificationPullDelete**](docs/NotificationsApi.md#v2notificationpulldelete) | **DELETE** /v2/notification/pull | Delete notification Long Poll channel
*NotificationsApi* | [**V2NotificationPullGet**](docs/NotificationsApi.md#v2notificationpullget) | **GET** /v2/notification/pull | Get notifications using Long Poll
*ResourcesApi* | [**V2EndpointsDeviceIdResourcePathDelete**](docs/ResourcesApi.md#v2endpointsdeviceidresourcepathdelete) | **DELETE** /v2/endpoints/{device-id}/{resourcePath} | Delete a resource
*ResourcesApi* | [**V2EndpointsDeviceIdResourcePathGet**](docs/ResourcesApi.md#v2endpointsdeviceidresourcepathget) | **GET** /v2/endpoints/{device-id}/{resourcePath} | Read from a resource
*ResourcesApi* | [**V2EndpointsDeviceIdResourcePathPost**](docs/ResourcesApi.md#v2endpointsdeviceidresourcepathpost) | **POST** /v2/endpoints/{device-id}/{resourcePath} | Execute a function on a resource
*ResourcesApi* | [**V2EndpointsDeviceIdResourcePathPut**](docs/ResourcesApi.md#v2endpointsdeviceidresourcepathput) | **PUT** /v2/endpoints/{device-id}/{resourcePath} | Write to a resource
*SubscriptionsApi* | [**V2SubscriptionsDelete**](docs/SubscriptionsApi.md#v2subscriptionsdelete) | **DELETE** /v2/subscriptions | Remove all subscriptions
*SubscriptionsApi* | [**V2SubscriptionsDeviceIdDelete**](docs/SubscriptionsApi.md#v2subscriptionsdeviceiddelete) | **DELETE** /v2/subscriptions/{device-id} | Delete subscriptions from an endpoint
*SubscriptionsApi* | [**V2SubscriptionsDeviceIdGet**](docs/SubscriptionsApi.md#v2subscriptionsdeviceidget) | **GET** /v2/subscriptions/{device-id} | Read endpoints subscriptions
*SubscriptionsApi* | [**V2SubscriptionsDeviceIdResourcePathDelete**](docs/SubscriptionsApi.md#v2subscriptionsdeviceidresourcepathdelete) | **DELETE** /v2/subscriptions/{device-id}/{resourcePath} | Remove a subscription
*SubscriptionsApi* | [**V2SubscriptionsDeviceIdResourcePathGet**](docs/SubscriptionsApi.md#v2subscriptionsdeviceidresourcepathget) | **GET** /v2/subscriptions/{device-id}/{resourcePath} | Read subscription status
*SubscriptionsApi* | [**V2SubscriptionsDeviceIdResourcePathPut**](docs/SubscriptionsApi.md#v2subscriptionsdeviceidresourcepathput) | **PUT** /v2/subscriptions/{device-id}/{resourcePath} | Subscribe to a resource path
*SubscriptionsApi* | [**V2SubscriptionsGet**](docs/SubscriptionsApi.md#v2subscriptionsget) | **GET** /v2/subscriptions | Get pre-subscriptions
*SubscriptionsApi* | [**V2SubscriptionsPut**](docs/SubscriptionsApi.md#v2subscriptionsput) | **PUT** /v2/subscriptions | Set pre-subscriptions


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AsyncID](docs/AsyncID.md)
 - [Model.AsyncIDResponse](docs/AsyncIDResponse.md)
 - [Model.Endpoint](docs/Endpoint.md)
 - [Model.EndpointData](docs/EndpointData.md)
 - [Model.NotificationData](docs/NotificationData.md)
 - [Model.NotificationMessage](docs/NotificationMessage.md)
 - [Model.Presubscription](docs/Presubscription.md)
 - [Model.PresubscriptionArray](docs/PresubscriptionArray.md)
 - [Model.Resource](docs/Resource.md)
 - [Model.ResourcesData](docs/ResourcesData.md)
 - [Model.Webhook](docs/Webhook.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header
