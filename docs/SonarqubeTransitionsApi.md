# DefectDojo.Api.SonarqubeTransitionsApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SonarqubeTransitionsCreate**](SonarqubeTransitionsApi.md#sonarqubetransitionscreate) | **POST** /sonarqube_transitions/ | 
[**SonarqubeTransitionsDelete**](SonarqubeTransitionsApi.md#sonarqubetransitionsdelete) | **DELETE** /sonarqube_transitions/{id}/ | 
[**SonarqubeTransitionsList**](SonarqubeTransitionsApi.md#sonarqubetransitionslist) | **GET** /sonarqube_transitions/ | 
[**SonarqubeTransitionsPartialUpdate**](SonarqubeTransitionsApi.md#sonarqubetransitionspartialupdate) | **PATCH** /sonarqube_transitions/{id}/ | 
[**SonarqubeTransitionsRead**](SonarqubeTransitionsApi.md#sonarqubetransitionsread) | **GET** /sonarqube_transitions/{id}/ | 
[**SonarqubeTransitionsUpdate**](SonarqubeTransitionsApi.md#sonarqubetransitionsupdate) | **PUT** /sonarqube_transitions/{id}/ | 


<a name="sonarqubetransitionscreate"></a>
# **SonarqubeTransitionsCreate**
> SonarqubeIssueTransition SonarqubeTransitionsCreate (SonarqubeIssueTransition data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeTransitionsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeTransitionsApi();
            var data = new SonarqubeIssueTransition(); // SonarqubeIssueTransition | 

            try
            {
                SonarqubeIssueTransition result = apiInstance.SonarqubeTransitionsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeTransitionsApi.SonarqubeTransitionsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**SonarqubeIssueTransition**](SonarqubeIssueTransition.md)|  | 

### Return type

[**SonarqubeIssueTransition**](SonarqubeIssueTransition.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubetransitionsdelete"></a>
# **SonarqubeTransitionsDelete**
> void SonarqubeTransitionsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeTransitionsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeTransitionsApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ issue_ transition.

            try
            {
                apiInstance.SonarqubeTransitionsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeTransitionsApi.SonarqubeTransitionsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ issue_ transition. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubetransitionslist"></a>
# **SonarqubeTransitionsList**
> InlineResponse20020 SonarqubeTransitionsList (decimal? id = null, string sonarqubeIssue = null, string findingStatus = null, string sonarqubeStatus = null, string transitions = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeTransitionsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeTransitionsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var sonarqubeIssue = sonarqubeIssue_example;  // string |  (optional) 
            var findingStatus = findingStatus_example;  // string |  (optional) 
            var sonarqubeStatus = sonarqubeStatus_example;  // string |  (optional) 
            var transitions = transitions_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20020 result = apiInstance.SonarqubeTransitionsList(id, sonarqubeIssue, findingStatus, sonarqubeStatus, transitions, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeTransitionsApi.SonarqubeTransitionsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **sonarqubeIssue** | **string**|  | [optional] 
 **findingStatus** | **string**|  | [optional] 
 **sonarqubeStatus** | **string**|  | [optional] 
 **transitions** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubetransitionspartialupdate"></a>
# **SonarqubeTransitionsPartialUpdate**
> SonarqubeIssueTransition SonarqubeTransitionsPartialUpdate (int? id, SonarqubeIssueTransition data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeTransitionsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeTransitionsApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ issue_ transition.
            var data = new SonarqubeIssueTransition(); // SonarqubeIssueTransition | 

            try
            {
                SonarqubeIssueTransition result = apiInstance.SonarqubeTransitionsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeTransitionsApi.SonarqubeTransitionsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ issue_ transition. | 
 **data** | [**SonarqubeIssueTransition**](SonarqubeIssueTransition.md)|  | 

### Return type

[**SonarqubeIssueTransition**](SonarqubeIssueTransition.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubetransitionsread"></a>
# **SonarqubeTransitionsRead**
> SonarqubeIssueTransition SonarqubeTransitionsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeTransitionsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeTransitionsApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ issue_ transition.

            try
            {
                SonarqubeIssueTransition result = apiInstance.SonarqubeTransitionsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeTransitionsApi.SonarqubeTransitionsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ issue_ transition. | 

### Return type

[**SonarqubeIssueTransition**](SonarqubeIssueTransition.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubetransitionsupdate"></a>
# **SonarqubeTransitionsUpdate**
> SonarqubeIssueTransition SonarqubeTransitionsUpdate (int? id, SonarqubeIssueTransition data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeTransitionsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeTransitionsApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ issue_ transition.
            var data = new SonarqubeIssueTransition(); // SonarqubeIssueTransition | 

            try
            {
                SonarqubeIssueTransition result = apiInstance.SonarqubeTransitionsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeTransitionsApi.SonarqubeTransitionsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ issue_ transition. | 
 **data** | [**SonarqubeIssueTransition**](SonarqubeIssueTransition.md)|  | 

### Return type

[**SonarqubeIssueTransition**](SonarqubeIssueTransition.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

