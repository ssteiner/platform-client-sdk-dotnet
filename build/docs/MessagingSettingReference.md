---
title: MessagingSettingReference
---
## ININ.PureCloudApi.Model.MessagingSettingReference

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The messaging Setting unique identifier associated with this integration | |
| **Name** | **string** | The messaging Setting profile name | [optional] |
| **SelfUri** | **string** | The messaging Setting profile URI | [optional] |
| **DateCreated** | **DateTime?** | Date this messaging Setting was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | Date this messaging Setting was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Version** | **string** | Version number | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef.html) | User reference that created this Setting | [optional] |
| **UpdatedBy** | [**DomainEntityRef**](DomainEntityRef.html) | User reference that modified this Setting | [optional] |
| **Content** | [**ContentSetting**](ContentSetting.html) | Settings relating to message contents | [optional] |
| **Event** | [**EventSetting**](EventSetting.html) | Settings relating to events which may occur | [optional] |
{: class="table table-striped"}

