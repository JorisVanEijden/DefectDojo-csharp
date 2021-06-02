# DefectDojo.Api.EndpointsApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EndpointsCreate**](EndpointsApi.md#endpointscreate) | **POST** /endpoints/ | 
[**EndpointsDelete**](EndpointsApi.md#endpointsdelete) | **DELETE** /endpoints/{id}/ | 
[**EndpointsGenerateReport**](EndpointsApi.md#endpointsgeneratereport) | **POST** /endpoints/{id}/generate_report/ | 
[**EndpointsList**](EndpointsApi.md#endpointslist) | **GET** /endpoints/ | 
[**EndpointsPartialUpdate**](EndpointsApi.md#endpointspartialupdate) | **PATCH** /endpoints/{id}/ | 
[**EndpointsRead**](EndpointsApi.md#endpointsread) | **GET** /endpoints/{id}/ | 
[**EndpointsUpdate**](EndpointsApi.md#endpointsupdate) | **PUT** /endpoints/{id}/ | 


<a name="endpointscreate"></a>
# **EndpointsCreate**
> Endpoint EndpointsCreate (Endpoint data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var data = new Endpoint(); // Endpoint | 

            try
            {
                Endpoint result = apiInstance.EndpointsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.EndpointsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Endpoint**](Endpoint.md)|  | 

### Return type

[**Endpoint**](Endpoint.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointsdelete"></a>
# **EndpointsDelete**
> void EndpointsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 56;  // int? | A unique integer value identifying this endpoint.

            try
            {
                apiInstance.EndpointsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.EndpointsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this endpoint. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointsgeneratereport"></a>
# **EndpointsGenerateReport**
> ReportGenerate EndpointsGenerateReport (int? id, ReportGenerateOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointsGenerateReportExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 56;  // int? | A unique integer value identifying this endpoint.
            var data = new ReportGenerateOption(); // ReportGenerateOption | 

            try
            {
                ReportGenerate result = apiInstance.EndpointsGenerateReport(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.EndpointsGenerateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this endpoint. | 
 **data** | [**ReportGenerateOption**](ReportGenerateOption.md)|  | 

### Return type

[**ReportGenerate**](ReportGenerate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointslist"></a>
# **EndpointsList**
> InlineResponse2002 EndpointsList (decimal? id = null, string host = null, string product = null, string tags = null, string o = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var host = host_example;  // string |  (optional) 
            var product = product_example;  // string |  (optional) 
            var tags = tags_example;  // string |  (optional) 
            var o = o_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2002 result = apiInstance.EndpointsList(id, host, product, tags, o, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.EndpointsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **host** | **string**|  | [optional] 
 **product** | **string**|  | [optional] 
 **tags** | **string**|  | [optional] 
 **o** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointspartialupdate"></a>
# **EndpointsPartialUpdate**
> Endpoint EndpointsPartialUpdate (int? id, Endpoint data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 56;  // int? | A unique integer value identifying this endpoint.
            var data = new Endpoint(); // Endpoint | 

            try
            {
                Endpoint result = apiInstance.EndpointsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.EndpointsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this endpoint. | 
 **data** | [**Endpoint**](Endpoint.md)|  | 

### Return type

[**Endpoint**](Endpoint.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointsread"></a>
# **EndpointsRead**
> Endpoint EndpointsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 56;  // int? | A unique integer value identifying this endpoint.

            try
            {
                Endpoint result = apiInstance.EndpointsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.EndpointsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this endpoint. | 

### Return type

[**Endpoint**](Endpoint.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointsupdate"></a>
# **EndpointsUpdate**
> Endpoint EndpointsUpdate (int? id, Endpoint data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi();
            var id = 56;  // int? | A unique integer value identifying this endpoint.
            var data = new Endpoint(); // Endpoint | 

            try
            {
                Endpoint result = apiInstance.EndpointsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointsApi.EndpointsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this endpoint. | 
 **data** | [**Endpoint**](Endpoint.md)|  | 

### Return type

[**Endpoint**](Endpoint.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

