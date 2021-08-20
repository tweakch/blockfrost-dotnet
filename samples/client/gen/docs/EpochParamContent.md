# Blockfrost.Api.Gen.Model.EpochParamContent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Epoch** | **int?** | Epoch number | 
**MinFeeA** | **int?** | The linear factor for the minimum fee calculation for given epoch | 
**MinFeeB** | **int?** | The constant factor for the minimum fee calculation | 
**MaxBlockSize** | **int?** | Maximum block body size in Bytes | 
**MaxTxSize** | **int?** | Maximum transaction size | 
**MaxBlockHeaderSize** | **int?** | Maximum block header size | 
**KeyDeposit** | **string** | The amount of a key registration deposit in Lovelaces | 
**PoolDeposit** | **string** | The amount of a pool registration deposit in Lovelaces | 
**EMax** | **int?** | Epoch bound on pool retirement | 
**NOpt** | **int?** | Desired number of pools | 
**A0** | [**decimal?**](BigDecimal.md) | Pool pledge influence | 
**Rho** | [**decimal?**](BigDecimal.md) | Monetary expansion | 
**Tau** | [**decimal?**](BigDecimal.md) | Treasury expansion | 
**DecentralisationParam** | [**decimal?**](BigDecimal.md) | Percentage of blocks produced by federated nodes | 
**ExtraEntropy** | **Object** | Seed for extra entropy | 
**ProtocolMajorVer** | **int?** | Accepted protocol major version | 
**ProtocolMinorVer** | **int?** | Accepted protocol minor version | 
**MinUtxo** | **string** | Minimum UTXO value | 
**MinPoolCost** | **string** | Minimum stake cost forced on the pool | 
**Nonce** | **string** | Epoch number only used once | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

