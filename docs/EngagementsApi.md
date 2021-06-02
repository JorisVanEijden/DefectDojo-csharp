# DefectDojo.Api.EngagementsApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EngagementsAcceptRisks**](EngagementsApi.md#engagementsacceptrisks) | **POST** /engagements/{id}/accept_risks/ | 
[**EngagementsClose**](EngagementsApi.md#engagementsclose) | **POST** /engagements/{id}/close/ | 
[**EngagementsCreate**](EngagementsApi.md#engagementscreate) | **POST** /engagements/ | 
[**EngagementsDelete**](EngagementsApi.md#engagementsdelete) | **DELETE** /engagements/{id}/ | 
[**EngagementsFilesCreate**](EngagementsApi.md#engagementsfilescreate) | **POST** /engagements/{id}/files/ | 
[**EngagementsFilesPartialUpdate**](EngagementsApi.md#engagementsfilespartialupdate) | **PATCH** /engagements/{id}/files/ | 
[**EngagementsFilesRead**](EngagementsApi.md#engagementsfilesread) | **GET** /engagements/{id}/files/ | 
[**EngagementsGenerateReport**](EngagementsApi.md#engagementsgeneratereport) | **POST** /engagements/{id}/generate_report/ | 
[**EngagementsList**](EngagementsApi.md#engagementslist) | **GET** /engagements/ | 
[**EngagementsNotesCreate**](EngagementsApi.md#engagementsnotescreate) | **POST** /engagements/{id}/notes/ | 
[**EngagementsNotesPartialUpdate**](EngagementsApi.md#engagementsnotespartialupdate) | **PATCH** /engagements/{id}/notes/ | 
[**EngagementsNotesRead**](EngagementsApi.md#engagementsnotesread) | **GET** /engagements/{id}/notes/ | 
[**EngagementsPartialUpdate**](EngagementsApi.md#engagementspartialupdate) | **PATCH** /engagements/{id}/ | 
[**EngagementsRead**](EngagementsApi.md#engagementsread) | **GET** /engagements/{id}/ | 
[**EngagementsReopen**](EngagementsApi.md#engagementsreopen) | **POST** /engagements/{id}/reopen/ | 
[**EngagementsUpdate**](EngagementsApi.md#engagementsupdate) | **PUT** /engagements/{id}/ | 


<a name="engagementsacceptrisks"></a>
# **EngagementsAcceptRisks**
> RiskAcceptance EngagementsAcceptRisks (int? id, List<AcceptedRisk> data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsAcceptRisksExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.
            var data = new List<AcceptedRisk>(); // List<AcceptedRisk> | 

            try
            {
                RiskAcceptance result = apiInstance.EngagementsAcceptRisks(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsAcceptRisks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 
 **data** | [**List&lt;AcceptedRisk&gt;**](AcceptedRisk.md)|  | 

### Return type

[**RiskAcceptance**](RiskAcceptance.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsclose"></a>
# **EngagementsClose**
> void EngagementsClose (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsCloseExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.

            try
            {
                apiInstance.EngagementsClose(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsClose: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementscreate"></a>
# **EngagementsCreate**
> Engagement EngagementsCreate (Engagement data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var data = new Engagement(); // Engagement | 

            try
            {
                Engagement result = apiInstance.EngagementsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Engagement**](Engagement.md)|  | 

### Return type

[**Engagement**](Engagement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsdelete"></a>
# **EngagementsDelete**
> void EngagementsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.

            try
            {
                apiInstance.EngagementsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsfilescreate"></a>
# **EngagementsFilesCreate**
> System.IO.Stream EngagementsFilesCreate (int? id, AddNewFileOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsFilesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.
            var data = new AddNewFileOption(); // AddNewFileOption | 

            try
            {
                System.IO.Stream result = apiInstance.EngagementsFilesCreate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsFilesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 
 **data** | [**AddNewFileOption**](AddNewFileOption.md)|  | 

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsfilespartialupdate"></a>
# **EngagementsFilesPartialUpdate**
> System.IO.Stream EngagementsFilesPartialUpdate (int? id, AddNewFileOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsFilesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.
            var data = new AddNewFileOption(); // AddNewFileOption | 

            try
            {
                System.IO.Stream result = apiInstance.EngagementsFilesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsFilesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 
 **data** | [**AddNewFileOption**](AddNewFileOption.md)|  | 

### Return type

**System.IO.Stream**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsfilesread"></a>
# **EngagementsFilesRead**
> EngagementToFiles EngagementsFilesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsFilesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.

            try
            {
                EngagementToFiles result = apiInstance.EngagementsFilesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsFilesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 

### Return type

[**EngagementToFiles**](EngagementToFiles.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsgeneratereport"></a>
# **EngagementsGenerateReport**
> ReportGenerate EngagementsGenerateReport (int? id, ReportGenerateOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsGenerateReportExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.
            var data = new ReportGenerateOption(); // ReportGenerateOption | 

            try
            {
                ReportGenerate result = apiInstance.EngagementsGenerateReport(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsGenerateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 
 **data** | [**ReportGenerateOption**](ReportGenerateOption.md)|  | 

### Return type

[**ReportGenerate**](ReportGenerate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementslist"></a>
# **EngagementsList**
> InlineResponse2003 EngagementsList (decimal? id = null, string active = null, string engType = null, string targetStart = null, string targetEnd = null, string requester = null, string reportType = null, string updated = null, string threatModel = null, string apiTest = null, string penTest = null, string status = null, string product = null, string name = null, string version = null, string tags = null, string o = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var active = active_example;  // string |  (optional) 
            var engType = engType_example;  // string |  (optional) 
            var targetStart = targetStart_example;  // string |  (optional) 
            var targetEnd = targetEnd_example;  // string |  (optional) 
            var requester = requester_example;  // string |  (optional) 
            var reportType = reportType_example;  // string |  (optional) 
            var updated = updated_example;  // string |  (optional) 
            var threatModel = threatModel_example;  // string |  (optional) 
            var apiTest = apiTest_example;  // string |  (optional) 
            var penTest = penTest_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var product = product_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var version = version_example;  // string |  (optional) 
            var tags = tags_example;  // string |  (optional) 
            var o = o_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2003 result = apiInstance.EngagementsList(id, active, engType, targetStart, targetEnd, requester, reportType, updated, threatModel, apiTest, penTest, status, product, name, version, tags, o, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **active** | **string**|  | [optional] 
 **engType** | **string**|  | [optional] 
 **targetStart** | **string**|  | [optional] 
 **targetEnd** | **string**|  | [optional] 
 **requester** | **string**|  | [optional] 
 **reportType** | **string**|  | [optional] 
 **updated** | **string**|  | [optional] 
 **threatModel** | **string**|  | [optional] 
 **apiTest** | **string**|  | [optional] 
 **penTest** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **product** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **version** | **string**|  | [optional] 
 **tags** | **string**|  | [optional] 
 **o** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsnotescreate"></a>
# **EngagementsNotesCreate**
> Engagement EngagementsNotesCreate (int? id, Engagement data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsNotesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.
            var data = new Engagement(); // Engagement | 

            try
            {
                Engagement result = apiInstance.EngagementsNotesCreate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsNotesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 
 **data** | [**Engagement**](Engagement.md)|  | 

### Return type

[**Engagement**](Engagement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsnotespartialupdate"></a>
# **EngagementsNotesPartialUpdate**
> Engagement EngagementsNotesPartialUpdate (int? id, Engagement data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsNotesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.
            var data = new Engagement(); // Engagement | 

            try
            {
                Engagement result = apiInstance.EngagementsNotesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsNotesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 
 **data** | [**Engagement**](Engagement.md)|  | 

### Return type

[**Engagement**](Engagement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsnotesread"></a>
# **EngagementsNotesRead**
> Engagement EngagementsNotesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsNotesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.

            try
            {
                Engagement result = apiInstance.EngagementsNotesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsNotesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 

### Return type

[**Engagement**](Engagement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementspartialupdate"></a>
# **EngagementsPartialUpdate**
> Engagement EngagementsPartialUpdate (int? id, Engagement data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.
            var data = new Engagement(); // Engagement | 

            try
            {
                Engagement result = apiInstance.EngagementsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 
 **data** | [**Engagement**](Engagement.md)|  | 

### Return type

[**Engagement**](Engagement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsread"></a>
# **EngagementsRead**
> Engagement EngagementsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.

            try
            {
                Engagement result = apiInstance.EngagementsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 

### Return type

[**Engagement**](Engagement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsreopen"></a>
# **EngagementsReopen**
> void EngagementsReopen (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsReopenExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.

            try
            {
                apiInstance.EngagementsReopen(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsReopen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="engagementsupdate"></a>
# **EngagementsUpdate**
> Engagement EngagementsUpdate (int? id, Engagement data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class EngagementsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EngagementsApi();
            var id = 56;  // int? | A unique integer value identifying this engagement.
            var data = new Engagement(); // Engagement | 

            try
            {
                Engagement result = apiInstance.EngagementsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EngagementsApi.EngagementsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this engagement. | 
 **data** | [**Engagement**](Engagement.md)|  | 

### Return type

[**Engagement**](Engagement.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

