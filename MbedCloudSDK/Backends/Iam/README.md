# iam - the C# library for the Account Management API

API for managing accounts, users, creating API keys, uploading trusted certificates

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v3
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
using iam.Api;
using iam.Client;
using iam.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out iam.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using iam.Api;
using iam.Client;
using iam.Model;

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

            var apiInstance = new AccountAdminApi();
            var apiKey = apiKey_example;  // string | The ID of the API key to be added to the group.
            var body = ;  // List<string> | A list of IDs of the groups to be updated.

            try
            {
                // Add API key to a list of groups.
                UpdatedResponse result = apiInstance.AddApiKeyToGroups(apiKey, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountAdminApi.AddApiKeyToGroups: " + e.Message );
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
*AccountAdminApi* | [**AddApiKeyToGroups**](docs/AccountAdminApi.md#addapikeytogroups) | **POST** /v3/api-keys/{apiKey}/groups | Add API key to a list of groups.
*AccountAdminApi* | [**AddCertificate**](docs/AccountAdminApi.md#addcertificate) | **POST** /v3/trusted-certificates | Upload a new trusted certificate.
*AccountAdminApi* | [**AddSubjectsToGroup**](docs/AccountAdminApi.md#addsubjectstogroup) | **POST** /v3/policy-groups/{groupID} | Add members to a group.
*AccountAdminApi* | [**AddUserToGroups**](docs/AccountAdminApi.md#addusertogroups) | **POST** /v3/users/{user-id}/groups | Add user to a list of groups.
*AccountAdminApi* | [**CreateGroup**](docs/AccountAdminApi.md#creategroup) | **POST** /v3/policy-groups | Create a new group.
*AccountAdminApi* | [**CreateUser**](docs/AccountAdminApi.md#createuser) | **POST** /v3/users | Create a new user.
*AccountAdminApi* | [**DeleteGroup**](docs/AccountAdminApi.md#deletegroup) | **DELETE** /v3/policy-groups/{groupID} | Delete a group.
*AccountAdminApi* | [**DeleteUser**](docs/AccountAdminApi.md#deleteuser) | **DELETE** /v3/users/{user-id} | Delete a user.
*AccountAdminApi* | [**GetAllUsers**](docs/AccountAdminApi.md#getallusers) | **GET** /v3/users | Get the details of all users.
*AccountAdminApi* | [**GetGroupsOfApikey**](docs/AccountAdminApi.md#getgroupsofapikey) | **GET** /v3/api-keys/{apiKey}/groups | Get groups of the API key.
*AccountAdminApi* | [**GetGroupsOfUser**](docs/AccountAdminApi.md#getgroupsofuser) | **GET** /v3/users/{user-id}/groups | Get groups of the user.
*AccountAdminApi* | [**GetUser**](docs/AccountAdminApi.md#getuser) | **GET** /v3/users/{user-id} | Details of a user.
*AccountAdminApi* | [**GetUsersOfGroup**](docs/AccountAdminApi.md#getusersofgroup) | **GET** /v3/policy-groups/{groupID}/users | Get users of a group.
*AccountAdminApi* | [**RemoveApiKeyFromGroups**](docs/AccountAdminApi.md#removeapikeyfromgroups) | **DELETE** /v3/api-keys/{apiKey}/groups | Remove API key from groups.
*AccountAdminApi* | [**RemoveUserFromGroups**](docs/AccountAdminApi.md#removeuserfromgroups) | **DELETE** /v3/users/{user-id}/groups | Remove user from groups.
*AccountAdminApi* | [**RemoveUsersFromGroup**](docs/AccountAdminApi.md#removeusersfromgroup) | **DELETE** /v3/policy-groups/{groupID}/users | Remove users from a group.
*AccountAdminApi* | [**UpdateGroupName**](docs/AccountAdminApi.md#updategroupname) | **PUT** /v3/policy-groups/{groupID} | Update the group name.
*AccountAdminApi* | [**UpdateMyAccount**](docs/AccountAdminApi.md#updatemyaccount) | **PUT** /v3/accounts/me | Updates attributes of the account.
*AccountAdminApi* | [**UpdateUser**](docs/AccountAdminApi.md#updateuser) | **PUT** /v3/users/{user-id} | Update user details.
*AggregatorAccountAdminApi* | [**AddAccountApiKeyToGroups**](docs/AggregatorAccountAdminApi.md#addaccountapikeytogroups) | **POST** /v3/accounts/{accountID}/api-keys/{apiKey}/groups | Add API key to a list of groups.
*AggregatorAccountAdminApi* | [**AddAccountCertificate**](docs/AggregatorAccountAdminApi.md#addaccountcertificate) | **POST** /v3/accounts/{accountID}/trusted-certificates | Upload new trusted certificate.
*AggregatorAccountAdminApi* | [**AddAccountUserToGroups**](docs/AggregatorAccountAdminApi.md#addaccountusertogroups) | **POST** /v3/accounts/{accountID}/users/{user-id}/groups | Add user to a list of groups.
*AggregatorAccountAdminApi* | [**AddSubjectsToAccountGroup**](docs/AggregatorAccountAdminApi.md#addsubjectstoaccountgroup) | **POST** /v3/accounts/{accountID}/policy-groups/{groupID} | Add members to a group.
*AggregatorAccountAdminApi* | [**AttachAccountPolicyToApikeys**](docs/AggregatorAccountAdminApi.md#attachaccountpolicytoapikeys) | **POST** /v3/accounts/{accountID}/policies/{policy-id}/api-keys | Attach a policy to API keys.
*AggregatorAccountAdminApi* | [**AttachAccountPolicyToGroup**](docs/AggregatorAccountAdminApi.md#attachaccountpolicytogroup) | **POST** /v3/accounts/{accountID}/policies/{policy-id}/groups | Attach a policy to groups.
*AggregatorAccountAdminApi* | [**AttachAccountPolicyToUsers**](docs/AggregatorAccountAdminApi.md#attachaccountpolicytousers) | **POST** /v3/accounts/{accountID}/policies/{policy-id}/users | Attach a policy to users.
*AggregatorAccountAdminApi* | [**CheckAccountApiKey**](docs/AggregatorAccountAdminApi.md#checkaccountapikey) | **POST** /v3/accounts/{accountID}/api-keys/{apiKey} | Check the API key.
*AggregatorAccountAdminApi* | [**CreateAccount**](docs/AggregatorAccountAdminApi.md#createaccount) | **POST** /v3/accounts | Create a new account.
*AggregatorAccountAdminApi* | [**CreateAccountApiKey**](docs/AggregatorAccountAdminApi.md#createaccountapikey) | **POST** /v3/accounts/{accountID}/api-keys | Create a new API key.
*AggregatorAccountAdminApi* | [**CreateAccountPolicy**](docs/AggregatorAccountAdminApi.md#createaccountpolicy) | **POST** /v3/accounts/{accountID}/policies | Create a policy.
*AggregatorAccountAdminApi* | [**CreateAccountUser**](docs/AggregatorAccountAdminApi.md#createaccountuser) | **POST** /v3/accounts/{accountID}/users | Create a new user.
*AggregatorAccountAdminApi* | [**DeleteAccountApiKey**](docs/AggregatorAccountAdminApi.md#deleteaccountapikey) | **DELETE** /v3/accounts/{accountID}/api-keys/{apiKey} | Delete the API key.
*AggregatorAccountAdminApi* | [**DeleteAccountCertificate**](docs/AggregatorAccountAdminApi.md#deleteaccountcertificate) | **DELETE** /v3/accounts/{accountID}/trusted-certificates/{cert-id} | Delete trusted certificate by ID.
*AggregatorAccountAdminApi* | [**DeleteAccountPolicy**](docs/AggregatorAccountAdminApi.md#deleteaccountpolicy) | **DELETE** /v3/accounts/{accountID}/policies/{policy-id} | Delete policy.
*AggregatorAccountAdminApi* | [**DeleteAccountUser**](docs/AggregatorAccountAdminApi.md#deleteaccountuser) | **DELETE** /v3/accounts/{accountID}/users/{user-id} | Delete a user.
*AggregatorAccountAdminApi* | [**DetachAccountPolicyFromApikeys**](docs/AggregatorAccountAdminApi.md#detachaccountpolicyfromapikeys) | **DELETE** /v3/accounts/{accountID}/policies/{policy-id}/api-keys | Detach a policy from API keys.
*AggregatorAccountAdminApi* | [**DetachAccountPolicyFromUsers**](docs/AggregatorAccountAdminApi.md#detachaccountpolicyfromusers) | **DELETE** /v3/accounts/{accountID}/policies/{policy-id}/users | Detach a policy from users.
*AggregatorAccountAdminApi* | [**DetachAccountPolicyToGroup**](docs/AggregatorAccountAdminApi.md#detachaccountpolicytogroup) | **DELETE** /v3/accounts/{accountID}/policies/{policy-id}/groups | Detach a policy to groups.
*AggregatorAccountAdminApi* | [**GetAccountApiKey**](docs/AggregatorAccountAdminApi.md#getaccountapikey) | **GET** /v3/accounts/{accountID}/api-keys/{apiKey} | Get API key details.
*AggregatorAccountAdminApi* | [**GetAccountCertificate**](docs/AggregatorAccountAdminApi.md#getaccountcertificate) | **GET** /v3/accounts/{accountID}/trusted-certificates/{cert-id} | Get trusted certificate by ID.
*AggregatorAccountAdminApi* | [**GetAccountGroupSummary**](docs/AggregatorAccountAdminApi.md#getaccountgroupsummary) | **GET** /v3/accounts/{accountID}/policy-groups/{groupID} | Get group information.
*AggregatorAccountAdminApi* | [**GetAccountInfo**](docs/AggregatorAccountAdminApi.md#getaccountinfo) | **GET** /v3/accounts/{accountID} | Get account info.
*AggregatorAccountAdminApi* | [**GetAccountPolicy**](docs/AggregatorAccountAdminApi.md#getaccountpolicy) | **GET** /v3/accounts/{accountID}/policies/{policy-id} | Get policy by ID.
*AggregatorAccountAdminApi* | [**GetAccountPolicyApikeys**](docs/AggregatorAccountAdminApi.md#getaccountpolicyapikeys) | **GET** /v3/accounts/{accountID}/policies/{policy-id}/api-keys | Fetch details of policy's API keys.
*AggregatorAccountAdminApi* | [**GetAccountPolicyGroups**](docs/AggregatorAccountAdminApi.md#getaccountpolicygroups) | **GET** /v3/accounts/{accountID}/policies/{policy-id}/groups | Fetch details of policy's groups.
*AggregatorAccountAdminApi* | [**GetAccountPolicyUsers**](docs/AggregatorAccountAdminApi.md#getaccountpolicyusers) | **GET** /v3/accounts/{accountID}/policies/{policy-id}/users | Fetch details of policy's users.
*AggregatorAccountAdminApi* | [**GetAccountUser**](docs/AggregatorAccountAdminApi.md#getaccountuser) | **GET** /v3/accounts/{accountID}/users/{user-id} | Details of the user.
*AggregatorAccountAdminApi* | [**GetAllAccountApiKeys**](docs/AggregatorAccountAdminApi.md#getallaccountapikeys) | **GET** /v3/accounts/{accountID}/api-keys | Get all API keys.
*AggregatorAccountAdminApi* | [**GetAllAccountCertificates**](docs/AggregatorAccountAdminApi.md#getallaccountcertificates) | **GET** /v3/accounts/{accountID}/trusted-certificates | Get all trusted certificates.
*AggregatorAccountAdminApi* | [**GetAllAccountGroups**](docs/AggregatorAccountAdminApi.md#getallaccountgroups) | **GET** /v3/accounts/{accountID}/policy-groups | Get all group information.
*AggregatorAccountAdminApi* | [**GetAllAccountPolicies**](docs/AggregatorAccountAdminApi.md#getallaccountpolicies) | **GET** /v3/accounts/{accountID}/policies | Get all policies.
*AggregatorAccountAdminApi* | [**GetAllAccountUsers**](docs/AggregatorAccountAdminApi.md#getallaccountusers) | **GET** /v3/accounts/{accountID}/users | Get all user details.
*AggregatorAccountAdminApi* | [**GetAllAccounts**](docs/AggregatorAccountAdminApi.md#getallaccounts) | **GET** /v3/accounts | Get all accounts.
*AggregatorAccountAdminApi* | [**GetApiKeysOfAccountGroup**](docs/AggregatorAccountAdminApi.md#getapikeysofaccountgroup) | **GET** /v3/accounts/{accountID}/policy-groups/{groupID}/api-keys | Get API keys of a group.
*AggregatorAccountAdminApi* | [**GetGroupsOfAccountApikey**](docs/AggregatorAccountAdminApi.md#getgroupsofaccountapikey) | **GET** /v3/accounts/{accountID}/api-keys/{apiKey}/groups | Get groups of the API key.
*AggregatorAccountAdminApi* | [**GetGroupsOfAccountUser**](docs/AggregatorAccountAdminApi.md#getgroupsofaccountuser) | **GET** /v3/accounts/{accountID}/users/{user-id}/groups | Get groups of the user.
*AggregatorAccountAdminApi* | [**GetUsersOfAccountGroup**](docs/AggregatorAccountAdminApi.md#getusersofaccountgroup) | **GET** /v3/accounts/{accountID}/policy-groups/{groupID}/users | Get users of a group.
*AggregatorAccountAdminApi* | [**RemoveAccountApiKeyFromGroups**](docs/AggregatorAccountAdminApi.md#removeaccountapikeyfromgroups) | **DELETE** /v3/accounts/{accountID}/api-keys/{apiKey}/groups | Remove API key from groups.
*AggregatorAccountAdminApi* | [**RemoveAccountUserFromGroups**](docs/AggregatorAccountAdminApi.md#removeaccountuserfromgroups) | **DELETE** /v3/accounts/{accountID}/users/{user-id}/groups | Remove user from groups.
*AggregatorAccountAdminApi* | [**RemoveApiKeysFromAccountGroup**](docs/AggregatorAccountAdminApi.md#removeapikeysfromaccountgroup) | **DELETE** /v3/accounts/{accountID}/policy-groups/{groupID}/api-keys | Remove API keys from a group.
*AggregatorAccountAdminApi* | [**RemoveUsersFromAccountGroup**](docs/AggregatorAccountAdminApi.md#removeusersfromaccountgroup) | **DELETE** /v3/accounts/{accountID}/policy-groups/{groupID}/users | Remove users from a group.
*AggregatorAccountAdminApi* | [**ResetAccountApiKeySecret**](docs/AggregatorAccountAdminApi.md#resetaccountapikeysecret) | **POST** /v3/accounts/{accountID}/api-keys/{apiKey}/reset-secret | Reset the secret key.
*AggregatorAccountAdminApi* | [**UpdateAccount**](docs/AggregatorAccountAdminApi.md#updateaccount) | **PUT** /v3/accounts/{accountID} | Update attributes of an existing account.
*AggregatorAccountAdminApi* | [**UpdateAccountApiKey**](docs/AggregatorAccountAdminApi.md#updateaccountapikey) | **PUT** /v3/accounts/{accountID}/api-keys/{apiKey} | Update API key details.
*AggregatorAccountAdminApi* | [**UpdateAccountCertificate**](docs/AggregatorAccountAdminApi.md#updateaccountcertificate) | **PUT** /v3/accounts/{accountID}/trusted-certificates/{cert-id} | Update trusted certificate.
*AggregatorAccountAdminApi* | [**UpdateAccountPolicy**](docs/AggregatorAccountAdminApi.md#updateaccountpolicy) | **PUT** /v3/accounts/{accountID}/policies/{policy-id} | Update a policy.
*AggregatorAccountAdminApi* | [**UpdateAccountUser**](docs/AggregatorAccountAdminApi.md#updateaccountuser) | **PUT** /v3/accounts/{accountID}/users/{user-id} | Update user details.
*AggregatorAccountAdminApi* | [**ValidateAccountUserEmail**](docs/AggregatorAccountAdminApi.md#validateaccountuseremail) | **POST** /v3/accounts/{accountID}/users/{user-id}/validate-email | Validate the user email.
*DeveloperApi* | [**AddMeToGroups**](docs/DeveloperApi.md#addmetogroups) | **POST** /v3/users/me/groups | Add user to a list of groupS.
*DeveloperApi* | [**AddMyApiKeyToGroups**](docs/DeveloperApi.md#addmyapikeytogroups) | **POST** /v3/api-keys/me/groups | Add API key to a list of groups.
*DeveloperApi* | [**CreateApiKey**](docs/DeveloperApi.md#createapikey) | **POST** /v3/api-keys | Create a new API key.
*DeveloperApi* | [**DeleteApiKey**](docs/DeveloperApi.md#deleteapikey) | **DELETE** /v3/api-keys/{apiKey} | Delete API key.
*DeveloperApi* | [**DeleteCertificate**](docs/DeveloperApi.md#deletecertificate) | **DELETE** /v3/trusted-certificates/{cert-id} | Delete a trusted certificate by ID.
*DeveloperApi* | [**GetAllApiKeys**](docs/DeveloperApi.md#getallapikeys) | **GET** /v3/api-keys | Get all API keys
*DeveloperApi* | [**GetAllCertificates**](docs/DeveloperApi.md#getallcertificates) | **GET** /v3/trusted-certificates | Get all trusted certificates.
*DeveloperApi* | [**GetAllGroups**](docs/DeveloperApi.md#getallgroups) | **GET** /v3/policy-groups | Get all group information.
*DeveloperApi* | [**GetApiKey**](docs/DeveloperApi.md#getapikey) | **GET** /v3/api-keys/{apiKey} | Get API key details.
*DeveloperApi* | [**GetApiKeysOfGroup**](docs/DeveloperApi.md#getapikeysofgroup) | **GET** /v3/policy-groups/{groupID}/api-keys | Get the API keys of a group.
*DeveloperApi* | [**GetCertificate**](docs/DeveloperApi.md#getcertificate) | **GET** /v3/trusted-certificates/{cert-id} | Get trusted certificate by ID.
*DeveloperApi* | [**GetGroupSummary**](docs/DeveloperApi.md#getgroupsummary) | **GET** /v3/policy-groups/{groupID} | Get group information.
*DeveloperApi* | [**GetGroupsOfMyApiKey**](docs/DeveloperApi.md#getgroupsofmyapikey) | **GET** /v3/api-keys/me/groups | Get groups of the API key.
*DeveloperApi* | [**GetMyAccountInfo**](docs/DeveloperApi.md#getmyaccountinfo) | **GET** /v3/accounts/me | Get account info.
*DeveloperApi* | [**GetMyApiKey**](docs/DeveloperApi.md#getmyapikey) | **GET** /v3/api-keys/me | Get API key details.
*DeveloperApi* | [**GetMyGroups**](docs/DeveloperApi.md#getmygroups) | **GET** /v3/users/me/groups | Get groups of the user.
*DeveloperApi* | [**GetMyUser**](docs/DeveloperApi.md#getmyuser) | **GET** /v3/users/me | Details of the current user.
*DeveloperApi* | [**RemoveApiKeysFromGroup**](docs/DeveloperApi.md#removeapikeysfromgroup) | **DELETE** /v3/policy-groups/{groupID}/api-keys | Remove API keys from a group.
*DeveloperApi* | [**RemoveMeFromGroups**](docs/DeveloperApi.md#removemefromgroups) | **DELETE** /v3/users/me/groups | Remove user from a group.
*DeveloperApi* | [**RemoveMyApiKeyFromGroups**](docs/DeveloperApi.md#removemyapikeyfromgroups) | **DELETE** /v3/api-keys/me/groups | Remove API key from groups.
*DeveloperApi* | [**UpdateApiKey**](docs/DeveloperApi.md#updateapikey) | **PUT** /v3/api-keys/{apiKey} | Update API key details.
*DeveloperApi* | [**UpdateCertificate**](docs/DeveloperApi.md#updatecertificate) | **PUT** /v3/trusted-certificates/{cert-id} | Update trusted certificate.
*DeveloperApi* | [**UpdateMyApiKey**](docs/DeveloperApi.md#updatemyapikey) | **PUT** /v3/api-keys/me | Update API key details.
*DeveloperApi* | [**UpdateMyUser**](docs/DeveloperApi.md#updatemyuser) | **PUT** /v3/users/me | Update user details.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountCreationReq](docs/AccountCreationReq.md)
 - [Model.AccountCreationResp](docs/AccountCreationResp.md)
 - [Model.AccountInfo](docs/AccountInfo.md)
 - [Model.AccountInfoList](docs/AccountInfoList.md)
 - [Model.AccountUpdateReq](docs/AccountUpdateReq.md)
 - [Model.AccountUpdateRootReq](docs/AccountUpdateRootReq.md)
 - [Model.ActiveSession](docs/ActiveSession.md)
 - [Model.AdminUserUpdateReq](docs/AdminUserUpdateReq.md)
 - [Model.ApiKeyInfoReq](docs/ApiKeyInfoReq.md)
 - [Model.ApiKeyInfoResp](docs/ApiKeyInfoResp.md)
 - [Model.ApiKeyInfoRespList](docs/ApiKeyInfoRespList.md)
 - [Model.ApiKeyUpdateReq](docs/ApiKeyUpdateReq.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.FeaturePolicy](docs/FeaturePolicy.md)
 - [Model.Field](docs/Field.md)
 - [Model.GroupCreationInfo](docs/GroupCreationInfo.md)
 - [Model.GroupSummary](docs/GroupSummary.md)
 - [Model.GroupSummaryList](docs/GroupSummaryList.md)
 - [Model.GroupUpdateInfo](docs/GroupUpdateInfo.md)
 - [Model.LoginHistory](docs/LoginHistory.md)
 - [Model.MyUserInfoResp](docs/MyUserInfoResp.md)
 - [Model.PasswordPolicy](docs/PasswordPolicy.md)
 - [Model.PolicyCreationReq](docs/PolicyCreationReq.md)
 - [Model.PolicyInfo](docs/PolicyInfo.md)
 - [Model.PolicyInfoList](docs/PolicyInfoList.md)
 - [Model.PolicyUpdateReq](docs/PolicyUpdateReq.md)
 - [Model.SubjectList](docs/SubjectList.md)
 - [Model.TrustedCertificateInternalResp](docs/TrustedCertificateInternalResp.md)
 - [Model.TrustedCertificateInternalRespList](docs/TrustedCertificateInternalRespList.md)
 - [Model.TrustedCertificateReq](docs/TrustedCertificateReq.md)
 - [Model.TrustedCertificateResp](docs/TrustedCertificateResp.md)
 - [Model.TrustedCertificateRespList](docs/TrustedCertificateRespList.md)
 - [Model.TrustedCertificateRootReq](docs/TrustedCertificateRootReq.md)
 - [Model.TrustedCertificateUpdateReq](docs/TrustedCertificateUpdateReq.md)
 - [Model.UpdatedResponse](docs/UpdatedResponse.md)
 - [Model.UserInfoReq](docs/UserInfoReq.md)
 - [Model.UserInfoResp](docs/UserInfoResp.md)
 - [Model.UserInfoRespList](docs/UserInfoRespList.md)
 - [Model.UserUpdateReq](docs/UserUpdateReq.md)
 - [Model.UserUpdateResp](docs/UserUpdateResp.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header
