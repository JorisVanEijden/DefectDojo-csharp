# DefectDojo.Api.ImportScanApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImportScanCreate**](ImportScanApi.md#importscancreate) | **POST** /import-scan/ | 


<a name="importscancreate"></a>
# **ImportScanCreate**
> ImportScan ImportScanCreate (string scanType, int? engagement, DateTime? scanDate = null, string minimumSeverity = null, bool? active = null, bool? verified = null, int? endpointToAdd = null, System.IO.Stream file = null, int? lead = null, List<string> tags = null, bool? closeOldFindings = null, bool? pushToJira = null, string environment = null, string version = null, string buildId = null, string branchTag = null, string commitHash = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ImportScanCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportScanApi();
            var scanType = scanType_example;  // string | 
            var engagement = 56;  // int? | 
            var scanDate = 2013-10-20;  // DateTime? |  (optional)  (default to 2021-05-31)
            var minimumSeverity = minimumSeverity_example;  // string |  (optional)  (default to Info)
            var active = true;  // bool? |  (optional)  (default to true)
            var verified = true;  // bool? |  (optional)  (default to true)
            var endpointToAdd = 56;  // int? |  (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream |  (optional) 
            var lead = 56;  // int? |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 
            var closeOldFindings = true;  // bool? |  (optional)  (default to false)
            var pushToJira = true;  // bool? |  (optional)  (default to false)
            var environment = environment_example;  // string |  (optional) 
            var version = version_example;  // string |  (optional) 
            var buildId = buildId_example;  // string |  (optional) 
            var branchTag = branchTag_example;  // string |  (optional) 
            var commitHash = commitHash_example;  // string |  (optional) 

            try
            {
                ImportScan result = apiInstance.ImportScanCreate(scanType, engagement, scanDate, minimumSeverity, active, verified, endpointToAdd, file, lead, tags, closeOldFindings, pushToJira, environment, version, buildId, branchTag, commitHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportScanApi.ImportScanCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scanType** | **string**|  | 
 **engagement** | **int?**|  | 
 **scanDate** | **DateTime?**|  | [optional] [default to 2021-05-31]
 **minimumSeverity** | **string**|  | [optional] [default to Info]
 **active** | **bool?**|  | [optional] [default to true]
 **verified** | **bool?**|  | [optional] [default to true]
 **endpointToAdd** | **int?**|  | [optional] 
 **file** | **System.IO.Stream**|  | [optional] 
 **lead** | **int?**|  | [optional] 
 **tags** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **closeOldFindings** | **bool?**|  | [optional] [default to false]
 **pushToJira** | **bool?**|  | [optional] [default to false]
 **environment** | **string**|  | [optional] 
 **version** | **string**|  | [optional] 
 **buildId** | **string**|  | [optional] 
 **branchTag** | **string**|  | [optional] 
 **commitHash** | **string**|  | [optional] 

### Return type

[**ImportScan**](ImportScan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

