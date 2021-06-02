# DefectDojo.Model.Engagement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Version** | **string** | Version of the product the engagement tested. | [optional] 
**FirstContacted** | **DateTime?** |  | [optional] 
**TargetStart** | **DateTime?** |  | 
**TargetEnd** | **DateTime?** |  | 
**Reason** | **string** |  | [optional] 
**Updated** | **DateTime?** |  | [optional] 
**Created** | **DateTime?** |  | [optional] 
**Active** | **bool?** |  | [optional] 
**Tracker** | **string** | Link to epic or ticket system with changes to version. | [optional] 
**TestStrategy** | **string** |  | [optional] 
**ThreatModel** | **bool?** |  | [optional] 
**ApiTest** | **bool?** |  | [optional] 
**PenTest** | **bool?** |  | [optional] 
**CheckList** | **bool?** |  | [optional] 
**Status** | **string** |  | [optional] 
**Progress** | **string** |  | [optional] 
**TmodelPath** | **string** |  | [optional] 
**DoneTesting** | **bool?** |  | [optional] 
**EngagementType** | **string** |  | [optional] 
**BuildId** | **string** | Build ID of the product the engagement tested. | [optional] 
**CommitHash** | **string** | Commit hash from repo | [optional] 
**BranchTag** | **string** | Tag or branch of the product the engagement tested. | [optional] 
**SourceCodeManagementUri** | **string** | Resource link to source code | [optional] 
**DeduplicationOnEngagement** | **bool?** | If enabled deduplication will only mark a finding in this engagement as duplicate of another finding if both findings are in this engagement. If disabled, deduplication is on the product level. | [optional] 
**TagsFromDjangoTagging** | **string** | Temporary archive with tags from the previous tagging library we used | [optional] 
**EngType** | **int?** |  | [optional] 
**Lead** | **int?** |  | [optional] 
**Requester** | **int?** |  | [optional] 
**Preset** | **int?** | Settings and notes for performing this engagement. | [optional] 
**ReportType** | **int?** |  | [optional] 
**Product** | **int?** |  | 
**BuildServer** | **int?** | Build server responsible for CI/CD test | [optional] 
**SourceCodeManagementServer** | **int?** | Source code server for CI/CD test | [optional] 
**OrchestrationEngine** | **int?** | Orchestration service responsible for CI/CD test | [optional] 
**Notes** | [**List&lt;Note&gt;**](Note.md) |  | [optional] 
**Files** | **List&lt;System.IO.Stream&gt;** |  | [optional] 
**RiskAcceptance** | **List&lt;int?&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

