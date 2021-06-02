# DefectDojo.Api.TestsApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TestsAcceptRisks**](TestsApi.md#testsacceptrisks) | **POST** /tests/{id}/accept_risks/ | 
[**TestsCreate**](TestsApi.md#testscreate) | **POST** /tests/ | 
[**TestsDelete**](TestsApi.md#testsdelete) | **DELETE** /tests/{id}/ | 
[**TestsFilesCreate**](TestsApi.md#testsfilescreate) | **POST** /tests/{id}/files/ | 
[**TestsFilesPartialUpdate**](TestsApi.md#testsfilespartialupdate) | **PATCH** /tests/{id}/files/ | 
[**TestsFilesRead**](TestsApi.md#testsfilesread) | **GET** /tests/{id}/files/ | 
[**TestsGenerateReport**](TestsApi.md#testsgeneratereport) | **POST** /tests/{id}/generate_report/ | 
[**TestsList**](TestsApi.md#testslist) | **GET** /tests/ | 
[**TestsNotesCreate**](TestsApi.md#testsnotescreate) | **POST** /tests/{id}/notes/ | 
[**TestsNotesPartialUpdate**](TestsApi.md#testsnotespartialupdate) | **PATCH** /tests/{id}/notes/ | 
[**TestsNotesRead**](TestsApi.md#testsnotesread) | **GET** /tests/{id}/notes/ | 
[**TestsPartialUpdate**](TestsApi.md#testspartialupdate) | **PATCH** /tests/{id}/ | 
[**TestsRead**](TestsApi.md#testsread) | **GET** /tests/{id}/ | 
[**TestsUpdate**](TestsApi.md#testsupdate) | **PUT** /tests/{id}/ | 


<a name="testsacceptrisks"></a>
# **TestsAcceptRisks**
> RiskAcceptance TestsAcceptRisks (int? id, List<AcceptedRisk> data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsAcceptRisksExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.
            var data = new List<AcceptedRisk>(); // List<AcceptedRisk> | 

            try
            {
                RiskAcceptance result = apiInstance.TestsAcceptRisks(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsAcceptRisks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 
 **data** | [**List&lt;AcceptedRisk&gt;**](AcceptedRisk.md)|  | 

### Return type

[**RiskAcceptance**](RiskAcceptance.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testscreate"></a>
# **TestsCreate**
> TestCreate TestsCreate (TestCreate data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var data = new TestCreate(); // TestCreate | 

            try
            {
                TestCreate result = apiInstance.TestsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TestCreate**](TestCreate.md)|  | 

### Return type

[**TestCreate**](TestCreate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsdelete"></a>
# **TestsDelete**
> void TestsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.

            try
            {
                apiInstance.TestsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsfilescreate"></a>
# **TestsFilesCreate**
> System.IO.Stream TestsFilesCreate (int? id, AddNewFileOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsFilesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.
            var data = new AddNewFileOption(); // AddNewFileOption | 

            try
            {
                System.IO.Stream result = apiInstance.TestsFilesCreate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsFilesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 
 **data** | [**AddNewFileOption**](AddNewFileOption.md)|  | 

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsfilespartialupdate"></a>
# **TestsFilesPartialUpdate**
> System.IO.Stream TestsFilesPartialUpdate (int? id, AddNewFileOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsFilesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.
            var data = new AddNewFileOption(); // AddNewFileOption | 

            try
            {
                System.IO.Stream result = apiInstance.TestsFilesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsFilesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 
 **data** | [**AddNewFileOption**](AddNewFileOption.md)|  | 

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsfilesread"></a>
# **TestsFilesRead**
> TestToFiles TestsFilesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsFilesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.

            try
            {
                TestToFiles result = apiInstance.TestsFilesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsFilesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 

### Return type

[**TestToFiles**](TestToFiles.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsgeneratereport"></a>
# **TestsGenerateReport**
> ReportGenerate TestsGenerateReport (int? id, ReportGenerateOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsGenerateReportExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.
            var data = new ReportGenerateOption(); // ReportGenerateOption | 

            try
            {
                ReportGenerate result = apiInstance.TestsGenerateReport(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsGenerateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 
 **data** | [**ReportGenerateOption**](ReportGenerateOption.md)|  | 

### Return type

[**ReportGenerate**](ReportGenerate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testslist"></a>
# **TestsList**
> InlineResponse20027 TestsList (decimal? id = null, string title = null, string testType = null, string targetStart = null, string targetEnd = null, string notes = null, decimal? percentComplete = null, string actualTime = null, string engagement = null, string version = null, string branchTag = null, string buildId = null, string commitHash = null, string tags = null, string o = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var title = title_example;  // string |  (optional) 
            var testType = testType_example;  // string |  (optional) 
            var targetStart = targetStart_example;  // string |  (optional) 
            var targetEnd = targetEnd_example;  // string |  (optional) 
            var notes = notes_example;  // string |  (optional) 
            var percentComplete = 8.14;  // decimal? |  (optional) 
            var actualTime = actualTime_example;  // string |  (optional) 
            var engagement = engagement_example;  // string |  (optional) 
            var version = version_example;  // string |  (optional) 
            var branchTag = branchTag_example;  // string |  (optional) 
            var buildId = buildId_example;  // string |  (optional) 
            var commitHash = commitHash_example;  // string |  (optional) 
            var tags = tags_example;  // string |  (optional) 
            var o = o_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20027 result = apiInstance.TestsList(id, title, testType, targetStart, targetEnd, notes, percentComplete, actualTime, engagement, version, branchTag, buildId, commitHash, tags, o, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **title** | **string**|  | [optional] 
 **testType** | **string**|  | [optional] 
 **targetStart** | **string**|  | [optional] 
 **targetEnd** | **string**|  | [optional] 
 **notes** | **string**|  | [optional] 
 **percentComplete** | **decimal?**|  | [optional] 
 **actualTime** | **string**|  | [optional] 
 **engagement** | **string**|  | [optional] 
 **version** | **string**|  | [optional] 
 **branchTag** | **string**|  | [optional] 
 **buildId** | **string**|  | [optional] 
 **commitHash** | **string**|  | [optional] 
 **tags** | **string**|  | [optional] 
 **o** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20027**](InlineResponse20027.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsnotescreate"></a>
# **TestsNotesCreate**
> TestCreate TestsNotesCreate (int? id, TestCreate data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsNotesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.
            var data = new TestCreate(); // TestCreate | 

            try
            {
                TestCreate result = apiInstance.TestsNotesCreate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsNotesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 
 **data** | [**TestCreate**](TestCreate.md)|  | 

### Return type

[**TestCreate**](TestCreate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsnotespartialupdate"></a>
# **TestsNotesPartialUpdate**
> Test TestsNotesPartialUpdate (int? id, Test data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsNotesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.
            var data = new Test(); // Test | 

            try
            {
                Test result = apiInstance.TestsNotesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsNotesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 
 **data** | [**Test**](Test.md)|  | 

### Return type

[**Test**](Test.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsnotesread"></a>
# **TestsNotesRead**
> Test TestsNotesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsNotesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.

            try
            {
                Test result = apiInstance.TestsNotesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsNotesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 

### Return type

[**Test**](Test.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testspartialupdate"></a>
# **TestsPartialUpdate**
> Test TestsPartialUpdate (int? id, Test data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.
            var data = new Test(); // Test | 

            try
            {
                Test result = apiInstance.TestsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 
 **data** | [**Test**](Test.md)|  | 

### Return type

[**Test**](Test.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsread"></a>
# **TestsRead**
> Test TestsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.

            try
            {
                Test result = apiInstance.TestsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 

### Return type

[**Test**](Test.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testsupdate"></a>
# **TestsUpdate**
> Test TestsUpdate (int? id, Test data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class TestsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestsApi();
            var id = 56;  // int? | A unique integer value identifying this test.
            var data = new Test(); // Test | 

            try
            {
                Test result = apiInstance.TestsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestsApi.TestsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this test. | 
 **data** | [**Test**](Test.md)|  | 

### Return type

[**Test**](Test.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

