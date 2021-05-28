# DefectDojo.Api.FindingTemplatesApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindingTemplatesCreate**](FindingTemplatesApi.md#findingtemplatescreate) | **POST** /finding_templates/ | 
[**FindingTemplatesList**](FindingTemplatesApi.md#findingtemplateslist) | **GET** /finding_templates/ | 
[**FindingTemplatesPartialUpdate**](FindingTemplatesApi.md#findingtemplatespartialupdate) | **PATCH** /finding_templates/{id}/ | 
[**FindingTemplatesRead**](FindingTemplatesApi.md#findingtemplatesread) | **GET** /finding_templates/{id}/ | 
[**FindingTemplatesUpdate**](FindingTemplatesApi.md#findingtemplatesupdate) | **PUT** /finding_templates/{id}/ | 


<a name="findingtemplatescreate"></a>
# **FindingTemplatesCreate**
> FindingTemplate FindingTemplatesCreate (FindingTemplate data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingTemplatesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingTemplatesApi();
            var data = new FindingTemplate(); // FindingTemplate | 

            try
            {
                FindingTemplate result = apiInstance.FindingTemplatesCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingTemplatesApi.FindingTemplatesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**FindingTemplate**](FindingTemplate.md)|  | 

### Return type

[**FindingTemplate**](FindingTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingtemplateslist"></a>
# **FindingTemplatesList**
> InlineResponse2004 FindingTemplatesList (decimal? id = null, string title = null, decimal? cwe = null, string severity = null, string description = null, string mitigation = null, string tags = null, string o = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingTemplatesListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingTemplatesApi();
            var id = 8.14;  // decimal? |  (optional) 
            var title = title_example;  // string |  (optional) 
            var cwe = 8.14;  // decimal? |  (optional) 
            var severity = severity_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var mitigation = mitigation_example;  // string |  (optional) 
            var tags = tags_example;  // string |  (optional) 
            var o = o_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse2004 result = apiInstance.FindingTemplatesList(id, title, cwe, severity, description, mitigation, tags, o, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingTemplatesApi.FindingTemplatesList: " + e.Message );
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
 **cwe** | **decimal?**|  | [optional] 
 **severity** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **mitigation** | **string**|  | [optional] 
 **tags** | **string**|  | [optional] 
 **o** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingtemplatespartialupdate"></a>
# **FindingTemplatesPartialUpdate**
> FindingTemplate FindingTemplatesPartialUpdate (int? id, FindingTemplate data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingTemplatesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingTemplatesApi();
            var id = 56;  // int? | A unique integer value identifying this finding_ template.
            var data = new FindingTemplate(); // FindingTemplate | 

            try
            {
                FindingTemplate result = apiInstance.FindingTemplatesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingTemplatesApi.FindingTemplatesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding_ template. | 
 **data** | [**FindingTemplate**](FindingTemplate.md)|  | 

### Return type

[**FindingTemplate**](FindingTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingtemplatesread"></a>
# **FindingTemplatesRead**
> FindingTemplate FindingTemplatesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingTemplatesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingTemplatesApi();
            var id = 56;  // int? | A unique integer value identifying this finding_ template.

            try
            {
                FindingTemplate result = apiInstance.FindingTemplatesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingTemplatesApi.FindingTemplatesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding_ template. | 

### Return type

[**FindingTemplate**](FindingTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findingtemplatesupdate"></a>
# **FindingTemplatesUpdate**
> FindingTemplate FindingTemplatesUpdate (int? id, FindingTemplate data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class FindingTemplatesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindingTemplatesApi();
            var id = 56;  // int? | A unique integer value identifying this finding_ template.
            var data = new FindingTemplate(); // FindingTemplate | 

            try
            {
                FindingTemplate result = apiInstance.FindingTemplatesUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindingTemplatesApi.FindingTemplatesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this finding_ template. | 
 **data** | [**FindingTemplate**](FindingTemplate.md)|  | 

### Return type

[**FindingTemplate**](FindingTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

