# DefectDojo.Model.User
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**Username** | **string** | Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only. | 
**FirstName** | **string** |  | [optional] 
**LastName** | **string** |  | [optional] 
**Email** | **string** |  | [optional] 
**LastLogin** | **DateTime?** |  | [optional] 
**IsActive** | **bool?** | Designates whether this user should be treated as active. Unselect this instead of deleting accounts. | [optional] 
**IsStaff** | **bool?** | Designates whether the user can log into this admin site. | [optional] 
**IsSuperuser** | **bool?** | Designates that this user has all permissions without explicitly assigning them. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

