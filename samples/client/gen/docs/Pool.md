# Blockfrost.Api.Gen.Models.Pool
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PoolId** | **string** | Bech32 pool ID | 
**Hex** | **string** | Hexadecimal pool ID. | 
**VrfKey** | **string** | VRF key hash | 
**BlocksMinted** | **int?** | Total minted blocks | 
**LiveStake** | **string** |  | 
**LiveSize** | [**decimal?**](BigDecimal.md) |  | 
**LiveSaturation** | [**decimal?**](BigDecimal.md) |  | 
**LiveDelegators** | [**decimal?**](BigDecimal.md) |  | 
**ActiveStake** | **string** |  | 
**ActiveSize** | [**decimal?**](BigDecimal.md) |  | 
**DeclaredPledge** | **string** | Stake pool certificate pledge | 
**LivePledge** | **string** | Stake pool current pledge | 
**MarginCost** | [**decimal?**](BigDecimal.md) | Margin tax cost of the stake pool | 
**FixedCost** | **string** | Fixed tax cost of the stake pool | 
**RewardAccount** | **string** | Bech32 reward account of the stake pool | 
**Owners** | **List&lt;string&gt;** |  | 
**Registration** | **List&lt;string&gt;** |  | 
**Retirement** | **List&lt;string&gt;** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

