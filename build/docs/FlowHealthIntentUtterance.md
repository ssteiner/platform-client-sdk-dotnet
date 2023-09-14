---
title: FlowHealthIntentUtterance
---
## ININ.PureCloudApi.Model.FlowHealthIntentUtterance

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Text** | **string** | Utterance Text. | [optional] |
| **IssueCount** | **long?** | Number of issues found for this utterance. | [optional] |
| **StaticValidationResults** | **List&lt;string&gt;** | Validation results for this utterance. | [optional] |
| **OutlierInfo** | [**OutlierInfo**](OutlierInfo.html) | Details about this utterance being an outlier or not. | [optional] |
| **ConfusionInfo** | [**ConfusionInfo**](ConfusionInfo.html) | Confusion details with other utterances. | [optional] |
{: class="table table-striped"}

