# DefectDojo.Api.SystemSettingsApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SystemSettingsList**](SystemSettingsApi.md#systemsettingslist) | **GET** /system_settings/ | 
[**SystemSettingsPartialUpdate**](SystemSettingsApi.md#systemsettingspartialupdate) | **PATCH** /system_settings/{id}/ | 
[**SystemSettingsUpdate**](SystemSettingsApi.md#systemsettingsupdate) | **PUT** /system_settings/{id}/ | 


<a name="systemsettingslist"></a>
# **SystemSettingsList**
> InlineResponse20022 SystemSettingsList (int? limit = null, int? offset = null)



Basic control over System Settings. Use 'id' 1 for PUT, PATCH operations

### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SystemSettingsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SystemSettingsApi();
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20022 result = apiInstance.SystemSettingsList(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemSettingsApi.SystemSettingsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="systemsettingspartialupdate"></a>
# **SystemSettingsPartialUpdate**
> SystemSettings SystemSettingsPartialUpdate (int? id, SystemSettings data)



Basic control over System Settings. Use 'id' 1 for PUT, PATCH operations

### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SystemSettingsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SystemSettingsApi();
            var id = 56;  // int? | A unique integer value identifying this system_ settings.
            var data = new SystemSettings(); // SystemSettings | 

            try
            {
                SystemSettings result = apiInstance.SystemSettingsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemSettingsApi.SystemSettingsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this system_ settings. | 
 **data** | [**SystemSettings**](SystemSettings.md)|  | 

### Return type

[**SystemSettings**](SystemSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="systemsettingsupdate"></a>
# **SystemSettingsUpdate**
> SystemSettings SystemSettingsUpdate (int? id, SystemSettings data)



Basic control over System Settings. Use 'id' 1 for PUT, PATCH operations

### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SystemSettingsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SystemSettingsApi();
            var id = 56;  // int? | A unique integer value identifying this system_ settings.
            var data = new SystemSettings(); // SystemSettings | 

            try
            {
                SystemSettings result = apiInstance.SystemSettingsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemSettingsApi.SystemSettingsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this system_ settings. | 
 **data** | [**SystemSettings**](SystemSettings.md)|  | 

### Return type

[**SystemSettings**](SystemSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

