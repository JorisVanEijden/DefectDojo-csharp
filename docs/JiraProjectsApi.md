# DefectDojo.Api.JiraProjectsApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JiraProjectsCreate**](JiraProjectsApi.md#jiraprojectscreate) | **POST** /jira_projects/ | 
[**JiraProjectsDelete**](JiraProjectsApi.md#jiraprojectsdelete) | **DELETE** /jira_projects/{id}/ | 
[**JiraProjectsList**](JiraProjectsApi.md#jiraprojectslist) | **GET** /jira_projects/ | 
[**JiraProjectsPartialUpdate**](JiraProjectsApi.md#jiraprojectspartialupdate) | **PATCH** /jira_projects/{id}/ | 
[**JiraProjectsRead**](JiraProjectsApi.md#jiraprojectsread) | **GET** /jira_projects/{id}/ | 
[**JiraProjectsUpdate**](JiraProjectsApi.md#jiraprojectsupdate) | **PUT** /jira_projects/{id}/ | 


<a name="jiraprojectscreate"></a>
# **JiraProjectsCreate**
> JIRAProject JiraProjectsCreate (JIRAProject data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProjectsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProjectsApi();
            var data = new JIRAProject(); // JIRAProject | 

            try
            {
                JIRAProject result = apiInstance.JiraProjectsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProjectsApi.JiraProjectsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**JIRAProject**](JIRAProject.md)|  | 

### Return type

[**JIRAProject**](JIRAProject.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jiraprojectsdelete"></a>
# **JiraProjectsDelete**
> void JiraProjectsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProjectsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProjectsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ project.

            try
            {
                apiInstance.JiraProjectsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProjectsApi.JiraProjectsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ project. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jiraprojectslist"></a>
# **JiraProjectsList**
> InlineResponse2009 JiraProjectsList (decimal? id = null, string jiraInstance = null, string product = null, string component = null, string projectKey = null, string pushAllIssues = null, string enableEngagementEpicMapping = null, string pushNotes = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProjectsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProjectsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var jiraInstance = jiraInstance_example;  // string |  (optional) 
            var product = product_example;  // string |  (optional) 
            var component = component_example;  // string |  (optional) 
            var projectKey = projectKey_example;  // string |  (optional) 
            var pushAllIssues = pushAllIssues_example;  // string |  (optional) 
            var enableEngagementEpicMapping = enableEngagementEpicMapping_example;  // string |  (optional) 
            var pushNotes = pushNotes_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2009 result = apiInstance.JiraProjectsList(id, jiraInstance, product, component, projectKey, pushAllIssues, enableEngagementEpicMapping, pushNotes, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProjectsApi.JiraProjectsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **jiraInstance** | **string**|  | [optional] 
 **product** | **string**|  | [optional] 
 **component** | **string**|  | [optional] 
 **projectKey** | **string**|  | [optional] 
 **pushAllIssues** | **string**|  | [optional] 
 **enableEngagementEpicMapping** | **string**|  | [optional] 
 **pushNotes** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jiraprojectspartialupdate"></a>
# **JiraProjectsPartialUpdate**
> JIRAProject JiraProjectsPartialUpdate (int? id, JIRAProject data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProjectsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProjectsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ project.
            var data = new JIRAProject(); // JIRAProject | 

            try
            {
                JIRAProject result = apiInstance.JiraProjectsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProjectsApi.JiraProjectsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ project. | 
 **data** | [**JIRAProject**](JIRAProject.md)|  | 

### Return type

[**JIRAProject**](JIRAProject.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jiraprojectsread"></a>
# **JiraProjectsRead**
> JIRAProject JiraProjectsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProjectsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProjectsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ project.

            try
            {
                JIRAProject result = apiInstance.JiraProjectsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProjectsApi.JiraProjectsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ project. | 

### Return type

[**JIRAProject**](JIRAProject.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jiraprojectsupdate"></a>
# **JiraProjectsUpdate**
> JIRAProject JiraProjectsUpdate (int? id, JIRAProject data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProjectsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProjectsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ project.
            var data = new JIRAProject(); // JIRAProject | 

            try
            {
                JIRAProject result = apiInstance.JiraProjectsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProjectsApi.JiraProjectsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ project. | 
 **data** | [**JIRAProject**](JIRAProject.md)|  | 

### Return type

[**JIRAProject**](JIRAProject.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

