# Blockfrost.Api.Gen.Models.TxContent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hash** | **string** | Transaction hash | 
**Block** | **string** | Block hash | 
**BlockHeight** | **int?** | Block number | 
**Slot** | **int?** | Slot number | 
**Index** | **int?** | Transaction index within the block | 
**OutputAmount** | [**List&lt;TxContentOutputAmount&gt;**](TxContentOutputAmount.md) |  | 
**Fees** | **string** | Fees of the transaction in Lovelaces | 
**Deposit** | **string** | Deposit within the transaction in Lovelaces | 
**Size** | **int?** | Size of the transaction in Bytes | 
**InvalidBefore** | **string** | Left (included) endpoint of the timelock validity intervals | 
**InvalidHereafter** | **string** | Right (excluded) endpoint of the timelock validity intervals | 
**UtxoCount** | **int?** | Count of UTXOs within the transaction | 
**WithdrawalCount** | **int?** | Count of the withdrawals within the transaction | 
**MirCertCount** | **int?** | Count of the MIR certificates within the transaction | 
**DelegationCount** | **int?** | Count of the delegations within the transaction | 
**StakeCertCount** | **int?** | Count of the stake keys (de)registration and delegation certificates within the transaction | 
**PoolUpdateCount** | **int?** | Count of the stake pool registration and update certificates within the transaction | 
**PoolRetireCount** | **int?** | Count of the stake pool retirement certificates within the transaction | 
**AssetMintOrBurnCount** | **int?** | Count of asset mints and burns within the transaction | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

