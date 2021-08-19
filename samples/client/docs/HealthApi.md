# Blockfrost.Api.Api.HealthApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HealthClockGet**](HealthApi.md#healthclockget) | **GET** /health/clock | Current backend time
[**HealthGet**](HealthApi.md#healthget) | **GET** /health | Backend health status
[**RootGet**](HealthApi.md#rootget) | **GET** / | Root endpoint

<a name="healthclockget"></a>
# **HealthClockGet**
> InlineResponse2002 HealthClockGet ()

Current backend time

This endpoint provides the current UNIX time. Your application might use this to verify if the client clock is not out of sync. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class HealthClockGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new HealthApi();

            try
            {
                // Current backend time
                InlineResponse2002 result = apiInstance.HealthClockGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.HealthClockGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="healthget"></a>
# **HealthGet**
> InlineResponse2001 HealthGet ()

Backend health status

Return backend status as a boolean. Your application     should handle situations when backend for the given chain is unavailable. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class HealthGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new HealthApi();

            try
            {
                // Backend health status
                InlineResponse2001 result = apiInstance.HealthGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.HealthGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="rootget"></a>
# **RootGet**
> InlineResponse200 RootGet ()

Root endpoint

Root endpoint has no other function than to point end users to documentation. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class RootGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new HealthApi();

            try
            {
                // Root endpoint
                InlineResponse200 result = apiInstance.RootGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.RootGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
