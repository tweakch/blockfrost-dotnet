# Blockfrost.Api.Gen.Models.InlineResponse2006
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeCreated** | **int?** | Creation time of the IPFS object on our backends | 
**TimePinned** | **int?** | Pin time of the IPFS object on our backends | 
**IpfsHash** | **string** | IPFS hash of the pinned object | 
**Size** | **string** | Size of the object in Bytes | 
**State** | **string** | State of the pinned object, which is &#x60;queued&#x60; when we are retriving object. If this is successful the state is changed to &#x60;pinned&#x60; or &#x60;failed&#x60; if not. The state &#x60;gc&#x60; means the pinned item has been garbage collected due to account being over storage quota or after it has been moved to &#x60;unpinned&#x60; state by removing the object pin.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

