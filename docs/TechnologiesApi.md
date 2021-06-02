# DefectDojo.Api.TechnologiesApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TechnologiesCreate**](TechnologiesApi.md#technologiescreate) | **POST** /technologies/ | 
[**TechnologiesDelete**](TechnologiesApi.md#technologiesdelete) | **DELETE** /technologies/{id}/ | 
[**TechnologiesList**](TechnologiesApi.md#technologieslist) | **GET** /technologies/ | 
[**TechnologiesPartialUpdate**](TechnologiesApi.md#technologiespartialupdate) | **PATCH** /technologies/{id}/ | 
[**TechnologiesRead**](TechnologiesApi.md#technologiesread) | **GET** /technologies/{id}/ | 
[**TechnologiesUpdate**](TechnologiesApi.md#technologiesupdate) | **PUT** /technologies/{id}/ | 


<a name="technologiescreate"></a>
# **TechnologiesCreate**
> AppAnalysis TechnologiesCreate (AppAnalysis data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TechnologiesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TechnologiesApi();
            var data = new AppAnalysis(); // AppAnalysis | 

            try
            {
                AppAnalysis result = apiInstance.TechnologiesCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnologiesApi.TechnologiesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**AppAnalysis**](AppAnalysis.md)|  | 

### Return type

[**AppAnalysis**](AppAnalysis.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="technologiesdelete"></a>
# **TechnologiesDelete**
> void TechnologiesDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TechnologiesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TechnologiesApi();
            var id = 56;  // int? | A unique integer value identifying this app_ analysis.

            try
            {
                apiInstance.TechnologiesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnologiesApi.TechnologiesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this app_ analysis. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="technologieslist"></a>
# **TechnologiesList**
> InlineResponse20023 TechnologiesList (string product = null, string name = null, string user = null, string version = null, string tags = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TechnologiesListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TechnologiesApi();
            var product = product_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var user = user_example;  // string |  (optional) 
            var version = version_example;  // string |  (optional) 
            var tags = tags_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20023 result = apiInstance.TechnologiesList(product, name, user, version, tags, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnologiesApi.TechnologiesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **product** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **user** | **string**|  | [optional] 
 **version** | **string**|  | [optional] 
 **tags** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="technologiespartialupdate"></a>
# **TechnologiesPartialUpdate**
> AppAnalysis TechnologiesPartialUpdate (int? id, AppAnalysis data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TechnologiesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TechnologiesApi();
            var id = 56;  // int? | A unique integer value identifying this app_ analysis.
            var data = new AppAnalysis(); // AppAnalysis | 

            try
            {
                AppAnalysis result = apiInstance.TechnologiesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnologiesApi.TechnologiesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this app_ analysis. | 
 **data** | [**AppAnalysis**](AppAnalysis.md)|  | 

### Return type

[**AppAnalysis**](AppAnalysis.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="technologiesread"></a>
# **TechnologiesRead**
> AppAnalysis TechnologiesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TechnologiesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TechnologiesApi();
            var id = 56;  // int? | A unique integer value identifying this app_ analysis.

            try
            {
                AppAnalysis result = apiInstance.TechnologiesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnologiesApi.TechnologiesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this app_ analysis. | 

### Return type

[**AppAnalysis**](AppAnalysis.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="technologiesupdate"></a>
# **TechnologiesUpdate**
> AppAnalysis TechnologiesUpdate (int? id, AppAnalysis data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TechnologiesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TechnologiesApi();
            var id = 56;  // int? | A unique integer value identifying this app_ analysis.
            var data = new AppAnalysis(); // AppAnalysis | 

            try
            {
                AppAnalysis result = apiInstance.TechnologiesUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TechnologiesApi.TechnologiesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this app_ analysis. | 
 **data** | [**AppAnalysis**](AppAnalysis.md)|  | 

### Return type

[**AppAnalysis**](AppAnalysis.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

