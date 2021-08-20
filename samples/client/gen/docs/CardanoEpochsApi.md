# Blockfrost.Api.Gen.Api.CardanoEpochsApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EpochsLatestGet**](CardanoEpochsApi.md#epochslatestget) | **GET** /epochs/latest | Latest epoch
[**EpochsLatestParametersGet**](CardanoEpochsApi.md#epochslatestparametersget) | **GET** /epochs/latest/parameters | Latest epoch protocol parameters
[**EpochsNumberBlocksGet**](CardanoEpochsApi.md#epochsnumberblocksget) | **GET** /epochs/{number}/blocks | Block distribution
[**EpochsNumberBlocksPoolIdGet**](CardanoEpochsApi.md#epochsnumberblockspoolidget) | **GET** /epochs/{number}/blocks/{pool_id} | Block distribution
[**EpochsNumberGet**](CardanoEpochsApi.md#epochsnumberget) | **GET** /epochs/{number} | Specific epoch
[**EpochsNumberNextGet**](CardanoEpochsApi.md#epochsnumbernextget) | **GET** /epochs/{number}/next | Listing of next epochs
[**EpochsNumberParametersGet**](CardanoEpochsApi.md#epochsnumberparametersget) | **GET** /epochs/{number}/parameters | Protocol parameters
[**EpochsNumberPreviousGet**](CardanoEpochsApi.md#epochsnumberpreviousget) | **GET** /epochs/{number}/previous | Listing of previous epochs
[**EpochsNumberStakesGet**](CardanoEpochsApi.md#epochsnumberstakesget) | **GET** /epochs/{number}/stakes | Stake distribution
[**EpochsNumberStakesPoolIdGet**](CardanoEpochsApi.md#epochsnumberstakespoolidget) | **GET** /epochs/{number}/stakes/{pool_id} | Stake distribution by pool

<a name="epochslatestget"></a>
# **EpochsLatestGet**
> EpochContent EpochsLatestGet ()

Latest epoch

Return the information about the latest, therefore current, epoch.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsLatestGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();

            try
            {
                // Latest epoch
                EpochContent result = apiInstance.EpochsLatestGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsLatestGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**EpochContent**](EpochContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epochslatestparametersget"></a>
# **EpochsLatestParametersGet**
> EpochParamContent EpochsLatestParametersGet ()

Latest epoch protocol parameters

Return the protocol parameters for the latest epoch.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsLatestParametersGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();

            try
            {
                // Latest epoch protocol parameters
                EpochParamContent result = apiInstance.EpochsLatestParametersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsLatestParametersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**EpochParamContent**](EpochParamContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epochsnumberblocksget"></a>
# **EpochsNumberBlocksGet**
> EpochBlockContent EpochsNumberBlocksGet (int? number, int? count = null, int? page = null, string order = null)

Block distribution

Return the blocks minted for the epoch specified.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsNumberBlocksGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();
            var number = 56;  // int? | Number of the epoch
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Block distribution
                EpochBlockContent result = apiInstance.EpochsNumberBlocksGet(number, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsNumberBlocksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **int?**| Number of the epoch | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**EpochBlockContent**](EpochBlockContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epochsnumberblockspoolidget"></a>
# **EpochsNumberBlocksPoolIdGet**
> EpochBlockContent EpochsNumberBlocksPoolIdGet (int? number, string poolId, int? count = null, int? page = null, string order = null)

Block distribution

Return the block minted for the epoch specified by stake pool.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsNumberBlocksPoolIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();
            var number = 56;  // int? | Number of the epoch
            var poolId = poolId_example;  // string | Stake pool ID to filter
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Block distribution
                EpochBlockContent result = apiInstance.EpochsNumberBlocksPoolIdGet(number, poolId, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsNumberBlocksPoolIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **int?**| Number of the epoch | 
 **poolId** | **string**| Stake pool ID to filter | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**EpochBlockContent**](EpochBlockContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epochsnumberget"></a>
# **EpochsNumberGet**
> EpochContent EpochsNumberGet (int? number)

Specific epoch

Return the content of the requested epoch.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsNumberGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();
            var number = 56;  // int? | Number of the epoch

            try
            {
                // Specific epoch
                EpochContent result = apiInstance.EpochsNumberGet(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsNumberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **int?**| Number of the epoch | 

### Return type

[**EpochContent**](EpochContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epochsnumbernextget"></a>
# **EpochsNumberNextGet**
> EpochContentArray EpochsNumberNextGet (int? number, int? count = null, int? page = null)

Listing of next epochs

Return the list of epochs following a specific epoch.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsNumberNextGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();
            var number = 56;  // int? | Number of the requested epoch.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)

            try
            {
                // Listing of next epochs
                EpochContentArray result = apiInstance.EpochsNumberNextGet(number, count, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsNumberNextGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **int?**| Number of the requested epoch. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]

### Return type

[**EpochContentArray**](EpochContentArray.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epochsnumberparametersget"></a>
# **EpochsNumberParametersGet**
> EpochParamContent EpochsNumberParametersGet (int? number)

Protocol parameters

Return the protocol parameters for the epoch specified.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsNumberParametersGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();
            var number = 56;  // int? | Number of the epoch

            try
            {
                // Protocol parameters
                EpochParamContent result = apiInstance.EpochsNumberParametersGet(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsNumberParametersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **int?**| Number of the epoch | 

### Return type

[**EpochParamContent**](EpochParamContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epochsnumberpreviousget"></a>
# **EpochsNumberPreviousGet**
> EpochContentArray EpochsNumberPreviousGet (int? number, int? count = null, int? page = null)

Listing of previous epochs

Return the list of epochs preceding a specific epoch.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsNumberPreviousGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();
            var number = 56;  // int? | Number of the epoch
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results (optional)  (default to 1)

            try
            {
                // Listing of previous epochs
                EpochContentArray result = apiInstance.EpochsNumberPreviousGet(number, count, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsNumberPreviousGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **int?**| Number of the epoch | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results | [optional] [default to 1]

### Return type

[**EpochContentArray**](EpochContentArray.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epochsnumberstakesget"></a>
# **EpochsNumberStakesGet**
> EpochStakeContent EpochsNumberStakesGet (int? number, int? count = null, int? page = null)

Stake distribution

Return the active stake distribution for the specified epoch.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsNumberStakesGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();
            var number = 56;  // int? | Number of the epoch
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)

            try
            {
                // Stake distribution
                EpochStakeContent result = apiInstance.EpochsNumberStakesGet(number, count, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsNumberStakesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **int?**| Number of the epoch | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]

### Return type

[**EpochStakeContent**](EpochStakeContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epochsnumberstakespoolidget"></a>
# **EpochsNumberStakesPoolIdGet**
> EpochStakePoolContent EpochsNumberStakesPoolIdGet (int? number, string poolId, int? count = null, int? page = null)

Stake distribution by pool

Return the active stake distribution for the epoch specified by stake pool.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class EpochsNumberStakesPoolIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoEpochsApi();
            var number = 56;  // int? | Number of the epoch
            var poolId = poolId_example;  // string | Stake pool ID to filter
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)

            try
            {
                // Stake distribution by pool
                EpochStakePoolContent result = apiInstance.EpochsNumberStakesPoolIdGet(number, poolId, count, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoEpochsApi.EpochsNumberStakesPoolIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **int?**| Number of the epoch | 
 **poolId** | **string**| Stake pool ID to filter | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]

### Return type

[**EpochStakePoolContent**](EpochStakePoolContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
