# DefectDojo.Api.ProductsApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductsCreate**](ProductsApi.md#productscreate) | **POST** /products/ | 
[**ProductsDelete**](ProductsApi.md#productsdelete) | **DELETE** /products/{id}/ | 
[**ProductsGenerateReport**](ProductsApi.md#productsgeneratereport) | **POST** /products/{id}/generate_report/ | 
[**ProductsList**](ProductsApi.md#productslist) | **GET** /products/ | 
[**ProductsPartialUpdate**](ProductsApi.md#productspartialupdate) | **PATCH** /products/{id}/ | 
[**ProductsRead**](ProductsApi.md#productsread) | **GET** /products/{id}/ | 
[**ProductsUpdate**](ProductsApi.md#productsupdate) | **PUT** /products/{id}/ | 


<a name="productscreate"></a>
# **ProductsCreate**
> Product ProductsCreate (Product data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var data = new Product(); // Product | 

            try
            {
                Product result = apiInstance.ProductsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Product**](Product.md)|  | 

### Return type

[**Product**](Product.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsdelete"></a>
# **ProductsDelete**
> void ProductsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 56;  // int? | A unique integer value identifying this product.

            try
            {
                apiInstance.ProductsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this product. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsgeneratereport"></a>
# **ProductsGenerateReport**
> ReportGenerate ProductsGenerateReport (int? id, ReportGenerateOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductsGenerateReportExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 56;  // int? | A unique integer value identifying this product.
            var data = new ReportGenerateOption(); // ReportGenerateOption | 

            try
            {
                ReportGenerate result = apiInstance.ProductsGenerateReport(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsGenerateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this product. | 
 **data** | [**ReportGenerateOption**](ReportGenerateOption.md)|  | 

### Return type

[**ReportGenerate**](ReportGenerate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productslist"></a>
# **ProductsList**
> InlineResponse20015 ProductsList (string duplicate = null, string externalAudience = null, string internetAccessible = null, string name = null, string description = null, string businessCriticality = null, string platform = null, string lifecycle = null, string origin = null, decimal? id = null, decimal? productManager = null, decimal? technicalContact = null, decimal? teamManager = null, decimal? prodType = null, decimal? tid = null, decimal? authorizedUsers = null, decimal? prodNumericGrade = null, decimal? userRecords = null, decimal? regulations = null, decimal? activeFindingCount = null, string tag = null, string tags = null, string created = null, string updated = null, decimal? revenue = null, string o = null, int? limit = null, int? offset = null, List<string> prefetch = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var duplicate = duplicate_example;  // string |  (optional) 
            var externalAudience = externalAudience_example;  // string |  (optional) 
            var internetAccessible = internetAccessible_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var description = description_example;  // string |  (optional) 
            var businessCriticality = businessCriticality_example;  // string |  (optional) 
            var platform = platform_example;  // string |  (optional) 
            var lifecycle = lifecycle_example;  // string |  (optional) 
            var origin = origin_example;  // string |  (optional) 
            var id = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var productManager = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var technicalContact = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var teamManager = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var prodType = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var tid = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var authorizedUsers = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var prodNumericGrade = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var userRecords = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var regulations = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var activeFindingCount = 8.14;  // decimal? | Multiple values may be separated by commas. (optional) 
            var tag = tag_example;  // string |  (optional) 
            var tags = tags_example;  // string |  (optional) 
            var created = created_example;  // string |  (optional) 
            var updated = updated_example;  // string |  (optional) 
            var revenue = 8.14;  // decimal? |  (optional) 
            var o = o_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var prefetch = prefetch_example;  // List<string> |  (optional) 

            try
            {
                InlineResponse20015 result = apiInstance.ProductsList(duplicate, externalAudience, internetAccessible, name, description, businessCriticality, platform, lifecycle, origin, id, productManager, technicalContact, teamManager, prodType, tid, authorizedUsers, prodNumericGrade, userRecords, regulations, activeFindingCount, tag, tags, created, updated, revenue, o, limit, offset, prefetch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **duplicate** | **string**|  | [optional] 
 **externalAudience** | **string**|  | [optional] 
 **internetAccessible** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **description** | **string**|  | [optional] 
 **businessCriticality** | **string**|  | [optional] 
 **platform** | **string**|  | [optional] 
 **lifecycle** | **string**|  | [optional] 
 **origin** | **string**|  | [optional] 
 **id** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **productManager** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **technicalContact** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **teamManager** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **prodType** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **tid** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **authorizedUsers** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **prodNumericGrade** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **userRecords** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **regulations** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **activeFindingCount** | **decimal?**| Multiple values may be separated by commas. | [optional] 
 **tag** | **string**|  | [optional] 
 **tags** | **string**|  | [optional] 
 **created** | **string**|  | [optional] 
 **updated** | **string**|  | [optional] 
 **revenue** | **decimal?**|  | [optional] 
 **o** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **prefetch** | **List&lt;string&gt;**|  | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productspartialupdate"></a>
# **ProductsPartialUpdate**
> Product ProductsPartialUpdate (int? id, Product data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 56;  // int? | A unique integer value identifying this product.
            var data = new Product(); // Product | 

            try
            {
                Product result = apiInstance.ProductsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this product. | 
 **data** | [**Product**](Product.md)|  | 

### Return type

[**Product**](Product.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsread"></a>
# **ProductsRead**
> InlineResponse20016 ProductsRead (int? id, List<string> prefetch = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 56;  // int? | A unique integer value identifying this product.
            var prefetch = prefetch_example;  // List<string> |  (optional) 

            try
            {
                InlineResponse20016 result = apiInstance.ProductsRead(id, prefetch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this product. | 
 **prefetch** | **List&lt;string&gt;**|  | [optional] 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsupdate"></a>
# **ProductsUpdate**
> Product ProductsUpdate (int? id, Product data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 56;  // int? | A unique integer value identifying this product.
            var data = new Product(); // Product | 

            try
            {
                Product result = apiInstance.ProductsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this product. | 
 **data** | [**Product**](Product.md)|  | 

### Return type

[**Product**](Product.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

