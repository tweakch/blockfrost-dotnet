# IO.Swagger.Api.CardanoBlocksApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BlocksEpochEpochNumberSlotSlotNumberGet**](CardanoBlocksApi.md#blocksepochepochnumberslotslotnumberget) | **GET** /blocks/epoch/{epoch_number}/slot/{slot_number} | Specific block in a slot in an epoch
[**BlocksHashOrNumberGet**](CardanoBlocksApi.md#blockshashornumberget) | **GET** /blocks/{hash_or_number} | Specific block
[**BlocksHashOrNumberNextGet**](CardanoBlocksApi.md#blockshashornumbernextget) | **GET** /blocks/{hash_or_number}/next | Listing of next blocks
[**BlocksHashOrNumberPreviousGet**](CardanoBlocksApi.md#blockshashornumberpreviousget) | **GET** /blocks/{hash_or_number}/previous | Listing of previous blocks
[**BlocksHashOrNumberTxsGet**](CardanoBlocksApi.md#blockshashornumbertxsget) | **GET** /blocks/{hash_or_number}/txs | Block transactions
[**BlocksLatestGet**](CardanoBlocksApi.md#blockslatestget) | **GET** /blocks/latest | Latest block
[**BlocksLatestTxsGet**](CardanoBlocksApi.md#blockslatesttxsget) | **GET** /blocks/latest/txs | Latest block transactions
[**BlocksSlotSlotNumberGet**](CardanoBlocksApi.md#blocksslotslotnumberget) | **GET** /blocks/slot/{slot_number} | Specific block in a slot

<a name="blocksepochepochnumberslotslotnumberget"></a>
# **BlocksEpochEpochNumberSlotSlotNumberGet**
> BlockContent BlocksEpochEpochNumberSlotSlotNumberGet (int? epochNumber, int? slotNumber)

Specific block in a slot in an epoch

Return the content of a requested block for a specific slot in an epoch. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlocksEpochEpochNumberSlotSlotNumberGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoBlocksApi();
            var epochNumber = 56;  // int? | Epoch for specific epoch slot.
            var slotNumber = 56;  // int? | Slot position for requested block.

            try
            {
                // Specific block in a slot in an epoch
                BlockContent result = apiInstance.BlocksEpochEpochNumberSlotSlotNumberGet(epochNumber, slotNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoBlocksApi.BlocksEpochEpochNumberSlotSlotNumberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **epochNumber** | **int?**| Epoch for specific epoch slot. | 
 **slotNumber** | **int?**| Slot position for requested block. | 

### Return type

[**BlockContent**](BlockContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="blockshashornumberget"></a>
# **BlocksHashOrNumberGet**
> BlockContent BlocksHashOrNumberGet (string hashOrNumber)

Specific block

Return the content of a requested block. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlocksHashOrNumberGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoBlocksApi();
            var hashOrNumber = hashOrNumber_example;  // string | Hash or number of the requested block.

            try
            {
                // Specific block
                BlockContent result = apiInstance.BlocksHashOrNumberGet(hashOrNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoBlocksApi.BlocksHashOrNumberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hashOrNumber** | **string**| Hash or number of the requested block. | 

### Return type

[**BlockContent**](BlockContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="blockshashornumbernextget"></a>
# **BlocksHashOrNumberNextGet**
> BlockContentArray BlocksHashOrNumberNextGet (string hashOrNumber, int? count = null, int? page = null)

Listing of next blocks

Return the list of blocks following a specific block. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlocksHashOrNumberNextGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoBlocksApi();
            var hashOrNumber = hashOrNumber_example;  // string | Hash of the requested block.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)

            try
            {
                // Listing of next blocks
                BlockContentArray result = apiInstance.BlocksHashOrNumberNextGet(hashOrNumber, count, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoBlocksApi.BlocksHashOrNumberNextGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hashOrNumber** | **string**| Hash of the requested block. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]

### Return type

[**BlockContentArray**](BlockContentArray.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="blockshashornumberpreviousget"></a>
# **BlocksHashOrNumberPreviousGet**
> BlockContentArray BlocksHashOrNumberPreviousGet (string hashOrNumber, int? count = null, int? page = null)

Listing of previous blocks

Return the list of blocks preceding a specific block. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlocksHashOrNumberPreviousGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoBlocksApi();
            var hashOrNumber = hashOrNumber_example;  // string | Hash of the requested block
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)

            try
            {
                // Listing of previous blocks
                BlockContentArray result = apiInstance.BlocksHashOrNumberPreviousGet(hashOrNumber, count, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoBlocksApi.BlocksHashOrNumberPreviousGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hashOrNumber** | **string**| Hash of the requested block | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]

### Return type

[**BlockContentArray**](BlockContentArray.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="blockshashornumbertxsget"></a>
# **BlocksHashOrNumberTxsGet**
> BlockContentTxs BlocksHashOrNumberTxsGet (string hashOrNumber, int? count = null, int? page = null, string order = null)

Block transactions

Return the transactions within the block.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlocksHashOrNumberTxsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoBlocksApi();
            var hashOrNumber = hashOrNumber_example;  // string | Hash of the requested block.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Block transactions
                BlockContentTxs result = apiInstance.BlocksHashOrNumberTxsGet(hashOrNumber, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoBlocksApi.BlocksHashOrNumberTxsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hashOrNumber** | **string**| Hash of the requested block. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**BlockContentTxs**](BlockContentTxs.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="blockslatestget"></a>
# **BlocksLatestGet**
> BlockContent BlocksLatestGet ()

Latest block

Return the latest block available to the backends, also known as the tip of the blockchain. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlocksLatestGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoBlocksApi();

            try
            {
                // Latest block
                BlockContent result = apiInstance.BlocksLatestGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoBlocksApi.BlocksLatestGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BlockContent**](BlockContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="blockslatesttxsget"></a>
# **BlocksLatestTxsGet**
> BlockContentTxs BlocksLatestTxsGet (int? count = null, int? page = null, string order = null)

Latest block transactions

Return the transactions within the latest block.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlocksLatestTxsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoBlocksApi();
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Latest block transactions
                BlockContentTxs result = apiInstance.BlocksLatestTxsGet(count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoBlocksApi.BlocksLatestTxsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| Ordered by tx index in the block. The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**BlockContentTxs**](BlockContentTxs.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="blocksslotslotnumberget"></a>
# **BlocksSlotSlotNumberGet**
> BlockContent BlocksSlotSlotNumberGet (int? slotNumber)

Specific block in a slot

Return the content of a requested block for a specific slot. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BlocksSlotSlotNumberGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoBlocksApi();
            var slotNumber = 56;  // int? | Slot position for requested block.

            try
            {
                // Specific block in a slot
                BlockContent result = apiInstance.BlocksSlotSlotNumberGet(slotNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoBlocksApi.BlocksSlotSlotNumberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **slotNumber** | **int?**| Slot position for requested block. | 

### Return type

[**BlockContent**](BlockContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
