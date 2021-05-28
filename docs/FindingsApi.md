# DefectDojo.Api.FindingsApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindingsAcceptRisks**](FindingsApi.md#findingsacceptrisks) | **POST** /findings/accept_risks/ | 
[**FindingsCreate**](FindingsApi.md#findingscreate) | **POST** /findings/ | 
[**FindingsDelete**](FindingsApi.md#findingsdelete) | **DELETE** /findings/{id}/ | 
[**FindingsDuplicateResetFindingDuplicateStatus**](FindingsApi.md#findingsduplicateresetfindingduplicatestatus) | **POST** /findings/{id}/duplicate/reset/ | 
[**FindingsFilesCreate**](FindingsApi.md#findingsfilescreate) | **POST** /findings/{id}/files/ | 
[**FindingsFilesPartialUpdate**](FindingsApi.md#findingsfilespartialupdate) | **PATCH** /findings/{id}/files/ | 
[**FindingsFilesRead**](FindingsApi.md#findingsfilesread) | **GET** /findings/{id}/files/ | 
[**FindingsGenerateReport**](FindingsApi.md#findingsgeneratereport) | **POST** /findings/generate_report/ | 
[**FindingsGetDuplicateStatus**](FindingsApi.md#findingsgetduplicatestatus) | **GET** /findings/{id}/duplicate/ | 
[**FindingsList**](FindingsApi.md#findingslist) | **GET** /findings/ | 
[**FindingsMetadataCreate**](FindingsApi.md#findingsmetadatacreate) | **POST** /findings/{id}/metadata/ | 
[**FindingsMetadataDelete**](FindingsApi.md#findingsmetadatadelete) | **DELETE** /findings/{id}/metadata/ | 
[**FindingsMetadataRead**](FindingsApi.md#findingsmetadataread) | **GET** /findings/{id}/metadata/ | 
[**FindingsMetadataUpdate**](FindingsApi.md#findingsmetadataupdate) | **PUT** /findings/{id}/metadata/ | 
[**FindingsNotesCreate**](FindingsApi.md#findingsnotescreate) | **POST** /findings/{id}/notes/ | 
[**FindingsNotesPartialUpdate**](FindingsApi.md#findingsnotespartialupdate) | **PATCH** /findings/{id}/notes/ | 
[**FindingsNotesRead**](FindingsApi.md#findingsnotesread) | **GET** /findings/{id}/notes/ | 
[**FindingsPartialUpdate**](FindingsApi.md#findingspartialupdate) | **PATCH** /findings/{id}/ | 
[**FindingsRead**](FindingsApi.md#findingsread) | **GET** /findings/{id}/ | 
[**FindingsRemoveNote**](FindingsApi.md#findingsremovenote) | **PATCH** /findings/{id}/remove_note/ | 
[**FindingsRemoveTagsPartialUpdate**](FindingsApi.md#findingsremovetagspartialupdate) | **PATCH** /findings/{id}/remove_tags/ | 
[**FindingsRemoveTagsUpdate**](FindingsApi.md#findingsremovetagsupdate) | **PUT** /findings/{id}/remove_tags/ | 
[**FindingsRequestResponseCreate**](FindingsApi.md#findingsrequestresponsecreate) | **POST** /findings/{id}/request_response/ | 
[**FindingsRequestResponseRead**](FindingsApi.md#findingsrequestresponseread) | **GET** /findings/{id}/request_response/ | 
[**FindingsSetFindingAsOriginal**](FindingsApi.md#findingssetfindingasoriginal) | **POST** /findings/{id}/original/{new_fid}/ | 
[**FindingsTagsCreate**](FindingsApi.md#findingstagscreate) | **POST** /findings/{id}/tags/ | 
[**FindingsTagsRead**](FindingsApi.md#findingstagsread) | **GET** /findings/{id}/tags/ | 
[**FindingsUpdate**](FindingsApi.md#findingsupdate) | **PUT** /findings/{id}/ | 


<a name="findingsacceptrisks"></a>
# **FindingsAcceptRisks**
> RiskAcceptance FindingsAcceptRisks (List<AcceptedRisk> data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsAcceptRisksExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var data = new List<AcceptedRisk>(); // List<AcceptedRisk> | 

            try
            {
                RiskAcceptance result = apiInstance.FindingsAcceptRisks(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsAcceptRisks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**List&lt;AcceptedRisk&gt;**](AcceptedRisk.md)|  | 

### Return type

[**RiskAcceptance**](RiskAcceptance.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingscreate"></a>
# **FindingsCreate**
> FindingCreate FindingsCreate (FindingCreate data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var data = new FindingCreate(); // FindingCreate | 

            try
            {
                FindingCreate result = apiInstance.FindingsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**FindingCreate**](FindingCreate.md)|  | 

### Return type

[**FindingCreate**](FindingCreate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsdelete"></a>
# **FindingsDelete**
> void FindingsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.

            try
            {
                apiInstance.FindingsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsduplicateresetfindingduplicatestatus"></a>
# **FindingsDuplicateResetFindingDuplicateStatus**
> void FindingsDuplicateResetFindingDuplicateStatus (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsDuplicateResetFindingDuplicateStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.

            try
            {
                apiInstance.FindingsDuplicateResetFindingDuplicateStatus(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsDuplicateResetFindingDuplicateStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsfilescreate"></a>
# **FindingsFilesCreate**
> FindingToFiles FindingsFilesCreate (int? id, AddNewFileOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsFilesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new AddNewFileOption(); // AddNewFileOption | 

            try
            {
                FindingToFiles result = apiInstance.FindingsFilesCreate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsFilesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**AddNewFileOption**](AddNewFileOption.md)|  | 

### Return type

[**FindingToFiles**](FindingToFiles.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsfilespartialupdate"></a>
# **FindingsFilesPartialUpdate**
> FindingToFiles FindingsFilesPartialUpdate (int? id, AddNewFileOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsFilesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new AddNewFileOption(); // AddNewFileOption | 

            try
            {
                FindingToFiles result = apiInstance.FindingsFilesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsFilesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**AddNewFileOption**](AddNewFileOption.md)|  | 

### Return type

[**FindingToFiles**](FindingToFiles.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsfilesread"></a>
# **FindingsFilesRead**
> FindingToFiles FindingsFilesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsFilesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.

            try
            {
                FindingToFiles result = apiInstance.FindingsFilesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsFilesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 

### Return type

[**FindingToFiles**](FindingToFiles.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsgeneratereport"></a>
# **FindingsGenerateReport**
> ReportGenerate FindingsGenerateReport (ReportGenerateOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsGenerateReportExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var data = new ReportGenerateOption(); // ReportGenerateOption | 

            try
            {
                ReportGenerate result = apiInstance.FindingsGenerateReport(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsGenerateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ReportGenerateOption**](ReportGenerateOption.md)|  | 

### Return type

[**ReportGenerate**](ReportGenerate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsgetduplicatestatus"></a>
# **FindingsGetDuplicateStatus**
> List<Finding> FindingsGetDuplicateStatus (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsGetDuplicateStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.

            try
            {
                List&lt;Finding&gt; result = apiInstance.FindingsGetDuplicateStatus(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsGetDuplicateStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 

### Return type

[**List<Finding>**](Finding.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingslist"></a>
# **FindingsList**
> InlineResponse2005 FindingsList (string title = null, string date = null, string slaStartDate = null, decimal? cwe = null, string cve = null, string cvssv3 = null, decimal? cvssv3Score = null, string severity = null, string description = null, string mitigation = null, string impact = null, string stepsToReproduce = null, string severityJustification = null, decimal? endpoints = null, string references = null, string test = null, string active = null, string verified = null, string falseP = null, string duplicate = null, string duplicateFinding = null, string outOfScope = null, string riskAccepted = null, string underReview = null, string lastStatusUpdate = null, decimal? reviewRequestedBy = null, decimal? reviewers = null, string underDefectReview = null, decimal? defectReviewRequestedBy = null, string isMitigated = null, string mitigated = null, decimal? mitigatedBy = null, decimal? reporter = null, string numericalSeverity = null, string lastReviewed = null, decimal? lastReviewedBy = null, string lineNumber = null, string sourcefilepath = null, string param = null, string payload = null, string hashCode = null, string filePath = null, string componentName = null, string componentVersion = null, decimal? foundBy = null, string staticFinding = null, string dynamicFinding = null, string created = null, decimal? scannerConfidence = null, decimal? sonarqubeIssue = null, string uniqueIdFromTool = null, string vulnIdFromTool = null, string sastSourceObject = null, string sastSinkObject = null, decimal? sastSourceLine = null, string sastSourceFilePath = null, decimal? nbOccurences = null, string publishDate = null, string tags = null, string stepToReproduce = null, string sourcefile = null, string jiraCreation = null, string jiraChange = null, decimal? id = null, decimal? testTestType = null, decimal? testEngagement = null, decimal? testEngagementProduct = null, decimal? findingGroup = null, string riskAcceptance = null, string tag = null, string o = null, int? limit = null, int? offset = null, List<string> prefetch = null, bool? relatedFields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var title = title_example;  // string |  (optional) 
            var date = date_example;  // string |  (optional) 
            var slaStartDate = slaStartDate_example;  // string |  (optional) 
            var cwe = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var cve = cve_example;  // string |  (optional) 
            var cvssv3 = cvssv3_example;  // string |  (optional) 
            var cvssv3Score = 8.14;  // decimal? |  (optional) 
            var severity = severity_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var mitigation = mitigation_example;  // string |  (optional) 
            var impact = impact_example;  // string |  (optional) 
            var stepsToReproduce = stepsToReproduce_example;  // string |  (optional) 
            var severityJustification = severityJustification_example;  // string |  (optional) 
            var endpoints = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var references = references_example;  // string |  (optional) 
            var test = test_example;  // string |  (optional) 
            var active = active_example;  // string |  (optional) 
            var verified = verified_example;  // string |  (optional) 
            var falseP = falseP_example;  // string |  (optional) 
            var duplicate = duplicate_example;  // string |  (optional) 
            var duplicateFinding = duplicateFinding_example;  // string |  (optional) 
            var outOfScope = outOfScope_example;  // string |  (optional) 
            var riskAccepted = riskAccepted_example;  // string |  (optional) 
            var underReview = underReview_example;  // string |  (optional) 
            var lastStatusUpdate = lastStatusUpdate_example;  // string |  (optional) 
            var reviewRequestedBy = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var reviewers = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var underDefectReview = underDefectReview_example;  // string |  (optional) 
            var defectReviewRequestedBy = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var isMitigated = isMitigated_example;  // string |  (optional) 
            var mitigated = mitigated_example;  // string |  (optional) 
            var mitigatedBy = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var reporter = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var numericalSeverity = numericalSeverity_example;  // string |  (optional) 
            var lastReviewed = lastReviewed_example;  // string |  (optional) 
            var lastReviewedBy = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var lineNumber = lineNumber_example;  // string |  (optional) 
            var sourcefilepath = sourcefilepath_example;  // string |  (optional) 
            var param = param_example;  // string |  (optional) 
            var payload = payload_example;  // string |  (optional) 
            var hashCode = hashCode_example;  // string |  (optional) 
            var filePath = filePath_example;  // string |  (optional) 
            var componentName = componentName_example;  // string |  (optional) 
            var componentVersion = componentVersion_example;  // string |  (optional) 
            var foundBy = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var staticFinding = staticFinding_example;  // string |  (optional) 
            var dynamicFinding = dynamicFinding_example;  // string |  (optional) 
            var created = created_example;  // string |  (optional) 
            var scannerConfidence = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var sonarqubeIssue = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var uniqueIdFromTool = uniqueIdFromTool_example;  // string |  (optional) 
            var vulnIdFromTool = vulnIdFromTool_example;  // string |  (optional) 
            var sastSourceObject = sastSourceObject_example;  // string |  (optional) 
            var sastSinkObject = sastSinkObject_example;  // string |  (optional) 
            var sastSourceLine = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var sastSourceFilePath = sastSourceFilePath_example;  // string |  (optional) 
            var nbOccurences = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var publishDate = publishDate_example;  // string |  (optional) 
            var tags = tags_example;  // string |  (optional) 
            var stepToReproduce = stepToReproduce_example;  // string |  (optional) 
            var sourcefile = sourcefile_example;  // string |  (optional) 
            var jiraCreation = jiraCreation_example;  // string |  (optional) 
            var jiraChange = jiraChange_example;  // string |  (optional) 
            var id = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var testTestType = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var testEngagement = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var testEngagementProduct = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var findingGroup = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var riskAcceptance = riskAcceptance_example;  // string |  (optional) 
            var tag = tag_example;  // string |  (optional) 
            var o = o_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var prefetch = prefetch_example;  // List<string> |  (optional) 
            var relatedFields = true;  // bool? | Expand finding external relations (engagement, environment, product, product_type, test, test_type) (optional) 

            try
            {
                InlineResponse2005 result = apiInstance.FindingsList(title, date, slaStartDate, cwe, cve, cvssv3, cvssv3Score, severity, description, mitigation, impact, stepsToReproduce, severityJustification, endpoints, references, test, active, verified, falseP, duplicate, duplicateFinding, outOfScope, riskAccepted, underReview, lastStatusUpdate, reviewRequestedBy, reviewers, underDefectReview, defectReviewRequestedBy, isMitigated, mitigated, mitigatedBy, reporter, numericalSeverity, lastReviewed, lastReviewedBy, lineNumber, sourcefilepath, param, payload, hashCode, filePath, componentName, componentVersion, foundBy, staticFinding, dynamicFinding, created, scannerConfidence, sonarqubeIssue, uniqueIdFromTool, vulnIdFromTool, sastSourceObject, sastSinkObject, sastSourceLine, sastSourceFilePath, nbOccurences, publishDate, tags, stepToReproduce, sourcefile, jiraCreation, jiraChange, id, testTestType, testEngagement, testEngagementProduct, findingGroup, riskAcceptance, tag, o, limit, offset, prefetch, relatedFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**|  | [optional] 
 **date** | **string**|  | [optional] 
 **slaStartDate** | **string**|  | [optional] 
 **cwe** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **cve** | **string**|  | [optional] 
 **cvssv3** | **string**|  | [optional] 
 **cvssv3Score** | **decimal?**|  | [optional] 
 **severity** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **mitigation** | **string**|  | [optional] 
 **impact** | **string**|  | [optional] 
 **stepsToReproduce** | **string**|  | [optional] 
 **severityJustification** | **string**|  | [optional] 
 **endpoints** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **references** | **string**|  | [optional] 
 **test** | **string**|  | [optional] 
 **active** | **string**|  | [optional] 
 **verified** | **string**|  | [optional] 
 **falseP** | **string**|  | [optional] 
 **duplicate** | **string**|  | [optional] 
 **duplicateFinding** | **string**|  | [optional] 
 **outOfScope** | **string**|  | [optional] 
 **riskAccepted** | **string**|  | [optional] 
 **underReview** | **string**|  | [optional] 
 **lastStatusUpdate** | **string**|  | [optional] 
 **reviewRequestedBy** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **reviewers** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **underDefectReview** | **string**|  | [optional] 
 **defectReviewRequestedBy** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **isMitigated** | **string**|  | [optional] 
 **mitigated** | **string**|  | [optional] 
 **mitigatedBy** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **reporter** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **numericalSeverity** | **string**|  | [optional] 
 **lastReviewed** | **string**|  | [optional] 
 **lastReviewedBy** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **lineNumber** | **string**|  | [optional] 
 **sourcefilepath** | **string**|  | [optional] 
 **param** | **string**|  | [optional] 
 **payload** | **string**|  | [optional] 
 **hashCode** | **string**|  | [optional] 
 **filePath** | **string**|  | [optional] 
 **componentName** | **string**|  | [optional] 
 **componentVersion** | **string**|  | [optional] 
 **foundBy** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **staticFinding** | **string**|  | [optional] 
 **dynamicFinding** | **string**|  | [optional] 
 **created** | **string**|  | [optional] 
 **scannerConfidence** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **sonarqubeIssue** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **uniqueIdFromTool** | **string**|  | [optional] 
 **vulnIdFromTool** | **string**|  | [optional] 
 **sastSourceObject** | **string**|  | [optional] 
 **sastSinkObject** | **string**|  | [optional] 
 **sastSourceLine** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **sastSourceFilePath** | **string**|  | [optional] 
 **nbOccurences** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **publishDate** | **string**|  | [optional] 
 **tags** | **string**|  | [optional] 
 **stepToReproduce** | **string**|  | [optional] 
 **sourcefile** | **string**|  | [optional] 
 **jiraCreation** | **string**|  | [optional] 
 **jiraChange** | **string**|  | [optional] 
 **id** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **testTestType** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **testEngagement** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **testEngagementProduct** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **findingGroup** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **riskAcceptance** | **string**|  | [optional] 
 **tag** | **string**|  | [optional] 
 **o** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **prefetch** | **List&lt;string&gt;**|  | [optional] 
 **relatedFields** | **bool?**| Expand finding external relations (engagement, environment, product, product_type, test, test_type) | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsmetadatacreate"></a>
# **FindingsMetadataCreate**
> FindingMeta FindingsMetadataCreate (int? id, FindingMeta data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsMetadataCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new FindingMeta(); // FindingMeta | 

            try
            {
                FindingMeta result = apiInstance.FindingsMetadataCreate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsMetadataCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**FindingMeta**](FindingMeta.md)|  | 

### Return type

[**FindingMeta**](FindingMeta.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsmetadatadelete"></a>
# **FindingsMetadataDelete**
> void FindingsMetadataDelete (int? id, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsMetadataDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var name = name_example;  // string | name of the metadata to retrieve. If name is empty, return all the                             metadata associated with the finding

            try
            {
                apiInstance.FindingsMetadataDelete(id, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsMetadataDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **name** | **string**| name of the metadata to retrieve. If name is empty, return all the                             metadata associated with the finding | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsmetadataread"></a>
# **FindingsMetadataRead**
> List<FindingMeta> FindingsMetadataRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsMetadataReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.

            try
            {
                List&lt;FindingMeta&gt; result = apiInstance.FindingsMetadataRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsMetadataRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 

### Return type

[**List<FindingMeta>**](FindingMeta.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsmetadataupdate"></a>
# **FindingsMetadataUpdate**
> FindingMeta FindingsMetadataUpdate (int? id, FindingMeta data, string name)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsMetadataUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new FindingMeta(); // FindingMeta | 
            var name = name_example;  // string | name of the metadata to edit

            try
            {
                FindingMeta result = apiInstance.FindingsMetadataUpdate(id, data, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsMetadataUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**FindingMeta**](FindingMeta.md)|  | 
 **name** | **string**| name of the metadata to edit | 

### Return type

[**FindingMeta**](FindingMeta.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsnotescreate"></a>
# **FindingsNotesCreate**
> Note FindingsNotesCreate (int? id, AddNewNoteOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsNotesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new AddNewNoteOption(); // AddNewNoteOption | 

            try
            {
                Note result = apiInstance.FindingsNotesCreate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsNotesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**AddNewNoteOption**](AddNewNoteOption.md)|  | 

### Return type

[**Note**](Note.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsnotespartialupdate"></a>
# **FindingsNotesPartialUpdate**
> Note FindingsNotesPartialUpdate (int? id, AddNewNoteOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsNotesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new AddNewNoteOption(); // AddNewNoteOption | 

            try
            {
                Note result = apiInstance.FindingsNotesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsNotesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**AddNewNoteOption**](AddNewNoteOption.md)|  | 

### Return type

[**Note**](Note.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsnotesread"></a>
# **FindingsNotesRead**
> FindingToNotes FindingsNotesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsNotesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.

            try
            {
                FindingToNotes result = apiInstance.FindingsNotesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsNotesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 

### Return type

[**FindingToNotes**](FindingToNotes.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingspartialupdate"></a>
# **FindingsPartialUpdate**
> Finding FindingsPartialUpdate (int? id, Finding data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new Finding(); // Finding | 

            try
            {
                Finding result = apiInstance.FindingsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**Finding**](Finding.md)|  | 

### Return type

[**Finding**](Finding.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsread"></a>
# **FindingsRead**
> InlineResponse2006 FindingsRead (int? id, List<string> prefetch = null, bool? relatedFields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var prefetch = prefetch_example;  // List<string> |  (optional) 
            var relatedFields = true;  // bool? | Expand finding external relations (engagement, environment, product, product_type, test, test_type) (optional) 

            try
            {
                InlineResponse2006 result = apiInstance.FindingsRead(id, prefetch, relatedFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **prefetch** | **List&lt;string&gt;**|  | [optional] 
 **relatedFields** | **bool?**| Expand finding external relations (engagement, environment, product, product_type, test, test_type) | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsremovenote"></a>
# **FindingsRemoveNote**
> void FindingsRemoveNote (int? id, FindingNote data)



Remove Note From Finding Note

### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsRemoveNoteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new FindingNote(); // FindingNote | 

            try
            {
                apiInstance.FindingsRemoveNote(id, data);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsRemoveNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**FindingNote**](FindingNote.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsremovetagspartialupdate"></a>
# **FindingsRemoveTagsPartialUpdate**
> void FindingsRemoveTagsPartialUpdate (int? id, Tag data)



Remove Tag(s) from finding list of tags

### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsRemoveTagsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new Tag(); // Tag | 

            try
            {
                apiInstance.FindingsRemoveTagsPartialUpdate(id, data);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsRemoveTagsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**Tag**](Tag.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsremovetagsupdate"></a>
# **FindingsRemoveTagsUpdate**
> void FindingsRemoveTagsUpdate (int? id, Tag data)



Remove Tag(s) from finding list of tags

### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsRemoveTagsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new Tag(); // Tag | 

            try
            {
                apiInstance.FindingsRemoveTagsUpdate(id, data);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsRemoveTagsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**Tag**](Tag.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsrequestresponsecreate"></a>
# **FindingsRequestResponseCreate**
> BurpRawRequestResponse FindingsRequestResponseCreate (int? id, BurpRawRequestResponse data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsRequestResponseCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new BurpRawRequestResponse(); // BurpRawRequestResponse | 

            try
            {
                BurpRawRequestResponse result = apiInstance.FindingsRequestResponseCreate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsRequestResponseCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**BurpRawRequestResponse**](BurpRawRequestResponse.md)|  | 

### Return type

[**BurpRawRequestResponse**](BurpRawRequestResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsrequestresponseread"></a>
# **FindingsRequestResponseRead**
> BurpRawRequestResponse FindingsRequestResponseRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsRequestResponseReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.

            try
            {
                BurpRawRequestResponse result = apiInstance.FindingsRequestResponseRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsRequestResponseRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 

### Return type

[**BurpRawRequestResponse**](BurpRawRequestResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingssetfindingasoriginal"></a>
# **FindingsSetFindingAsOriginal**
> void FindingsSetFindingAsOriginal (int? id, string newFid)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsSetFindingAsOriginalExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var newFid = newFid_example;  // string | 

            try
            {
                apiInstance.FindingsSetFindingAsOriginal(id, newFid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsSetFindingAsOriginal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **newFid** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingstagscreate"></a>
# **FindingsTagsCreate**
> Tag FindingsTagsCreate (int? id, Tag data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsTagsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new Tag(); // Tag | 

            try
            {
                Tag result = apiInstance.FindingsTagsCreate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsTagsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**Tag**](Tag.md)|  | 

### Return type

[**Tag**](Tag.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingstagsread"></a>
# **FindingsTagsRead**
> Tag FindingsTagsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsTagsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.

            try
            {
                Tag result = apiInstance.FindingsTagsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsTagsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 

### Return type

[**Tag**](Tag.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingsupdate"></a>
# **FindingsUpdate**
> Finding FindingsUpdate (int? id, Finding data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingsApi();
            var id = 56;  // int? | A unique integer value identifying this finding.
            var data = new Finding(); // Finding | 

            try
            {
                Finding result = apiInstance.FindingsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingsApi.FindingsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding. | 
 **data** | [**Finding**](Finding.md)|  | 

### Return type

[**Finding**](Finding.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

