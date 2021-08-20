# Blockfrost.Api.Gen.Model.BlockContent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **int?** | Block creation time in UNIX time | 
**Height** | **int?** | Block number | 
**Hash** | **string** | Hash of the block | 
**Slot** | **int?** | Slot number | 
**Epoch** | **int?** | Epoch number | 
**EpochSlot** | **int?** | Slot within the epoch | 
**SlotLeader** | **string** | Bech32 ID of the slot leader or specific block description in case there is no slot leader | 
**Size** | **int?** | Block size in Bytes | 
**TxCount** | **int?** | Number of transactions in the block | 
**Output** | **string** | Total output within the block in Lovelaces | 
**Fees** | **string** | Total fees within the block in Lovelaces | 
**BlockVrf** | **string** | VRF key of the block | 
**PreviousBlock** | **string** | Hash of the previous block | 
**NextBlock** | **string** | Hash of the next block | 
**Confirmations** | **int?** | Number of block confirmations | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

