# DefectDojo.Api.JiraConfigurationsApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JiraConfigurationsCreate**](JiraConfigurationsApi.md#jiraconfigurationscreate) | **POST** /jira_configurations/ | 
[**JiraConfigurationsDelete**](JiraConfigurationsApi.md#jiraconfigurationsdelete) | **DELETE** /jira_configurations/{id}/ | 
[**JiraConfigurationsList**](JiraConfigurationsApi.md#jiraconfigurationslist) | **GET** /jira_configurations/ | 
[**JiraConfigurationsPartialUpdate**](JiraConfigurationsApi.md#jiraconfigurationspartialupdate) | **PATCH** /jira_configurations/{id}/ | 
[**JiraConfigurationsRead**](JiraConfigurationsApi.md#jiraconfigurationsread) | **GET** /jira_configurations/{id}/ | 
[**JiraConfigurationsUpdate**](JiraConfigurationsApi.md#jiraconfigurationsupdate) | **PUT** /jira_configurations/{id}/ | 


<a name="jiraconfigurationscreate"></a>
# **JiraConfigurationsCreate**
> JIRAInstance JiraConfigurationsCreate (JIRAInstance data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraConfigurationsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraConfigurationsApi();
            var data = new JIRAInstance(); // JIRAInstance | 

            try
            {
                JIRAInstance result = apiInstance.JiraConfigurationsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraConfigurationsApi.JiraConfigurationsCreate: " + e.Message );
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

<a name="jiraconfigurationsdelete"></a>
# **JiraConfigurationsDelete**
> void JiraConfigurationsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraConfigurationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ instance.

            try
            {
                apiInstance.JiraConfigurationsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraConfigurationsApi.JiraConfigurationsDelete: " + e.Message );
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

<a name="jiraconfigurationslist"></a>
# **JiraConfigurationsList**
> InlineResponse2007 JiraConfigurationsList (decimal? id = null, string url = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraConfigurationsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraConfigurationsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var url = url_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2007 result = apiInstance.JiraConfigurationsList(id, url, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraConfigurationsApi.JiraConfigurationsList: " + e.Message );
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

<a name="jiraconfigurationspartialupdate"></a>
# **JiraConfigurationsPartialUpdate**
> JIRAInstance JiraConfigurationsPartialUpdate (int? id, JIRAInstance data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraConfigurationsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ instance.
            var data = new JIRAInstance(); // JIRAInstance | 

            try
            {
                JIRAInstance result = apiInstance.JiraConfigurationsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraConfigurationsApi.JiraConfigurationsPartialUpdate: " + e.Message );
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

<a name="jiraconfigurationsread"></a>
# **JiraConfigurationsRead**
> JIRAInstance JiraConfigurationsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraConfigurationsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ instance.

            try
            {
                JIRAInstance result = apiInstance.JiraConfigurationsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraConfigurationsApi.JiraConfigurationsRead: " + e.Message );
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

<a name="jiraconfigurationsupdate"></a>
# **JiraConfigurationsUpdate**
> JIRAInstance JiraConfigurationsUpdate (int? id, JIRAInstance data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class JiraConfigurationsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JiraConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this jir a_ instance.
            var data = new JIRAInstance(); // JIRAInstance | 

            try
            {
                JIRAInstance result = apiInstance.JiraConfigurationsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JiraConfigurationsApi.JiraConfigurationsUpdate: " + e.Message );
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

