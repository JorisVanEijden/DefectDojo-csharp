# DefectDojo.Api.NotesApi

All URIs are relative to *https://localhost:8080/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotesList**](NotesApi.md#noteslist) | **GET** /notes/ | 
[**NotesPartialUpdate**](NotesApi.md#notespartialupdate) | **PATCH** /notes/{id}/ | 
[**NotesRead**](NotesApi.md#notesread) | **GET** /notes/{id}/ | 
[**NotesUpdate**](NotesApi.md#notesupdate) | **PUT** /notes/{id}/ | 


<a name="noteslist"></a>
# **NotesList**
> InlineResponse20012 NotesList (decimal? id = null, string entry = null, string author = null, string _private = null, string date = null, string edited = null, string editTime = null, string editor = null, int? limit = null, int? offset = null)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NotesListExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var id = 8.14;  // decimal? |  (optional) 
            var entry = entry_example;  // string |  (optional) 
            var author = author_example;  // string |  (optional) 
            var _private = _private_example;  // string |  (optional) 
            var date = date_example;  // string |  (optional) 
            var edited = edited_example;  // string |  (optional) 
            var editTime = editTime_example;  // string |  (optional) 
            var editor = editor_example;  // string |  (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 
            var offset = 56;  // int? | The initial index from which to return the results. (optional) 

            try
            {
                InlineResponse20012 result = apiInstance.NotesList(id, entry, author, _private, date, edited, editTime, editor, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal?**|  | [optional] 
 **entry** | **string**|  | [optional] 
 **author** | **string**|  | [optional] 
 **_private** | **string**|  | [optional] 
 **date** | **string**|  | [optional] 
 **edited** | **string**|  | [optional] 
 **editTime** | **string**|  | [optional] 
 **editor** | **string**|  | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 
 **offset** | **int?**| The initial index from which to return the results. | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notespartialupdate"></a>
# **NotesPartialUpdate**
> Note NotesPartialUpdate (int? id, Note data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NotesPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var id = 56;  // int? | A unique integer value identifying this notes.
            var data = new Note(); // Note | 

            try
            {
                Note result = apiInstance.NotesPartialUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this notes. | 
 **data** | [**Note**](Note.md)|  | 

### Return type

[**Note**](Note.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notesread"></a>
# **NotesRead**
> Note NotesRead (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NotesReadExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var id = 56;  // int? | A unique integer value identifying this notes.

            try
            {
                Note result = apiInstance.NotesRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this notes. | 

### Return type

[**Note**](Note.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notesupdate"></a>
# **NotesUpdate**
> Note NotesUpdate (int? id, Note data)



### Example
```csharp
using System;
using System.Diagnostics;
using DefectDojo.Api;
using DefectDojo.Client;
using DefectDojo.Model;

namespace Example
{
    public class NotesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var id = 56;  // int? | A unique integer value identifying this notes.
            var data = new Note(); // Note | 

            try
            {
                Note result = apiInstance.NotesUpdate(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this notes. | 
 **data** | [**Note**](Note.md)|  | 

### Return type

[**Note**](Note.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

