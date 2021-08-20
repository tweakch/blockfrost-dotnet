# Blockfrost.Api.Gen.Services.CardanoLedgerApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenesisGet**](CardanoLedgerApi.md#genesisget) | **GET** /genesis | Blockchain genesis

<a name="genesisget"></a>
# **GenesisGet**
> GenesisContent GenesisGet ()

Blockchain genesis

Return the information about blockchain genesis.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class GenesisGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoLedgerApi();

            try
            {
                // Blockchain genesis
                GenesisContent result = apiInstance.GenesisGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoLedgerApi.GenesisGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GenesisContent**](GenesisContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
