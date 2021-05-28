# DefectDojo.Api.SonarqubeProductConfigurationsApi

All URIs are relative to *https://defectdojo.office.oneshoe.nl/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SonarqubeProductConfigurationsCreate**](SonarqubeProductConfigurationsApi.md#sonarqubeproductconfigurationscreate) | **POST** /sonarqube_product_configurations/ | 
[**SonarqubeProductConfigurationsDelete**](SonarqubeProductConfigurationsApi.md#sonarqubeproductconfigurationsdelete) | **DELETE** /sonarqube_product_configurations/{id}/ | 
[**SonarqubeProductConfigurationsList**](SonarqubeProductConfigurationsApi.md#sonarqubeproductconfigurationslist) | **GET** /sonarqube_product_configurations/ | 
[**SonarqubeProductConfigurationsPartialUpdate**](SonarqubeProductConfigurationsApi.md#sonarqubeproductconfigurationspartialupdate) | **PATCH** /sonarqube_product_configurations/{id}/ | 
[**SonarqubeProductConfigurationsRead**](SonarqubeProductConfigurationsApi.md#sonarqubeproductconfigurationsread) | **GET** /sonarqube_product_configurations/{id}/ | 
[**SonarqubeProductConfigurationsUpdate**](SonarqubeProductConfigurationsApi.md#sonarqubeproductconfigurationsupdate) | **PUT** /sonarqube_product_configurations/{id}/ | 


<a name="sonarqubeproductconfigurationscreate"></a>
# **SonarqubeProductConfigurationsCreate**
> SonarqubeProduct SonarqubeProductConfigurationsCreate (SonarqubeProduct data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeProductConfigurationsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeProductConfigurationsApi();
            var data = new SonarqubeProduct(); // SonarqubeProduct | 

            try
            {
                SonarqubeProduct result = apiInstance.SonarqubeProductConfigurationsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeProductConfigurationsApi.SonarqubeProductConfigurationsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**SonarqubeProduct**](SonarqubeProduct.md)|  | 

### Return type

[**SonarqubeProduct**](SonarqubeProduct.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeproductconfigurationsdelete"></a>
# **SonarqubeProductConfigurationsDelete**
> void SonarqubeProductConfigurationsDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeProductConfigurationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeProductConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ product.

            try
            {
                apiInstance.SonarqubeProductConfigurationsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeProductConfigurationsApi.SonarqubeProductConfigurationsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ product. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeproductconfigurationslist"></a>
# **SonarqubeProductConfigurationsList**
> InlineResponse20019 SonarqubeProductConfigurationsList (decimal? id = null, string product = null, string sonarqubeProjectKey = null, string sonarqubeToolConfig = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeProductConfigurationsListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeProductConfigurationsApi();
            var id = 8.14;  // decimal? |  (optional) 
            var product = product_example;  // string |  (optional) 
            var sonarqubeProjectKey = sonarqubeProjectKey_example;  // string |  (optional) 
            var sonarqubeToolConfig = sonarqubeToolConfig_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20019 result = apiInstance.SonarqubeProductConfigurationsList(id, product, sonarqubeProjectKey, sonarqubeToolConfig, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeProductConfigurationsApi.SonarqubeProductConfigurationsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **product** | **string**|  | [optional] 
 **sonarqubeProjectKey** | **string**|  | [optional] 
 **sonarqubeToolConfig** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeproductconfigurationspartialupdate"></a>
# **SonarqubeProductConfigurationsPartialUpdate**
> SonarqubeProduct SonarqubeProductConfigurationsPartialUpdate (int? id, SonarqubeProduct data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeProductConfigurationsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeProductConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ product.
            var data = new SonarqubeProduct(); // SonarqubeProduct | 

            try
            {
                SonarqubeProduct result = apiInstance.SonarqubeProductConfigurationsPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeProductConfigurationsApi.SonarqubeProductConfigurationsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ product. | 
 **data** | [**SonarqubeProduct**](SonarqubeProduct.md)|  | 

### Return type

[**SonarqubeProduct**](SonarqubeProduct.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeproductconfigurationsread"></a>
# **SonarqubeProductConfigurationsRead**
> SonarqubeProduct SonarqubeProductConfigurationsRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeProductConfigurationsReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeProductConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ product.

            try
            {
                SonarqubeProduct result = apiInstance.SonarqubeProductConfigurationsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeProductConfigurationsApi.SonarqubeProductConfigurationsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ product. | 

### Return type

[**SonarqubeProduct**](SonarqubeProduct.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sonarqubeproductconfigurationsupdate"></a>
# **SonarqubeProductConfigurationsUpdate**
> SonarqubeProduct SonarqubeProductConfigurationsUpdate (int? id, SonarqubeProduct data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class SonarqubeProductConfigurationsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SonarqubeProductConfigurationsApi();
            var id = 56;  // int? | A unique integer value identifying this sonarqube_ product.
            var data = new SonarqubeProduct(); // SonarqubeProduct | 

            try
            {
                SonarqubeProduct result = apiInstance.SonarqubeProductConfigurationsUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SonarqubeProductConfigurationsApi.SonarqubeProductConfigurationsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this sonarqube_ product. | 
 **data** | [**SonarqubeProduct**](SonarqubeProduct.md)|  | 

### Return type

[**SonarqubeProduct**](SonarqubeProduct.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

