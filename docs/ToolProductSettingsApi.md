# DefectDojo.Api.ToolProductSettingsApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ToolProductSettingsCreate**](ToolProductSettingsApi.md#toolproductsettingscreate) | **POST** /tool_product_settings/ | 
[**ToolProductSettingsDelete**](ToolProductSettingsApi.md#toolproductsettingsdelete) | **DELETE** /tool_product_settings/{id}/ | 
[**ToolProductSettingsList**](ToolProductSettingsApi.md#toolproductsettingslist) | **GET** /tool_product_settings/ | 
[**ToolProductSettingsPartialUpdate**](ToolProductSettingsApi.md#toolproductsettingspartialupdate) | **PATCH** /tool_product_settings/{id}/ | 
[**ToolProductSettingsRead**](ToolProductSettingsApi.md#toolproductsettingsread) | **GET** /tool_product_settings/{id}/ | 
[**ToolProductSettingsUpdate**](ToolProductSettingsApi.md#toolproductsettingsupdate) | **PUT** /tool_product_settings/{id}/ | 


<a name="toolproductsettingscreate"></a>
# **ToolProductSettingsCreate**
> ToolProductSettings ToolProductSettingsCreate (ToolProductSettings data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolProductSettingsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolProductSettingsApi();
            var data = new ToolProductSettings(); // ToolProductSettings | 

            try
            {
                ToolProductSettings result = apiInstance.ToolProductSettingsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolProductSettingsApi.ToolProductSettingsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ToolProductSettings**](ToolProductSettings.md)|  | 

### Return type

[**ToolProductSettings**](ToolProductSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolproductsettingsdelete"></a>
# **ToolProductSettingsDelete**
> void ToolProductSettingsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolProductSettingsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolProductSettingsApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ product_ settings.

            try
            {
                apiInstance.ToolProductSettingsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolProductSettingsApi.ToolProductSettingsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ product_ settings. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolproductsettingslist"></a>
# **ToolProductSettingsList**
> InlineResponse20029 ToolProductSettingsList (decimal? id = null, string name = null, string product = null, string toolConfiguration = null, string toolProjectId = null, string url = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolProductSettingsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolProductSettingsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var product = product_example;  // string |  (optional) 
            var toolConfiguration = toolConfiguration_example;  // string |  (optional) 
            var toolProjectId = toolProjectId_example;  // string |  (optional) 
            var url = url_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20029 result = apiInstance.ToolProductSettingsList(id, name, product, toolConfiguration, toolProjectId, url, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolProductSettingsApi.ToolProductSettingsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **name** | **string**|  | [optional] 
 **product** | **string**|  | [optional] 
 **toolConfiguration** | **string**|  | [optional] 
 **toolProjectId** | **string**|  | [optional] 
 **url** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolproductsettingspartialupdate"></a>
# **ToolProductSettingsPartialUpdate**
> ToolProductSettings ToolProductSettingsPartialUpdate (int? id, ToolProductSettings data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolProductSettingsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolProductSettingsApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ product_ settings.
            var data = new ToolProductSettings(); // ToolProductSettings | 

            try
            {
                ToolProductSettings result = apiInstance.ToolProductSettingsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolProductSettingsApi.ToolProductSettingsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ product_ settings. | 
 **data** | [**ToolProductSettings**](ToolProductSettings.md)|  | 

### Return type

[**ToolProductSettings**](ToolProductSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolproductsettingsread"></a>
# **ToolProductSettingsRead**
> ToolProductSettings ToolProductSettingsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolProductSettingsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolProductSettingsApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ product_ settings.

            try
            {
                ToolProductSettings result = apiInstance.ToolProductSettingsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolProductSettingsApi.ToolProductSettingsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ product_ settings. | 

### Return type

[**ToolProductSettings**](ToolProductSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolproductsettingsupdate"></a>
# **ToolProductSettingsUpdate**
> ToolProductSettings ToolProductSettingsUpdate (int? id, ToolProductSettings data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolProductSettingsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolProductSettingsApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ product_ settings.
            var data = new ToolProductSettings(); // ToolProductSettings | 

            try
            {
                ToolProductSettings result = apiInstance.ToolProductSettingsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolProductSettingsApi.ToolProductSettingsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ product_ settings. | 
 **data** | [**ToolProductSettings**](ToolProductSettings.md)|  | 

### Return type

[**ToolProductSettings**](ToolProductSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

