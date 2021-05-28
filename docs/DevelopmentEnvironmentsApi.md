# DefectDojo.Api.DevelopmentEnvironmentsApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DevelopmentEnvironmentsCreate**](DevelopmentEnvironmentsApi.md#developmentenvironmentscreate) | **POST** /development_environments/ | 
[**DevelopmentEnvironmentsDelete**](DevelopmentEnvironmentsApi.md#developmentenvironmentsdelete) | **DELETE** /development_environments/{id}/ | 
[**DevelopmentEnvironmentsList**](DevelopmentEnvironmentsApi.md#developmentenvironmentslist) | **GET** /development_environments/ | 
[**DevelopmentEnvironmentsPartialUpdate**](DevelopmentEnvironmentsApi.md#developmentenvironmentspartialupdate) | **PATCH** /development_environments/{id}/ | 
[**DevelopmentEnvironmentsRead**](DevelopmentEnvironmentsApi.md#developmentenvironmentsread) | **GET** /development_environments/{id}/ | 
[**DevelopmentEnvironmentsUpdate**](DevelopmentEnvironmentsApi.md#developmentenvironmentsupdate) | **PUT** /development_environments/{id}/ | 


<a name="developmentenvironmentscreate"></a>
# **DevelopmentEnvironmentsCreate**
> DevelopmentEnvironment DevelopmentEnvironmentsCreate (DevelopmentEnvironment data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class DevelopmentEnvironmentsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DevelopmentEnvironmentsApi();
            var data = new DevelopmentEnvironment(); // DevelopmentEnvironment | 

            try
            {
                DevelopmentEnvironment result = apiInstance.DevelopmentEnvironmentsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopmentEnvironmentsApi.DevelopmentEnvironmentsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DevelopmentEnvironment**](DevelopmentEnvironment.md)|  | 

### Return type

[**DevelopmentEnvironment**](DevelopmentEnvironment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="developmentenvironmentsdelete"></a>
# **DevelopmentEnvironmentsDelete**
> void DevelopmentEnvironmentsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class DevelopmentEnvironmentsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DevelopmentEnvironmentsApi();
            var id = 56;  // int? | A unique integer value identifying this development_ environment.

            try
            {
                apiInstance.DevelopmentEnvironmentsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopmentEnvironmentsApi.DevelopmentEnvironmentsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this development_ environment. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="developmentenvironmentslist"></a>
# **DevelopmentEnvironmentsList**
> InlineResponse200 DevelopmentEnvironmentsList (int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class DevelopmentEnvironmentsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DevelopmentEnvironmentsApi();
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse200 result = apiInstance.DevelopmentEnvironmentsList(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopmentEnvironmentsApi.DevelopmentEnvironmentsList: " + e.Message );
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="developmentenvironmentspartialupdate"></a>
# **DevelopmentEnvironmentsPartialUpdate**
> DevelopmentEnvironment DevelopmentEnvironmentsPartialUpdate (int? id, DevelopmentEnvironment data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class DevelopmentEnvironmentsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DevelopmentEnvironmentsApi();
            var id = 56;  // int? | A unique integer value identifying this development_ environment.
            var data = new DevelopmentEnvironment(); // DevelopmentEnvironment | 

            try
            {
                DevelopmentEnvironment result = apiInstance.DevelopmentEnvironmentsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopmentEnvironmentsApi.DevelopmentEnvironmentsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this development_ environment. | 
 **data** | [**DevelopmentEnvironment**](DevelopmentEnvironment.md)|  | 

### Return type

[**DevelopmentEnvironment**](DevelopmentEnvironment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="developmentenvironmentsread"></a>
# **DevelopmentEnvironmentsRead**
> DevelopmentEnvironment DevelopmentEnvironmentsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class DevelopmentEnvironmentsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DevelopmentEnvironmentsApi();
            var id = 56;  // int? | A unique integer value identifying this development_ environment.

            try
            {
                DevelopmentEnvironment result = apiInstance.DevelopmentEnvironmentsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopmentEnvironmentsApi.DevelopmentEnvironmentsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this development_ environment. | 

### Return type

[**DevelopmentEnvironment**](DevelopmentEnvironment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="developmentenvironmentsupdate"></a>
# **DevelopmentEnvironmentsUpdate**
> DevelopmentEnvironment DevelopmentEnvironmentsUpdate (int? id, DevelopmentEnvironment data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class DevelopmentEnvironmentsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DevelopmentEnvironmentsApi();
            var id = 56;  // int? | A unique integer value identifying this development_ environment.
            var data = new DevelopmentEnvironment(); // DevelopmentEnvironment | 

            try
            {
                DevelopmentEnvironment result = apiInstance.DevelopmentEnvironmentsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopmentEnvironmentsApi.DevelopmentEnvironmentsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this development_ environment. | 
 **data** | [**DevelopmentEnvironment**](DevelopmentEnvironment.md)|  | 

### Return type

[**DevelopmentEnvironment**](DevelopmentEnvironment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

