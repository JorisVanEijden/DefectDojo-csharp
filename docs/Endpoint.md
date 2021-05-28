# DefectDojo.Model.Endpoint
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**Protocol** | **string** | The communication protocol such as &#39;http&#39;, &#39;ftp&#39;, etc. | [optional] 
**Host** | **string** | The host name or IP address, you can also include the port number. For example&#39;127.0.0.1&#39;, &#39;127.0.0.1:8080&#39;, &#39;localhost&#39;, &#39;yourdomain.com&#39;. | [optional] 
**Fqdn** | **string** |  | [optional] 
**Port** | **int?** | The network port associated with the endpoint. | [optional] 
**Path** | **string** | The location of the resource, it should start with a &#39;/&#39;. For example/endpoint/420/edit | [optional] 
**Query** | **string** | The query string, the question mark should be omitted.For example &#39;group&#x3D;4&amp;team&#x3D;8&#39; | [optional] 
**Fragment** | **string** | The fragment identifier which follows the hash mark. The hash mark should be omitted. For example &#39;section-13&#39;, &#39;paragraph-2&#39;. | [optional] 
**Mitigated** | **bool?** |  | [optional] 
**TagsFromDjangoTagging** | **string** | Temporary archive with tags from the previous tagging library we used | [optional] 
**Product** | **int?** |  | [optional] 
**EndpointParams** | **List&lt;int?&gt;** |  | [optional] 
**EndpointStatus** | **List&lt;int?&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

