# DefectDojo.Api.JiraFindingMappingsApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JiraFindingMappingsCreate**](JiraFindingMappingsApi.md#jirafindingmappingscreate) | **POST** /jira_finding_mappings/ | 
[**JiraFindingMappingsDelete**](JiraFindingMappingsApi.md#jirafindingmappingsdelete) | **DELETE** /jira_finding_mappings/{id}/ | 
[**JiraFindingMappingsList**](JiraFindingMappingsApi.md#jirafindingmappingslist) | **GET** /jira_finding_mappings/ | 
[**JiraFindingMappingsPartialUpdate**](JiraFindingMappingsApi.md#jirafindingmappingspartialupdate) | **PATCH** /jira_finding_mappings/{id}/ | 
[**JiraFindingMappingsRead**](JiraFindingMappingsApi.md#jirafindingmappingsread) | **GET** /jira_finding_mappings/{id}/ | 
[**JiraFindingMappingsUpdate**](JiraFindingMappingsApi.md#jirafindingmappingsupdate) | **PUT** /jira_finding_mappings/{id}/ | 


<a name="jirafindingmappingscreate"></a>
# **JiraFindingMappingsCreate**
> JIRAIssue JiraFindingMappingsCreate (JIRAIssue data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraFindingMappingsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraFindingMappingsApi();
            var data = new JIRAIssue(); // JIRAIssue | 

            try
            {
                JIRAIssue result = apiInstance.JiraFindingMappingsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraFindingMappingsApi.JiraFindingMappingsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**JIRAIssue**](JIRAIssue.md)|  | 

### Return type

[**JIRAIssue**](JIRAIssue.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirafindingmappingsdelete"></a>
# **JiraFindingMappingsDelete**
> void JiraFindingMappingsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraFindingMappingsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraFindingMappingsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ issue.

            try
            {
                apiInstance.JiraFindingMappingsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraFindingMappingsApi.JiraFindingMappingsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ issue. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirafindingmappingslist"></a>
# **JiraFindingMappingsList**
> InlineResponse2008 JiraFindingMappingsList (decimal? id = null, string jiraId = null, string jiraKey = null, string findingId = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraFindingMappingsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraFindingMappingsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var jiraId = jiraId_example;  // string |  (optional) 
            var jiraKey = jiraKey_example;  // string |  (optional) 
            var findingId = findingId_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2008 result = apiInstance.JiraFindingMappingsList(id, jiraId, jiraKey, findingId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraFindingMappingsApi.JiraFindingMappingsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **jiraId** | **string**|  | [optional] 
 **jiraKey** | **string**|  | [optional] 
 **findingId** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirafindingmappingspartialupdate"></a>
# **JiraFindingMappingsPartialUpdate**
> JIRAIssue JiraFindingMappingsPartialUpdate (int? id, JIRAIssue data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraFindingMappingsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraFindingMappingsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ issue.
            var data = new JIRAIssue(); // JIRAIssue | 

            try
            {
                JIRAIssue result = apiInstance.JiraFindingMappingsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraFindingMappingsApi.JiraFindingMappingsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ issue. | 
 **data** | [**JIRAIssue**](JIRAIssue.md)|  | 

### Return type

[**JIRAIssue**](JIRAIssue.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirafindingmappingsread"></a>
# **JiraFindingMappingsRead**
> JIRAIssue JiraFindingMappingsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraFindingMappingsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraFindingMappingsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ issue.

            try
            {
                JIRAIssue result = apiInstance.JiraFindingMappingsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraFindingMappingsApi.JiraFindingMappingsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ issue. | 

### Return type

[**JIRAIssue**](JIRAIssue.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jirafindingmappingsupdate"></a>
# **JiraFindingMappingsUpdate**
> JIRAIssue JiraFindingMappingsUpdate (int? id, JIRAIssue data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraFindingMappingsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraFindingMappingsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ issue.
            var data = new JIRAIssue(); // JIRAIssue | 

            try
            {
                JIRAIssue result = apiInstance.JiraFindingMappingsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraFindingMappingsApi.JiraFindingMappingsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this jir a_ issue. | 
 **data** | [**JIRAIssue**](JIRAIssue.md)|  | 

### Return type

[**JIRAIssue**](JIRAIssue.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

