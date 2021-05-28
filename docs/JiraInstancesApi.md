# DefectDojo.Api.JiraInstancesApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JiraInstancesCreate**](JiraInstancesApi.md#jirainstancescreate) | **POST** /jira_instances/ | 
[**JiraInstancesDelete**](JiraInstancesApi.md#jirainstancesdelete) | **DELETE** /jira_instances/{id}/ | 
[**JiraInstancesList**](JiraInstancesApi.md#jirainstanceslist) | **GET** /jira_instances/ | 
[**JiraInstancesPartialUpdate**](JiraInstancesApi.md#jirainstancespartialupdate) | **PATCH** /jira_instances/{id}/ | 
[**JiraInstancesRead**](JiraInstancesApi.md#jirainstancesread) | **GET** /jira_instances/{id}/ | 
[**JiraInstancesUpdate**](JiraInstancesApi.md#jirainstancesupdate) | **PUT** /jira_instances/{id}/ | 


<a name="jirainstancescreate"></a>
# **JiraInstancesCreate**
> JIRAInstance JiraInstancesCreate (JIRAInstance data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraInstancesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraInstancesApi();
            var data = new JIRAInstance(); // JIRAInstance | 

            try
            {
                JIRAInstance result = apiInstance.JiraInstancesCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraInstancesApi.JiraInstancesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**JIRAInstance**](JIRAInstance.md)|  | 

### Return type

[**JIRAInstance**](JIRAInstance.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirainstancesdelete"></a>
# **JiraInstancesDelete**
> void JiraInstancesDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraInstancesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraInstancesApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ instance.

            try
            {
                apiInstance.JiraInstancesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraInstancesApi.JiraInstancesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ instance. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirainstanceslist"></a>
# **JiraInstancesList**
> InlineResponse2007 JiraInstancesList (decimal? id = null, string url = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraInstancesListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraInstancesApi();
            var id = 8.14;  // decimal? |  (optional) 
            var url = url_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2007 result = apiInstance.JiraInstancesList(id, url, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraInstancesApi.JiraInstancesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **url** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirainstancespartialupdate"></a>
# **JiraInstancesPartialUpdate**
> JIRAInstance JiraInstancesPartialUpdate (int? id, JIRAInstance data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraInstancesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraInstancesApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ instance.
            var data = new JIRAInstance(); // JIRAInstance | 

            try
            {
                JIRAInstance result = apiInstance.JiraInstancesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraInstancesApi.JiraInstancesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ instance. | 
 **data** | [**JIRAInstance**](JIRAInstance.md)|  | 

### Return type

[**JIRAInstance**](JIRAInstance.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirainstancesread"></a>
# **JiraInstancesRead**
> JIRAInstance JiraInstancesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraInstancesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraInstancesApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ instance.

            try
            {
                JIRAInstance result = apiInstance.JiraInstancesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraInstancesApi.JiraInstancesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ instance. | 

### Return type

[**JIRAInstance**](JIRAInstance.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirainstancesupdate"></a>
# **JiraInstancesUpdate**
> JIRAInstance JiraInstancesUpdate (int? id, JIRAInstance data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraInstancesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraInstancesApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ instance.
            var data = new JIRAInstance(); // JIRAInstance | 

            try
            {
                JIRAInstance result = apiInstance.JiraInstancesUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraInstancesApi.JiraInstancesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ instance. | 
 **data** | [**JIRAInstance**](JIRAInstance.md)|  | 

### Return type

[**JIRAInstance**](JIRAInstance.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

