# DefectDojo.Api.NoteTypeApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NoteTypeCreate**](NoteTypeApi.md#notetypecreate) | **POST** /note_type/ | 
[**NoteTypeDelete**](NoteTypeApi.md#notetypedelete) | **DELETE** /note_type/{id}/ | 
[**NoteTypeList**](NoteTypeApi.md#notetypelist) | **GET** /note_type/ | 
[**NoteTypePartialUpdate**](NoteTypeApi.md#notetypepartialupdate) | **PATCH** /note_type/{id}/ | 
[**NoteTypeRead**](NoteTypeApi.md#notetyperead) | **GET** /note_type/{id}/ | 
[**NoteTypeUpdate**](NoteTypeApi.md#notetypeupdate) | **PUT** /note_type/{id}/ | 


<a name="notetypecreate"></a>
# **NoteTypeCreate**
> NoteType NoteTypeCreate (NoteType data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NoteTypeCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NoteTypeApi();
            var data = new NoteType(); // NoteType | 

            try
            {
                NoteType result = apiInstance.NoteTypeCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NoteTypeApi.NoteTypeCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**NoteType**](NoteType.md)|  | 

### Return type

[**NoteType**](NoteType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notetypedelete"></a>
# **NoteTypeDelete**
> void NoteTypeDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NoteTypeDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NoteTypeApi();
            var id = 56;  // int? | A unique integer value identifying this note_ type.

            try
            {
                apiInstance.NoteTypeDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NoteTypeApi.NoteTypeDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this note_ type. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notetypelist"></a>
# **NoteTypeList**
> InlineResponse20011 NoteTypeList (decimal? id = null, string name = null, string description = null, string isSingle = null, string isActive = null, string isMandatory = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NoteTypeListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NoteTypeApi();
            var id = 8.14;  // decimal? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var isSingle = isSingle_example;  // string |  (optional) 
            var isActive = isActive_example;  // string |  (optional) 
            var isMandatory = isMandatory_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20011 result = apiInstance.NoteTypeList(id, name, description, isSingle, isActive, isMandatory, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NoteTypeApi.NoteTypeList: " + e.Message );
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
 **isSingle** | **string**|  | [optional] 
 **isActive** | **string**|  | [optional] 
 **isMandatory** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notetypepartialupdate"></a>
# **NoteTypePartialUpdate**
> NoteType NoteTypePartialUpdate (int? id, NoteType data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NoteTypePartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NoteTypeApi();
            var id = 56;  // int? | A unique integer value identifying this note_ type.
            var data = new NoteType(); // NoteType | 

            try
            {
                NoteType result = apiInstance.NoteTypePartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NoteTypeApi.NoteTypePartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this note_ type. | 
 **data** | [**NoteType**](NoteType.md)|  | 

### Return type

[**NoteType**](NoteType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notetyperead"></a>
# **NoteTypeRead**
> NoteType NoteTypeRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NoteTypeReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NoteTypeApi();
            var id = 56;  // int? | A unique integer value identifying this note_ type.

            try
            {
                NoteType result = apiInstance.NoteTypeRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NoteTypeApi.NoteTypeRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this note_ type. | 

### Return type

[**NoteType**](NoteType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notetypeupdate"></a>
# **NoteTypeUpdate**
> NoteType NoteTypeUpdate (int? id, NoteType data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NoteTypeUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NoteTypeApi();
            var id = 56;  // int? | A unique integer value identifying this note_ type.
            var data = new NoteType(); // NoteType | 

            try
            {
                NoteType result = apiInstance.NoteTypeUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NoteTypeApi.NoteTypeUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this note_ type. | 
 **data** | [**NoteType**](NoteType.md)|  | 

### Return type

[**NoteType**](NoteType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

