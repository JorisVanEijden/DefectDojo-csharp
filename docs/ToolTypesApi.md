# DefectDojo.Api.ToolTypesApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ToolTypesCreate**](ToolTypesApi.md#tooltypescreate) | **POST** /tool_types/ | 
[**ToolTypesDelete**](ToolTypesApi.md#tooltypesdelete) | **DELETE** /tool_types/{id}/ | 
[**ToolTypesList**](ToolTypesApi.md#tooltypeslist) | **GET** /tool_types/ | 
[**ToolTypesPartialUpdate**](ToolTypesApi.md#tooltypespartialupdate) | **PATCH** /tool_types/{id}/ | 
[**ToolTypesRead**](ToolTypesApi.md#tooltypesread) | **GET** /tool_types/{id}/ | 
[**ToolTypesUpdate**](ToolTypesApi.md#tooltypesupdate) | **PUT** /tool_types/{id}/ | 


<a name="tooltypescreate"></a>
# **ToolTypesCreate**
> ToolType ToolTypesCreate (ToolType data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolTypesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolTypesApi();
            var data = new ToolType(); // ToolType | 

            try
            {
                ToolType result = apiInstance.ToolTypesCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolTypesApi.ToolTypesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ToolType**](ToolType.md)|  | 

### Return type

[**ToolType**](ToolType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tooltypesdelete"></a>
# **ToolTypesDelete**
> void ToolTypesDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolTypesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolTypesApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ type.

            try
            {
                apiInstance.ToolTypesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolTypesApi.ToolTypesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ type. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tooltypeslist"></a>
# **ToolTypesList**
> InlineResponse20030 ToolTypesList (decimal? id = null, string name = null, string description = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolTypesListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolTypesApi();
            var id = 8.14;  // decimal? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20030 result = apiInstance.ToolTypesList(id, name, description, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolTypesApi.ToolTypesList: " + e.Message );
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
 **description** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tooltypespartialupdate"></a>
# **ToolTypesPartialUpdate**
> ToolType ToolTypesPartialUpdate (int? id, ToolType data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolTypesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolTypesApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ type.
            var data = new ToolType(); // ToolType | 

            try
            {
                ToolType result = apiInstance.ToolTypesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolTypesApi.ToolTypesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ type. | 
 **data** | [**ToolType**](ToolType.md)|  | 

### Return type

[**ToolType**](ToolType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tooltypesread"></a>
# **ToolTypesRead**
> ToolType ToolTypesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolTypesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolTypesApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ type.

            try
            {
                ToolType result = apiInstance.ToolTypesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolTypesApi.ToolTypesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ type. | 

### Return type

[**ToolType**](ToolType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tooltypesupdate"></a>
# **ToolTypesUpdate**
> ToolType ToolTypesUpdate (int? id, ToolType data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ToolTypesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ToolTypesApi();
            var id = 56;  // int? | A unique integer value identifying this tool_ type.
            var data = new ToolType(); // ToolType | 

            try
            {
                ToolType result = apiInstance.ToolTypesUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToolTypesApi.ToolTypesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this tool_ type. | 
 **data** | [**ToolType**](ToolType.md)|  | 

### Return type

[**ToolType**](ToolType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

