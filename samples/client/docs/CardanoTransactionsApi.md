# IO.Swagger.Api.CardanoTransactionsApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TxSubmitPost**](CardanoTransactionsApi.md#txsubmitpost) | **POST** /tx/submit | Submit a transaction
[**TxsHashDelegationsGet**](CardanoTransactionsApi.md#txshashdelegationsget) | **GET** /txs/{hash}/delegations | Transaction delegation certificates
[**TxsHashGet**](CardanoTransactionsApi.md#txshashget) | **GET** /txs/{hash} | Specific transaction
[**TxsHashMetadataCborGet**](CardanoTransactionsApi.md#txshashmetadatacborget) | **GET** /txs/{hash}/metadata/cbor | Transaction metadata in CBOR
[**TxsHashMetadataGet**](CardanoTransactionsApi.md#txshashmetadataget) | **GET** /txs/{hash}/metadata | Transaction metadata
[**TxsHashMirsGet**](CardanoTransactionsApi.md#txshashmirsget) | **GET** /txs/{hash}/mirs | Transaction MIRs
[**TxsHashPoolRetiresGet**](CardanoTransactionsApi.md#txshashpoolretiresget) | **GET** /txs/{hash}/pool_retires | Transaction stake pool retirement certificates
[**TxsHashPoolUpdatesGet**](CardanoTransactionsApi.md#txshashpoolupdatesget) | **GET** /txs/{hash}/pool_updates | Transaction stake pool registration and update certificates
[**TxsHashStakesGet**](CardanoTransactionsApi.md#txshashstakesget) | **GET** /txs/{hash}/stakes | Transaction stake addresses certificates
[**TxsHashUtxosGet**](CardanoTransactionsApi.md#txshashutxosget) | **GET** /txs/{hash}/utxos | Transaction UTXOs
[**TxsHashWithdrawalsGet**](CardanoTransactionsApi.md#txshashwithdrawalsget) | **GET** /txs/{hash}/withdrawals | Transaction withdrawal

<a name="txsubmitpost"></a>
# **TxSubmitPost**
> string TxSubmitPost (string contentType)

Submit a transaction

Submit an already serialized transaction to the network.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxSubmitPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // Submit a transaction
                string result = apiInstance.TxSubmitPost(contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxSubmitPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 

### Return type

**string**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashdelegationsget"></a>
# **TxsHashDelegationsGet**
> TxContentDelegations TxsHashDelegationsGet (string hash)

Transaction delegation certificates

Obtain information about delegation certificates of a specific transaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashDelegationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction.

            try
            {
                // Transaction delegation certificates
                TxContentDelegations result = apiInstance.TxsHashDelegationsGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashDelegationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction. | 

### Return type

[**TxContentDelegations**](TxContentDelegations.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashget"></a>
# **TxsHashGet**
> TxContent TxsHashGet (string hash)

Specific transaction

Return content of the requested transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction

            try
            {
                // Specific transaction
                TxContent result = apiInstance.TxsHashGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction | 

### Return type

[**TxContent**](TxContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashmetadatacborget"></a>
# **TxsHashMetadataCborGet**
> TxContentMetadataCbor TxsHashMetadataCborGet (string hash)

Transaction metadata in CBOR

Obtain the transaction metadata in CBOR.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashMetadataCborGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction

            try
            {
                // Transaction metadata in CBOR
                TxContentMetadataCbor result = apiInstance.TxsHashMetadataCborGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashMetadataCborGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction | 

### Return type

[**TxContentMetadataCbor**](TxContentMetadataCbor.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashmetadataget"></a>
# **TxsHashMetadataGet**
> TxContentMetadata TxsHashMetadataGet (string hash)

Transaction metadata

Obtain the transaction metadata.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashMetadataGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction

            try
            {
                // Transaction metadata
                TxContentMetadata result = apiInstance.TxsHashMetadataGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashMetadataGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction | 

### Return type

[**TxContentMetadata**](TxContentMetadata.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashmirsget"></a>
# **TxsHashMirsGet**
> TxContentMirs TxsHashMirsGet (string hash)

Transaction MIRs

Obtain information about Move Instantaneous Rewards (MIRs) of a specific transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashMirsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction.

            try
            {
                // Transaction MIRs
                TxContentMirs result = apiInstance.TxsHashMirsGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashMirsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction. | 

### Return type

[**TxContentMirs**](TxContentMirs.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashpoolretiresget"></a>
# **TxsHashPoolRetiresGet**
> TxContentPoolRetires TxsHashPoolRetiresGet (string hash)

Transaction stake pool retirement certificates

Obtain information about stake pool retirements within a specific transaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashPoolRetiresGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction

            try
            {
                // Transaction stake pool retirement certificates
                TxContentPoolRetires result = apiInstance.TxsHashPoolRetiresGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashPoolRetiresGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction | 

### Return type

[**TxContentPoolRetires**](TxContentPoolRetires.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashpoolupdatesget"></a>
# **TxsHashPoolUpdatesGet**
> TxContentPoolCerts TxsHashPoolUpdatesGet (string hash)

Transaction stake pool registration and update certificates

Obtain information about stake pool registration and update certificates of a specific transaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashPoolUpdatesGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction

            try
            {
                // Transaction stake pool registration and update certificates
                TxContentPoolCerts result = apiInstance.TxsHashPoolUpdatesGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashPoolUpdatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction | 

### Return type

[**TxContentPoolCerts**](TxContentPoolCerts.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashstakesget"></a>
# **TxsHashStakesGet**
> TxContentStakeAddr TxsHashStakesGet (string hash)

Transaction stake addresses certificates

Obtain information about (de)registration of stake addresses within a transaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashStakesGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction.

            try
            {
                // Transaction stake addresses certificates
                TxContentStakeAddr result = apiInstance.TxsHashStakesGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashStakesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction. | 

### Return type

[**TxContentStakeAddr**](TxContentStakeAddr.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashutxosget"></a>
# **TxsHashUtxosGet**
> TxContentUtxo TxsHashUtxosGet (string hash)

Transaction UTXOs

Return the inputs and UTXOs of the specific transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashUtxosGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction

            try
            {
                // Transaction UTXOs
                TxContentUtxo result = apiInstance.TxsHashUtxosGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashUtxosGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction | 

### Return type

[**TxContentUtxo**](TxContentUtxo.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="txshashwithdrawalsget"></a>
# **TxsHashWithdrawalsGet**
> TxContentWithdrawals TxsHashWithdrawalsGet (string hash)

Transaction withdrawal

Obtain information about withdrawals of a specific transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TxsHashWithdrawalsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoTransactionsApi();
            var hash = hash_example;  // string | Hash of the requested transaction.

            try
            {
                // Transaction withdrawal
                TxContentWithdrawals result = apiInstance.TxsHashWithdrawalsGet(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoTransactionsApi.TxsHashWithdrawalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| Hash of the requested transaction. | 

### Return type

[**TxContentWithdrawals**](TxContentWithdrawals.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
