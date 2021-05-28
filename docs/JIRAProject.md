# DefectDojo.Model.JIRAProject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**ProjectKey** | **string** |  | [optional] 
**IssueTemplateDir** | **string** | Choose the folder containing the Django templates used to render the JIRA issue description. These are stored in dojo/templates/issue-trackers. Leave empty to use the default jira_full templates. | [optional] 
**Component** | **string** |  | [optional] 
**PushAllIssues** | **bool?** | Automatically maintain parity with JIRA. Always create and update JIRA tickets for findings in this Product. | [optional] 
**EnableEngagementEpicMapping** | **bool?** |  | [optional] 
**PushNotes** | **bool?** |  | [optional] 
**ProductJiraSlaNotification** | **bool?** |  | [optional] 
**RiskAcceptanceExpirationNotification** | **bool?** |  | [optional] 
**JiraInstance** | **int?** |  | [optional] 
**Product** | **int?** |  | [optional] 
**Engagement** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

