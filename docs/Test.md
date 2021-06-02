# DefectDojo.Model.Test
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**TestTypeName** | **string** |  | [optional] 
**FindingGroups** | [**List&lt;FindingGroup&gt;**](FindingGroup.md) |  | [optional] 
**Title** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**TargetStart** | **DateTime?** |  | 
**TargetEnd** | **DateTime?** |  | 
**EstimatedTime** | **string** |  | [optional] 
**ActualTime** | **string** |  | [optional] 
**PercentComplete** | **int?** |  | [optional] 
**Updated** | **DateTime?** |  | [optional] 
**Created** | **DateTime?** |  | [optional] 
**TagsFromDjangoTagging** | **string** | Temporary archive with tags from the previous tagging library we used | [optional] 
**Version** | **string** |  | [optional] 
**BuildId** | **string** | Build ID that was tested, a reimport may update this field. | [optional] 
**CommitHash** | **string** | Commit hash tested, a reimport may update this field. | [optional] 
**BranchTag** | **string** | Tag or branch that was tested, a reimport may update this field. | [optional] 
**Engagement** | **int?** |  | [optional] 
**Lead** | **int?** |  | [optional] 
**TestType** | **int?** |  | 
**Environment** | **int?** |  | [optional] 
**Notes** | [**List&lt;Note&gt;**](Note.md) |  | [optional] 
**Files** | **List&lt;System.IO.Stream&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

