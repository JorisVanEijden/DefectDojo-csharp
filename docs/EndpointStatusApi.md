# DefectDojo.Api.EndpointStatusApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EndpointStatusCreate**](EndpointStatusApi.md#endpointstatuscreate) | **POST** /endpoint_status/ | 
[**EndpointStatusDelete**](EndpointStatusApi.md#endpointstatusdelete) | **DELETE** /endpoint_status/{id}/ | 
[**EndpointStatusList**](EndpointStatusApi.md#endpointstatuslist) | **GET** /endpoint_status/ | 
[**EndpointStatusPartialUpdate**](EndpointStatusApi.md#endpointstatuspartialupdate) | **PATCH** /endpoint_status/{id}/ | 
[**EndpointStatusRead**](EndpointStatusApi.md#endpointstatusread) | **GET** /endpoint_status/{id}/ | 
[**EndpointStatusUpdate**](EndpointStatusApi.md#endpointstatusupdate) | **PUT** /endpoint_status/{id}/ | 


<a name="endpointstatuscreate"></a>
# **EndpointStatusCreate**
> EndpointStatus EndpointStatusCreate (EndpointStatus data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointStatusCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointStatusApi();
            var data = new EndpointStatus(); // EndpointStatus | 

            try
            {
                EndpointStatus result = apiInstance.EndpointStatusCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointStatusApi.EndpointStatusCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**EndpointStatus**](EndpointStatus.md)|  | 

### Return type

[**EndpointStatus**](EndpointStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointstatusdelete"></a>
# **EndpointStatusDelete**
> void EndpointStatusDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointStatusDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointStatusApi();
            var id = 56;  // int? | A unique integer value identifying this endpoint_ status.

            try
            {
                apiInstance.EndpointStatusDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointStatusApi.EndpointStatusDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this endpoint_ status. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointstatuslist"></a>
# **EndpointStatusList**
> InlineResponse2001 EndpointStatusList (int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointStatusListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointStatusApi();
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2001 result = apiInstance.EndpointStatusList(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointStatusApi.EndpointStatusList: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointstatuspartialupdate"></a>
# **EndpointStatusPartialUpdate**
> EndpointStatus EndpointStatusPartialUpdate (int? id, EndpointStatus data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointStatusPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointStatusApi();
            var id = 56;  // int? | A unique integer value identifying this endpoint_ status.
            var data = new EndpointStatus(); // EndpointStatus | 

            try
            {
                EndpointStatus result = apiInstance.EndpointStatusPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointStatusApi.EndpointStatusPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this endpoint_ status. | 
 **data** | [**EndpointStatus**](EndpointStatus.md)|  | 

### Return type

[**EndpointStatus**](EndpointStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointstatusread"></a>
# **EndpointStatusRead**
> EndpointStatus EndpointStatusRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointStatusReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointStatusApi();
            var id = 56;  // int? | A unique integer value identifying this endpoint_ status.

            try
            {
                EndpointStatus result = apiInstance.EndpointStatusRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointStatusApi.EndpointStatusRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this endpoint_ status. | 

### Return type

[**EndpointStatus**](EndpointStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endpointstatusupdate"></a>
# **EndpointStatusUpdate**
> EndpointStatus EndpointStatusUpdate (int? id, EndpointStatus data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EndpointStatusUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointStatusApi();
            var id = 56;  // int? | A unique integer value identifying this endpoint_ status.
            var data = new EndpointStatus(); // EndpointStatus | 

            try
            {
                EndpointStatus result = apiInstance.EndpointStatusUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EndpointStatusApi.EndpointStatusUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this endpoint_ status. | 
 **data** | [**EndpointStatus**](EndpointStatus.md)|  | 

### Return type

[**EndpointStatus**](EndpointStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

