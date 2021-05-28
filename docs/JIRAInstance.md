# DefectDojo.Model.JIRAInstance
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**ConfigurationName** | **string** | Enter a name to give to this configuration | [optional] 
**Url** | **string** | For more information how to configure Jira, read the DefectDojo documentation. | 
**Username** | **string** |  | 
**Password** | **string** |  | 
**DefaultIssueType** | **string** | You can define extra issue types in settings.py | [optional] 
**IssueTemplateDir** | **string** | Choose the folder containing the Django templates used to render the JIRA issue description. These are stored in dojo/templates/issue-trackers. Leave empty to use the default jira_full templates. | [optional] 
**EpicNameId** | **int?** | To obtain the &#39;Epic name id&#39; visit https://&lt;YOUR JIRA URL&gt;/rest/api/2/field and search for Epic Name. Copy the number out of cf[number] and paste it here. | 
**OpenStatusKey** | **int?** | Transition ID to Re-Open JIRA issues, visit https://&lt;YOUR JIRA URL&gt;/rest/api/latest/issue/&lt;ANY VALID ISSUE KEY&gt;/transitions?expand&#x3D;transitions.fields to find the ID for your JIRA instance | 
**CloseStatusKey** | **int?** | Transition ID to Close JIRA issues, visit https://&lt;YOUR JIRA URL&gt;/rest/api/latest/issue/&lt;ANY VALID ISSUE KEY&gt;/transitions?expand&#x3D;transitions.fields to find the ID for your JIRA instance | 
**InfoMappingSeverity** | **string** | Maps to the &#39;Priority&#39; field in Jira. For example: Info | 
**LowMappingSeverity** | **string** | Maps to the &#39;Priority&#39; field in Jira. For example: Low | 
**MediumMappingSeverity** | **string** | Maps to the &#39;Priority&#39; field in Jira. For example: Medium | 
**HighMappingSeverity** | **string** | Maps to the &#39;Priority&#39; field in Jira. For example: High | 
**CriticalMappingSeverity** | **string** | Maps to the &#39;Priority&#39; field in Jira. For example: Critical | 
**FindingText** | **string** | Additional text that will be added to the finding in Jira. For example including how the finding was created or who to contact for more information. | [optional] 
**AcceptedMappingResolution** | **string** | JIRA resolution names (comma-separated values) that maps to an Accepted Finding | [optional] 
**FalsePositiveMappingResolution** | **string** | JIRA resolution names (comma-separated values) that maps to a False Positive Finding | [optional] 
**GlobalJiraSlaNotification** | **bool?** | This setting can be overidden at the Product level | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

