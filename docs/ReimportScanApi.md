# DefectDojo.Api.ReimportScanApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReimportScanCreate**](ReimportScanApi.md#reimportscancreate) | **POST** /reimport-scan/ | 


<a name="reimportscancreate"></a>
# **ReimportScanCreate**
> ReImportScan ReimportScanCreate (DateTime? scanDate, string scanType, int? test, string minimumSeverity = null, bool? active = null, bool? verified = null, int? endpointToAdd = null, System.IO.Stream file = null, bool? pushToJira = null, bool? closeOldFindings = null, string version = null, string buildId = null, string branchTag = null, string commitHash = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ReimportScanCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReimportScanApi();
            var scanDate = 2013-10-20;  // DateTime? | 
            var scanType = scanType_example;  // string | 
            var test = 56;  // int? | 
            var minimumSeverity = minimumSeverity_example;  // string |  (optional)  (default to Info)
            var active = true;  // bool? |  (optional)  (default to true)
            var verified = true;  // bool? |  (optional)  (default to true)
            var endpointToAdd = 56;  // int? |  (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream |  (optional) 
            var pushToJira = true;  // bool? |  (optional)  (default to false)
            var closeOldFindings = true;  // bool? |  (optional)  (default to true)
            var version = version_example;  // string |  (optional) 
            var buildId = buildId_example;  // string |  (optional) 
            var branchTag = branchTag_example;  // string |  (optional) 
            var commitHash = commitHash_example;  // string |  (optional) 

            try
            {
                ReImportScan result = apiInstance.ReimportScanCreate(scanDate, scanType, test, minimumSeverity, active, verified, endpointToAdd, file, pushToJira, closeOldFindings, version, buildId, branchTag, commitHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReimportScanApi.ReimportScanCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scanDate** | **DateTime?**|  | 
 **scanType** | **string**|  | 
 **test** | **int?**|  | 
 **minimumSeverity** | **string**|  | [optional] [default to Info]
 **active** | **bool?**|  | [optional] [default to true]
 **verified** | **bool?**|  | [optional] [default to true]
 **endpointToAdd** | **int?**|  | [optional] 
 **file** | **System.IO.Stream**|  | [optional] 
 **pushToJira** | **bool?**|  | [optional] [default to false]
 **closeOldFindings** | **bool?**|  | [optional] [default to true]
 **version** | **string**|  | [optional] 
 **buildId** | **string**|  | [optional] 
 **branchTag** | **string**|  | [optional] 
 **commitHash** | **string**|  | [optional] 

### Return type

[**ReImportScan**](ReImportScan.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

