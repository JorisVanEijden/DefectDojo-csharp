# DefectDojo.Api.StubFindingsApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StubFindingsCreate**](StubFindingsApi.md#stubfindingscreate) | **POST** /stub_findings/ | 
[**StubFindingsList**](StubFindingsApi.md#stubfindingslist) | **GET** /stub_findings/ | 
[**StubFindingsPartialUpdate**](StubFindingsApi.md#stubfindingspartialupdate) | **PATCH** /stub_findings/{id}/ | 
[**StubFindingsRead**](StubFindingsApi.md#stubfindingsread) | **GET** /stub_findings/{id}/ | 
[**StubFindingsUpdate**](StubFindingsApi.md#stubfindingsupdate) | **PUT** /stub_findings/{id}/ | 


<a name="stubfindingscreate"></a>
# **StubFindingsCreate**
> StubFindingCreate StubFindingsCreate (StubFindingCreate data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class StubFindingsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StubFindingsApi();
            var data = new StubFindingCreate(); // StubFindingCreate | 

            try
            {
                StubFindingCreate result = apiInstance.StubFindingsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StubFindingsApi.StubFindingsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**StubFindingCreate**](StubFindingCreate.md)|  | 

### Return type

[**StubFindingCreate**](StubFindingCreate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stubfindingslist"></a>
# **StubFindingsList**
> InlineResponse20021 StubFindingsList (decimal? id = null, string title = null, string date = null, string severity = null, string description = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class StubFindingsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StubFindingsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var title = title_example;  // string |  (optional) 
            var date = date_example;  // string |  (optional) 
            var severity = severity_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20021 result = apiInstance.StubFindingsList(id, title, date, severity, description, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StubFindingsApi.StubFindingsList: " + e.Message );
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
 **date** | **string**|  | [optional] 
 **severity** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stubfindingspartialupdate"></a>
# **StubFindingsPartialUpdate**
> StubFinding StubFindingsPartialUpdate (int? id, StubFinding data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class StubFindingsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StubFindingsApi();
            var id = 56;  // int? | A unique integer value identifying this stub_ finding.
            var data = new StubFinding(); // StubFinding | 

            try
            {
                StubFinding result = apiInstance.StubFindingsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StubFindingsApi.StubFindingsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this stub_ finding. | 
 **data** | [**StubFinding**](StubFinding.md)|  | 

### Return type

[**StubFinding**](StubFinding.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stubfindingsread"></a>
# **StubFindingsRead**
> StubFinding StubFindingsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class StubFindingsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StubFindingsApi();
            var id = 56;  // int? | A unique integer value identifying this stub_ finding.

            try
            {
                StubFinding result = apiInstance.StubFindingsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StubFindingsApi.StubFindingsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this stub_ finding. | 

### Return type

[**StubFinding**](StubFinding.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stubfindingsupdate"></a>
# **StubFindingsUpdate**
> StubFinding StubFindingsUpdate (int? id, StubFinding data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class StubFindingsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StubFindingsApi();
            var id = 56;  // int? | A unique integer value identifying this stub_ finding.
            var data = new StubFinding(); // StubFinding | 

            try
            {
                StubFinding result = apiInstance.StubFindingsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StubFindingsApi.StubFindingsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this stub_ finding. | 
 **data** | [**StubFinding**](StubFinding.md)|  | 

### Return type

[**StubFinding**](StubFinding.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

