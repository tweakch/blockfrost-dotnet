# Blockfrost.Api.Gen.Services.MetricsApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MetricsEndpointsGet**](MetricsApi.md#metricsendpointsget) | **GET** /metrics/endpoints | Blockfrost endpoint usage metrics
[**MetricsGet**](MetricsApi.md#metricsget) | **GET** /metrics/ | Blockfrost usage metrics

<a name="metricsendpointsget"></a>
# **MetricsEndpointsGet**
> MetricsEndpoints MetricsEndpointsGet ()

Blockfrost endpoint usage metrics

History of your Blockfrost usage metrics per endpoint in the past 30 days. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class MetricsEndpointsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new MetricsApi();

            try
            {
                // Blockfrost endpoint usage metrics
                MetricsEndpoints result = apiInstance.MetricsEndpointsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.MetricsEndpointsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MetricsEndpoints**](MetricsEndpoints.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="metricsget"></a>
# **MetricsGet**
> Metrics MetricsGet ()

Blockfrost usage metrics

History of your Blockfrost usage metrics in the past 30 days.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class MetricsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new MetricsApi();

            try
            {
                // Blockfrost usage metrics
                Metrics result = apiInstance.MetricsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.MetricsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Metrics**](Metrics.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
