# DefectDojo.Model.FindingTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**Title** | **string** |  | 
**Cwe** | **int?** |  | [optional] 
**Cve** | **string** |  | [optional] 
**Cvssv3** | **string** |  | [optional] 
**Severity** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Mitigation** | **string** |  | [optional] 
**Impact** | **string** |  | [optional] 
**References** | **string** |  | [optional] 
**LastUsed** | **DateTime?** |  | [optional] 
**NumericalSeverity** | **string** |  | [optional] 
**TemplateMatch** | **bool?** | Enables this template for matching remediation advice. Match will be applied to all active, verified findings by CWE. | [optional] 
**TemplateMatchTitle** | **bool?** | Matches by title text (contains search) and CWE. | [optional] 
**TagsFromDjangoTagging** | **string** | Temporary archive with tags from the previous tagging library we used | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

