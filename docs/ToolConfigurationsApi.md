# DefectDojo.Api.ToolConfigurationsApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ToolConfigurationsCreate**](ToolConfigurationsApi.md#toolconfigurationscreate) | **POST** /tool_configurations/ | 
[**ToolConfigurationsDelete**](ToolConfigurationsApi.md#toolconfigurationsdelete) | **DELETE** /tool_configurations/{id}/ | 
[**ToolConfigurationsList**](ToolConfigurationsApi.md#toolconfigurationslist) | **GET** /tool_configurations/ | 
[**ToolConfigurationsPartialUpdate**](ToolConfigurationsApi.md#toolconfigurationspartialupdate) | **PATCH** /tool_configurations/{id}/ | 
[**ToolConfigurationsRead**](ToolConfigurationsApi.md#toolconfigurationsread) | **GET** /tool_configurations/{id}/ | 
[**ToolConfigurationsUpdate**](ToolConfigurationsApi.md#toolconfigurationsupdate) | **PUT** /tool_configurations/{id}/ | 


<a name="toolconfigurationscreate"></a>
# **ToolConfigurationsCreate**
> ToolConfiguration ToolConfigurationsCreate (ToolConfiguration data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolConfigurationsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolConfigurationsApi();
            var data = new ToolConfiguration(); // ToolConfiguration | 

            try
            {
                ToolConfiguration result = apiInstance.ToolConfigurationsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolConfigurationsApi.ToolConfigurationsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ToolConfiguration**](ToolConfiguration.md)|  | 

### Return type

[**ToolConfiguration**](ToolConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolconfigurationsdelete"></a>
# **ToolConfigurationsDelete**
> void ToolConfigurationsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolConfigurationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ configuration.

            try
            {
                apiInstance.ToolConfigurationsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolConfigurationsApi.ToolConfigurationsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ configuration. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolconfigurationslist"></a>
# **ToolConfigurationsList**
> InlineResponse20028 ToolConfigurationsList (decimal? id = null, string name = null, string toolType = null, string url = null, string authenticationType = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolConfigurationsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolConfigurationsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var toolType = toolType_example;  // string |  (optional) 
            var url = url_example;  // string |  (optional) 
            var authenticationType = authenticationType_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20028 result = apiInstance.ToolConfigurationsList(id, name, toolType, url, authenticationType, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolConfigurationsApi.ToolConfigurationsList: " + e.Message );
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
 **toolType** | **string**|  | [optional] 
 **url** | **string**|  | [optional] 
 **authenticationType** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolconfigurationspartialupdate"></a>
# **ToolConfigurationsPartialUpdate**
> ToolConfiguration ToolConfigurationsPartialUpdate (int? id, ToolConfiguration data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolConfigurationsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ configuration.
            var data = new ToolConfiguration(); // ToolConfiguration | 

            try
            {
                ToolConfiguration result = apiInstance.ToolConfigurationsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolConfigurationsApi.ToolConfigurationsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ configuration. | 
 **data** | [**ToolConfiguration**](ToolConfiguration.md)|  | 

### Return type

[**ToolConfiguration**](ToolConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolconfigurationsread"></a>
# **ToolConfigurationsRead**
> ToolConfiguration ToolConfigurationsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolConfigurationsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ configuration.

            try
            {
                ToolConfiguration result = apiInstance.ToolConfigurationsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolConfigurationsApi.ToolConfigurationsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ configuration. | 

### Return type

[**ToolConfiguration**](ToolConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolconfigurationsupdate"></a>
# **ToolConfigurationsUpdate**
> ToolConfiguration ToolConfigurationsUpdate (int? id, ToolConfiguration data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolConfigurationsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ configuration.
            var data = new ToolConfiguration(); // ToolConfiguration | 

            try
            {
                ToolConfiguration result = apiInstance.ToolConfigurationsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolConfigurationsApi.ToolConfigurationsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ configuration. | 
 **data** | [**ToolConfiguration**](ToolConfiguration.md)|  | 

### Return type

[**ToolConfiguration**](ToolConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

