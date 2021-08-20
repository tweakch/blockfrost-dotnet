# Blockfrost.Api.Gen.Models.GenesisContent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveSlotsCoefficient** | [**decimal?**](BigDecimal.md) | The proportion of slots in which blocks should be issued | 
**UpdateQuorum** | **int?** | Determines the quorum needed for votes on the protocol parameter updates | 
**MaxLovelaceSupply** | **string** | The total number of lovelace in the system | 
**NetworkMagic** | **int?** | Network identifier | 
**EpochLength** | **int?** | Number of slots in an epoch | 
**SystemStart** | **int?** | Time of slot 0 in UNIX time | 
**SlotsPerKesPeriod** | **int?** | Number of slots in an KES period | 
**SlotLength** | **int?** | Duration of one slot in seconds | 
**MaxKesEvolutions** | **int?** | The maximum number of time a KES key can be evolved before a pool operator must create a new operational certificate | 
**SecurityParam** | **int?** | Security parameter k | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

