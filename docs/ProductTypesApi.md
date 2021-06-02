# DefectDojo.Api.ProductTypesApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductTypesCreate**](ProductTypesApi.md#producttypescreate) | **POST** /product_types/ | 
[**ProductTypesGenerateReport**](ProductTypesApi.md#producttypesgeneratereport) | **POST** /product_types/{id}/generate_report/ | 
[**ProductTypesList**](ProductTypesApi.md#producttypeslist) | **GET** /product_types/ | 
[**ProductTypesPartialUpdate**](ProductTypesApi.md#producttypespartialupdate) | **PATCH** /product_types/{id}/ | 
[**ProductTypesRead**](ProductTypesApi.md#producttypesread) | **GET** /product_types/{id}/ | 
[**ProductTypesUpdate**](ProductTypesApi.md#producttypesupdate) | **PUT** /product_types/{id}/ | 


<a name="producttypescreate"></a>
# **ProductTypesCreate**
> ProductType ProductTypesCreate (ProductType data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductTypesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductTypesApi();
            var data = new ProductType(); // ProductType | 

            try
            {
                ProductType result = apiInstance.ProductTypesCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductTypesApi.ProductTypesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ProductType**](ProductType.md)|  | 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="producttypesgeneratereport"></a>
# **ProductTypesGenerateReport**
> ReportGenerate ProductTypesGenerateReport (int? id, ReportGenerateOption data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductTypesGenerateReportExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductTypesApi();
            var id = 56;  // int? | A unique integer value identifying this product_ type.
            var data = new ReportGenerateOption(); // ReportGenerateOption | 

            try
            {
                ReportGenerate result = apiInstance.ProductTypesGenerateReport(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductTypesApi.ProductTypesGenerateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this product_ type. | 
 **data** | [**ReportGenerateOption**](ReportGenerateOption.md)|  | 

### Return type

[**ReportGenerate**](ReportGenerate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="producttypeslist"></a>
# **ProductTypesList**
> InlineResponse20013 ProductTypesList (decimal? id = null, string name = null, string criticalProduct = null, string keyProduct = null, string created = null, string updated = null, int? limit = null, int? offset = null, List<string> prefetch = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductTypesListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductTypesApi();
            var id = 8.14;  // decimal? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var criticalProduct = criticalProduct_example;  // string |  (optional) 
            var keyProduct = keyProduct_example;  // string |  (optional) 
            var created = created_example;  // string |  (optional) 
            var updated = updated_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 
            var prefetch = prefetch_example;  // List<string> |  (optional) 

            try
            {
                InlineResponse20013 result = apiInstance.ProductTypesList(id, name, criticalProduct, keyProduct, created, updated, limit, offset, prefetch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductTypesApi.ProductTypesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **name** | **string**|  | [optional] 
 **criticalProduct** | **string**|  | [optional] 
 **keyProduct** | **string**|  | [optional] 
 **created** | **string**|  | [optional] 
 **updated** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 
 **prefetch** | **List&lt;string&gt;**|  | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="producttypespartialupdate"></a>
# **ProductTypesPartialUpdate**
> ProductType ProductTypesPartialUpdate (int? id, ProductType data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductTypesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductTypesApi();
            var id = 56;  // int? | A unique integer value identifying this product_ type.
            var data = new ProductType(); // ProductType | 

            try
            {
                ProductType result = apiInstance.ProductTypesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductTypesApi.ProductTypesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this product_ type. | 
 **data** | [**ProductType**](ProductType.md)|  | 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="producttypesread"></a>
# **ProductTypesRead**
> InlineResponse20014 ProductTypesRead (int? id, List<string> prefetch = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductTypesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductTypesApi();
            var id = 56;  // int? | A unique integer value identifying this product_ type.
            var prefetch = prefetch_example;  // List<string> |  (optional) 

            try
            {
                InlineResponse20014 result = apiInstance.ProductTypesRead(id, prefetch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductTypesApi.ProductTypesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this product_ type. | 
 **prefetch** | **List&lt;string&gt;**|  | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="producttypesupdate"></a>
# **ProductTypesUpdate**
> ProductType ProductTypesUpdate (int? id, ProductType data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class ProductTypesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProductTypesApi();
            var id = 56;  // int? | A unique integer value identifying this product_ type.
            var data = new ProductType(); // ProductType | 

            try
            {
                ProductType result = apiInstance.ProductTypesUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductTypesApi.ProductTypesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this product_ type. | 
 **data** | [**ProductType**](ProductType.md)|  | 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

