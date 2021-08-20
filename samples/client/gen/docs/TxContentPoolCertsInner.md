# Blockfrost.Api.Gen.Model.TxContentPoolCertsInner
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertIndex** | **int?** | Index of the certificate within the transaction | 
**PoolId** | **string** | Bech32 encoded pool ID | 
**VrfKey** | **string** | VRF key hash | 
**Pledge** | **string** | Stake pool certificate pledge in Lovelaces | 
**MarginCost** | [**decimal?**](BigDecimal.md) | Margin tax cost of the stake pool | 
**FixedCost** | **string** | Fixed tax cost of the stake pool in Lovelaces | 
**RewardAccount** | **string** | Bech32 reward account of the stake pool | 
**Owners** | **List&lt;string&gt;** |  | 
**Metadata** | **Object** |  | 
**Relays** | **List&lt;Object&gt;** |  | 
**ActiveEpoch** | **int?** | Epoch that the delegation becomes active | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

