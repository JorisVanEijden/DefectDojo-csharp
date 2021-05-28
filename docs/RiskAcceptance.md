# DefectDojo.Model.RiskAcceptance
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**Name** | **string** | Descriptive name which in the future may also be used to group risk acceptances together across engagements and products | 
**Recommendation** | **string** | Recommendation from the security team. | [optional] 
**RecommendationDetails** | **string** | Explanation of security recommendation | [optional] 
**Decision** | **string** | Risk treatment decision by risk owner | [optional] 
**DecisionDetails** | **string** | If a compensating control exists to mitigate the finding or reduce risk, then list the compensating control(s). | [optional] 
**AcceptedBy** | **string** | The person that accepts the risk, can be outside of DefectDojo. | [optional] 
**Path** | **string** |  | [optional] 
**ExpirationDate** | **DateTime?** | When the risk acceptance expires, the findings will be reactivated (unless disabled below). | [optional] 
**ExpirationDateWarned** | **DateTime?** | (readonly) Date at which notice about the risk acceptance expiration was sent. | [optional] 
**ExpirationDateHandled** | **DateTime?** | (readonly) When the risk acceptance expiration was handled (manually or by the daily job). | [optional] 
**ReactivateExpired** | **bool?** | Reactivate findings when risk acceptance expires? | [optional] 
**RestartSlaExpired** | **bool?** | When enabled, the SLA for findings is restarted when the risk acceptance expires. | [optional] 
**Created** | **DateTime?** |  | [optional] 
**Updated** | **DateTime?** |  | [optional] 
**Owner** | **int?** | User in DefectDojo owning this acceptance. Only the owner and staff users can edit the risk acceptance. | 
**AcceptedFindings** | **List&lt;int?&gt;** |  | 
**Notes** | **List&lt;int?&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

