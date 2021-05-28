# DefectDojo.Api.JiraProductConfigurationsApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JiraProductConfigurationsCreate**](JiraProductConfigurationsApi.md#jiraproductconfigurationscreate) | **POST** /jira_product_configurations/ | 
[**JiraProductConfigurationsDelete**](JiraProductConfigurationsApi.md#jiraproductconfigurationsdelete) | **DELETE** /jira_product_configurations/{id}/ | 
[**JiraProductConfigurationsList**](JiraProductConfigurationsApi.md#jiraproductconfigurationslist) | **GET** /jira_product_configurations/ | 
[**JiraProductConfigurationsPartialUpdate**](JiraProductConfigurationsApi.md#jiraproductconfigurationspartialupdate) | **PATCH** /jira_product_configurations/{id}/ | 
[**JiraProductConfigurationsRead**](JiraProductConfigurationsApi.md#jiraproductconfigurationsread) | **GET** /jira_product_configurations/{id}/ | 
[**JiraProductConfigurationsUpdate**](JiraProductConfigurationsApi.md#jiraproductconfigurationsupdate) | **PUT** /jira_product_configurations/{id}/ | 


<a name="jiraproductconfigurationscreate"></a>
# **JiraProductConfigurationsCreate**
> JIRAProject JiraProductConfigurationsCreate (JIRAProject data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProductConfigurationsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProductConfigurationsApi();
            var data = new JIRAProject(); // JIRAProject | 

            try
            {
                JIRAProject result = apiInstance.JiraProductConfigurationsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProductConfigurationsApi.JiraProductConfigurationsCreate: " + e.Message );
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

<a name="jiraproductconfigurationsdelete"></a>
# **JiraProductConfigurationsDelete**
> void JiraProductConfigurationsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProductConfigurationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProductConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ project.

            try
            {
                apiInstance.JiraProductConfigurationsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProductConfigurationsApi.JiraProductConfigurationsDelete: " + e.Message );
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

<a name="jiraproductconfigurationslist"></a>
# **JiraProductConfigurationsList**
> InlineResponse2009 JiraProductConfigurationsList (decimal? id = null, string jiraInstance = null, string product = null, string component = null, string projectKey = null, string pushAllIssues = null, string enableEngagementEpicMapping = null, string pushNotes = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProductConfigurationsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProductConfigurationsApi();
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
                InlineResponse2009 result = apiInstance.JiraProductConfigurationsList(id, jiraInstance, product, component, projectKey, pushAllIssues, enableEngagementEpicMapping, pushNotes, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProductConfigurationsApi.JiraProductConfigurationsList: " + e.Message );
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

<a name="jiraproductconfigurationspartialupdate"></a>
# **JiraProductConfigurationsPartialUpdate**
> JIRAProject JiraProductConfigurationsPartialUpdate (int? id, JIRAProject data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProductConfigurationsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProductConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ project.
            var data = new JIRAProject(); // JIRAProject | 

            try
            {
                JIRAProject result = apiInstance.JiraProductConfigurationsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProductConfigurationsApi.JiraProductConfigurationsPartialUpdate: " + e.Message );
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

<a name="jiraproductconfigurationsread"></a>
# **JiraProductConfigurationsRead**
> JIRAProject JiraProductConfigurationsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProductConfigurationsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProductConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ project.

            try
            {
                JIRAProject result = apiInstance.JiraProductConfigurationsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProductConfigurationsApi.JiraProductConfigurationsRead: " + e.Message );
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

<a name="jiraproductconfigurationsupdate"></a>
# **JiraProductConfigurationsUpdate**
> JIRAProject JiraProductConfigurationsUpdate (int? id, JIRAProject data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraProductConfigurationsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraProductConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ project.
            var data = new JIRAProject(); // JIRAProject | 

            try
            {
                JIRAProject result = apiInstance.JiraProductConfigurationsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraProductConfigurationsApi.JiraProductConfigurationsUpdate: " + e.Message );
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

