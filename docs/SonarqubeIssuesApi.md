# DefectDojo.Api.SonarqubeIssuesApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SonarqubeIssuesCreate**](SonarqubeIssuesApi.md#sonarqubeissuescreate) | **POST** /sonarqube_issues/ | 
[**SonarqubeIssuesDelete**](SonarqubeIssuesApi.md#sonarqubeissuesdelete) | **DELETE** /sonarqube_issues/{id}/ | 
[**SonarqubeIssuesList**](SonarqubeIssuesApi.md#sonarqubeissueslist) | **GET** /sonarqube_issues/ | 
[**SonarqubeIssuesPartialUpdate**](SonarqubeIssuesApi.md#sonarqubeissuespartialupdate) | **PATCH** /sonarqube_issues/{id}/ | 
[**SonarqubeIssuesRead**](SonarqubeIssuesApi.md#sonarqubeissuesread) | **GET** /sonarqube_issues/{id}/ | 
[**SonarqubeIssuesUpdate**](SonarqubeIssuesApi.md#sonarqubeissuesupdate) | **PUT** /sonarqube_issues/{id}/ | 


<a name="sonarqubeissuescreate"></a>
# **SonarqubeIssuesCreate**
> SonarqubeIssue SonarqubeIssuesCreate (SonarqubeIssue data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeIssuesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeIssuesApi();
            var data = new SonarqubeIssue(); // SonarqubeIssue | 

            try
            {
                SonarqubeIssue result = apiInstance.SonarqubeIssuesCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeIssuesApi.SonarqubeIssuesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**SonarqubeIssue**](SonarqubeIssue.md)|  | 

### Return type

[**SonarqubeIssue**](SonarqubeIssue.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeissuesdelete"></a>
# **SonarqubeIssuesDelete**
> void SonarqubeIssuesDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeIssuesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeIssuesApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ issue.

            try
            {
                apiInstance.SonarqubeIssuesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeIssuesApi.SonarqubeIssuesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ issue. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeissueslist"></a>
# **SonarqubeIssuesList**
> InlineResponse20018 SonarqubeIssuesList (decimal? id = null, string key = null, string status = null, string type = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeIssuesListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeIssuesApi();
            var id = 8.14;  // decimal? |  (optional) 
            var key = key_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var type = type_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20018 result = apiInstance.SonarqubeIssuesList(id, key, status, type, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeIssuesApi.SonarqubeIssuesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **key** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **type** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeissuespartialupdate"></a>
# **SonarqubeIssuesPartialUpdate**
> SonarqubeIssue SonarqubeIssuesPartialUpdate (int? id, SonarqubeIssue data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeIssuesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeIssuesApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ issue.
            var data = new SonarqubeIssue(); // SonarqubeIssue | 

            try
            {
                SonarqubeIssue result = apiInstance.SonarqubeIssuesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeIssuesApi.SonarqubeIssuesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ issue. | 
 **data** | [**SonarqubeIssue**](SonarqubeIssue.md)|  | 

### Return type

[**SonarqubeIssue**](SonarqubeIssue.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeissuesread"></a>
# **SonarqubeIssuesRead**
> SonarqubeIssue SonarqubeIssuesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeIssuesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeIssuesApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ issue.

            try
            {
                SonarqubeIssue result = apiInstance.SonarqubeIssuesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeIssuesApi.SonarqubeIssuesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ issue. | 

### Return type

[**SonarqubeIssue**](SonarqubeIssue.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeissuesupdate"></a>
# **SonarqubeIssuesUpdate**
> SonarqubeIssue SonarqubeIssuesUpdate (int? id, SonarqubeIssue data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeIssuesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeIssuesApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ issue.
            var data = new SonarqubeIssue(); // SonarqubeIssue | 

            try
            {
                SonarqubeIssue result = apiInstance.SonarqubeIssuesUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeIssuesApi.SonarqubeIssuesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ issue. | 
 **data** | [**SonarqubeIssue**](SonarqubeIssue.md)|  | 

### Return type

[**SonarqubeIssue**](SonarqubeIssue.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

