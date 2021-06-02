# DefectDojo.Api.TestImportsApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TestImportsDelete**](TestImportsApi.md#testimportsdelete) | **DELETE** /test_imports/{id}/ | 
[**TestImportsList**](TestImportsApi.md#testimportslist) | **GET** /test_imports/ | 
[**TestImportsRead**](TestImportsApi.md#testimportsread) | **GET** /test_imports/{id}/ | 


<a name="testimportsdelete"></a>
# **TestImportsDelete**
> void TestImportsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestImportsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestImportsApi();
            var id = 56;  // int? | A unique integer value identifying this test_ import.

            try
            {
                apiInstance.TestImportsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestImportsApi.TestImportsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test_ import. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testimportslist"></a>
# **TestImportsList**
> InlineResponse20024 TestImportsList (string test = null, string findingsAffected = null, string version = null, string branchTag = null, string buildId = null, string commitHash = null, string testImportFindingActionAction = null, string testImportFindingActionFinding = null, string testImportFindingActionCreated = null, int? limit = null, int? offset = null, List<string> prefetch = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestImportsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestImportsApi();
            var test = test_example;  // string |  (optional) 
            var findingsAffected = findingsAffected_example;  // string |  (optional) 
            var version = version_example;  // string |  (optional) 
            var branchTag = branchTag_example;  // string |  (optional) 
            var buildId = buildId_example;  // string |  (optional) 
            var commitHash = commitHash_example;  // string |  (optional) 
            var testImportFindingActionAction = testImportFindingActionAction_example;  // string |  (optional) 
            var testImportFindingActionFinding = testImportFindingActionFinding_example;  // string |  (optional) 
            var testImportFindingActionCreated = testImportFindingActionCreated_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var prefetch = prefetch_example;  // List<string> |  (optional) 

            try
            {
                InlineResponse20024 result = apiInstance.TestImportsList(test, findingsAffected, version, branchTag, buildId, commitHash, testImportFindingActionAction, testImportFindingActionFinding, testImportFindingActionCreated, limit, offset, prefetch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestImportsApi.TestImportsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **test** | **string**|  | [optional] 
 **findingsAffected** | **string**|  | [optional] 
 **version** | **string**|  | [optional] 
 **branchTag** | **string**|  | [optional] 
 **buildId** | **string**|  | [optional] 
 **commitHash** | **string**|  | [optional] 
 **testImportFindingActionAction** | **string**|  | [optional] 
 **testImportFindingActionFinding** | **string**|  | [optional] 
 **testImportFindingActionCreated** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **prefetch** | **List&lt;string&gt;**|  | [optional] 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testimportsread"></a>
# **TestImportsRead**
> InlineResponse20025 TestImportsRead (int? id, List<string> prefetch = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestImportsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestImportsApi();
            var id = 56;  // int? | A unique integer value identifying this test_ import.
            var prefetch = prefetch_example;  // List<string> |  (optional) 

            try
            {
                InlineResponse20025 result = apiInstance.TestImportsRead(id, prefetch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestImportsApi.TestImportsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test_ import. | 
 **prefetch** | **List&lt;string&gt;**|  | [optional] 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

