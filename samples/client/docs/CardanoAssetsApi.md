# Blockfrost.Api.Api.CardanoAssetsApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssetsAssetAddressesGet**](CardanoAssetsApi.md#assetsassetaddressesget) | **GET** /assets/{asset}/addresses | Asset addresses
[**AssetsAssetGet**](CardanoAssetsApi.md#assetsassetget) | **GET** /assets/{asset} | Specific asset
[**AssetsAssetHistoryGet**](CardanoAssetsApi.md#assetsassethistoryget) | **GET** /assets/{asset}/history | Asset history
[**AssetsAssetTransactionsGet**](CardanoAssetsApi.md#assetsassettransactionsget) | **GET** /assets/{asset}/transactions | Asset transactions
[**AssetsAssetTxsGet**](CardanoAssetsApi.md#assetsassettxsget) | **GET** /assets/{asset}/txs | Asset transactions
[**AssetsGet**](CardanoAssetsApi.md#assetsget) | **GET** /assets | Assets
[**AssetsPolicyPolicyIdGet**](CardanoAssetsApi.md#assetspolicypolicyidget) | **GET** /assets/policy/{policy_id} | Assets of a specific policy

<a name="assetsassetaddressesget"></a>
# **AssetsAssetAddressesGet**
> AssetAddresses AssetsAssetAddressesGet (string asset, int? count = null, int? page = null, string order = null)

Asset addresses

List of a addresses containing a specific asset

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AssetsAssetAddressesGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAssetsApi();
            var asset = asset_example;  // string | Concatenation of the policy_id and hex-encoded asset_name
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Asset addresses
                AssetAddresses result = apiInstance.AssetsAssetAddressesGet(asset, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAssetsApi.AssetsAssetAddressesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asset** | **string**| Concatenation of the policy_id and hex-encoded asset_name | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AssetAddresses**](AssetAddresses.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assetsassetget"></a>
# **AssetsAssetGet**
> Asset AssetsAssetGet (string asset)

Specific asset

Information about a specific asset

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AssetsAssetGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAssetsApi();
            var asset = asset_example;  // string | Concatenation of the policy_id and hex-encoded asset_name

            try
            {
                // Specific asset
                Asset result = apiInstance.AssetsAssetGet(asset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAssetsApi.AssetsAssetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asset** | **string**| Concatenation of the policy_id and hex-encoded asset_name | 

### Return type

[**Asset**](Asset.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assetsassethistoryget"></a>
# **AssetsAssetHistoryGet**
> AssetHistory AssetsAssetHistoryGet (string asset, int? count = null, int? page = null, string order = null)

Asset history

History of a specific asset

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AssetsAssetHistoryGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAssetsApi();
            var asset = asset_example;  // string | Concatenation of the policy_id and hex-encoded asset_name
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Asset history
                AssetHistory result = apiInstance.AssetsAssetHistoryGet(asset, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAssetsApi.AssetsAssetHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asset** | **string**| Concatenation of the policy_id and hex-encoded asset_name | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AssetHistory**](AssetHistory.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assetsassettransactionsget"></a>
# **AssetsAssetTransactionsGet**
> AssetTransactions AssetsAssetTransactionsGet (string asset, int? count = null, int? page = null, string order = null)

Asset transactions

List of a specific asset transactions

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AssetsAssetTransactionsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAssetsApi();
            var asset = asset_example;  // string | Concatenation of the policy_id and hex-encoded asset_name
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Asset transactions
                AssetTransactions result = apiInstance.AssetsAssetTransactionsGet(asset, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAssetsApi.AssetsAssetTransactionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asset** | **string**| Concatenation of the policy_id and hex-encoded asset_name | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AssetTransactions**](AssetTransactions.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assetsassettxsget"></a>
# **AssetsAssetTxsGet**
> AssetTxs AssetsAssetTxsGet (string asset, int? count = null, int? page = null, string order = null)

Asset transactions

List of a specific asset transactions

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AssetsAssetTxsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAssetsApi();
            var asset = asset_example;  // string | Concatenation of the policy_id and hex-encoded asset_name
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Asset transactions
                AssetTxs result = apiInstance.AssetsAssetTxsGet(asset, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAssetsApi.AssetsAssetTxsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asset** | **string**| Concatenation of the policy_id and hex-encoded asset_name | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AssetTxs**](AssetTxs.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assetsget"></a>
# **AssetsGet**
> Assets AssetsGet (int? count = null, int? page = null, string order = null)

Assets

List of assets.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AssetsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAssetsApi();
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Assets
                Assets result = apiInstance.AssetsGet(count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAssetsApi.AssetsGet: " + e.Message );
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
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**Assets**](Assets.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assetspolicypolicyidget"></a>
# **AssetsPolicyPolicyIdGet**
> AssetPolicy AssetsPolicyPolicyIdGet (string policyId, int? count = null, int? page = null, string order = null)

Assets of a specific policy

List of asset minted under a specific policy

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AssetsPolicyPolicyIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAssetsApi();
            var policyId = policyId_example;  // string | Specific policy_id
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Assets of a specific policy
                AssetPolicy result = apiInstance.AssetsPolicyPolicyIdGet(policyId, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAssetsApi.AssetsPolicyPolicyIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyId** | **string**| Specific policy_id | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AssetPolicy**](AssetPolicy.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
