# Blockfrost.Api.Gen.Services.CardanoAddressesApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressesAddressGet**](CardanoAddressesApi.md#addressesaddressget) | **GET** /addresses/{address} | Specific address
[**AddressesAddressTotalGet**](CardanoAddressesApi.md#addressesaddresstotalget) | **GET** /addresses/{address}/total | Address details
[**AddressesAddressTransactionsGet**](CardanoAddressesApi.md#addressesaddresstransactionsget) | **GET** /addresses/{address}/transactions | Address transactions
[**AddressesAddressTxsGet**](CardanoAddressesApi.md#addressesaddresstxsget) | **GET** /addresses/{address}/txs | Address transactions
[**AddressesAddressUtxosGet**](CardanoAddressesApi.md#addressesaddressutxosget) | **GET** /addresses/{address}/utxos | Address UTXOs

<a name="addressesaddressget"></a>
# **AddressesAddressGet**
> AddressContent AddressesAddressGet (string address)

Specific address

Obtain information about a specific address.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Models;

namespace Example
{
    public class AddressesAddressGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAddressesApi();
            var address = address_example;  // string | Bech32 address.

            try
            {
                // Specific address
                AddressContent result = apiInstance.AddressesAddressGet(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAddressesApi.AddressesAddressGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Bech32 address. | 

### Return type

[**AddressContent**](AddressContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addressesaddresstotalget"></a>
# **AddressesAddressTotalGet**
> AddressContentTotal AddressesAddressTotalGet (string address)

Address details

Obtain details about an address.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Models;

namespace Example
{
    public class AddressesAddressTotalGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAddressesApi();
            var address = address_example;  // string | Bech32 address.

            try
            {
                // Address details
                AddressContentTotal result = apiInstance.AddressesAddressTotalGet(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAddressesApi.AddressesAddressTotalGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Bech32 address. | 

### Return type

[**AddressContentTotal**](AddressContentTotal.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addressesaddresstransactionsget"></a>
# **AddressesAddressTransactionsGet**
> AddressTransactionsContent AddressesAddressTransactionsGet (string address, int? count = null, int? page = null, string order = null, string from = null, string to = null)

Address transactions

Transactions on the address.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Models;

namespace Example
{
    public class AddressesAddressTransactionsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAddressesApi();
            var address = address_example;  // string | Bech32 address.
            var count = 56;  // int? | The numbers of pools per page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)
            var from = from_example;  // string | The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to `to` parameter.  (optional) 
            var to = to_example;  // string | The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to `from` parameter.  (optional) 

            try
            {
                // Address transactions
                AddressTransactionsContent result = apiInstance.AddressesAddressTransactionsGet(address, count, page, order, from, to);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAddressesApi.AddressesAddressTransactionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Bech32 address. | 
 **count** | **int?**| The numbers of pools per page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]
 **from** | **string**| The block number and optionally also index from which (inclusive) to start search for results, concatenated using colon. Has to be lower than or equal to &#x60;to&#x60; parameter.  | [optional] 
 **to** | **string**| The block number and optionally also index where (inclusive) to end the search for results, concatenated using colon. Has to be higher than or equal to &#x60;from&#x60; parameter.  | [optional] 

### Return type

[**AddressTransactionsContent**](AddressTransactionsContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addressesaddresstxsget"></a>
# **AddressesAddressTxsGet**
> AddressTxsContent AddressesAddressTxsGet (string address, int? count = null, int? page = null, string order = null)

Address transactions

Transactions on the address.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Models;

namespace Example
{
    public class AddressesAddressTxsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAddressesApi();
            var address = address_example;  // string | Bech32 address.
            var count = 56;  // int? | The number of transactions per page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Address transactions
                AddressTxsContent result = apiInstance.AddressesAddressTxsGet(address, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAddressesApi.AddressesAddressTxsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Bech32 address. | 
 **count** | **int?**| The number of transactions per page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AddressTxsContent**](AddressTxsContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addressesaddressutxosget"></a>
# **AddressesAddressUtxosGet**
> AddressUtxoContent AddressesAddressUtxosGet (string address, int? count = null, int? page = null, string order = null)

Address UTXOs

UTXOs of the address.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Models;

namespace Example
{
    public class AddressesAddressUtxosGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAddressesApi();
            var address = address_example;  // string | Bech32 address.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Address UTXOs
                AddressUtxoContent result = apiInstance.AddressesAddressUtxosGet(address, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAddressesApi.AddressesAddressUtxosGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Bech32 address. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AddressUtxoContent**](AddressUtxoContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
